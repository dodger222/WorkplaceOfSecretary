#pragma checksum "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e453ba8216c82e0b319bc3bf86d965fb72d6cfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Committee_Delete), @"mvc.1.0.view", @"/Views/Committee/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Committee/Delete.cshtml", typeof(AspNetCore.Views_Committee_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e453ba8216c82e0b319bc3bf86d965fb72d6cfd", @"/Views/Committee/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78448a6b5d6daf32f79a6a0e48a491fbb75261ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Committee_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkplaceOfSecretary.Models.Committee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(90, 42, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n<p class=\"text-danger\">");
            EndContext();
            BeginContext(133, 24, false);
#line 8 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
                  Write(ViewData["ErrorMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(157, 164, true);
            WriteLiteral("</p>\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Committee</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(322, 39, false);
#line 15 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Seb));

#line default
#line hidden
            EndContext();
            BeginContext(361, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(425, 45, false);
#line 18 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Seb.NameOfSEB));

#line default
#line hidden
            EndContext();
            BeginContext(470, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(539, 47, false);
#line 21 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Chairperson));

#line default
#line hidden
            EndContext();
            BeginContext(586, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(650, 52, false);
#line 24 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Chairperson.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(702, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(771, 45, false);
#line 27 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Secretary));

#line default
#line hidden
            EndContext();
            BeginContext(816, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(880, 50, false);
#line 30 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Secretary.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(930, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(999, 45, false);
#line 33 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MemberOne));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1108, 50, false);
#line 36 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MemberOne.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1158, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1227, 45, false);
#line 39 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MemberTwo));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1336, 50, false);
#line 42 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MemberTwo.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1455, 47, false);
#line 45 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MemberThree));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1566, 52, false);
#line 48 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MemberThree.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1618, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1662, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e453ba8216c82e0b319bc3bf86d965fb72d6cfd10531", async() => {
                BeginContext(1688, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1698, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e453ba8216c82e0b319bc3bf86d965fb72d6cfd10924", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 53 "F:\Git\WorkplaceOfSecretary\WorkplaceOfSecretary\Views\Committee\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1734, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1817, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e453ba8216c82e0b319bc3bf86d965fb72d6cfd12829", async() => {
                    BeginContext(1839, 12, true);
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
                BeginContext(1855, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1868, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkplaceOfSecretary.Models.Committee> Html { get; private set; }
    }
}
#pragma warning restore 1591
