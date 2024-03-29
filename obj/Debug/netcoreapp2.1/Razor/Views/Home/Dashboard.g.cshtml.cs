#pragma checksum "/Users/kratos/Desktop/C#/WeddingPlanner/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4107cebb3c64e0fff3c86621a09e532db8d489fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/Users/kratos/Desktop/C#/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "/Users/kratos/Desktop/C#/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4107cebb3c64e0fff3c86621a09e532db8d489fa", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 715, true);
            WriteLiteral(@"<nav class=""navbar navbar-fluid navbar-expand-lg navbar-dark bg-dark mb-5"">
    <a class=""navbar-brand ml-5 lead"" href=""#""><big> Welcome to Wedding Planner </big></a>
    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
        <ul class=""navbar-nav ml-auto"">
            <li class=""nav-item"">
                <a class=""nav-link text-white"" href=""/logout"">Logout</a>
            </li>
        </ul>
    </div>
</nav>
<div class=""container"">
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th>Wedding</th>
                <th>Date</th>
                <th>Guests</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 22 "/Users/kratos/Desktop/C#/WeddingPlanner/Views/Home/Dashboard.cshtml"
             foreach( var g in ViewBag.Weddings)
            {

#line default
#line hidden
            BeginContext(778, 74, true);
            WriteLiteral("            <tr>\n                <th scope=\"row\"><a href=\"/wed/{g.WedId}\">");
            EndContext();
            BeginContext(853, 8, false);
#line 25 "/Users/kratos/Desktop/C#/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                                    Write(g.WedOne);

#line default
#line hidden
            EndContext();
            BeginContext(861, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(867, 8, false);
#line 25 "/Users/kratos/Desktop/C#/WeddingPlanner/Views/Home/Dashboard.cshtml"
                                                                  Write(g.WedTwo);

#line default
#line hidden
            EndContext();
            BeginContext(875, 31, true);
            WriteLiteral("!</a></th>\n                <td>");
            EndContext();
            BeginContext(907, 6, false);
#line 26 "/Users/kratos/Desktop/C#/WeddingPlanner/Views/Home/Dashboard.cshtml"
               Write(g.Date);

#line default
#line hidden
            EndContext();
            BeginContext(913, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 27 "/Users/kratos/Desktop/C#/WeddingPlanner/Views/Home/Dashboard.cshtml"
                 foreach(var h in g.Guests)
                {

#line default
#line hidden
            BeginContext(981, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(1002, 6, false);
#line 29 "/Users/kratos/Desktop/C#/WeddingPlanner/Views/Home/Dashboard.cshtml"
               Write(g.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1008, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 30 "/Users/kratos/Desktop/C#/WeddingPlanner/Views/Home/Dashboard.cshtml"
                 if (g.WedId == h.UserId) {

#line default
#line hidden
            BeginContext(1058, 36, true);
            WriteLiteral("                    <td>Delete</td>\n");
            EndContext();
#line 32 "/Users/kratos/Desktop/C#/WeddingPlanner/Views/Home/Dashboard.cshtml"
                } else {

#line default
#line hidden
            BeginContext(1119, 34, true);
            WriteLiteral("                    <td>RSVP</td>\n");
            EndContext();
#line 34 "/Users/kratos/Desktop/C#/WeddingPlanner/Views/Home/Dashboard.cshtml"
                }

#line default
#line hidden
#line 34 "/Users/kratos/Desktop/C#/WeddingPlanner/Views/Home/Dashboard.cshtml"
                 
                }

#line default
#line hidden
            BeginContext(1189, 18, true);
            WriteLiteral("            </tr>\n");
            EndContext();
#line 37 "/Users/kratos/Desktop/C#/WeddingPlanner/Views/Home/Dashboard.cshtml"
            }

#line default
#line hidden
            BeginContext(1221, 99, true);
            WriteLiteral("        </tbody>\n    </table>\n    <a href=\"/newwedding\" class=\"btn btn-dark\">New Wedding</a>\n</div>");
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
