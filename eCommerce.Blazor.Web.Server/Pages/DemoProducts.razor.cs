using eCommerce.Blazor.Web.Models.Models;

namespace eCommerce.Blazor.Web.Server.Pages
{
    public partial class DemoProducts
    {
        public List<DemoProduct> Products { get; set; }

        public DemoProducts()
        {
            Products = new List<DemoProduct>();
        }

        protected override void OnInitialized()
        {
            Products.Add( new()
            {
                Id                = 1,
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

            Products.Add( new()
            {
                Id                = 1,
                Name              = "Fiery Spark",
                IsActive          = true,
                Price             = 99.95,
                ProductProperties = new()
                {
                    new DemoProductProp { Id = 1, Key = "Flavor", Value = "Hot" },
                    new DemoProductProp { Id = 2, Key = "Size", Value = "66oz" },
                    new DemoProductProp { Id = 3, Key = "Color", Value = "Red" }
                }
            } );
        }
    }
}
