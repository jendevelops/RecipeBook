#pragma checksum "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Ingredient/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d91809929546573f632862c69b9bdd2e476d79d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingredient_Create), @"mvc.1.0.view", @"/Views/Ingredient/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ingredient/Create.cshtml", typeof(AspNetCore.Views_Ingredient_Create))]
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
#line 1 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/_ViewImports.cshtml"
using RecipeBook;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/_ViewImports.cshtml"
using RecipeBook.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d91809929546573f632862c69b9bdd2e476d79d", @"/Views/Ingredient/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f55e906a5633bee239e13d6bf3a32417c57e856", @"/Views/_ViewImports.cshtml")]
    public class Views_Ingredient_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBook.Models.Ingredient>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Ingredient/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(64, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Ingredient/Create.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
            BeginContext(94, 21, true);
            WriteLiteral("    <h4> Ingredient: ");
            EndContext();
            BeginContext(116, 36, false);
#line 10 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Ingredient/Create.cshtml"
                Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(152, 83, true);
            WriteLiteral("</h4>\n    <input type=\"submit\" value=\"Add new ingredient\" class=\"btn btn-default\">\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Ingredient/Create.cshtml"

}

#line default
#line hidden
            BeginContext(238, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(243, 48, false);
#line 15 "/Users/Guest/Desktop/RecipeBook/RecipeBook/Views/Ingredient/Create.cshtml"
Write(Html.ActionLink("Show all ingredients", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(291, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBook.Models.Ingredient> Html { get; private set; }
    }
}
#pragma warning restore 1591
