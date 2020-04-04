using System;
using System.Collections.Generic;
using System.Text;

namespace demoNetCore.ViewModel.Catalog.Products
{
    public class ProductImageViewMode
    {
        public int Id { get; set; }
        public string  FilePath { get; set; }
        public bool isDefault { get; set; }
        public long FileSizes { get; set; }
    }
}
