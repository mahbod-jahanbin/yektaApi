using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yektaApi.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "نام دسته")]
        [Required(ErrorMessage = "نباید بدون مقدار باشد")]
        [MaxLength(50, ErrorMessage = "مقدار {0} نباید بیش تر از {1} کاراکتر باشد")]
        public string Name { get; set; }

        [ForeignKey("Parent")]
        public int? ParentId { get; set; }

        [Display(Name = "آیکون")]
        [MaxLength(20, ErrorMessage = "مقدار {0} نباید بیش تر از {1} کاراکتر باشد")]
        public string Icon { get; set; }

        public virtual Category Parent { get; set; }

    }
}
