#pragma checksum "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Communication\ChildThreeComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3816f1088aba994bc602266110317f9c406ec176"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerappDemo.Pages.Communication
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
    public partial class ChildThreeComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "ChildThreeComponent : ");
            __builder.AddContent(2, 
#nullable restore
#line 1 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Communication\ChildThreeComponent.razor"
                           MainTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n \r\n");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 3 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Communication\ChildThreeComponent.razor"
                                                         ModifyMainTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 3 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Communication\ChildThreeComponent.razor"
              MainTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => MainTitle = __value, MainTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\FreeLancerAssignments\Edureka\BankOfAmericaSessions\BOA4\BoaSessionFourNew\WebApp\BoaFourSolution\BlazorServerappDemo\Pages\Communication\ChildThreeComponent.razor"
       
    [Parameter]
    public string MainTitle { get; set; }

    [Parameter]

    public EventCallback<string> MainTitleChanged { get; set; }

    public async Task ModifyMainTitle()
    {
        await MainTitleChanged.InvokeAsync(MainTitle);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
