using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleRepairService.Models.ORM
{
    public class ServiceRecords:BaseModel
    {
        public Customer Customer { get; set; }
        public int CustomerId { get; set; } 
        public string EquipmentType { get; set; }
        [MaxLength(20)]
        public string Brand {  get; set; }
        [MaxLength(20)]
        public string Model { get; set; }
        [MaxLength(20)]
        public string SerialNumber { get; set; }
        [MaxLength(20)]
        public string Description { get; set; }
        
        public DateTime AcceptedDate { get; set; }
        public DateTime DeliveryTime { get; set; }
        public ServiceStatus Status { get; set; }
        public int ServiceStatusId {  get; set; }
        public Invoices Invoices { get; set; }
        public Personel Personel { get; set; }
        public int PersonelId { get; set; } 



    }
}
