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
        void DeactiveProduct(Product product);
        
    }
}
