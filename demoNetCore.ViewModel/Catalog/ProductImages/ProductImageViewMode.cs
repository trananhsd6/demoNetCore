using System;

namespace demoNetCore.ViewModel.Catalog.ProductImages
{
    public class ProductImageViewMode
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public string Caption { get; set; }
        public bool IsDefault { get; set; }

        public int SortOrder { get; set; }
        public long FileSize { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
