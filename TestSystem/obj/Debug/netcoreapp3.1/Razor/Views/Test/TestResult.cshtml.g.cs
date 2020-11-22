#pragma checksum "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72aa24628fcd9ff986e8d2546ee85a7074f24dbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_TestResult), @"mvc.1.0.view", @"/Views/Test/TestResult.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72aa24628fcd9ff986e8d2546ee85a7074f24dbb", @"/Views/Test/TestResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"695bc706f3d1ddd8eec5a67426576255df862a9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_TestResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestSystem.Models.Test>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
  
    ViewData["Title"] = "Общий тест";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
 foreach (var question in Model.CloseQuestions)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <p>\r\n        <b>\r\n            ");
#nullable restore
#line 12 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
        Write(Model.CloseQuestions.IndexOf(question) + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 12 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
                                                      Write(Html.DisplayFor(item => question.Task));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </b>\r\n\r\n    </p>\r\n");
#nullable restore
#line 16 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"

    foreach (var answer in question.Answers)
    {

        if (answer.IsChecked == true && answer.IsRight == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                <h5 style=\"background:rgba(84, 255, 98, 0.87)\">\r\n                    <pre>");
#nullable restore
#line 24 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
                    Write(Html.CheckBoxFor(a => answer.IsChecked));

#line default
#line hidden
#nullable disable
            WriteLiteral("<label>  ");
#nullable restore
#line 24 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
                                                                     Write(answer.TextAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></pre>\r\n                </h5>\r\n            </p>\r\n");
#nullable restore
#line 27 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
        }
        else if (answer.IsChecked != answer.IsRight)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                <h5 style=\"background:rgb(255, 62, 62)\">\r\n                    <pre>");
#nullable restore
#line 32 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
                    Write(Html.CheckBoxFor(a => answer.IsChecked));

#line default
#line hidden
#nullable disable
            WriteLiteral("<label>  ");
#nullable restore
#line 32 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
                                                                     Write(answer.TextAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></pre>\r\n                </h5>\r\n            </p>\r\n");
#nullable restore
#line 35 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                <pre>");
#nullable restore
#line 39 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
                Write(Html.CheckBoxFor(a => answer.IsChecked));

#line default
#line hidden
#nullable disable
            WriteLiteral("<label>  ");
#nullable restore
#line 39 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
                                                                 Write(answer.TextAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></pre>\r\n            </p>\r\n");
#nullable restore
#line 41 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
        }
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 45 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
 foreach (var question in Model.OpenQuestions)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <p>\r\n        <b>\r\n            ");
#nullable restore
#line 50 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
        Write(Model.OpenQuestions.IndexOf(question) + 9);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 50 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
                                                     Write(Html.DisplayFor(item => question.Task));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </b>\r\n\r\n    </p>\r\n");
#nullable restore
#line 54 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"

    if (question.RightAnswer.TextAnswer == question.Choice)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p><h5 style=\"background:rgba(84, 255, 98, 0.87)\">Правильный ответ:</h5></p>\r\n    <p>\r\n        ");
#nullable restore
#line 59 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
   Write(Html.TextBoxFor(a => question.Choice, new { @readonly = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 61 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
    }

    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <h5 style=\"background:rgb(255, 62, 62)\">Неверный ответ:</h5>\r\n    </p>\r\n    <p> \r\n        ");
#nullable restore
#line 69 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
   Write(Html.TextBoxFor(a => question.Choice, new { @readonly = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p>Правильный вариант ответа</p>\r\n    <p>\r\n        ");
#nullable restore
#line 73 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
   Write(Html.TextBoxFor(a => question.RightAnswer.TextAnswer, new { @readonly = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 75 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"

    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Результат:</h3>\r\n<h5>Процент правильно определённых ответов: ");
#nullable restore
#line 80 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
                                       Write(Model.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</h5>\r\n<h5>Оценка: ");
#nullable restore
#line 81 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
       Write(Math.Round(Model.Result / 10));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n");
#nullable restore
#line 83 "D:\labs\ASP\TestSystem\Views\Test\TestResult.cshtml"
Write(Html.ActionLink("Отправить результат на почту", "SendMail", "Result", new { mark = @Math.Round(Model.Result / 10) }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
