#pragma checksum "D:\Zshan Mentoring\Task 6\ASP.NET-Core-MVC-3.1\BookStore\BookStore 2.0\Views\Book\GetBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebad860151f6fd4efd2bdb9ed727669cdb14e4ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetBook), @"mvc.1.0.view", @"/Views/Book/GetBook.cshtml")]
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
#line 1 "D:\Zshan Mentoring\Task 6\ASP.NET-Core-MVC-3.1\BookStore\BookStore 2.0\_ViewImports.cshtml"
using BookStore_2._0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebad860151f6fd4efd2bdb9ed727669cdb14e4ae", @"/Views/Book/GetBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d66d5bf4850524116f6f2a598b7c2dbc07bf351", @"/_ViewImports.cshtml")]
    public class Views_Book_GetBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6"">
            <div id=""carouselExampleCaptions"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
                    <li data-target=""#carouselExampleCaptions"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#carouselExampleCaptions"" data-slide-to=""1""></li>
                    <li data-target=""#carouselExampleCaptions"" data-slide-to=""2""></li>
                </ol>
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"">
                        <img src=""..."" class=""d-block w-100"" alt=""..."">
                        <div class=""carousel-caption d-none d-md-block"">
                            <h5>First slide label</h5>
                            <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
                        </div>
                    </div>
                    <div class=""carous");
            WriteLiteral(@"el-item"">
                        <img src=""..."" class=""d-block w-100"" alt=""..."">
                        <div class=""carousel-caption d-none d-md-block"">
                            <h5>Second slide label</h5>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                        </div>
                    </div>
                    <div class=""carousel-item"">
                        <img src=""..."" class=""d-block w-100"" alt=""..."">
                        <div class=""carousel-caption d-none d-md-block"">
                            <h5>Third slide label</h5>
                            <p>Praesent commodo cursus magna, vel scelerisque nisl consectetur.</p>
                        </div>
                    </div>
                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
               ");
            WriteLiteral(@"     <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h1>");
#nullable restore
#line 52 "D:\Zshan Mentoring\Task 6\ASP.NET-Core-MVC-3.1\BookStore\BookStore 2.0\Views\Book\GetBook.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12 text-primary\">\r\n                    <span class=\"label\">By:</span>\r\n                    <span class=\"text-monospace\">");
#nullable restore
#line 58 "D:\Zshan Mentoring\Task 6\ASP.NET-Core-MVC-3.1\BookStore\BookStore 2.0\Views\Book\GetBook.cshtml"
                                            Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p class=\"description\">\r\n                        ");
#nullable restore
#line 64 "D:\Zshan Mentoring\Task 6\ASP.NET-Core-MVC-3.1\BookStore\BookStore 2.0\Views\Book\GetBook.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-4"">
                    <button class=""btn btn-primary"">
                        Read now
                    </button>
                </div>
            </div>
            <hr />
            <ul class=""list-group"">
                <li class=""list-group-item""><span class=""font-weight-bold"">Category-</span> ");
#nullable restore
#line 77 "D:\Zshan Mentoring\Task 6\ASP.NET-Core-MVC-3.1\BookStore\BookStore 2.0\Views\Book\GetBook.cshtml"
                                                                                       Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Total pages-</span>");
#nullable restore
#line 78 "D:\Zshan Mentoring\Task 6\ASP.NET-Core-MVC-3.1\BookStore\BookStore 2.0\Views\Book\GetBook.cshtml"
                                                                                         Write(Model.Totalpages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Language-</span> ");
#nullable restore
#line 79 "D:\Zshan Mentoring\Task 6\ASP.NET-Core-MVC-3.1\BookStore\BookStore 2.0\Views\Book\GetBook.cshtml"
                                                                                       Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
