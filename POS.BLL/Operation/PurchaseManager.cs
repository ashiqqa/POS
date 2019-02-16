using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DAL.Operation;
using POS.Models.Operation;

namespace POS.BLL.Operation
{
    public class PurchaseManager
    {
        PurchaseGetway _purchaseGetway = new PurchaseGetway();

        public bool Add(Purchase purchase)
        {
            return _purchaseGetway.Add(purchase);
        }
    }
}
