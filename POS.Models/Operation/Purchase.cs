using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Models.Operation
{
    public class Purchase
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int OrganizationId { get; set; }
        public int BranchId { get; set; }
        public int EmployeeId { get; set; }
        public int PartyId { get; set; }
        public double TotalAmmmount { get; set; }
        public double DueAmmount { get; set; }
        public  DateTime PurchaseDate { get; set; }
        public string Remarks { get; set; }

        public virtual List<PurchaseDetails> PurchaseDetailses { get; set; }
    }
}
