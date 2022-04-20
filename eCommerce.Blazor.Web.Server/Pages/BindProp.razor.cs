using eCommerce.Blazor.Web.Models.Models;

namespace eCommerce.Blazor.Web.Server.Pages
{
    public partial class BindProp
    {
        public DemoProduct Product { get; set; }
        private double _priceCache { get; set; }
        private string _selectedProp = string.Empty;

        public BindProp()
        {
            Product = new DemoProduct()
            {
                Id = 1,
                IsActive = true,
                Name = "Rose Candle",
                Price = 19.99,
                ProductProperties = new List<DemoProductProp>()
                {
                    new DemoProductProp() { Id = 0, Key = "Color", Value = "Black" },
                    new DemoProductProp() { Id = 1, Key = "Flavor", Value = "Rose Jasmine" },
                    new DemoProductProp() { Id = 2, Key = "Size", Value = "20oz" }
                }
            };    
        }

        public void OnSave()
        {
            Product.Price = _priceCache;
        }
    }
}
