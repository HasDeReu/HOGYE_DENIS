using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HOGYE_DENIS.Models
{
    public class Phone
    {
        public int ID { get; set; }
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }
        [Display(Name = "Model Name")]
        public string ModelName { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
