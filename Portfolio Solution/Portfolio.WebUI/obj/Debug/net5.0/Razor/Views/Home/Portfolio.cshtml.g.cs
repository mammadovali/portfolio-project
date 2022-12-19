#pragma checksum "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Home\Portfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07dff14e871c87d0228423870eb052868ee4ca61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Portfolio), @"mvc.1.0.view", @"/Views/Home/Portfolio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07dff14e871c87d0228423870eb052868ee4ca61", @"/Views/Home/Portfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd3aea1bc0d8c5a130b4116d058a41c3c6970ef", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Portfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PortfolioViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Projects", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Home\Portfolio.cshtml"
  
    ViewData["Title"] = "Portfolio";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div role=""tabpanel"" class=""tab-pane fade active in"" id=""portfolio"">
    <div class=""inside-sec"">
        <!-- BIO AND SKILLS -->
        <h5 class=""tittle"">PORTFOLIO</h5>

        <!-- PORTFOLIO -->
        <section class=""portfolio padding-top-50 padding-bottom-50"">
            <!-- Work Filter -->
            <ul class=""tabs portfolio-filter text-center margin-bottom-30"">
                <li class=""filter"" data-filter=""all"">all</li>
");
#nullable restore
#line 17 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Home\Portfolio.cshtml"
                 foreach (var item in Model.ProjectCategories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"filter\" data-filter=\".c-");
#nullable restore
#line 19 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Home\Portfolio.cshtml"
                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 19 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Home\Portfolio.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 20 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Home\Portfolio.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n\r\n            <!-- PORTFOLIO ITEMS -->\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07dff14e871c87d0228423870eb052868ee4ca617449", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </section>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral("\r\n<script>\r\n    $(document).ready(function(e){\r\n        e.preventDefault();\r\n\r\n        let fd = new FormData();\r\n\r\n        var categoryId = ");
#nullable restore
#line 36 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Home\Portfolio.cshtml"
                    Write(Model.ProjectCategories);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\r\n        $.ajax({\r\n             url: `");
#nullable restore
#line 39 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\portfolio-project\Portfolio Solution\Portfolio.WebUI\Views\Home\Portfolio.cshtml"
              Write(Url.Action("Portfolio"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
             type: 'POST',
             data: fd,
             contentType: false,
             processData: false,
             success: function (response) {
                 console.log(response)
                 if (response.error == true) {
                     return;
                 }
                 location.reload();
             },
             error: function (errorResponse) {
                 console.error(errorResponse);
             }
        });
    })
</script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PortfolioViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
