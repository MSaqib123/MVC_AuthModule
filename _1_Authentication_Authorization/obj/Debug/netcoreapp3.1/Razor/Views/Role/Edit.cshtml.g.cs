#pragma checksum "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e3e083c5de26959961aab4b1be84587ccd5bb3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Edit), @"mvc.1.0.view", @"/Views/Role/Edit.cshtml")]
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
#line 1 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\_ViewImports.cshtml"
using _3_Authentication_Authorization_Other_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\_ViewImports.cshtml"
using DML._1_clsAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\_ViewImports.cshtml"
using DAL.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\_ViewImports.cshtml"
using _1_Authentication_Authorization.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e3e083c5de26959961aab4b1be84587ccd5bb3b", @"/Views/Role/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7de8e1eb5ccb3e2a9bf8cb68b80bb2bf4a3bdfeb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Role_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssignRoleViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
  
    ViewData["Title"] = "Edit Role";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit Roles</h1>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-10\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e3e083c5de26959961aab4b1be84587ccd5bb3b5220", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e3e083c5de26959961aab4b1be84587ccd5bb3b5490", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"RoleName\"");
                BeginWriteAttribute("value", " value=\"", 312, "\"", 336, 1);
#nullable restore
#line 14 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
WriteAttributeValue("", 320, Model.Role.Name, 320, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n            <div class=\"row\">\r\n");
                WriteLiteral("                <div class=\"col-6\">\r\n                    <h2>Add Users to <span class=\"badge badge-primary\">");
#nullable restore
#line 19 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
                                                                  Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> role</h2>\r\n\r\n                    <table class=\"table table-bordered\">\r\n");
#nullable restore
#line 22 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
                         if (Model.NonMembers.Count() == 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr><td>All Users are membser.</td></tr>\r\n");
#nullable restore
#line 25 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
                        }
                        else
                        {
                            foreach (var user in Model.NonMembers)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 31 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
                                   Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>\r\n                                        <input type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 1242, "\"", 1258, 1);
#nullable restore
#line 33 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
WriteAttributeValue("", 1250, user.Id, 1250, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"AddIds\" />\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 36 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </table>\r\n                </div>\r\n\r\n");
                WriteLiteral("\r\n                <div class=\"col-6\">\r\n                    <h2>Remove Users from <span class=\"badge badge-primary\">");
#nullable restore
#line 44 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
                                                                       Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> role</h2>\r\n                    <table class=\"table table-bordered\">\r\n");
#nullable restore
#line 46 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
                         if (Model.Members.Count() == 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr><td>No Users are membser.</td></tr>\r\n");
#nullable restore
#line 49 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
                        }
                        else
                        {
                            foreach (ApplicationUser user in Model.Members)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 55 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
                                   Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>\r\n                                        <input type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 2373, "\"", 2389, 1);
#nullable restore
#line 57 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
WriteAttributeValue("", 2381, user.Id, 2381, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"DeleteIds\" />\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 60 "E:\_6_Authentication_Authorization_Other_Project\_1_Authentication_Authorization\Views\Role\Edit.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </table>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssignRoleViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
