#pragma checksum "C:\Users\toklu\Desktop\Local-Projects\DotNetProjects\Library\library.webui\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02b3921d2c479b9ee636a56818160a475fe84bf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 2 "C:\Users\toklu\Desktop\Local-Projects\DotNetProjects\Library\library.webui\Views\_ViewImports.cshtml"
using library.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02b3921d2c479b9ee636a56818160a475fe84bf8", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f21fc80d8e98be23e87d75a6f43894ee746f215", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\toklu\Desktop\Local-Projects\DotNetProjects\Library\library.webui\Views\Book\Index.cshtml"
  
    var books = Model.books;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 9 "C:\Users\toklu\Desktop\Local-Projects\DotNetProjects\Library\library.webui\Views\Book\Index.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\toklu\Desktop\Local-Projects\DotNetProjects\Library\library.webui\Views\Book\Index.cshtml"
 if (books.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\toklu\Desktop\Local-Projects\DotNetProjects\Library\library.webui\Views\Book\Index.cshtml"
Write(await Html.PartialAsync("_nobook"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\toklu\Desktop\Local-Projects\DotNetProjects\Library\library.webui\Views\Book\Index.cshtml"
                                       

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 20 "C:\Users\toklu\Desktop\Local-Projects\DotNetProjects\Library\library.webui\Views\Book\Index.cshtml"
         foreach (var product in books)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\r\n                ");
#nullable restore
#line 23 "C:\Users\toklu\Desktop\Local-Projects\DotNetProjects\Library\library.webui\Views\Book\Index.cshtml"
           Write(await Html.PartialAsync("_book",product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\toklu\Desktop\Local-Projects\DotNetProjects\Library\library.webui\Views\Book\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 27 "C:\Users\toklu\Desktop\Local-Projects\DotNetProjects\Library\library.webui\Views\Book\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
