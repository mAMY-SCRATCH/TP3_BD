using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sinapse.Model
{
    public class Projet
    {
        [Key]
        public long ProjetID { get; set; }

        [Required, StringLength(25)]
        public string Nom { get; set; }

        public int Budget { get; set; }

        public virtual ICollection<Affectation> Affectations { get; set; }

        [Required]
        public virtual Client ClientID { get; set; }
    }
}
