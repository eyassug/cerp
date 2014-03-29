using System;
using CERP.Modules.DataManagement.Domain;
using CERP.Modules.DataManagement.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CERP.Modules.DataManagement.Tests
{
    [TestClass]
    public class SupplierServicesTest
    {
        readonly ISupplierService _supplierService = new SupplierService();

        [TestMethod]
        public void AddNewSupplierTest_ShouldThrowException()
        {
            //_productService.RenameProduct(null,);
        }

        [TestMethod]
        public void AddNewSupplier_ShouldPass()
        {
            var s = new Supplier
                            {
                                Name = "TYG PLC"
                                
                            };
            _supplierService.AddNewSupplier(s);
        }

        [TestMethod]
        public void RemoveSupplier_ShouldPass()
        {
            var s = new Supplier { SupplierID = 4,Name = "TYG PLC" };
            _supplierService.RemoveSupplier(s);
        }

        [TestMethod]
        public void RenameSupplier_ShouldPass()
        {
            var s = new Supplier() { SupplierID = 3, Name = "Eyassu Getachew"};
            _supplierService.RenameSupplier(s, "Samuel Habtewold");
        }
         [TestMethod]
        public void GetSupplier_ShouldPass()
        {
       _supplierService.GetSuppliers();
           }


    }
}
