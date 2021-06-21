#pragma checksum "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e235a05cdbb0d1324f08df5c621252eba126882e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Join_SearchAction), @"mvc.1.0.view", @"/Views/Join/SearchAction.cshtml")]
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
#line 1 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using WorkerHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using WorkerHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using WorkerHub.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\_ViewImports.cshtml"
using WorkerHub.Interface;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e235a05cdbb0d1324f08df5c621252eba126882e", @"/Views/Join/SearchAction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d99adaa4a1a3d046c077d7a6583cb17ad8954426", @"/Views/_ViewImports.cshtml")]
    public class Views_Join_SearchAction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JoinViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"">
    <div class=""col-md-6 offset-3 mt-4"">
        <div class=""input-group"">
            <input id=""txtfiled"" class=""form-control"" placeholder=""Search for Employees,Skill or Skill Sets"" />
        </div>
    </div>
    
    <div class=""container mt-5"">
        <table class=""table table-dark table-hover text-center"" border=""1"">
            <thead>
                <tr>
                    <th>Full Name</th>
                    <th>Domain</th>
                    <th>Skill Description</th>
                    <th>Address</th>
                    <th>Availability</th>
                </tr>
            </thead>
            <tbody id=""Filter"">
");
#nullable restore
#line 21 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e235a05cdbb0d1324f08df5c621252eba126882e5326", async() => {
#nullable restore
#line 24 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
                                                                                        Write(item.Firstname);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 24 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
                                                                                                        Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
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
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
                   Write(item.Skill);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
                   Write(item.skillDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 27 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
                     if (item.PermanentAddress != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 29 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
                       Write(item.PermanentAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 30 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 33 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
                       Write(item.TemporaryAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 34 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
                     if (@item.Availablility)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Available</td>\r\n");
#nullable restore
#line 38 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Not Aavailable</td>\r\n");
#nullable restore
#line 42 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 44 "D:\Main project\Final intern project\WorkerHub\WorkerHub\Views\Join\SearchAction.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            $(""#txtfiled"").on(""keyup"", function () {
                //gets all the value
                var value = $(this).val().toLowerCase();
                $(""#Filter tr"").filter(function () {
                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                });
            });
        });
    </script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JoinViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
