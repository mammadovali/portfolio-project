#pragma checksum "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeExperience\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3e2b2ca62112883b14005ddcbc42fce26fcace3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ResumeExperience_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ResumeExperience/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e2b2ca62112883b14005ddcbc42fce26fcace3", @"/Views/Shared/Components/ResumeExperience/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd3aea1bc0d8c5a130b4116d058a41c3c6970ef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ResumeExperience_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Experience>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeExperience\Default.cshtml"
 foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"exp\">\r\n    <div class=\"media-left\">\r\n        <span class=\"sun\">");
#nullable restore
#line 7 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeExperience\Default.cshtml"
                     Write(item.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"media-body\">\r\n        <h6>");
#nullable restore
#line 10 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeExperience\Default.cshtml"
       Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <p>");
#nullable restore
#line 11 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeExperience\Default.cshtml"
      Write(item.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 12 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeExperience\Default.cshtml"
      Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"margin-top-10 ellipse\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeExperience\Default.cshtml"
       Write(Html.Raw(item.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 18 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Shared\Components\ResumeExperience\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
