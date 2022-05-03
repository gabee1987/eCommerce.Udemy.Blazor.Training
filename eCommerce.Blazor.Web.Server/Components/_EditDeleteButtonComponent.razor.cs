using Microsoft.AspNetCore.Components;

namespace eCommerce.Blazor.Web.Server.Components
{
    public partial class _EditDeleteButtonComponent
    {
        [Parameter]
        public bool ProductIsActive { get; set; }
    }
}
