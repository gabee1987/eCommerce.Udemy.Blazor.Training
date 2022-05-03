using eCommerce.Blazor.Web.Models.Models;
using Microsoft.AspNetCore.Components;

namespace eCommerce.Blazor.Web.Server.Components
{
    public partial class _DemoProductComponent
    {
        [Parameter]
        public DemoProduct Product { get; set; }
    }
}
