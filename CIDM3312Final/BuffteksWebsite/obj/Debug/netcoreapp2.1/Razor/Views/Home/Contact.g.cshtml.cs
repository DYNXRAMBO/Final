#pragma checksum "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cae93b5d7d512d9201c8fb9d3eefa11776b8af7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cae93b5d7d512d9201c8fb9d3eefa11776b8af7", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa45fcdfe59cbc6eb4c5ec57a208b4bd7d61e026", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(40, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(45, 17, false);
#line 4 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(62, 10, true);
            WriteLiteral("</h2>\n<h3>");
            EndContext();
            BeginContext(73, 19, false);
#line 5 "C:\Users\mbm-m\Desktop\Final\CIDM3312Final\BuffteksWebsite\Views\Home\Contact.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(92, 347, true);
            WriteLiteral(@"</h3>

<address>
    2501 4th Ave.<br />
    Canyon, Tx 79016<br />
    <abbr title=""Phone"">P:</abbr>
     806-651-2080
</address>

<address>
    <strong>Support:</strong> <a href=""mailto:Support@example.com"">Support@example.com</a><br />
    <strong>Marketing:</strong> <a href=""mailto:Marketing@example.com"">Marketing@example.com</a>
</address>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
