using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleRepairService.Models.ORM
{
    public class Invoices:BaseModel
    {
        public DateTime CreateDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int ServiceRecordsId { get; set; }
        public ServiceRecords ServiceRecord { get; set; }
        

    }
}
