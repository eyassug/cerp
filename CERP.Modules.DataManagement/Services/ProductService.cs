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

        #region IProductService Implementation

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
            var p = _context.Products.SingleOrDefault(m => m.ProductID == product.ProductID);
            if(p == null)
                throw new Exception("The supplied product was not found in the database!!!");
            try
            {
                _context.Products.Remove(p);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Could not remove product. Product has associated transactions.");
            }
        }

        public void DisableProduct(Product product)
        {
            var p = _context.Products.SingleOrDefault(m => m.ProductID == product.ProductID);
            if(p == null)
                throw new Exception("Product not found!!!");
            p.IsActive = false;
            _context.SaveChanges();
        }

        public ICollection<Product> GetProducts()
        {
            var inactiveProducts = from p in _context.Products
                                   join m in _context.Manufacturers on p.ManufacturerID equals m.ManufacturerID
                                   join c in _context.ProductCategories on p.ProductCategoryID equals c.ProductCategoryID
                                   where p.IsActive
                                   select new Product
                                   {
                                       ProductID = p.ProductID,
                                       Name = p.Name,
                                       ProductNumber = p.ProductNumber,
                                       Manufacturer = new Manufacturer { ManufacturerID = p.ManufacturerID, Name = m.Name },
                                       ProductCategory = new ProductCategory { ProductCategoryID = p.ProductCategoryID }
                                   };
            return inactiveProducts.ToList();
        }

        public ICollection<Product> GetInactiveProducts()
        {
            var inactiveProducts = from p in _context.Products
                                   join m in _context.Manufacturers on p.ManufacturerID equals m.ManufacturerID
                                   join c in _context.ProductCategories on p.ProductCategoryID equals c.ProductCategoryID
                                   where p.IsActive == false
                                   select new Product
                                              {
                                                  ProductID = p.ProductID,
                                                  Name = p.Name,
                                                  ProductNumber = p.ProductNumber,
                                                  Manufacturer = new Manufacturer {ManufacturerID = p.ManufacturerID, Name = m.Name },
                                                  ProductCategory = new ProductCategory {ProductCategoryID = p.ProductCategoryID}
                                              };
            return inactiveProducts.ToList();
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
            if (string.IsNullOrWhiteSpace(query))
                return GetProducts();
            var sanitisedQuery = query.Trim().ToLower();
            var searchResults = from p in _context.Products
                                join m in _context.Manufacturers on p.ManufacturerID equals m.ManufacturerID
                                join c in _context.ProductCategories on p.ProductCategoryID equals c.ProductCategoryID
                                where p.IsActive &&
                                (p.Name.ToLower().Contains(sanitisedQuery) ||
                                p.ProductNumber.ToLower().Contains(sanitisedQuery) ||
                                m.Name.ToLower().Contains(sanitisedQuery) ||
                                c.Name.ToLower().Contains(sanitisedQuery))
                                select new Product
                                {
                                    ProductID = p.ProductID,
                                    Name = p.Name,
                                    ProductNumber = p.ProductNumber,
                                    Manufacturer = new Manufacturer { ManufacturerID = p.ManufacturerID, Name = m.Name },
                                    ProductCategory = new ProductCategory { ProductCategoryID = p.ProductCategoryID }
                                };
            return searchResults.ToList();
        }

        public void ChangeProductNumber(Product product, string newProductNumber)
        {
            if(string.IsNullOrWhiteSpace(newProductNumber))
                throw new Exception("Invalid Product Number");
            var p = _context.Products.SingleOrDefault(m => m.ProductID == product.ProductID);
            if(p == null)
                throw new Exception("Product doesn't exist.");
            p.ProductNumber = newProductNumber;
            _context.SaveChanges();
        }


        public ICollection<Product> GetProducts(ProductCategory productCategory)
        {
            if(productCategory == null)
                throw new ArgumentNullException("productCategory");
            var products = from p in _context.Products
                           join m in _context.Manufacturers on p.ManufacturerID equals m.ManufacturerID
                           where p.ProductCategoryID == productCategory.ProductCategoryID
                           select new Product
                                      {
                                          ProductID = p.ProductID,
                                          Name = p.Name,
                                          ProductNumber = p.ProductNumber,
                                          ProductCategory = productCategory,
                                          Manufacturer = new Manufacturer {ManufacturerID = m.ManufacturerID, Name = m.Name}
                                      };
            return products.ToList();
        }

        public ICollection<Product> GetProducts(Manufacturer manufacturer)
        {
            if (manufacturer == null)
                throw new ArgumentNullException("manufacturer");
            var products = from p in _context.Products
                           join c in _context.ProductCategories on p.ProductCategoryID equals c.ProductCategoryID
                           where p.ProductCategoryID == manufacturer.ManufacturerID
                           select new Product
                           {
                               ProductID = p.ProductID,
                               Name = p.Name,
                               ProductNumber = p.ProductNumber,
                               ProductCategory = new ProductCategory {ProductCategoryID = c.ProductCategoryID, Name = c.Name},
                               Manufacturer = manufacturer
                           };
            return products.ToList();
        }

        public ICollection<Unit> GetUnits()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
