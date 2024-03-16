using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleRepairService.Models.ORM
{
    public class SpareParts:BaseModel
    {
        public string Name {  get; set; }
        [MaxLength(20)]
        public string Brand { get; set; }
        [MaxLength(20)]
        public string Model { get; set; }
        [MaxLength(20)]
        public int StockInQuantity { get; set; }
        public decimal Price { get; set; }

    }
}
