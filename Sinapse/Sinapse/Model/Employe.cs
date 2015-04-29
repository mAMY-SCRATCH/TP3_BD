using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sinapse.Model
{
    public class Employe
    {
        [Key]
        public int EmployeID { get; set; }

        [Required]
        public long NAS { get; set; }

        [Required, StringLength(15)]
        public string Nom { get; set; }

        [Required, StringLength(15)]
        public string Prenom { get; set; }

        public string Fonction { get; set; }

        public int Salaire { get; set; }

        public virtual ICollection<Affectation> Affectations { get; set; }
    }
}
