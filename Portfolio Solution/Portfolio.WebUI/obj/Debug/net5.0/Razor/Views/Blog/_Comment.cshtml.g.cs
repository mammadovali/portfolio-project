#pragma checksum "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Blog\_Comment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fe419094ce25bfacb3b5da92247ef26924a613f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog__Comment), @"mvc.1.0.view", @"/Views/Blog/_Comment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fe419094ce25bfacb3b5da92247ef26924a613f", @"/Views/Blog/_Comment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd3aea1bc0d8c5a130b4116d058a41c3c6970ef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog__Comment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogPostComment>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li");
            BeginWriteAttribute("class", " class=\"", 29, "\"", 108, 3);
            WriteAttributeValue("", 37, "margin-bottom-30", 37, 16, true);
#nullable restore
#line 3 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Blog\_Comment.cshtml"
WriteAttributeValue(" ", 53, Model.ParentId != null ? "comment-sub" : "", 54, 46, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 100, "comment", 101, 8, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 109, "\"", 125, 2);
            WriteAttributeValue("", 114, "c-", 114, 2, true);
#nullable restore
#line 3 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Blog\_Comment.cshtml"
WriteAttributeValue("", 116, Model.Id, 116, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-comment-id=\"");
#nullable restore
#line 3 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Blog\_Comment.cshtml"
                                                                                                                 Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    <div class=\"media\">\r\n        <div class=\"media-body\">\r\n            <div class=\"a-com\">\r\n                <span class=\"a-name text-color-primary\">");
#nullable restore
#line 7 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Blog\_Comment.cshtml"
                                                    Write($"{Model.CreatedByUser?.Name} {Model.CreatedByUser?.Surname}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"date\">");
#nullable restore
#line 7 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Blog\_Comment.cshtml"
                                                                                                                                             Write(Model.CreatedDate.ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(".</span>\r\n                <p class=\"margin-top-20\">\r\n                    ");
#nullable restore
#line 9 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Blog\_Comment.cshtml"
               Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <a class=\"text-right btn-comment-reply\"> REPLAY <i class=\"fa fa-reply\"></i></a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</li>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogPostComment> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
