using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Blazor.Web.Models.Models
{
    public class DemoProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public double Price { get; set; }
        public virtual string IsActiveDisplayHelper => IsActive ? "Active" : "Not Active";

        public List<DemoProductProp> ProductProperties { get; set; }
    }
}
