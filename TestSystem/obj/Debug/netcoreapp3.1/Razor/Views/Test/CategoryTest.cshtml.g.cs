#pragma checksum "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b33cbb696fda708c9970e9f90ad0dd8051c87ec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_CategoryTest), @"mvc.1.0.view", @"/Views/Test/CategoryTest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33cbb696fda708c9970e9f90ad0dd8051c87ec9", @"/Views/Test/CategoryTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"695bc706f3d1ddd8eec5a67426576255df862a9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_CategoryTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestSystem.Models.Test>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
  
    ViewData["Title"] = "Тест по разделу";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b33cbb696fda708c9970e9f90ad0dd8051c87ec93882", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 10 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
Write(Html.HiddenFor(name => Model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 11 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
Write(Html.HiddenFor(category => Model.Category));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 13 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
     for (int n = 0; n < Model.CloseQuestions.Count(); n++)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\r\n        <p>\r\n            <b>\r\n                ");
#nullable restore
#line 18 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
            Write(n + 1);

#line default
#line hidden
#nullable disable
                WriteLiteral(". <span style=\"white-space: pre-line\">");
#nullable restore
#line 18 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
                                                         Write(Model.CloseQuestions[n].Task);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </b>\r\n\r\n        </p>\r\n");
#nullable restore
#line 22 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"

        for (int i = 0; i < Model.CloseQuestions[n].Answers.Count; i++)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
       Write(Html.HiddenFor(q => Model.CloseQuestions[i].Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
       Write(Html.HiddenFor(q => Model.CloseQuestions[i].Category));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
       Write(Html.HiddenFor(q => Model.CloseQuestions[i].IsOpen));

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>\r\n                <pre>  ");
#nullable restore
#line 29 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
                  Write(Html.CheckBoxFor(a => Model.CloseQuestions[n].Answers[i].IsChecked));

#line default
#line hidden
#nullable disable
                WriteLiteral("<label>  ");
#nullable restore
#line 29 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
                                                                                               Write(Model.CloseQuestions[n].Answers[i].TextAnswer);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></pre>\r\n                ");
#nullable restore
#line 30 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
           Write(Html.HiddenFor(a => Model.CloseQuestions[n].Answers[i].Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 31 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
           Write(Html.HiddenFor(a => Model.CloseQuestions[n].Answers[i].QuestionId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 32 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
           Write(Html.HiddenFor(a => Model.CloseQuestions[n].Answers[i].TextAnswer));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 33 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
           Write(Html.HiddenFor(a => Model.CloseQuestions[n].Answers[i].IsRight));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n");
#nullable restore
#line 35 "D:\labs\ASP\TestSystem\Views\Test\CategoryTest.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <p>\r\n        <input type=\"submit\" value=\"Отправить\" />\r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestSystem.Models.Test> Html { get; private set; }
    }
}
#pragma warning restore 1591
