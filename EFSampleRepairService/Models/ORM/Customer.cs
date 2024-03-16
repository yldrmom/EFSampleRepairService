using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleRepairService.Models.ORM
{
    public class Customer:BaseModel
    {
      
        public string Name { get; set; }
        [MaxLength(20)]
        public string Surname { get; set; }
        [MaxLength(20)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; } 




    }
}
