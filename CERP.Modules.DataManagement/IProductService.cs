using System.Collections.Generic;
using CERP.Modules.DataManagement.Domain;

namespace CERP.Modules.DataManagement
{
    public interface IProductService
    {
        /// <summary>
        /// Adds a new Product to the database
        /// </summary>
        /// <param name="product">Product entity to be added</param>
        void AddProduct(Product product);
        /// <summary>
        /// Removes the given Product from the database provided that the product doesn't have associated transactions
        /// </summary>
        /// <param name="product">Product to be removed from the database</param>
        void RemoveProduct(Product product);
        /// <summary>
        /// Sets the given product as inactive (restricting it from future transactions)
        /// </summary>
        /// <param name="product"></param>
        void DisableProduct(Product product);
        /// <summary>
        /// Returns all active products in the database
        /// </summary>
        /// <returns>A list of active products</returns>
        ICollection<Product> GetProducts();
        /// <summary>
        /// Returns all inactive products in the database
        /// </summary>
        /// <returns></returns>
        ICollection<Product> GetInactiveProducts();
        /// <summary>
        /// Renames the given product
        /// </summary>
        /// <param name="product">Product to be renamed</param>
        /// <param name="newName">New name to replace the existing one</param>
        void RenameProduct(Product product, string newName);
        /// <summary>
        /// Returns all products that match the given query
        /// </summary>
        /// <param name="query">Query to search the Products database</param>
        /// <returns></returns>
        ICollection<Product> SearchProducts(string query);
        /// <summary>
        /// Changes the given Product's identification number
        /// </summary>
        /// <param name="product">Product</param>
        /// <param name="newProductNumber">New identification number to be assigned for the product</param>
        void ChangeProductNumber(Product product, string newProductNumber);

    }
}
