#pragma checksum "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Lifecycle\ChildlifecycleComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a818caed65695991928e8f9853ae34e3f37449f0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerappDemo.Pages.Lifecycle
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
    public partial class ChildlifecycleComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ChildlifecycleComponent</h3>\r\n\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, " OnParameterSet  ");
            __builder.AddContent(3, 
#nullable restore
#line 3 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Lifecycle\ChildlifecycleComponent.razor"
                      RandNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " : ");
            __builder.AddContent(5, 
#nullable restore
#line 3 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Lifecycle\ChildlifecycleComponent.razor"
                                    randNumwithDelay

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Lifecycle\ChildlifecycleComponent.razor"
       
    [Parameter]
    public int RandNumber { get; set; } = 0;

    int randNumwithDelay = 0;

    public override Task SetParametersAsync(ParameterView parameters)
    {
        foreach (var item in parameters)
        {
            Console.WriteLine(item.Name + " " + item.Value);
        }
        return base.SetParametersAsync(parameters);
    }

    protected async override Task OnParametersSetAsync()
    {
        await Task.Delay(3000);
        randNumwithDelay = RandNumber;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
