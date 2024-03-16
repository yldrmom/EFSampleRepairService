using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleRepairService.Models.ORM
{
    public class RepairDetail:BaseModel
    {
        public SpareParts SpareParts { get; set; }
        
        public ServiceRecords SpareRecords { get; set; }    
        
        public string UsedSpareParts { get; set; }
        public int UsedSparePartsAmount { get; set; }
        public decimal UsedSparePartsCost { get; set;}
    }
}
