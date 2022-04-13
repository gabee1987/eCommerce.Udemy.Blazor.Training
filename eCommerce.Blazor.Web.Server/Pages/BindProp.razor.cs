using eCommerce.Blazor.Web.Models.Models;

namespace eCommerce.Blazor.Web.Server.Pages
{
    public partial class BindProp
    {
        public DemoProduct Product { get; set; }

        public BindProp()
        {
            Product = new DemoProduct()
            { 
                Id = 1, IsActive = true, Name = "Rose Candle" 
            };    
        }
    }
}
