#pragma checksum "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeAcademicBackground\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ed3cfb2af192eb2965e6f65abd16b1f7ba67d18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ResumeAcademicBackground_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ResumeAcademicBackground/Default.cshtml")]
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
#line 4 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI.ViewModels.ContactPostViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI.ViewModels.ResumeViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI.ViewModels.PortfolioVIewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI.ViewModels.BlogPostSingleViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ed3cfb2af192eb2965e6f65abd16b1f7ba67d18", @"/Views/Shared/Components/ResumeAcademicBackground/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd3aea1bc0d8c5a130b4116d058a41c3c6970ef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ResumeAcademicBackground_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AcademicBackground>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeAcademicBackground\Default.cshtml"
 foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"exp\">\r\n        <div class=\"media-left\">\r\n            <span class=\"sun\">");
#nullable restore
#line 7 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeAcademicBackground\Default.cshtml"
                         Write(item.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"media-body\">\r\n            <!-- COmpany Logo -->\r\n            <div class=\"company-logo\">\r\n                <span class=\"diploma\">\r\n");
            WriteLiteral("                </span>\r\n            </div>\r\n            <h6>");
#nullable restore
#line 16 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeAcademicBackground\Default.cshtml"
           Write(item.InstituteOrUniversityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <p>");
#nullable restore
#line 17 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeAcademicBackground\Default.cshtml"
          Write(item.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"margin-top-10\">\r\n                ");
#nullable restore
#line 19 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeAcademicBackground\Default.cshtml"
           Write(item.Details.ToPlainText());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 23 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeAcademicBackground\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AcademicBackground>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
