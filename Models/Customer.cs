using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace yektaApi.Models
{
    public class Customer
    {
        [Key]
        public int CId { get; set; }
        [Required]
        public string CName { get; set; }
        public string CFamily { get; set; }
        public uint CCodemeli { get; set; }
        public uint CCodeTax { get; set; }
        public string CCity { get; set; }
        public string  Cmail { get; set; }
        public string Ctel { get; set; }
        public string Cmobile { get; set; }
        [MaxLength(1000)]
        public string CAddress { get; set; }
        public string Cpostalcode { get; set; }
        public string CContext { get; set; }
        public bool Ctype { get; set; }
        public int UId { get; set; }


    }
}
