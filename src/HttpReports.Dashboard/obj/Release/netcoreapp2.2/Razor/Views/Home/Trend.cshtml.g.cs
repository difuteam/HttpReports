#pragma checksum "G:\Lee\HttpReports\src\HttpReports.Dashboard\Views\Home\Trend.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4609390210263283becf121e5d57774b68776bd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Trend), @"mvc.1.0.view", @"/Views/Home/Trend.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Trend.cshtml", typeof(AspNetCore.Views_Home_Trend))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4609390210263283becf121e5d57774b68776bd8", @"/Views/Home/Trend.cshtml")]
    public class Views_Home_Trend : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\Lee\HttpReports\src\HttpReports.Dashboard\Views\Home\Trend.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

     List<string> nodes = ViewBag.nodes; 

#line default
#line hidden
            BeginContext(136, 711, true);
            WriteLiteral(@"
<div class=""panel panel-default"">

    <div class=""panel-body"" style=""padding-left:30px;padding-right:30px;padding-top:30px;min-height:720px"">

        <div class=""row"" style=""padding-left:13px;padding-right:13px"">

            <div class=""panel panel-default"">
                <div class=""panel-body shadow-box"" style=""padding-bottom:20px"">

                    <div class=""form-inline form"">

                        <div class=""col-sm-12"" style=""margin-top:10px"">

                            <b><i class=""glyphicon glyphicon-signal""></i> 服务节点</b>

                            <span class=""glyphicon glyphicon-info-sign serviceTip"" style=""font-size:20px;top:0.2em;cursor:pointer""></span>

");
            EndContext();
            BeginContext(1188, 153, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"col-sm-12 node-row\" style=\"margin-top:8px;margin-bottom:8px;min-height:44px\">\r\n\r\n");
            EndContext();
#line 34 "G:\Lee\HttpReports\src\HttpReports.Dashboard\Views\Home\Trend.cshtml"
                             foreach (var item in nodes)
                            {

#line default
#line hidden
            BeginContext(1430, 159, true);
            WriteLiteral("                                <button onclick=\"check_node(this)\" style=\"width:120px;margin-left:20px;border-radius:4px;\" class=\"btn btn-info service-button\">");
            EndContext();
            BeginContext(1590, 4, false);
#line 36 "G:\Lee\HttpReports\src\HttpReports.Dashboard\Views\Home\Trend.cshtml"
                                                                                                                                                          Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(1594, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 37 "G:\Lee\HttpReports\src\HttpReports.Dashboard\Views\Home\Trend.cshtml"
                            }

#line default
#line hidden
            BeginContext(1636, 1020, true);
            WriteLiteral(@"
                        </div>

                    </div>

                    <div class=""col-sm-12"" style="""">

                        <div class=""col-sm-3"" style=""padding-left:0"">

                            <button style=""min-width:120px;"" onclick=""QueryClick(this)"" class=""btn btn-info  btn-search"">查询</button>

                        </div>

                    </div>

                </div>
            </div>

        </div>

        <div class=""row"">

            <div class=""col-md-12"">

                <div class=""panel panel-default"">
                    <div class=""panel-body shadow-box"" style=""padding-top:20px;padding-bottom:14px"">

                        <div class=""col-sm-12"" style=""margin-bottom:12px;"">

                            <div class=""form-inline form"">


                                <label class=""form-label"">按天查询</label>
                                <input type=""text"" style=""max-width:120px;min-width:120px"" class=""form-control laydate day""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2656, "\"", 2702, 1);
#line 71 "G:\Lee\HttpReports\src\HttpReports.Dashboard\Views\Home\Trend.cshtml"
WriteAttributeValue("", 2664, DateTime.Now.ToString("yyyy-MM-dd"), 2664, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2703, 1217, true);
            WriteLiteral(@">

                                <button style=""min-width:120px;margin-left:6px;"" onclick=""GetDayChart()"" class=""btn btn-info btn-search"">查询</button>

                            </div>

                        </div>

                        <div class=""col-sm-12"">
                            <div id=""DayStateTimesBar"" style=""height:300px""></div>
                        </div>

                        <div class=""col-sm-12"" style=""margin-top:12px"">
                            <div id=""DayStateAvgBar"" style=""height:300px""></div>
                        </div>

                    </div>
                </div>

            </div>

        </div> 


        <div class=""row"">

            <div class=""col-md-12"">

                <div class=""panel panel-default"">
                    <div class=""panel-body shadow-box"">

                        <div class=""col-sm-12"" style=""margin-bottom:12px;padding-top:20px;"">

                            <div class=""form-inline form"">


    ");
            WriteLiteral("                            <label class=\"form-label\">按月查询</label>\r\n                                <input type=\"text\" style=\"max-width:120px;min-width:120px\" class=\"form-control laydate month\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3920, "\"", 3963, 1);
#line 108 "G:\Lee\HttpReports\src\HttpReports.Dashboard\Views\Home\Trend.cshtml"
WriteAttributeValue("", 3928, DateTime.Now.ToString("yyyy-MM"), 3928, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3964, 1029, true);
            WriteLiteral(@">

                                <button style=""min-width:120px;margin-left:6px;"" onclick=""GetLatelyChart()"" class=""btn btn-info btn-search"">查询</button>

                            </div>

                        </div>

                        <div class=""col-sm-12"">

                            <div id=""LatelyDayChart"" style=""height:360px""></div>

                        </div>

                    </div>
                </div>

            </div>

        </div>

        <div class=""row"">

            <div class=""col-md-12"">

                <div class=""panel panel-default"">
                    <div class=""panel-body shadow-box"">

                        <div class=""col-sm-12"" style=""margin-bottom:12px;padding-top:20px;"">

                            <div class=""form-inline form"">


                                <label class=""form-label"">按年查询</label>
                                <input type=""text"" style=""max-width:120px;min-width:120px"" class=""form-control laydate ");
            WriteLiteral("year\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4993, "\"", 5033, 1);
#line 142 "G:\Lee\HttpReports\src\HttpReports.Dashboard\Views\Home\Trend.cshtml"
WriteAttributeValue("", 5001, DateTime.Now.ToString("yyyy"), 5001, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5034, 587, true);
            WriteLiteral(@">

                                <button style=""min-width:120px;margin-left:6px;"" onclick=""GetLatelyMonthChart()"" class=""btn btn-info btn-search"">查询</button>

                            </div>

                        </div>

                        <div class=""col-sm-12"">

                            <div id=""LatelyMonthChart"" style=""height:360px""></div>

                        </div>

                    </div>
                </div>

            </div>

        </div>


    </div>

</div>

 
<script src=""/Content/page/trend.js?ver=1.0.1""></script>");
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