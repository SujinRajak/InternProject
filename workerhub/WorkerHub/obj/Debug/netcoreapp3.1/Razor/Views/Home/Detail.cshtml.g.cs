#pragma checksum "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f94e7628d5e1377e8336f567f0cbe51fd8f9702"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f94e7628d5e1377e8336f567f0cbe51fd8f9702", @"/Views/Home/Detail.cshtml")]
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
 if (Model.AppUser.InactiveUsers == false)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-12\" id=\"viewprofile\">\r\n        <div class=\"container\">\r\n            <div class=\"container\">\r\n                <div class=\"addprofilepic col-md-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f94e7628d5e1377e8336f567f0cbe51fd8f97024876", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f94e7628d5e1377e8336f567f0cbe51fd8f97026081", async() => {
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
#line 19 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                   Write(Model.AppUser.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                                            Write(Model.AppUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral(@"                                    <td></td>
                                </tr>
                                <tr>
                                    <td>sth</td>
                                </tr>
                                <tr>
                                    <td></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""seperator "">
                        <div class=""userinfo "">
                            <div class=""userinfoHeader text-center"">
                                <h4>Candidate Overview</h4>
                            </div>
                            <div class=""UserFrom"">
                                <div class=""row register-row"">
                                    <div class=""form-group col-md-6"">
                         ");
            WriteLiteral("               <label>First Name</label>\r\n                                        <label>");
#nullable restore
#line 45 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                          Write(Model.AppUser.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n                                    </div>\r\n                                    <div class=\"form-group col-md-6\">\r\n                                        <label>Last Name</label>\r\n                                        <label>");
#nullable restore
#line 50 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                          Write(Model.AppUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                    </div>
                                </div>
                                <div class=""row register-row"">
                                    <div class=""form-group col-md-6"">
                                        <label>Gender</label>
                                        <label>");
#nullable restore
#line 56 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                          Write(Model.AppUser.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                    </div>
                                </div>
                                <div class=""register-row"">
                                    <div class="" form-group  col-md-12"">
                                        <label class=""col-form-label"">Description</label>
                                        <label>");
#nullable restore
#line 62 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                          Write(Model.AppUser.Descripition);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""seperator "">
                        <div class=""userinfo "">
                            <div class=""userinfoHeader text-center"">
                                <h4>Candidate Details</h4>
                            </div>
                            <div class=""UserFrom"">
                                <div class=""row register-row"">
                                    <div class=""form-group col-md-6"">
                                        <label>Gender</label>
                                        <label>");
#nullable restore
#line 79 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                          Write(Model.AppUser.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                    </div>\r\n                                    <div class=\"form-group col-md-6\">\r\n                                        <label>Experience</label>\r\n                                        <label>");
#nullable restore
#line 83 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                          Write(Model.AppUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                    </div>
                                </div>
                                <div class="" row register-row"">
                                    <div class=""form-group col-md-6"">
                                        <label>Qualification</label>
                                        <label>");
#nullable restore
#line 89 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                          Write(Model.AppUser.PermanentAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""gap""></div>
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""seperator "">
                        <div class=""userinfo "">
                            <div class=""userinfoHeader text-center"">
                                <h4>Extra Skill and Knowledge</h4>
                            </div>
                            <div class=""UserFrom"">
                                <div class=""row register-row"">
                                    <div class=""form-group col-md-6"">
                                        <label>First Name </label>
                                        <label></label>

                                    </div>
                                    <div class=""form-gr");
            WriteLiteral(@"oup col-md-6"">
                                        <label>Last Name</label>
                                        <label></label>
                                    </div>
                                </div>
                                <div class=""row register-row"">
                                    <div class=""form-group col-md-6"">
                                        <label>Gender</label>
                                        <label></label>
                                    </div>
                                </div>
                                <div class=""register-row"">
                                    <div class="" form-group  col-md-12"">
                                        <label class=""col-form-label"">Description</label>
                                        <label></label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
            WriteLiteral(@"                </div>
                <div class=""col-md-6"">
                    <div class=""seperator "">
                        <div class=""userinfo "">
                            <div class=""userinfoHeader text-center"">
                                <h4>Candidate Address</h4>
                            </div>
                            <div class=""row register-row"">
                                <div class=""form-group col-md-6"">
                                    <label>Phone Number</label>
                                    <label>");
#nullable restore
#line 142 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                      Write(Model.AppUser.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                </div>\r\n                                <div class=\"form-group col-md-6\">\r\n                                    <label>Email</label>\r\n                                    <label>");
#nullable restore
#line 146 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                      Write(Model.AppUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                </div>
                            </div>
                            <div class="" row register-row"">
                                <div class=""form-group col-md-6"">
                                    <label>Permanent Address</label>
                                    <label>");
#nullable restore
#line 152 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                      Write(Model.AppUser.PermanentAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                </div>\r\n\r\n                                <div class=\"form-group col-md-6\">\r\n                                    <label>Temporary Address</label>\r\n                                    <label>");
#nullable restore
#line 157 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
                                      Write(Model.AppUser.TemporaryAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""gap""></div>

            <div class=""col-md-12"">
                <div class=""seperator "">
                    <div class=""userinfo "">
                        <div class=""userinfoHeader text-center"">
                            <h4>Education</h4>
                        </div>
                        <div class=""UserFrom"">
                            <div class=""row register-row"">
                                <div class=""form-group col-md-6"">
                                    <label>First Name </label>
                                    <label></label>

                                </div>
                                <div class=""form-group col-md-6"">
                                    <label>Last Name</label>
                                    <label></label>
         ");
            WriteLiteral(@"                       </div>
                            </div>
                            <div class=""row register-row"">
                                <div class=""form-group col-md-6"">
                                    <label>Gender</label>
                                    <label></label>
                                </div>
                            </div>
                            <div class=""register-row"">
                                <div class="" form-group  col-md-12"">
                                    <label class=""col-form-label"">Description</label>
                                    <label></label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
");
#nullable restore
#line 203 "C:\Users\Sujin\Desktop\InternProject\WorkerHub\WorkerHub\Views\Home\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
