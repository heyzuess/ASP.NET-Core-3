#pragma checksum "C:\Users\jesse\Documents\Projects\dotnet_core\SportsSln\SportsStore\Pages\Admin\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "501c8d353994a6cdb9d0474171a9030386f02804"
// <auto-generated/>
#pragma warning disable 1591
namespace SportsStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\jesse\Documents\Projects\dotnet_core\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jesse\Documents\Projects\dotnet_core\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jesse\Documents\Projects\dotnet_core\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jesse\Documents\Projects\dotnet_core\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jesse\Documents\Projects\dotnet_core\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jesse\Documents\Projects\dotnet_core\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"table table-sm table-bordered table-striped\">\r\n    Details\r\n</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-sm table-bordered table-striped");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.AddMarkupContent(8, "<th>ID</th>\r\n            ");
            __builder.OpenElement(9, "th");
            __builder.AddContent(10, 
#nullable restore
#line 11 "C:\Users\jesse\Documents\Projects\dotnet_core\SportsSln\SportsStore\Pages\Admin\Details.razor"
                 Product.ProductID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.AddMarkupContent(15, "<th>Name</th>\r\n            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 15 "C:\Users\jesse\Documents\Projects\dotnet_core\SportsSln\SportsStore\Pages\Admin\Details.razor"
                 Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.AddMarkupContent(22, "<th>Description</th>\r\n            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 19 "C:\Users\jesse\Documents\Projects\dotnet_core\SportsSln\SportsStore\Pages\Admin\Details.razor"
                 Product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.AddMarkupContent(29, "<th>Category</th>\r\n            ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 23 "C:\Users\jesse\Documents\Projects\dotnet_core\SportsSln\SportsStore\Pages\Admin\Details.razor"
                 Product.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "tr");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.AddMarkupContent(36, "<th>Price</th>\r\n            ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 27 "C:\Users\jesse\Documents\Projects\dotnet_core\SportsSln\SportsStore\Pages\Admin\Details.razor"
                 Product.Price.ToString("C")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(43);
            __builder.AddAttribute(44, "class", "btn btn-warning");
            __builder.AddAttribute(45, "href", 
#nullable restore
#line 32 "C:\Users\jesse\Documents\Projects\dotnet_core\SportsSln\SportsStore\Pages\Admin\Details.razor"
                                        EditUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(47, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
            __builder.AddAttribute(50, "class", "btn btn-secondary");
            __builder.AddAttribute(51, "href", "/admin/products");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(53, "Back");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\jesse\Documents\Projects\dotnet_core\SportsSln\SportsStore\Pages\Admin\Details.razor"
       
    [Inject]
    public IStoreRepository Repository { get; set; }

    [Parameter]
    public long Id { get; set; }

    public Product Product { get; set; }

    protected override void OnParametersSet()
    {
        Product = Repository.Products.FirstOrDefault(p => p.ProductID == Id);
    }

    public string EditUrl => $"/admin/products/edit/{Product.ProductID}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591