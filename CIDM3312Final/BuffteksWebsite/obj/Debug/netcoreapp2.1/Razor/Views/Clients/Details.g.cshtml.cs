#pragma checksum "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Clients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cda6c3621b2789ae99032477b44c963c57b21b98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Details), @"mvc.1.0.view", @"/Views/Clients/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Details.cshtml", typeof(AspNetCore.Views_Clients_Details))]
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
#line 1 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\_ViewImports.cshtml"
using BuffteksWebsite;

#line default
#line hidden
#line 2 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\_ViewImports.cshtml"
using BuffteksWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cda6c3621b2789ae99032477b44c963c57b21b98", @"/Views/Clients/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa45fcdfe59cbc6eb4c5ec57a208b4bd7d61e026", @"/Views/_ViewImports.cshtml")]
    public class Views_Clients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BuffteksWebsite.Models.Client>
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
            BeginContext(37, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Clients\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 112, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Client</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(191, 47, false);
#line 14 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(238, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(279, 43, false);
#line 17 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(322, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(363, 45, false);
#line 20 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(408, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(449, 41, false);
#line 23 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(490, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(531, 44, false);
#line 26 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(575, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(616, 40, false);
#line 29 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(656, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(697, 41, false);
#line 32 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(738, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(779, 37, false);
#line 35 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(816, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(857, 41, false);
#line 38 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(898, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(939, 37, false);
#line 41 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(976, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1018, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed9a10737e964315a7aee8defbae26b5", async() => {
                BeginContext(1064, 4, true);
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
#line 46 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Clients\Details.cshtml"
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
            BeginContext(1072, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1079, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3963556b9c44a4eabce766421b7e6c4", async() => {
                BeginContext(1101, 12, true);
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
            BeginContext(1117, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BuffteksWebsite.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
