#pragma checksum "G:\C#\SklepCS\Sklep\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e7351a93ed786669647d8acb3f88dc773ff549c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Sklep.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Sklep.Pages
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
#line 1 "G:\C#\SklepCS\Sklep\Pages\_ViewImports.cshtml"
using Sklep;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e7351a93ed786669647d8acb3f88dc773ff549c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1900ae173913f9d29aaa1e2f04bee5c7d246724", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Products/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dark-grey-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "G:\C#\SklepCS\Sklep\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">

    <div class=""row pt-4"">

        <!-- Content -->
        <div class=""col-lg-12"">

            <!-- Products Grid -->
            <section class=""section my-5 pb-5"">

                <!-- Grid row -->
                <div class=""row"">

                    <!-- Grid column -->
                    <div class=""col-lg-8 col-md-12 mb-3 pb-lg-2"">

                        <!-- Image -->
                        <div class=""view zoom z-depth-1"">

                            <img src=""https://mdbootstrap.com/img/Photos/Others/product1.jpg"" class=""img-fluid"" alt=""sample image"">

                            <div class=""mask rgba-white-light"">

                                <div class=""dark-grey-text d-flex align-items-center pt-4 ml-3 pl-3"">

                                    <div>

                                        <a><span class=""badge badge-danger"">bestseller</span></a>

                                        <h2 class=""card-title font-weight-bold p");
            WriteLiteral("t-2\"><strong>This is news title</strong></h2>\r\n\r\n                                        <p");
            BeginWriteAttribute("class", " class=\"", 1186, "\"", 1194, 0);
            EndWriteAttribute();
            WriteLiteral(@">Lorem ipsum dolor sit amet, consectetur adipisicing elit. </p>

                                        <a class=""btn btn-danger btn-sm btn-rounded clearfix d-none d-md-inline-block"">Read more</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- Image -->
                    </div>
                    <!-- Grid column -->
                    <!-- Grid column -->
                    <div class=""col-lg-4 col-md-12 mb-4"">

                        <!-- Section: Categories -->
                        <section class=""section"">

                            <ul class=""list-group z-depth-1"">

");
#nullable restore
#line 56 "G:\C#\SklepCS\Sklep\Pages\Index.cshtml"
                                 foreach (var item in Model.KatProd)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n\r\n                                        <a class=\"dark-grey-text font-small\">\r\n\r\n                                            ");
#nullable restore
#line 62 "G:\C#\SklepCS\Sklep\Pages\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Nazwa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2414, "\"", 2421, 0);
            EndWriteAttribute();
            WriteLiteral("></a><span class=\"badge badge-danger badge-pill\">\r\n                                            ");
#nullable restore
#line 66 "G:\C#\SklepCS\Sklep\Pages\Index.cshtml"
                                       Write(item.ProduktyCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </span>\r\n                                    </li>\r\n");
#nullable restore
#line 69 "G:\C#\SklepCS\Sklep\Pages\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </section>
                        <!-- Section: Categories -->
                    </div>
                    <!-- Grid column -->
                </div>
                <!-- Grid row -->
                <!-- Section small products -->
                <section>

                    <!-- Grid row -->
                    <div class=""row"">
");
#nullable restore
#line 82 "G:\C#\SklepCS\Sklep\Pages\Index.cshtml"
                          
                            for (int i = 0; i < 9; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <!-- Grid column -->
                                <div class=""col-lg-4 col-md-12 mb-4"">
                                    <!-- Card -->
                                    <div class=""card card-ecommerce"">

                                        <!-- Card image -->
                                        <div class=""view overlay"">

                                            <img src=""https://mdbootstrap.com/img/Photos/Horizontal/E-commerce/Products/1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", "\r\n                                                 alt=\"", 3715, "\"", 3771, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                                            <a>

                                                <div class=""mask rgba-white-slight""></div>

                                            </a>

                                        </div>
                                        <!-- Card image -->
                                        <!-- Card content -->


                                        <div class=""card-body"">

                                            <!-- Category & Title -->
                                            <h5 class=""card-title mb-1"">
                                                <strong>
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e7351a93ed786669647d8acb3f88dc773ff549c9368", async() => {
                WriteLiteral("\r\n                                                       ");
#nullable restore
#line 113 "G:\C#\SklepCS\Sklep\Pages\Index.cshtml"
                                                  Write(Model.Produkty[Model.RandomList[i]].Nazwa);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "G:\C#\SklepCS\Sklep\Pages\Index.cshtml"
                                                                                            WriteLiteral(Model.Produkty[Model.RandomList[i]].ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </strong>
                                            </h5>

                                            <!-- Card footer -->
                                            <div class=""card-footer pb-0"">

                                                <div class=""row mb-0"">

                                                    <span class=""float-left"">
                                                        <strong>
                                                           ");
#nullable restore
#line 125 "G:\C#\SklepCS\Sklep\Pages\Index.cshtml"
                                                      Write(Model.Produkty[Model.RandomList[i]].Cena_brutto);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" PLN
                                                        </strong>
                                                    </span>

                                                    <div class=""float-right ml-5"">

                                                        <a");
            BeginWriteAttribute("class", " class=\"", 5609, "\"", 5617, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-toggle=""tooltip"" data-placement=""top"" title=""Add to Cart"">
                                                            <i class=""fa fa-shopping-cart ""></i>
                                                        </a>

                                                    </div>

                                                </div>

                                            </div>

                                        </div>
                                        <!-- Card content -->

                                    </div>
                                    <!-- Card -->

                                </div>
                                <!-- Grid column -->
");
#nullable restore
#line 149 "G:\C#\SklepCS\Sklep\Pages\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <!-- Grid row -->
                </section>
                <!-- Section small products -->
            </section>
            <!-- Products Grid -->
        </div>
        <!-- Content -->
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
