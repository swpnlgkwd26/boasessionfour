#pragma checksum "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\ManageProducts\TableRow.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1efe1926deec1577ff64a4e8dbd05b66701543c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerappDemo.Pages.ManageProducts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\_Imports.razor"
using BlazorServerappDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\_Imports.razor"
using BlazorServerappDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\_Imports.razor"
using BlazorServerappDemo.Data;

#line default
#line hidden
#nullable disable
    public partial class TableRow : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tr");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "td");
            __builder.AddContent(3, " ");
            __builder.AddContent(4, 
#nullable restore
#line 2 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\ManageProducts\TableRow.razor"
          Product.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, " ");
            __builder.AddContent(8, 
#nullable restore
#line 3 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\ManageProducts\TableRow.razor"
          Product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, " ");
            __builder.AddContent(12, 
#nullable restore
#line 4 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\ManageProducts\TableRow.razor"
          Product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, " ");
            __builder.AddContent(16, 
#nullable restore
#line 5 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\ManageProducts\TableRow.razor"
          Product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, " ");
            __builder.AddContent(20, 
#nullable restore
#line 6 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\ManageProducts\TableRow.razor"
          Product.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-primary");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\ManageProducts\TableRow.razor"
                          OnDetailClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "\r\n            Show Details\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\ManageProducts\TableRow.razor"
       
    [Parameter]
    public Product Product { get; set; }

    // EventCallback for Child to Parent Communication
    [Parameter]
    public EventCallback<int> OnDetail { get; set; }

    public void OnDetailClicked()
    {
        OnDetail.InvokeAsync(Product.ProductId);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591