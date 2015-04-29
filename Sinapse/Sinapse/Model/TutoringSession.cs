using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinapse.Model
{
    class TutoringSession
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public virtual Tutor TutorID { get; set; }

        [Required]
        public virtual HelpedStudent HelpedID { get; set; }

        [Required]
        public DateTime DateSession { get; set; }

        [Required]
        public DateTime TimeSession { get; set; }

        [Required]
        public int LengthSession { get; set; }
    }
}
