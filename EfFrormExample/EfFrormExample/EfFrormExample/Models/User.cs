using EfFrormExample.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfFrormExample.Models
{
    public class User:CommonProperty
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(18)]
        public string Password { get; set; }
        public DateTime CreateAccountDate { get; set; }= DateTime.Now;
        public int RoleId { get; set; }
        //[ForeignKey(nameof(RoleId))]
        //[ForeignKey("RoleId")]
        public Role Role { get; set; }

        [NotMapped]
        public string FullName {
            get {
                return $"{Name} {Surname}";
            }
        }
    }
}
