using System;
using CERP.Modules.DataManagement.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CERP.Modules.DataManagement.Tests
{
    [TestClass]
    public class ProductServiceTest
    {
        readonly IProductService productService;
        readonly private IProductCategoryService productCategoryService;


        [TestMethod]
        public void AddNewProductWithoutAManufacturerTest_ShouldThrowException()
        {
            var category = new ProductCategory {Name = "Laptop"};
            productCategoryService.AddNewProductCategory(category);
            var newProduct = new Product
                                 {
                                     Name = "Toshiba L755-4905",
                                     IsActive = true,
                                     ProductCategory = category,
                                     ProductCode = "TL755"
                                 };

            productService.AddProduct(newProduct);
        }
    }
}
