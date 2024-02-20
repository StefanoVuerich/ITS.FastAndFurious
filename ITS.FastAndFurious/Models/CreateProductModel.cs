namespace ITS.FastAndFurious.Models
{
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class CreateProductModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Origin { get; set; }
        public int SupplierId { get; set; }
        public List<SelectListItem> SupplierList { get; set; } = new List<SelectListItem>();
    }
}
