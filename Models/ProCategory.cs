using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace yektaApi.Models
{
    public class ProCategory
    {
        [Key]
        public int CPId { get; set; }
        [Required]
        [MaxLength(200)]
        public string CPName { get; set; }
        [Required]
        [MaxLength(500)]
        public string CPInfo { get; set; }
    }
}
