#pragma checksum "E:\University\Level 3\Second Semester\Software Engineering 2\Project\WebApplication1\Views\Shared\_Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7066a6673f9811ba026bfe4f87898f241c3b88d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Search), @"mvc.1.0.view", @"/Views/Shared/_Search.cshtml")]
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
#line 1 "E:\University\Level 3\Second Semester\Software Engineering 2\Project\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\University\Level 3\Second Semester\Software Engineering 2\Project\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7066a6673f9811ba026bfe4f87898f241c3b88d", @"/Views/Shared/_Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\University\Level 3\Second Semester\Software Engineering 2\Project\WebApplication1\Views\Shared\_Search.cshtml"
 using(Html.BeginForm("Operations", "Faculties")){

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row ml-4\">\r\n    <div class=\" col-md-4 \">\r\n\r\n        <div class=\"form-group\">\r\n            <label>Search</label>\r\n            <input type=\"text\" class=\"form-control\" name=\"SearchString\" />\r\n        </div>\r\n    </div>\r\n</div>");
#nullable restore
#line 11 "E:\University\Level 3\Second Semester\Software Engineering 2\Project\WebApplication1\Views\Shared\_Search.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
