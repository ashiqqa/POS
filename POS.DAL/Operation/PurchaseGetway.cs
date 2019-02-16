using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Models.Operation;

namespace POS.DAL.Operation
{
    public class PurchaseGetway
    {
        PosDbContext _posDbContext = new PosDbContext();
        public bool Add(Purchase purchase)
        {
            _posDbContext.Purchases.Add(purchase);
            return _posDbContext.SaveChanges() > 0;
        }
    }
}
