#pragma checksum "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bc818c134624bf20ba9f1b9c82285f691b23798"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerWeatherApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/_Imports.razor"
using BlazorServerWeatherApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/_Imports.razor"
using BlazorServerWeatherApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
using BlazorServerWeatherApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/current")]
    public partial class CurrentForecast : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Current Forecast</h1>\n\n");
#nullable restore
#line 8 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
 if (darkSkyResponse == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
                      exampleModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
                                                   HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "id", "zip");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
                                         exampleModel.Zip

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => exampleModel.Zip = __value, exampleModel.Zip))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => exampleModel.Zip));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n\n        ");
                __builder2.AddMarkupContent(17, "<button type=\"submit\">Submit</button>\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\n");
#nullable restore
#line 18 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "    ");
            __builder.OpenElement(20, "p");
            __builder.OpenElement(21, "em");
            __builder.AddContent(22, 
#nullable restore
#line 21 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
            zipCodeResponse.City

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, ", ");
            __builder.AddContent(24, 
#nullable restore
#line 21 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
                                   zipCodeResponse.State

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n    ");
            __builder.OpenElement(26, "table");
            __builder.AddAttribute(27, "class", "table");
            __builder.AddMarkupContent(28, "\n        ");
            __builder.AddMarkupContent(29, "<thead>\n            <tr>\n                <th>Summary</th>\n                <th>Temp. (F)</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(30, "tbody");
            __builder.AddMarkupContent(31, "\n            ");
            __builder.OpenElement(32, "tr");
            __builder.AddMarkupContent(33, "\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 31 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
                     darkSkyResponse.Currently.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 32 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
                     Math.Round(darkSkyResponse.Currently.Temperature)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(43);
            __builder.AddAttribute(44, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 36 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
                      exampleModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 36 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
                                                   HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(47, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(48);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(50);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\n\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(52);
                __builder2.AddAttribute(53, "id", "zip");
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
                                         exampleModel.Zip

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => exampleModel.Zip = __value, exampleModel.Zip))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => exampleModel.Zip));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\n\n        ");
                __builder2.AddMarkupContent(58, "<button type=\"submit\">Submit</button>\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\n");
#nullable restore
#line 44 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "/Users/randyroughhouse/Documents/Programming Projects/ASP.NET/BlazorServerWeatherApp/Pages/CurrentForecast.razor"
       
    private DarkSkyResponse darkSkyResponse;
    private ZipCodeResponse zipCodeResponse;

    private int zip;

    private ExampleModel exampleModel = new ExampleModel();
    protected async Task HandleValidSubmit()
    {
        zip = int.Parse(exampleModel.Zip);
        zipCodeResponse = await ZipCodeResponseService.GetZipCodeResponseAsync(zip);
        double lat = zipCodeResponse.Lat;
        double lng = zipCodeResponse.Lng;
        darkSkyResponse = await DarkSkyResponseService.GetDarkSkyResponseAsync(lat, lng);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DarkSkyResponseService DarkSkyResponseService { get; set; }
    }
}
#pragma warning restore 1591
