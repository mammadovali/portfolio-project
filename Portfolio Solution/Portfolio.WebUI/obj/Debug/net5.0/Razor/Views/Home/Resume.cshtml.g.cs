#pragma checksum "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92fd7411d9b6ae0ebb82b3b65ffca1eb896e8e83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Resume), @"mvc.1.0.view", @"/Views/Home/Resume.cshtml")]
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
#line 4 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI.ViewModels.ContactPostViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI.ViewModels.ResumeViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92fd7411d9b6ae0ebb82b3b65ffca1eb896e8e83", @"/Views/Home/Resume.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b23df5dd80fedc5ebef78576a21501b3fb6e467", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Resume : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResumeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
  
    ViewData["Title"] = "Resume";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- RESUME -->
<div style=""opacity:1; display:block;"" role=""tabpanel"" class=""tab-pane fade"" id=""resume"">
    <div class=""inside-sec"">
        <!-- BIO AND SKILLS -->
        <h5 class=""tittle"">Bio & Skills</h5>
        <div class=""bio-info padding-30"">
            <div>
                ");
#nullable restore
#line 13 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
           Write(Html.Raw(Model.ResumeBio.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>

            <div class=""skills"">

                <!-- HARD SKILLS -->
                <h5 class=""margin-top-30"">Hard Skills</h5>
                <h6>Physical SCiences</h6>

                <!-- Sound Engineering -->
                <div class=""panel-group accordion"" id=""accordion5"">
                    <div class=""panel panel-default"">
                        <div class=""row"">
                            <div class=""col-sm-4"">
                                <!-- PANEL HEADING -->
                                <div class=""panel-heading"">
                                    <h4 class=""panel-title""> <a data-toggle=""collapse"" data-parent=""#accordion5"" href=""#collapseOne5""> Sound Engineering</a> </h4>
                                </div>
                            </div>

                            <!-- Skillls Bars -->
                            <div class=""col-sm-8"">
                                <div class=""progress"">
                                    <di");
            WriteLiteral(@"v class=""progress-bar"" role=""progressbar"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 80%;""> <span class=""sr-only"">60% Complete</span> </div>
                                </div>

                                <!-- Skillls Text -->
                                <div id=""collapseOne5"" class=""panel-collapse collapse in"">
                                    <div class=""panel-body"">
                                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem.</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- Business Administration -->
                    <h6>Business Administration</h6>
                    <div class=""panel panel-default"">
                        <div class=""row"">
                            <di");
            WriteLiteral(@"v class=""col-sm-4"">
                                <!-- PANEL HEADING -->
                                <div class=""panel-heading"">
                                    <h4 class=""panel-title""> <a data-toggle=""collapse"" data-parent=""#accordion5"" href=""#collapsetwo5"" class=""collapsed""> Farming Economics</a> </h4>
                                </div>
                            </div>

                            <!-- Skillls Bars -->
                            <div class=""col-sm-8"">
                                <div class=""progress"">
                                    <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 60%;""> <span class=""sr-only"">60% Complete</span> </div>
                                </div>

                                <!-- Skillls Text -->
                                <div id=""collapsetwo5"" class=""panel-collapse collapse"">
                                    <div class=""panel-body"">
          ");
            WriteLiteral(@"                              <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem.</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Soft Skills -->
                <h5 class=""margin-top-30"">Soft Skills</h5>

                <!-- Application of knowledge -->
                <h6>Application of knowledge</h6>
                <div class=""panel-group accordion"" id=""accordion1"">
                    <div class=""panel panel-default"">
                        <div class=""row"">
                            <div class=""col-sm-4"">
                                <!-- PANEL HEADING -->
                                <div class=""panel-heading"">
                                    <h4 class=""panel-title""> <a data-toggle=""collapse"" data-parent=""#accor");
            WriteLiteral(@"dion1"" href=""#collapsethr"" class=""collapsed""> Farming Economics</a> </h4>
                                </div>
                            </div>

                            <!-- Skillls Bars -->
                            <div class=""col-sm-8"">
                                <div class=""progress"">
                                    <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 100%;""> <span class=""sr-only"">60% Complete</span> </div>
                                </div>

                                <!-- Skillls Text -->
                                <div id=""collapsethr"" class=""panel-collapse collapse"">
                                    <div class=""panel-body"">
                                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem.</p>
                                    </div>
                          ");
            WriteLiteral(@"      </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Follow ethical -->
                <div class=""ethical"">
                    <h6>Follow ethical work practices</h6>
                    <a href=""#."">Prioritize Learning Tasks</a> <a href=""#."">Make Ethical Choices</a> <a href=""#."">Social Work</a> <a href=""#."">Community Work</a>
                </div>
            </div>
        </div>
    </div>

    <!-- Professional Experience -->
    <div class=""inside-sec margin-top-30"">
        <!-- Professional Experience -->
        <h5 class=""tittle"">Professional Experience</h5>
        <div class=""padding-30 exp-history"">

");
#nullable restore
#line 124 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
             foreach (var item in Model.Experiences)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"exp\">\r\n                    <div class=\"media-left\"> <span class=\"sun\">");
#nullable restore
#line 127 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
                                                          Write(item.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </div>\r\n                    <div class=\"media-body\">\r\n                        <h6>");
#nullable restore
#line 129 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
                       Write(item.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p>Company name: <b>");
#nullable restore
#line 130 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
                                       Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                        <p>");
#nullable restore
#line 131 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
                      Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        <p class=\"margin-top-10\"> Details: <br /> ");
#nullable restore
#line 132 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
                                                             Write(Html.Raw(item.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 135 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <!-- Academic Background -->\r\n    <div class=\"inside-sec margin-top-30\">\r\n        <!-- Academic Background -->\r\n        <h5 class=\"tittle\">Academic Background</h5>\r\n        <div class=\"padding-30 exp-history\">\r\n");
#nullable restore
#line 145 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
             foreach (var item in Model.AcademicBackgrounds)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"exp\">\r\n                    <div class=\"media-left\"> <span class=\"sun\">");
#nullable restore
#line 148 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
                                                          Write(item.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </div>\r\n                    <div class=\"media-body\">\r\n                        <h6>");
#nullable restore
#line 150 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
                       Write(item.Qualification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p>Degree: <b>");
#nullable restore
#line 151 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
                                 Write(item.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                        <p>University or institute: <b>");
#nullable restore
#line 152 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
                                                  Write(item.InstituteOrUniversityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> </p>\r\n                        <p class=\"margin-top-10\"> Details: <br /> ");
#nullable restore
#line 153 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
                                                             Write(Html.Raw(item.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 156 "C:\Users\Əli\Desktop\Back-end\ASP.NET\Asp Net Intro Solution\Portfolio Solution\Portfolio.WebUI\Views\Home\Resume.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResumeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
