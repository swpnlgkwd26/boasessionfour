#pragma checksum "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a701d8437d5d296b00b505fc08d2119355b4ea80"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerappDemo.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/details")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Details</h3>\r\nShow Or Hide :\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "type", "checkbox");
            __builder.AddAttribute(3, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                              IsChecked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => IsChecked = __value, IsChecked));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 6 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
 if (IsChecked)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-bordered");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.AddMarkupContent(12, "<td> Name</td>\r\n            ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, " ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                                           productViewModel.ProductName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productViewModel.ProductName = __value, productViewModel.ProductName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.AddMarkupContent(23, "<td> Price</td>\r\n            ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, " ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                                           productViewModel.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productViewModel.Price = __value, productViewModel.Price));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "tr");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.AddMarkupContent(34, "<td> Description</td>\r\n            ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, " ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "text");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                                           productViewModel.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productViewModel.Description = __value, productViewModel.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "tr");
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.AddMarkupContent(45, "<td> Category</td>\r\n            ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, " ");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "type", "text");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                                           productViewModel.Category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productViewModel.Category = __value, productViewModel.Category));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "tr");
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.AddMarkupContent(56, "<td> </td>\r\n            ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, " ");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "class", "btn btn-primary");
            __builder.AddAttribute(61, "disabled", 
#nullable restore
#line 27 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                                                             productViewModel.Price == 0

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(62, " Go Back");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 30 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(66, "\r\n\r\n\r\n");
            __builder.OpenElement(67, "p");
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.AddContent(69, 
#nullable restore
#line 35 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
     productViewModel.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(70, " , ");
            __builder.AddContent(71, 
#nullable restore
#line 35 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                                     productViewModel.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(72, " ,\r\n    ");
            __builder.AddContent(73, 
#nullable restore
#line 36 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
     productViewModel.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(74, ", ");
            __builder.AddContent(75, 
#nullable restore
#line 36 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                                    productViewModel.Category

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(76, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n\r\n");
            __builder.OpenElement(78, "h2");
            __builder.AddContent(79, " Category : ");
            __builder.AddContent(80, 
#nullable restore
#line 39 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                 SelectedCategory

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.OpenElement(82, "select");
            __builder.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
               SelectedCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedCategory = __value, SelectedCategory));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.OpenElement(86, "option");
            __builder.AddContent(87, " Select One");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 42 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
     foreach (var item in categories)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "        ");
            __builder.OpenElement(90, "option");
            __builder.AddContent(91, " ");
            __builder.AddContent(92, 
#nullable restore
#line 44 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                  item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n");
#nullable restore
#line 45 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n\r\n");
            __builder.OpenElement(95, "button");
            __builder.AddAttribute(96, "class", "btn btn-warning");
            __builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                                          AddProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(98, " Add Product");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n\r\nSearch Product  :\r\n");
            __builder.OpenElement(100, "input");
            __builder.AddAttribute(101, "type", "text");
            __builder.AddAttribute(102, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                          ProductName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ProductName = __value, ProductName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
            __builder.OpenElement(105, "button");
            __builder.AddAttribute(106, "class", "btn btn-warning");
            __builder.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                                          ()=> SearchProduct(ProductName)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(108, " Search Product");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n\r\n");
            __builder.AddMarkupContent(110, "<h3> Iterating Over Collections</h3>\r\n\r\n");
            __builder.OpenElement(111, "ul");
            __builder.AddMarkupContent(112, "\r\n");
#nullable restore
#line 57 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
     foreach (var item in listOfProductViewModels)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(113, "        ");
            __builder.OpenElement(114, "li");
            __builder.SetKey(
#nullable restore
#line 59 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                  item.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(115, " ");
            __builder.AddContent(116, 
#nullable restore
#line 59 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                                    item.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(117, " , ");
            __builder.AddContent(118, 
#nullable restore
#line 59 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                                                      item.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n");
#nullable restore
#line 60 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(120, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(122, "<h3> Attribute Splatting</h3>\r\n");
            __builder.OpenElement(123, "input");
            __builder.AddAttribute(124, "id", "useIndividualParams");
            __builder.AddAttribute(125, "maxlength", 
#nullable restore
#line 67 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                   maxlength

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(126, "placeholder", 
#nullable restore
#line 68 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                     placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(127, "required", 
#nullable restore
#line 69 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                  required

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(128, "size", 
#nullable restore
#line 70 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
              size

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n\r\n");
            __builder.OpenElement(130, "input");
            __builder.AddMultipleAttributes(131, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 72 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                    InputAttributes

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n");
            __builder.OpenElement(133, "input");
            __builder.AddMultipleAttributes(134, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 73 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                    InputAttributes

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n\r\n");
            __builder.AddMarkupContent(136, "<h3> Templated Component</h3>\r\n");
            __Blazor.BlazorServerappDemo.Pages.Details.TypeInference.CreateBlazorServerappDemo_Pages_TemplatedComponent_ListViewTemplate_0(__builder, 137, 138, 
#nullable restore
#line 76 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
                                                                      listOfProductViewModels

#line default
#line hidden
#nullable disable
            , 139, (product) => (__builder2) => {
                __builder2.AddMarkupContent(140, "\r\n        ");
                __builder2.OpenElement(141, "li");
                __builder2.AddContent(142, 
#nullable restore
#line 78 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
             product.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Details.razor"
       

    private string maxlength = "10";
    private string placeholder = "Input placeholder text";
    private string required = "required";
    private string size = "50";

    // Splatting
    private Dictionary<string, object> InputAttributes  =
         new Dictionary<string, object>()
         {
             { "maxlength", "10" },
             { "placeholder", "Input placeholder text" },
             { "required", "required" },
             { "size", "50" }
         };







    List<ProductViewModel> listOfProductViewModels = new List<ProductViewModel>
{
        new ProductViewModel
    {
        ProductId = 1,
        ProductName = "Chess Board1",
        Category = "Chess",
        Description = "Chess",
        Price = 100
    },
             new ProductViewModel
    {
        ProductId = 2,
        ProductName = "Chess Board2",
        Category = "Chess",
        Description = "Chess",
        Price = 100
    },
                  new ProductViewModel
    {
        ProductId = 3,
        ProductName = "Chess Board3",
        Category = "Chess",
        Description = "Chess",
        Price = 100
    }


    };

    public string SelectedCategory { get; set; }

    string[] categories = { "Cricket", "Chess", "Soccer" };

    public bool IsChecked { get; set; }

    ProductViewModel productViewModel = new ProductViewModel
    {
        ProductId = 1,
        ProductName = "Chess Board",
        Category = "Chess",
        Description = "Chess",
        Price = 100
    };

    public void AddProduct()
    {
        listOfProductViewModels.Add(new ProductViewModel
        {
            ProductId = 10,
            ProductName = "Cricket",
            Category = "Chess",
            Description = "Chess",
            Price = 100
        });
    }
    public string ProductName { get; set; }
    public void SearchProduct(string productName)
    {
        Console.WriteLine("Search Product : " + productName);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorServerappDemo.Pages.Details
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBlazorServerappDemo_Pages_TemplatedComponent_ListViewTemplate_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IReadOnlyList<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::BlazorServerappDemo.Pages.TemplatedComponent.ListViewTemplate<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ItemTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591