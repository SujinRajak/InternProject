﻿//using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using WorkerHub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WorkerHub.Interface;
using WorkerHub.Service.Dto;
using System.Linq;
using WorkerHub.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace WorkerHub.Controllers
{
    public class PaymentController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUser _context;
        private readonly ApplicationDbContext _dbcontext;
        private readonly IPaymentService _paymentService;

        public PaymentController(UserManager<ApplicationUser> userManager,
            IApplicationUser context,
            ApplicationDbContext dbcontext,
            IPaymentService paymentService)
        {
            _userManager = userManager;
            _context = context;
            _dbcontext = dbcontext;
            _paymentService = paymentService;
        }
        [HttpGet]
        public async Task<IActionResult> CatchMockResponse(
            string pidx,
            string txnId,
            decimal amount,
            decimal total_amount,
            string status,
            string mobile,
            string tidx,
            string purchase_order_id,
            string purchase_order_name,
            string transaction_id)
        {
            var order = await _dbcontext.Order.FirstOrDefaultAsync(s => s.Id.Equals(purchase_order_id));

            var a = await _dbcontext.Order.ToListAsync();

            var transacction = new Transaction
            {
                Id = Guid.NewGuid().ToString(),
                OrderId = order.Id.ToString(),
                Status = status,
                tidx = tidx,
                transaction_id = transaction_id
            };
            _dbcontext.Add(transacction);

            await _dbcontext.SaveChangesAsync();
            if (transacction.Status == "Completed")
                await _paymentService.CompletePaymentProcessAsync(order.Amount, order.ApplicationUserId);


            ViewBag.Success = transacction.Status == "Completed" ? true : false;

            return View();

        }
        public async Task<IActionResult> CatchResponse(
            string pidx,
            string txnId,
            decimal amount,
            decimal total_amount,
            string status,
            string mobile,
            string tidx,
            string purchase_order_id,
            string purchase_order_name,
            string transaction_id)
        {
            var order = await _dbcontext.Order.FirstOrDefaultAsync(s => s.Id.Equals(purchase_order_id));

            var transacction = new Transaction
            {
                Id = Guid.NewGuid().ToString(),
                OrderId = order.Id.ToString(),
                Status = status,
                tidx = tidx,
                transaction_id = transaction_id
            };
            _dbcontext.Add(transacction);

            await _dbcontext.SaveChangesAsync();
            if (transacction.Status == "Completed")
            {
                var check = await VerifyPayment(pidx);
                if(check)
                    await _paymentService.CompletePaymentProcessAsync(order.Amount, order.ApplicationUserId);
            }


            ViewBag.Success = transacction.Status == "Completed" ? true : false;

            return View();

        }
        private async Task<bool> VerifyPayment(string pxid)
        {
            var check = false;

            do
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    var url = "https://a.khalti.com/api/v2/epayment/lookup/";

                    var payload = new
                    {
                        pidx = pxid
                    };
                    var jsonPayload = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    var client = new HttpClient();
                    client.DefaultRequestHeaders.Add("Authorization", "key 6de045a8cd7a42879dafd3fc1418ddd4");

                    var response = await client.PostAsync(url, content);
                    var responseContent = await response.Content.ReadAsStringAsync();

                    var res = JsonConvert.DeserializeObject<KhaltiVerifyPaymentResponseDto>(responseContent);

                    if (res.status == "Completed")
                        return true;
                    else if (res.status == "Pending" || res.status == "Initiated")
                    {
                        await Task.Delay(10000);
                        check = true;
                    }
                    else
                        return false;
                }
            }
            while (check);

            return false;

        }
        [HttpPost]
        public async Task<string> MockPayment(int type)
        {
            try
            {
                // Get the current HTTP context
                HttpContext httpContext = HttpContext;

                // Get the host and port information
                string host = httpContext.Request.Host.Host;
                int port = httpContext.Request.Host.Port ?? 80; // Default to 80 if port is null

                // Construct the base URL
                string baseUrl = $"{httpContext.Request.Scheme}://{host}:{port}";

                ApplicationUser user = _context.getUser(_userManager.GetUserId(User));


                var _amount = type == 1 ? 1000 : type == 2 ? 3000 : type == 3 ? 5000 : 1000;

                var order = new Order
                {
                    Id = Guid.NewGuid().ToString(),
                    Amount = _amount,
                    ApplicationUserId = user.Id,
                    PurchaseOrderName = $"{type} Months Subscription",
                    ReturnUrl = $"{baseUrl}/Payment/CatchResponse",
                    WebsiteUrl = baseUrl
                };

                order.PxId = Guid.NewGuid().ToString();

                _dbcontext.Add(order);
                await _dbcontext.SaveChangesAsync();

                string pidx = Guid.NewGuid().ToString().Replace("-", "");
                string txnId = Guid.NewGuid().ToString().Replace("-", "");
                decimal amount = order.Amount;
                decimal total_amount = order.Amount;
                string status = "Completed";
                string mobile = "98XXXXX904";
                string tidx = txnId;
                string purchase_order_id = order.Id.ToString();
                string purchase_order_name = order.PurchaseOrderName;
                string transaction_id = txnId;

                // Construct the URL to redirect to CatchResponse
                var url = baseUrl + Url.Action("CatchMockResponse", "Payment", new
                {
                    pidx,
                    txnId,
                    amount,
                    total_amount,
                    status,
                    mobile,
                    tidx,
                    purchase_order_id,
                    purchase_order_name,
                    transaction_id
                });

                return url;

            }
            catch (Exception ex)
            {
                throw ex;
                
            }
        }

        [HttpPost]
        public async Task<string> InitiatePayment(int type)
        {
            try
            {

                // Get the current HTTP context
                HttpContext httpContext = HttpContext;

                // Get the host and port information
                string host = httpContext.Request.Host.Host;
                int port = httpContext.Request.Host.Port ?? 80; // Default to 80 if port is null

                // Construct the base URL
                string baseUrl = $"{httpContext.Request.Scheme}://{host}:{port}";

                ApplicationUser user = _context.getUser(_userManager.GetUserId(User));

                var amount = type == 1 ? 1000 : type == 2 ? 3000 : type == 3 ? 5000 : 1000;

                var order = new Order
                {
                    Id = Guid.NewGuid().ToString(),
                    Amount = amount,
                    ApplicationUserId = user.Id,
                    PurchaseOrderName = $"{type} Months Subscription",
                    ReturnUrl = $"{baseUrl}/Payment/CatchResponse",
                    WebsiteUrl = baseUrl
                };


                using (HttpClient httpClient = new HttpClient())
                {
                    var url = "https://a.khalti.com/api/v2/epayment/initiate/";

                    var payload = new
                    {
                        return_url = order.ReturnUrl,
                        website_url = order.WebsiteUrl,
                        amount = order.Amount,
                        purchase_order_id = order.Id,
                        purchase_order_name = order.PurchaseOrderName,
                        customer_info = new
                        {
                            name = "mani maharjan",
                            email = "mani.mhzn.182@gmail.com",
                            phone = "9800000001"
                        }
                    };

                    var jsonPayload = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    var client = new HttpClient();
                    client.DefaultRequestHeaders.Add("Authorization", "key 6de045a8cd7a42879dafd3fc1418ddd4");

                    var response = await client.PostAsync(url, content);
                    var responseContent = await response.Content.ReadAsStringAsync();

                    var res = JsonConvert.DeserializeObject<KhaltiInitiatePaymentResponseDto>(responseContent);

                    order.PxId = res.pidx;

                    _dbcontext.Add(order);
                    await _dbcontext.SaveChangesAsync();

                    Console.WriteLine(responseContent);

                    return res.payment_url;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }

        }

        [Authorize(Policy = "AdminOnly")]
        [HttpGet]
        public async Task<IActionResult> GetAdminTransactionList(DateTime? fromDate, DateTime? toDate, int page = 1)
        {
            if(fromDate == null && toDate == null)
            {
                toDate = DateTime.Now.Date;
                fromDate = DateTime.Today.AddDays(-7).Date;
            }
            var pageSize = 10;
            var transactionDetails = (from transaction in _dbcontext.Transactions
                                      join order in _dbcontext.Order on transaction.OrderId equals order.Id
                                      join user in _dbcontext.applicationUser on order.ApplicationUserId equals user.Id
                                      where transaction.CreatedAt.Date >= fromDate && transaction.CreatedAt.Date <= toDate
                                      select new TransactionDetailViewModel
                                      {
                                          Tidx = transaction.tidx,
                                          Status = transaction.Status,
                                          OrderId = order.Id,
                                          PurchaseOrderName = order.PurchaseOrderName,
                                          Amount = order.Amount,
                                          CreatedAt = transaction.CreatedAt,
                                          UserName = user.Firstname + " " + user.LastName
                                      });

            var totalItems = await transactionDetails.CountAsync();
            var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            var data = await transactionDetails.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;
            ViewBag.TotalSales = transactionDetails.Where(s=>s.Status.Equals("Completed")).Sum(s => s.Amount);
            ViewBag.FromDate = fromDate.Value.ToString("yyyy-MM-dd");
            ViewBag.ToDate = toDate.Value.ToString("yyyy-MM-dd");

            var viewModel = new TransactionIndexViewModel
            {
                Transactions = data,
                CurrentPage = page,
                TotalPages = totalPages
            };

            return View(viewModel);
        }
    }
}
