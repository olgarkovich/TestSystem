#pragma checksum "D:\labs\ASP\TestSystem\Views\Test\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69cea65ed671cf088fab0407b379a713552697c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Category), @"mvc.1.0.view", @"/Views/Test/Category.cshtml")]
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
#line 1 "D:\labs\ASP\TestSystem\Views\_ViewImports.cshtml"
using TestSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\labs\ASP\TestSystem\Views\_ViewImports.cshtml"
using TestSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69cea65ed671cf088fab0407b379a713552697c6", @"/Views/Test/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"695bc706f3d1ddd8eec5a67426576255df862a9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestSystem.Models.Test>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\labs\ASP\TestSystem\Views\Test\Category.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Список тестов</h2>\r\n");
#nullable restore
#line 8 "D:\labs\ASP\TestSystem\Views\Test\Category.cshtml"
 try
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Раздел \"");
#nullable restore
#line 10 "D:\labs\ASP\TestSystem\Views\Test\Category.cshtml"
       Write(Model.ElementAt(0).Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</h3>\r\n");
#nullable restore
#line 11 "D:\labs\ASP\TestSystem\Views\Test\Category.cshtml"
}
catch(Exception ex)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 14 "D:\labs\ASP\TestSystem\Views\Test\Category.cshtml"
   Write(ex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3>Тесты не найдены.</h3>\r\n");
#nullable restore
#line 16 "D:\labs\ASP\TestSystem\Views\Test\Category.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\labs\ASP\TestSystem\Views\Test\Category.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 21 "D:\labs\ASP\TestSystem\Views\Test\Category.cshtml"
   Write(Html.ActionLink(item.Name, "CategoryTest", new { index = item.Id, category = item.Category }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 23 "D:\labs\ASP\TestSystem\Views\Test\Category.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestSystem.Models.Test>> Html { get; private set; }
    }
}
#pragma warning restore 1591
