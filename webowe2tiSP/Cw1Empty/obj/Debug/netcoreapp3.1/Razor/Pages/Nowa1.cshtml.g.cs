#pragma checksum "D:\zdalne\zdalneNiepo2020\webowe2tiSP\Cw1Empty\Pages\Nowa1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa970a3b3dc1b132161eeb5acc92054a462b84f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Cw1Empty.Pages_Nowa1), @"mvc.1.0.razor-page", @"/Pages/Nowa1.cshtml")]
namespace Cw1Empty
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa970a3b3dc1b132161eeb5acc92054a462b84f4", @"/Pages/Nowa1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9ce11add4616b30254564980bfaae02447b08f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Nowa1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Nowa1</h3>\r\n<div>\r\n");
#nullable restore
#line 7 "D:\zdalne\zdalneNiepo2020\webowe2tiSP\Cw1Empty\Pages\Nowa1.cshtml"
     foreach (var item in Model.Numbers)
    {
        //@string.Format("{0} ",item);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>");
#nullable restore
#line 10 "D:\zdalne\zdalneNiepo2020\webowe2tiSP\Cw1Empty\Pages\Nowa1.cshtml"
         Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n");
#nullable restore
#line 11 "D:\zdalne\zdalneNiepo2020\webowe2tiSP\Cw1Empty\Pages\Nowa1.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.Nowa1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.Nowa1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.Nowa1Model>)PageContext?.ViewData;
        public MyApp.Namespace.Nowa1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
