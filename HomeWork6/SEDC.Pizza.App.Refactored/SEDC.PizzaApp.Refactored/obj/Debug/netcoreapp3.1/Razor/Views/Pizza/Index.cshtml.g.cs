#pragma checksum "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b84f7b372a7746ead99362c06deac25223b9e5c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Index), @"mvc.1.0.view", @"/Views/Pizza/Index.cshtml")]
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
#line 1 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Refactored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Refactored.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.OrderViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.PizzaViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.HomeViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b84f7b372a7746ead99362c06deac25223b9e5c2", @"/Views/Pizza/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fa8afc74590fd1079c202edeb11b6d5470af399", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PizzaListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pizza", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84f7b372a7746ead99362c06deac25223b9e5c25885", async() => {
                WriteLiteral("Create pizza");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <h2 class=\"display-4\">List of pizzas:</h2>\r\n</div>\r\n<br />\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Index.cshtml"
     foreach (var pizza in @Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card text-white bg-success mb-3\" style=\"max-width: 18rem; margin-left:10px;\">\r\n");
#nullable restore
#line 13 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Index.cshtml"
             if (pizza.IsOnPromotion)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card-header\">The pizza is on promotion</div>\r\n");
#nullable restore
#line 16 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card-header\">The piza is not on promotion</div>\r\n");
#nullable restore
#line 20 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">User: ");
#nullable restore
#line 22 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Index.cshtml"
                                        Write(pizza.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"card-title\">User: ");
#nullable restore
#line 23 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Index.cshtml"
                                        Write(pizza.PizzaSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"card-title\">User: ");
#nullable restore
#line 24 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Index.cshtml"
                                        Write(pizza.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84f7b372a7746ead99362c06deac25223b9e5c210023", async() => {
                WriteLiteral("See details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Index.cshtml"
                                                             WriteLiteral(pizza.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 28 "C:\Users\Kiko\Desktop\STEFAN\ASP.Net MVC Predavanja\Class 8\SEDC.Pizza.App.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PizzaListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
