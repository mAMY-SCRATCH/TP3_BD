using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sinapse.Model
{
    public class Affectation
    {
        [Key]
        public int AffectationID { get; set; }

        public DateTime DateAffectation { get; set; }

        [Required]
        public virtual Employe EmployeID { get; set; }

        [Required]
        public virtual Projet ProjetID { get; set; }

    }
}
