using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CERP.Modules.Procurement.Domain;

namespace CERP.Modules.Procurement.Service
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        
        #region IPurchaseOrderService Implementation

        public void CreatePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            throw new NotImplementedException();
        }

        public void RemovePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            throw new NotImplementedException();
        }

        public void ApprovePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            throw new NotImplementedException();
        }

        public void CancelPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            throw new NotImplementedException();
        }

        public void ClosePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            throw new NotImplementedException();
        }

        public ICollection<PurchaseOrder> GetAllPurchaseOrders()
        {
            throw new NotImplementedException();
        }

        public ICollection<PurchaseOrder> Search(string query)
        {
            throw new NotImplementedException();
        }

        public PurchaseOrder ClonePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            throw new NotImplementedException();
        }
        
        #endregion
    }
}
