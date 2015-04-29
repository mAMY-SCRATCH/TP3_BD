using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sinapse.Model
{
    public class HelpedStudent
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        public virtual ICollection<TutoringSession> TutoringSessions { get; set; }
    }
}
