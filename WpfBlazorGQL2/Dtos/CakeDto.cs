using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBlazorGQL2.Dtos
{
    public class CakeDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
