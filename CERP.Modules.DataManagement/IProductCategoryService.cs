using System.Collections.Generic;
using CERP.Modules.DataManagement.Domain;

namespace CERP.Modules.DataManagement
{
    public interface IProductCategoryService
    {
        /// <summary>
        /// Adds a new Product Category to the database
        /// </summary>
        /// <param name="productCategory">The Product Category to be added</param>
        void AddNewProductCategory(ProductCategory productCategory);
        /// <summary>
        /// Removes the Product Category from the database provided that it does not have associated Products or Sub-Categories
        /// </summary>
        /// <param name="productCategory"></param>
        void RemoveProductCategory(ProductCategory productCategory);
        /// <summary>
        /// Gets sub-categories under a particular Product category
        /// </summary>
        /// <param name="productCategory">Product category</param>
        ICollection<ProductCategory> GetSubCategories(ProductCategory productCategory);
        /// <summary>
        /// Gets all products listed under a particular category (including products in sub-categories)
        /// </summary>
        /// <param name="productCategory">Product category to search</param>
        ICollection<Product> GetProducts(ProductCategory productCategory);
    }
}
