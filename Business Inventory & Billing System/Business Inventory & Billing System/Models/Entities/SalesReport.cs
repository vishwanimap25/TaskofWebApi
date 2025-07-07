using System.ComponentModel.DataAnnotations;

namespace Business_Inventory___Billing_System.Models.Entities
{
    public class SalesReport
    {
        [Key]
        public int SerialNo { get; set; }
        public string CategoryName { get; set; }   //foregin key
        public Category Category { get; set; }  //navigation property
        public int SalesInDay { get; set; }
        public int SalesInMonth { get; set; }
        public int Total { get; set; }
    }
}

