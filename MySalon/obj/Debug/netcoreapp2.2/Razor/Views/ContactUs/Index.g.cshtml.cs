#pragma checksum "C:\Users\heysu\source\repos\MySalon\MySalon\Views\ContactUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c296ec705ee545070bfade295ead332feb12104"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactUs_Index), @"mvc.1.0.view", @"/Views/ContactUs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ContactUs/Index.cshtml", typeof(AspNetCore.Views_ContactUs_Index))]
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
#line 1 "C:\Users\heysu\source\repos\MySalon\MySalon\Views\_ViewImports.cshtml"
using MySalon;

#line default
#line hidden
#line 2 "C:\Users\heysu\source\repos\MySalon\MySalon\Views\_ViewImports.cshtml"
using MySalon.Models;

#line default
#line hidden
#line 1 "C:\Users\heysu\source\repos\MySalon\MySalon\Views\ContactUs\Index.cshtml"
using MySalon.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c296ec705ee545070bfade295ead332feb12104", @"/Views/ContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4410dbba6612675ceb64a23ac590b12f9b5323a1", @"/Views/_ViewImports.cshtml")]
    public class Views_ContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\heysu\source\repos\MySalon\MySalon\Views\ContactUs\Index.cshtml"
  
    ViewData["Title"] = "Contact Us";

#line default
#line hidden
            BeginContext(89, 1489, true);
            WriteLiteral(@"<div class=""container"">
<h2>Contact My Salon</h2>
    <p>WHY US?</p>
    <p>Our mission is simple: fashion forward style, mastery of the latest hair trends and techniques, superior customer service, and a personal dedication to excellence.</p></p>
    <p>Contact: 0450 520 690</p>
    <p>Address: 1/120 Mitchell Street, Darwin, Northern Territory Pearl st. Boulder, Co. 0820</p>
    <p>Salon Hours:</p>
    <p>Monday-Friday: 10am-8pm
        Saturday: 10am-5pm
        Closed on Sunday</p>
<div class=""container"">
    <style>
         /* Always set the map height explicitly to define the size of the div
        * element that contains the map. */
         #map {
             height: 400px;
             width: 800px;
         }
         /* Optional: Makes the sample page fill the window. */
         html, body {
             height: 100%;
             margin: 0;
             padding: 0;
         }
    </style>
    <div class=""row"">
        <div id=""map""></div>
        <script>
           ");
            WriteLiteral(@" var map;
            function initMap() {
                map = new google.maps.Map(document.getElementById('map'), {
                    center: { lat: 37.095142, lng: -95.582413 },
                    zoom: 8
                });
            }
        </script>
        <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyDJGVs0gYZOwt4F5TAjjy3h21IF2xwwbbQ&callback=initMap""
                async defer></script>
    </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591
