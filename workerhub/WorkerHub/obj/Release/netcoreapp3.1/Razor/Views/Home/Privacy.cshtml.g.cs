#pragma checksum "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63463172e73fcf75d5a184ed8b4c50ec42997147"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using WorkerHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using WorkerHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using WorkerHub.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using WorkerHub.Interface;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63463172e73fcf75d5a184ed8b4c50ec42997147", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d99adaa4a1a3d046c077d7a6583cb17ad8954426", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DisplayEmployee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("output_image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
  
    ViewBag.Title = "Employees";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section id=\"team\" class=\"team\">\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 11 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
             foreach (var item in Model.applicationUsers)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                 if (item.InactiveUsers == false && item.Availablility == true)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-xl-3 col-lg-4 col-md-6\" data-aos=\"fade-up\">\r\n                        <div class=\"member\">\r\n                            <div class=\"pic\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63463172e73fcf75d5a184ed8b4c50ec429971476350", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                                             WriteLiteral(Url.Content("~/images/" + (item.img ?? "user.png")));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 18 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                            <div class=\"member-info\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63463172e73fcf75d5a184ed8b4c50ec429971478767", async() => {
                WriteLiteral("\r\n                                    <h4 class=\"card-title\">");
#nullable restore
#line 21 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                                      Write(item.Firstname);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 21 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                                                      Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <span></span>\r\n                                <div class=\"social\">\r\n");
#nullable restore
#line 25 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                     foreach (var data in Model.TotalExpdata)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                         if (data.userid == item.Id)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                             if (data.totalExp!=0 && data.totalExp <= 3)
                                            {
                                                for (int i = 1; i <= 5; i++)
                                                {
                                                    if (i == 1)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <i class=\"fa fa-star fa-2x\" style=\"color:gold !important;\"></i>\r\n");
#nullable restore
#line 36 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <i class=\"fa fa-star fa-2x\" style=\"color:black !important;\"></i>\r\n");
#nullable restore
#line 40 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                                    }

                                                }
                                            }
                                            else if (data.totalExp > 3 && data.totalExp <= 6)
                                            {
                                                for (int i = 1; i <= 5; i++)
                                                {
                                                    if (i <= 2)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <i class=\"fa fa-star fa-2x\" style=\"color:gold !important;\"></i>\r\n");
#nullable restore
#line 51 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <i class=\"fa fa-star fa-2x\" style=\"color:black !important;\"></i>\r\n");
#nullable restore
#line 55 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                                    }

                                                }
                                            }
                                            else if (data.totalExp > 6)
                                            {
                                                for (int i = 1; i <= 5; i++)
                                                {
                                                    if (i <= 3)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <i class=\"fa fa-star fa-2x\" style=\"color:gold !important;\"></i>\r\n");
#nullable restore
#line 66 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <i class=\"fa fa-star fa-2x\" style=\"color:black !important;\"></i>\r\n");
#nullable restore
#line 70 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                for (int i = 1; i <= 5; i++)
                                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <i class=\"fa fa-star fa-2x\" style=\"color:black !important;\"></i>\r\n");
#nullable restore
#line 79 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                                }
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 88 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "D:\8th project\CurrentlWorkingproject\Final intern project\WorkerHub\WorkerHub\Views\Home\Privacy.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n</section><!-- End Our Team Section -->\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DisplayEmployee> Html { get; private set; }
    }
}
#pragma warning restore 1591
