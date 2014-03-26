using System.Collections.Generic;
using CERP.Modules.DataManagement.Domain;

namespace CERP.Modules.DataManagement.Services
{
    class ProductService : IProductService
    {
        public void AddProduct(Product product)
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        public ICollection<Product> SearchProducts(string query)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeProductNumber(Product product, string newProductNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}
