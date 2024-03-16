using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleRepairService.Models.ORM
{
    public class Personel:BaseModel
    {
        public string Name { get; set; }
        [MaxLength(20)]
        public string Surname { get; set; }

        public string Email { get; set; }
        [MaxLength(20)]
       
        public string Phone { get; set; }
        public DateTime StartDate { get; set; }
        public string Position { get; set; }
        


    }
}
