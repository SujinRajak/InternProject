#pragma checksum "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "206078554bd85738fbf8208dd68ba6f589fbd705"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 1 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using WorkerHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using WorkerHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using WorkerHub.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using WorkerHub.Interface;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"206078554bd85738fbf8208dd68ba6f589fbd705", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d99adaa4a1a3d046c077d7a6583cb17ad8954426", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/chrome.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/apple-touch-icon-180x180.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
 if (Model.AppUser.InactiveUsers == false)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-12\" id=\"viewprofile\">\r\n        <div class=\"container\">\r\n            <div class=\"container\">\r\n                <div class=\"addprofilepic col-md-12 box-shadow\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "206078554bd85738fbf8208dd68ba6f589fbd7054891", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"row  col-md-12 textfield\">\r\n");
            WriteLiteral("                        <div class=\"col-md-2\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "206078554bd85738fbf8208dd68ba6f589fbd7056096", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
            WriteLiteral("                        <div class=\"col-md-3 mt-5 \">\r\n                            <table>\r\n                                <tr>\r\n                                    <td>");
#nullable restore
#line 24 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                   Write(Model.AppUser.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                                            Write(Model.AppUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral(@"                                    <td></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""seperator"">
                        <div class=""userinfo box-shadow"">
                            <table class=""col-12"">
                                <tr class=""border-bottom text-center"">
                                    <td colspan=""2"">
                                        <h4>Candidate Overview</h4>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""col-form-label ml-2"">Full Name:</label>
                                    </td>
                                    <td>
                                ");
            WriteLiteral("        <input type=\"text\" readonly class=\"form-control-plaintext \"");
            BeginWriteAttribute("value", " value=\"", 2182, "\"", 2238, 2);
#nullable restore
#line 48 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
WriteAttributeValue("", 2190, Model.AppUser.Firstname, 2190, 24, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
WriteAttributeValue(" ", 2214, Model.AppUser.LastName, 2215, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""col-form-label ml-2"">Gender:</label>
                                    </td>
                                    <td>
                                        <input type=""text"" readonly class=""form-control-plaintext""");
            BeginWriteAttribute("value", " value=\"", 2679, "\"", 2705, 1);
#nullable restore
#line 56 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
WriteAttributeValue("", 2687, Model.AppUser.Sex, 2687, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""col-form-label ml-2"">Description:</label>
                                    </td>
                                    <td>
                                        <input type=""text"" readonly class=""form-control-plaintext""");
            BeginWriteAttribute("value", " value=\"", 3151, "\"", 3186, 1);
#nullable restore
#line 64 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
WriteAttributeValue("", 3159, Model.AppUser.Descripition, 3159, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""seperator box-shadow"">
                        <div class=""userinfo "">
                            <div class=""userinfoHeader text-center"">
                                <h4>Candidate Experience</h4>
                            </div>
                            <div class=""UserFrom"">
                                <div class=""tablesection text-center"">
                                    <table id=""mytable"" class=""col-md-12 "" border=""1"">
                                        <tr>
                                            <th>
                                                ");
#nullable restore
#line 82 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                           Write(Html.DisplayNameFor(Model => Model.AppExp.Sector));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 85 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                           Write(Html.DisplayNameFor(Model => Model.AppExp.Startdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 85 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                                                                                 Write(Html.DisplayNameFor(Model => Model.AppExp.Enddate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 88 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                           Write(Html.DisplayNameFor(Model => Model.AppExp.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 91 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                           Write(Html.DisplayNameFor(Model => Model.AppExp.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                        </tr>\r\n");
#nullable restore
#line 94 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                         foreach (var item in info.getrecords())
                                        {
                                            if (item.Userid == Model.AppUser.Id)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 101 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Sector));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 104 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Startdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 104 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                                                                                 Write(Html.DisplayFor(modelItem => item.Enddate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 107 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 110 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 113 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                            }

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""gap""></div>
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""seperator box-shadow"">
                        <div class=""userinfo "">
                            <div class=""userinfoHeader text-center"">
                                <h4>Extra Skill</h4>
                            </div>
                            <div class=""UserFrom"">
                                <div class=""tablesection text-center"">
                                    <table id=""mytable"" class=""col-md-12 "" border=""1"">
                                        <tr>
                                            <th>
                                                ");
#nullable restore
#line 136 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                           Write(Html.DisplayNameFor(Model => Model.AppSkill.Skill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 139 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                           Write(Html.DisplayNameFor(Model => Model.AppSkill.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                        </tr>\r\n");
#nullable restore
#line 142 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                         foreach (var item in skil.getrecords())
                                        {
                                            if (item.Userid == Model.AppUser.Id)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 149 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Skill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 152 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 155 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"

                                            }

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </table>
                                </div>


                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""seperator box-shadow"">
                        <div class=""userinfo "">
                            <table class=""col-12"">
                                <tr class=""border-bottom text-center"">
                                    <td colspan=""2"">
                                        <h4>Candidate Address</h4>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""col-form-label ml-2"">Email:</label>
                                    </td>
                                    <td>
                                        <input type=""text"" readonly class=""form-contr");
            WriteLiteral("ol-plaintext\"");
            BeginWriteAttribute("value", " value=\"", 9506, "\"", 9534, 1);
#nullable restore
#line 181 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
WriteAttributeValue("", 9514, Model.AppUser.Email, 9514, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""col-form-label ml-2"">Contact Number:</label>
                                    </td>
                                    <td>
                                        <input type=""text"" readonly class=""form-control-plaintext""");
            BeginWriteAttribute("value", " value=\"", 9983, "\"", 10017, 1);
#nullable restore
#line 189 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
WriteAttributeValue("", 9991, Model.AppUser.PhoneNumber, 9991, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""col-form-label ml-2"">Permanent Address:</label>
                                    </td>
                                    <td>
                                        <input type=""text"" readonly class=""form-control-plaintext""");
            BeginWriteAttribute("value", " value=\"", 10469, "\"", 10508, 1);
#nullable restore
#line 197 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
WriteAttributeValue("", 10477, Model.AppUser.PermanentAddress, 10477, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label class=""col-form-label ml-2"">Temporary Address:</label>
                                    </td>
                                    <td>
                                        <input type=""text"" readonly class=""form-control-plaintext""");
            BeginWriteAttribute("value", " value=\"", 10960, "\"", 10999, 1);
#nullable restore
#line 205 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
WriteAttributeValue("", 10968, Model.AppUser.TemporaryAddress, 10968, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""gap""></div>

            <div class=""col-md-12"">
                <div class=""seperator box-shadow"">
                    <div class=""userinfo "">
                        <div class=""userinfoHeader text-center"">
                            <h4>Education</h4>
                        </div>
                        <div class=""UserFrom"">
                            <div class=""tablesection"">

");
#nullable restore
#line 224 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                 foreach (var item in edu.getrecords())
                                {

                                    if (item.Userid == Model.AppUser.Id)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <i class=""fa fa-check fa-2x""></i>
                                        <table id=""mytable"" class=""col-md-12"" border=""1"">
                                            <tr>
                                                <td colspan=""3"">
                                                    ");
#nullable restore
#line 233 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Startdate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </td>
                                            </tr>
                                            <tr class=""text-center"">

                                                <td colspan=""2"" class=""col-md-6"">
                                                    ");
#nullable restore
#line 239 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Qualification));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </td>
                                                <td class=""col-md-6"">
                                                </td>

                                            </tr>
                                            <tr>
                                                <td colspan=""3"">
                                                    ");
#nullable restore
#line 247 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Enddate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n                                        </table>\r\n");
#nullable restore
#line 251 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"

                                    }

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 266 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ISkill skil { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IEducation edu { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IQualification info { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
