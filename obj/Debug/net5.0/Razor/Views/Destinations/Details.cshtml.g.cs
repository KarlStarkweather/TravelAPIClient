#pragma checksum "C:\Users\kstar\Desktop\TravelAPIClient\Views\Destinations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dd77f1d93249d0e850aa551e59158c611a11d14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destinations_Details), @"mvc.1.0.view", @"/Views/Destinations/Details.cshtml")]
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
#line 1 "C:\Users\kstar\Desktop\TravelAPIClient\Views\_ViewImports.cshtml"
using TravelAPIClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kstar\Desktop\TravelAPIClient\Views\_ViewImports.cshtml"
using TravelAPIClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dd77f1d93249d0e850aa551e59158c611a11d14", @"/Views/Destinations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b711794be444cb727a6e16d4329cf9aa56525df", @"/Views/_ViewImports.cshtml")]
    public class Views_Destinations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelAPIClient.Models.Destination>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Destination Details:</h1>\r\n");
#nullable restore
#line 3 "C:\Users\kstar\Desktop\TravelAPIClient\Views\Destinations\Details.cshtml"
Write(Html.ActionLink("Edit this destination", "Edit", new { id = @Model.DestinationID}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br> \r\n");
#nullable restore
#line 5 "C:\Users\kstar\Desktop\TravelAPIClient\Views\Destinations\Details.cshtml"
Write(Html.ActionLink("Delete destination", "Delete", new { id = @Model.DestinationID}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ol>\r\n    <ul>\r\n        <li>ID: ");
#nullable restore
#line 8 "C:\Users\kstar\Desktop\TravelAPIClient\Views\Destinations\Details.cshtml"
           Write(Model.DestinationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Name: ");
#nullable restore
#line 9 "C:\Users\kstar\Desktop\TravelAPIClient\Views\Destinations\Details.cshtml"
             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>City: ");
#nullable restore
#line 10 "C:\Users\kstar\Desktop\TravelAPIClient\Views\Destinations\Details.cshtml"
             Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Country: ");
#nullable restore
#line 11 "C:\Users\kstar\Desktop\TravelAPIClient\Views\Destinations\Details.cshtml"
                Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n</ol>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelAPIClient.Models.Destination> Html { get; private set; }
    }
}
#pragma warning restore 1591