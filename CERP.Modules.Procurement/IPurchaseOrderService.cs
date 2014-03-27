using System.Collections.Generic;
using CERP.Modules.Procurement.Domain;

namespace CERP.Modules.Procurement
{
    public interface IPurchaseOrderService
    {
        /// <summary>
        /// Creates a new Purchase Order in the database
        /// </summary>
        /// <param name="purchaseOrder"></param>
        void CreatePurchaseOrder(PurchaseOrder purchaseOrder);
        /// <summary>
        /// Removes the given Purchase Order from the database, assuming it doesn't have associated Invoices or Receipts
        /// </summary>
        /// <param name="purchaseOrder"></param>
        void RemovePurchaseOrder(PurchaseOrder purchaseOrder);
        /// <summary>
        /// Approves the given Purchase Order
        /// </summary>
        /// <param name="purchaseOrder">Purchase Order to be approved</param>
        void ApprovePurchaseOrder(PurchaseOrder purchaseOrder);
        /// <summary>
        /// Cancels the given Purchase Order
        /// </summary>
        /// <returns></returns>
        void CancelPurchaseOrder(PurchaseOrder purchaseOrder);
        /// <summary>
        /// Closes the given Purchase Order as fulfilled
        /// </summary>
        void ClosePurchaseOrder(PurchaseOrder purchaseOrder);
        /// <summary>
        /// Gets draft and approved purchase orders
        /// </summary>
        /// <returns>List of purchase orders</returns>
        ICollection<PurchaseOrder> GetAllPurchaseOrders();
        /// <summary>
        /// Returns all purchase orders that satisfy the given query
        /// </summary>
        /// <param name="query">Query to search the database against</param>
        /// <returns>List of purchase orders</returns>
        ICollection<PurchaseOrder> Search(string query);
        /// <summary>
        /// Creates a replica of the given Purchase Order
        /// </summary>
        /// <param name="purchaseOrder">Purchase Order to clone</param>
        /// <returns>A newly cloned Purchase Order</returns>
        PurchaseOrder ClonePurchaseOrder(PurchaseOrder purchaseOrder);

    }
}
