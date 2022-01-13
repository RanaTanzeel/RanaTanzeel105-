

using System.ComponentModel.DataAnnotations;

namespace Rana_Tanzeel.Models
{
    public class student
    {  [Key]
        public int ID { get; set; }
        [Required]
        
        public string Address { get; set; }
        [Required]
        public string Name { get; set; }


    }
}
