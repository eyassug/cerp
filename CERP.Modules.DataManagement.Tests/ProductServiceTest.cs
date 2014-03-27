using System;
using CERP.Modules.DataManagement.Domain;
using CERP.Modules.DataManagement.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CERP.Modules.DataManagement.Tests
{
    [TestClass]
    public class ProductServiceTest
    {
        readonly IProductService _productService = new ProductService();
       
        [TestMethod]
        public void AddNewProductWithoutAManufacturerTest_ShouldThrowException()
        {
            //_productService.RenameProduct(null,);
        }

        [TestMethod]
        public void AddNewProduct_ShouldPass()
        {
            //var p = new Product
            //                {
            //                    Name = "Toshiba L980",
            //                    ProductCategory = new ProductCategory {ProductCategoryID = 4, Name = "Electronics"},
            //                    Manufacturer = new Manufacturer {ManufacturerID = 1},
            //                    ProductCode = "XXX"
            //                };
            //_productService.AddProduct(p);
        }

        [TestMethod]
        public void RenameProduct_ShouldPass()
        {
            var p = new Product {ProductID = 1};
            _productService.RenameProduct(p,"Toshiba L755 Renamed");
        }
    }
}
