#pragma checksum "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Lifecycle\ParentlifecycleComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d452353bb29fa740396d6e8ec266c54404cb8a5"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/parentlifecycle")]
    public partial class ParentlifecycleComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ParentlifecycleComponent </h3>\r\n");
            __builder.OpenElement(1, "h2");
            __builder.AddContent(2, " Should Render : ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Lifecycle\ParentlifecycleComponent.razor"
                      count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Lifecycle\ParentlifecycleComponent.razor"
                  IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, " Increment Count");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Lifecycle\ParentlifecycleComponent.razor"
                  TurnOn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, " ON");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Lifecycle\ParentlifecycleComponent.razor"
                  TurnOff

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, " Off");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.AddMarkupContent(17, "<h2> OnAfterRender</h2>\r\n");
            __builder.OpenElement(18, "div");
            __builder.AddElementReferenceCapture(19, (__value) => {
#nullable restore
#line 10 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Lifecycle\ParentlifecycleComponent.razor"
           divElement = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(20, "Text During Render");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(22, "<h2> OnParameterSet</h2>\r\n");
            __builder.OpenComponent<BlazorServerappDemo.Pages.Lifecycle.ChildlifecycleComponent>(23);
            __builder.AddAttribute(24, "RandNumber", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Lifecycle\ParentlifecycleComponent.razor"
                                       randomNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Lifecycle\ParentlifecycleComponent.razor"
                  GenerateRandom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, " Generate Random No");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Lifecycle\ParentlifecycleComponent.razor"
       
    int randomNumber = 0;
    Random random = new Random();
    public void GenerateRandom()
    {
        randomNumber = random.Next(10000);
    }

    private ElementReference divElement;

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        await Task.Delay(3000);
        await JSRuntime.InvokeVoidAsync("setElementText", divElement, "Test After Render");
    }

    int count = 0;
    bool shouldRender = true;
    public void IncrementCount()
    {
        count++;
    }
    public void TurnOn()
    {
        shouldRender = true;
    }
    public void TurnOff()
    {
        shouldRender = false;
    }

    protected override bool ShouldRender()
    {
        return shouldRender;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591