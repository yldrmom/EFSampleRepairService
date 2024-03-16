using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleRepairService.Models.ORM
{
    public class ServiceStatus:BaseModel
    {
        public string Name { get; set; }
        [MaxLength(50)]
        public string Description { get; set; } 

    }
}
