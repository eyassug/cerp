using System;
using System.Collections.Generic;
using System.Linq;
using CERP.Modules.DataManagement.DataAccess;
using CERP.Modules.DataManagement.Domain;

namespace CERP.Modules.DataManagement.Services
{
    public class ProductService : IProductService
    {
        #region Fields
        private readonly DataManagementContext _context;
        #endregion

        #region Constructors

        public ProductService()
        {
            _context = new DataManagementContext();
        }

        #endregion

        public void AddProduct(Product product)
        {
            // Validation
            if(product.Name.Trim() == string.Empty || product.ProductCategory == null || product.Manufacturer == null )
            {
               throw new Exception("Can't add product!!!");
            }
            var newProduct = new Models.Inventory.Product
                                 {
                                     Name = product.Name,
                                     ManufacturerID = product.Manufacturer.ManufacturerID,
                                     ProductCategoryID = product.ProductCategory.ProductCategoryID,
                                     ProductNumber = "N/A",
                                     UnitMeasureCode = "PC"
                                 };
            _context.Products.Add(newProduct);
            _context.SaveChanges();
        }

        public void RemoveProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void DisableProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Product> GetProducts()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Product> GetInactiveProducts()
        {
            throw new System.NotImplementedException();
        }

        public void RenameProduct(Product product, string newName)
        {
            var p = _context.Products.SingleOrDefault(m => m.ProductID == product.ProductID);
            if(p == null)
                throw new Exception("Product doesn't exist.");
            p.Name = newName;
            _context.SaveChanges();
        }

        public ICollection<Product> SearchProducts(string query)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeProductNumber(Product product, string newProductNumber)
        {
            throw new System.NotImplementedException();
        }


        public ICollection<Product> GetProducts(ProductCategory productCategory)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Product> GetProducts(Manufacturer manufacturer)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Unit> GetUnits()
        {
            throw new System.NotImplementedException();
        }
    }
}
