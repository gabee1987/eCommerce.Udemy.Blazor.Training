using eCommerce.Blazor.Web.Models.Models;
using Microsoft.AspNetCore.Components;

namespace eCommerce.Blazor.Web.Server.Components
{
    public partial class _DemoProductComponent
    {
        [Parameter]
        public DemoProduct Product { get; set; }

        [Parameter]
        public EventCallback<bool> OnFavouriteUpdated { get; set; }
        private async Task FavouriteUpdated( ChangeEventArgs e )
        {
            await OnFavouriteUpdated.InvokeAsync( (bool)e.Value );
        }
    }
}
