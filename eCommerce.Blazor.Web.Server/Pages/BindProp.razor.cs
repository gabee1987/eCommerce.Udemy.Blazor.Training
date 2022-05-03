using eCommerce.Blazor.Web.Models.Models;

namespace eCommerce.Blazor.Web.Server.Pages
{
    public partial class BindProp
    {
        public DemoProduct Product { get; set; }
        public List<DemoProduct> Products { get; set; }
        private double _priceCache { get; set; }
        private string _selectedProp = string.Empty;

        public BindProp()
        {
            Product = new DemoProduct()
            {
                Id                = 1,
                IsActive          = true,
                Name              = "Rose Candle",
                Price             = 19.99,
                ProductProperties = new List<DemoProductProp>()
                {
                    new DemoProductProp() { Id = 0, Key = "Color", Value = "Black" },
                    new DemoProductProp() { Id = 1, Key = "Flavor", Value = "Rose Jasmine" },
                    new DemoProductProp() { Id = 2, Key = "Size", Value = "20oz" }
                }
            };

            Products = new List<DemoProduct>();
        }

        protected override void OnInitialized()
        {
            Products.Add( new()
            {
                Id                = 2,
                Name              = "Midnight Blaze",
                IsActive          = false,
                Price             = 17.45,
                ProductProperties = new()
                {
                    new DemoProductProp { Id = 1, Key = "Flavor", Value = "Rose" },
                    new DemoProductProp { Id = 2, Key = "Size", Value = "20oz" },
                    new DemoProductProp { Id = 3, Key = "Color", Value = "Purple" }
                }
            } );

            Products.Add( new()
            {
                Id                = 1,
                Name              = "Blossom Lily",
                IsActive          = true,
                Price             = 23.95,
                ProductProperties = new()
                {
                    new DemoProductProp { Id = 1, Key = "Flavor", Value = "Lily" },
                    new DemoProductProp { Id = 2, Key = "Size", Value = "18oz" },
                    new DemoProductProp { Id = 3, Key = "Color", Value = "White" }
                }
            } );
        }

        public void OnSave()
        {
            Product.Price = _priceCache;
        }
    }
}
