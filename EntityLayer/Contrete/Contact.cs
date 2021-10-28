using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Contrete
{
   public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string ContanctUserName { get; set; }
        public string ContanctMail { get; set; }
        public string ContanctSubject { get; set; }
        public string ContanctMessage { get; set; }
        public DateTime ContanctDate { get; set; }
        public bool ContactStatus { get; set; }

    }
}
