#pragma checksum "D:\Seavus\ASP.Net Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Feedback\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99b728e54c2bd63509d35e1d3e94e6f16f084061"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedback_Details), @"mvc.1.0.view", @"/Views/Feedback/Details.cshtml")]
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
#line 1 "D:\Seavus\ASP.Net Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Refactored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Seavus\ASP.Net Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Refactored.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Seavus\ASP.Net Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.OrderViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Seavus\ASP.Net Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Seavus\ASP.Net Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.PizzaViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Seavus\ASP.Net Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.HomeViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Seavus\ASP.Net Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b728e54c2bd63509d35e1d3e94e6f16f084061", @"/Views/Feedback/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fa8afc74590fd1079c202edeb11b6d5470af399", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedback_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FeedbackDetailsViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2 class=\"display-4\">Feedback Details</h2>\r\n</div>\r\n<br />\r\n<br />\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99b728e54c2bd63509d35e1d3e94e6f16f0840614643", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 10 "D:\Seavus\ASP.Net Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Feedback\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(": ");
#nullable restore
#line 10 "D:\Seavus\ASP.Net Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Feedback\Details.cshtml"
                                                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99b728e54c2bd63509d35e1d3e94e6f16f0840616481", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 11 "D:\Seavus\ASP.Net Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Feedback\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(": ");
#nullable restore
#line 11 "D:\Seavus\ASP.Net Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Feedback\Details.cshtml"
                                                                              Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99b728e54c2bd63509d35e1d3e94e6f16f0840618341", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 12 "D:\Seavus\ASP.Net Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Feedback\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Message);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(": ");
#nullable restore
#line 12 "D:\Seavus\ASP.Net Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Feedback\Details.cshtml"
                                                                                Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    </div>\r\n</div>\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FeedbackDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
