using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using Apex.Common.Data;
using CERP.Modules.DataManagement.DataAccess;
using CERP.Modules.DataManagement.Domain;
using CERP.Modules.DataManagement.Repository;

namespace CERP.Modules.DataManagement.Services
{
    public class ProductService : IProductService
    {
        #region Fields
        private readonly DataManagementContext _context;
        private readonly ProductRepository _productRepository;
        #endregion

        #region Constructors

        public ProductService()
        {
            _context = new DataManagementContext();
        }

        public ProductService(IUnitOfWork unitOfWork)
        {
            if(unitOfWork == null)
                throw new ArgumentNullException("unitOfWork");
            _context = unitOfWork as DataManagementContext;
            _productRepository = new ProductRepository(_context);
        }

        #endregion

        #region IProductService Implementation

        public void AddNewProduct(Product product)
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
            _productRepository.Add(newProduct);
            _context.CommitChanges();
        }

        public void RemoveProduct(Product product)
        {
            var p = _context.Products.SingleOrDefault(m => m.ProductID == product.ProductID);
            if(p == null)
                throw new Exception("The supplied product was not found in the database!!!");
            try
            {
                _context.Products.Remove(p);
                _context.CommitChanges();
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
            _context.CommitChanges();
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
            _context.CommitChanges();
        }

        public ICollection<Product> SearchProducts(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return GetProducts();
            var sanitisedQuery = string.Format("%{0}%", query.Sanitise().Trim());
            var searchResults = from p in _context.Products
                                join m in _context.Manufacturers on p.ManufacturerID equals m.ManufacturerID
                                join c in _context.ProductCategories on p.ProductCategoryID equals c.ProductCategoryID
                                where p.IsActive &&
                                (SqlFunctions.PatIndex(sanitisedQuery,p.Name) > 0 ||
                                SqlFunctions.PatIndex(sanitisedQuery, p.ProductNumber) > 0 ||
                                SqlFunctions.PatIndex(sanitisedQuery, c.Name) > 0 ||
                                SqlFunctions.PatIndex(sanitisedQuery, m.Name) > 0)
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
            _context.CommitChanges();
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
