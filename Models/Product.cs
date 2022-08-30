using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace yektaApi.Models
{
    public class Product
    {
        [Key]
        public int PId { get; set; }
        public int CPId{ get; set; }
        [MaxLength(200)]
        public string PName { get; set; }
        [MaxLength(200)]
        public string PInfo { get; set; }
        [MaxLength(200)]
        public string Pqhotr { get; set; }
        [MaxLength(200)]
        public string Psize { get; set; }
        [MaxLength(200)]
        public string Pzekhamat { get; set; }
        [MaxLength(200)]
        public string Pvazn { get; set; }
        [MaxLength(200)]
        public string Pestandard { get; set; }
        
        public int PPrice { get; set; }
        [MaxLength(200)]
        public string PPic { get; set; }



    }
}
