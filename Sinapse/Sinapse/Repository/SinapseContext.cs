using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Sinapse.Model;

namespace Sinapse.Repository
{
    public class SinapseContext : DbContext
    {
        public DbSet<HelpedStudent> HelpedStudents { get; set; }

        public DbSet<Tutor> Tutors { get; set; }

        public DbSet<TutoringSession> TutoringSessions { get; set; }

    }

    public class SinapseInitializer : DropCreateDatabaseIfModelChanges<SinapseContext>
    {
        protected override void Seed(SinapseContext appContext)
        {
            base.Seed(appContext);
            Tutor tut1 = new Tutor() { ID = 1, LastName = "Bilodeau", FirstName = "Gary", EmailAddress = "bgary2@hotmail.com" };
            Tutor tut2 = new Tutor() { ID = 2, LastName = "Gagnon", FirstName = "Samuel", EmailAddress = "samPP92@hotmail.com" };
            Tutor tut3 = new Tutor() { ID = 3, LastName = "Gingras", FirstName = "Simon", EmailAddress = "ptitguy22@bell.net" };
            Tutor tut4 = new Tutor() { ID = 4, LastName = "Roy", FirstName = "Éric", EmailAddress = "eroy231@videotron.ca" };
            Tutor tut5 = new Tutor() { ID = 5, LastName = "Veilleux", FirstName = "Caroline", EmailAddress = "caro.koko@hotmail.com" };
            Tutor tut6 = new Tutor() { ID = 6, LastName = "Tremblay", FirstName = "Karine", EmailAddress = "kar.tremblay@gmail.com" };
            Tutor tut7 = new Tutor() { ID = 7, LastName = "Vézina", FirstName = "Louis", EmailAddress = "vl410Bd@gmail.com" };

            appContext.Tutors.Add(tut1);
            appContext.Tutors.Add(tut2);
            appContext.Tutors.Add(tut3);
            appContext.Tutors.Add(tut4);
            appContext.Tutors.Add(tut5);
            appContext.Tutors.Add(tut6);
            appContext.Tutors.Add(tut7);

            HelpedStudent stu1 = new HelpedStudent(){ID = 100, LastName = "Arsenault", FirstName = "Marc", EmailAddress = "marco.arso@hotmail.com"}
			HelpedStudent stu2 = new HelpedStudent(){ID = 101, LastName = "Boilard", FirstName = "Eric", EmailAddress = "eric.r.boilard2@coop.com"}
			HelpedStudent stu3 = new HelpedStudent(){ID = 102, LastName = "Couture", FirstName = "Jean-Cristophe", EmailAddress = "jc.couture.wilde@hotmail.com"}
			HelpedStudent stu4 = new HelpedStudent(){ID = 103, LastName = "Desrosiers", FirstName = "Julianne", EmailAddress = "galypo13@hotmail.com"}
			HelpedStudent stu5 = new HelpedStudent(){ID = 104, LastName = "Grégoire-Allen", FirstName = "Léo", EmailAddress = "leoga@hotmail.com"}
			HelpedStudent stu6 = new HelpedStudent(){ID = 105, LastName = "Hamel", FirstName = "François", EmailAddress = "fran.ham@hotmail.com"}
			HelpedStudent stu7 = new HelpedStudent(){ID = 106, LastName = "Lepage", FirstName = "Jérémy", EmailAddress = "je.lepa@hotmail.com"}
			HelpedStudent stu8 = new HelpedStudent(){ID = 107, LastName = "Poitras", FirstName = "Nicolas", EmailAddress = "nic.poi@hotmail.com"}
			HelpedStudent stu9 = new HelpedStudent(){ID = 108, LastName = "Roy-Gagnon", FirstName = "Samuel", EmailAddress = "sam.roy@hotmail.com"}
			HelpedStudent stu10 = new HelpedStudent(){ID = 109, LastName = "Simard", FirstName = "Benjamin", EmailAddress = "ben.simard@hotmail.com"}
			HelpedStudent stu11 = new HelpedStudent(){ID = 110, LastName = "Vachon", FirstName = "Samuel", EmailAddress = "sam.vachon@hotmail.com"}

            appContext.HelpedStudents.Add(stu1);
			appContext.HelpedStudents.Add(stu2);
			appContext.HelpedStudents.Add(stu3);
			appContext.HelpedStudents.Add(stu4);
			appContext.HelpedStudents.Add(stu5);
			appContext.HelpedStudents.Add(stu6);
			appContext.HelpedStudents.Add(stu7);
			appContext.HelpedStudents.Add(stu8);
			appContext.HelpedStudents.Add(stu9);
			appContext.HelpedStudents.Add(stu10);
			appContext.HelpedStudents.Add(stu11);

            appContext.Affectations.Add(new Affectation { AffectationID = 1001, DateAffectation = DateTime.Today, EmployeID = emp1, ProjetID = p1 });
            appContext.Affectations.Add(new Affectation { AffectationID = 1002, DateAffectation = DateTime.Today, EmployeID = emp1, ProjetID = p2 });
            appContext.Affectations.Add(new Affectation { AffectationID = 1003, DateAffectation = DateTime.Today, EmployeID = emp2, ProjetID = p1 });
            appContext.Affectations.Add(new Affectation { AffectationID = 1004, DateAffectation = DateTime.Today, EmployeID = emp3, ProjetID = p1 });
            appContext.Affectations.Add(new Affectation { AffectationID = 1005, DateAffectation = DateTime.Today, EmployeID = emp3, ProjetID = p2 });
            appContext.Affectations.Add(new Affectation { AffectationID = 1006, DateAffectation = DateTime.Today, EmployeID = emp3, ProjetID = p3 });
            appContext.Affectations.Add(new Affectation { AffectationID = 1007, DateAffectation = DateTime.Today, EmployeID = emp4, ProjetID = p2 });
            appContext.Affectations.Add(new Affectation { AffectationID = 1007, DateAffectation = DateTime.Today, EmployeID = emp4, ProjetID = p3 });
            appContext.Affectations.Add(new Affectation { AffectationID = 1007, DateAffectation = DateTime.Today, EmployeID = emp5, ProjetID = p2 });
        }
    }
}
