// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder builder)
        {
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
   RenderFragment<Person> template = (person) => 

#line default
#line hidden
#nullable disable
            (builder2) => {
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                  __o = person.Name;

#line default
#line hidden
#nullable disable
            }
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                         ; 

#line default
#line hidden
#nullable disable
            __o = new Microsoft.AspNetCore.Components.RenderFragment<Test.Person>(
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                              template

#line default
#line hidden
#nullable disable
            );
            builder.AddAttribute(-1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
            }
            ));
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(MyComponent);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
