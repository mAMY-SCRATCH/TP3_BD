using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sinapse.Model
{
    public class Client
    {
        [Key]
        public long ClientID { get; set; }
        
        [Required]
        public string NomClient { get; set; }

        public int NoEnregistrement { get; set; }

        public string Ville { get; set; }

        public virtual ICollection<Projet> Projets { get; set; }
    }
}
