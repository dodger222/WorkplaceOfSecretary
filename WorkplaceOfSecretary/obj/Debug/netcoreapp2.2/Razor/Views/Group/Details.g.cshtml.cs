#pragma checksum "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1fce597c08d8d4d5b0668b3d9460f2f047f50f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_Details), @"mvc.1.0.view", @"/Views/Group/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Group/Details.cshtml", typeof(AspNetCore.Views_Group_Details))]
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
#line 1 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\_ViewImports.cshtml"
using WorkplaceOfSecretary;

#line default
#line hidden
#line 2 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\_ViewImports.cshtml"
using WorkplaceOfSecretary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1fce597c08d8d4d5b0668b3d9460f2f047f50f8", @"/Views/Group/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78448a6b5d6daf32f79a6a0e48a491fbb75261ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkplaceOfSecretary.Models.Group>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 126, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Group</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(214, 49, false);
#line 14 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfGroup));

#line default
#line hidden
            EndContext();
            BeginContext(263, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(325, 45, false);
#line 17 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfGroup));

#line default
#line hidden
            EndContext();
            BeginContext(370, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(431, 45, false);
#line 20 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Specialty));

#line default
#line hidden
            EndContext();
            BeginContext(476, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(538, 57, false);
#line 23 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml"
       Write(Html.DisplayFor(model => model.Specialty.NameOfSpecialty));

#line default
#line hidden
            EndContext();
            BeginContext(595, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(656, 44, false);
#line 26 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Students));

#line default
#line hidden
            EndContext();
            BeginContext(700, 331, true);
            WriteLiteral(@"
        </dt>
        <dd class=""col-sm-10"">
            <table class=""table"">
                <tr>
                    <th>Last Name</th>
                    <th>First Name</th>
                    <th>Patronymic</th>
                    <th>Avg score</th>
                    <th>Foreigner</th>
                </tr>
");
            EndContext();
#line 37 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml"
                 foreach (var item in Model.Students)
                {

#line default
#line hidden
            BeginContext(1105, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1178, 43, false);
#line 41 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1301, 44, false);
#line 44 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1425, 45, false);
#line 47 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Patronymic));

#line default
#line hidden
            EndContext();
            BeginContext(1470, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1550, 47, false);
#line 50 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AverageScore));

#line default
#line hidden
            EndContext();
            BeginContext(1597, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1677, 44, false);
#line 53 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Foreigner));

#line default
#line hidden
            EndContext();
            BeginContext(1721, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 56 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1792, 67, true);
            WriteLiteral("            </table>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1859, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1fce597c08d8d4d5b0668b3d9460f2f047f50f89511", async() => {
                BeginContext(1905, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Group\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1913, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1921, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1fce597c08d8d4d5b0668b3d9460f2f047f50f811828", async() => {
                BeginContext(1943, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1959, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkplaceOfSecretary.Models.Group> Html { get; private set; }
    }
}
#pragma warning restore 1591
