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
            Tutor tut1 = new Tutor() { ID = 100, LastName = "Bilodeau", FirstName = "Gary", EmailAddress = "bgary2@hotmail.com" };
            Tutor tut2 = new Tutor() { ID = 101, LastName = "Gagnon", FirstName = "Samuel", EmailAddress = "samPP92@hotmail.com" };
            Tutor tut3 = new Tutor() { ID = 102, LastName = "Gingras", FirstName = "Simon", EmailAddress = "ptitguy22@bell.net" };
            Tutor tut4 = new Tutor() { ID = 103, LastName = "Roy", FirstName = "Éric", EmailAddress = "eroy231@videotron.ca" };
            Tutor tut5 = new Tutor() { ID = 104, LastName = "Veilleux", FirstName = "Caroline", EmailAddress = "caro.koko@hotmail.com" };
            Tutor tut6 = new Tutor() { ID = 105, LastName = "Tremblay", FirstName = "Karine", EmailAddress = "kar.tremblay@gmail.com" };
            Tutor tut7 = new Tutor() { ID = 106, LastName = "Vézina", FirstName = "Louis", EmailAddress = "vl410Bd@gmail.com" };

            appContext.Tutors.Add(tut1);
            appContext.Tutors.Add(tut2);
            appContext.Tutors.Add(tut3);
            appContext.Tutors.Add(tut4);
            appContext.Tutors.Add(tut5);
            appContext.Tutors.Add(tut6);
            appContext.Tutors.Add(tut7);

            HelpedStudent stu1 = new HelpedStudent() { ID = 100, LastName = "Arsenault", FirstName = "Marc", EmailAddress = "marco.arso@hotmail.com" };
			HelpedStudent stu2 = new HelpedStudent(){ID = 101, LastName = "Boilard", FirstName = "Eric", EmailAddress = "eric.r.boilard2@coop.com"};
			HelpedStudent stu3 = new HelpedStudent(){ID = 102, LastName = "Couture", FirstName = "Jean-Cristophe", EmailAddress = "jc.couture.wilde@hotmail.com"};
			HelpedStudent stu4 = new HelpedStudent(){ID = 103, LastName = "Desrosiers", FirstName = "Julianne", EmailAddress = "galypo13@hotmail.com"};
			HelpedStudent stu5 = new HelpedStudent(){ID = 104, LastName = "Grégoire-Allen", FirstName = "Léo", EmailAddress = "leoga@hotmail.com"};
			HelpedStudent stu6 = new HelpedStudent(){ID = 105, LastName = "Hamel", FirstName = "François", EmailAddress = "fran.ham@hotmail.com"};
			HelpedStudent stu7 = new HelpedStudent(){ID = 106, LastName = "Lepage", FirstName = "Jérémy", EmailAddress = "je.lepa@hotmail.com"};
			HelpedStudent stu8 = new HelpedStudent(){ID = 107, LastName = "Poitras", FirstName = "Nicolas", EmailAddress = "nic.poi@hotmail.com"};
			HelpedStudent stu9 = new HelpedStudent(){ID = 108, LastName = "Roy-Gagnon", FirstName = "Samuel", EmailAddress = "sam.roy@hotmail.com"};
			HelpedStudent stu10 = new HelpedStudent(){ID = 109, LastName = "Simard", FirstName = "Benjamin", EmailAddress = "ben.simard@hotmail.com"};
			HelpedStudent stu11 = new HelpedStudent(){ID = 110, LastName = "Vachon", FirstName = "Samuel", EmailAddress = "sam.vachon@hotmail.com"};

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

            TutoringSession tgs1 = new TutoringSession() { ID = 100, DateSession = new DateTime(2015, 03, 16), TimeSession = 13, LengthSession = 2, HelpedID = stu5, TutorID = tut5};
            TutoringSession tgs2 = new TutoringSession() { ID = 101, DateSession = new DateTime(2015, 03, 24), TimeSession = 10, LengthSession = 1, HelpedID = stu5, TutorID = tut1 };
            TutoringSession tgs3 = new TutoringSession() { ID = 102, DateSession = new DateTime(2015, 03, 25), TimeSession = 13, LengthSession = 1, HelpedID = stu2, TutorID = tut4 };
            TutoringSession tgs4 = new TutoringSession() { ID = 103, DateSession = new DateTime(2015, 04, 01), TimeSession = 12, LengthSession = 2, HelpedID = stu1, TutorID = tut5 };
            TutoringSession tgs5 = new TutoringSession() { ID = 104, DateSession = new DateTime(2015, 04, 01), TimeSession = 13, LengthSession = 1, HelpedID = stu2, TutorID = tut3 };
            TutoringSession tgs6 = new TutoringSession() { ID = 105, DateSession = new DateTime(2015, 04, 06), TimeSession = 16, LengthSession = 1, HelpedID = stu1, TutorID = tut4 };
            TutoringSession tgs7 = new TutoringSession() { ID = 106, DateSession = new DateTime(2015, 04, 08), TimeSession = 10, LengthSession = 1, HelpedID = stu6, TutorID = tut4 };
            TutoringSession tgs8 = new TutoringSession() { ID = 107, DateSession = new DateTime(2015, 04, 10), TimeSession = 10, LengthSession = 2, HelpedID = stu1, TutorID = tut4 };
            TutoringSession tgs9 = new TutoringSession() { ID = 108, DateSession = new DateTime(2015, 04, 29), TimeSession = 12, LengthSession = 1, HelpedID = stu9, TutorID = tut5 };
            TutoringSession tgs10 = new TutoringSession() { ID = 109, DateSession = new DateTime(2015, 05, 25), TimeSession = 13, LengthSession = 1, HelpedID = stu10, TutorID = tut7 };
            TutoringSession tgs11 = new TutoringSession() { ID = 110, DateSession = new DateTime(2015, 05, 27), TimeSession = 12, LengthSession = 2, HelpedID = stu10, TutorID = tut5 };
            TutoringSession tgs12 = new TutoringSession() { ID = 111, DateSession = new DateTime(2015, 05, 27), TimeSession = 13, LengthSession = 1, HelpedID = stu2, TutorID = tut3 };
            TutoringSession tgs13 = new TutoringSession() { ID = 112, DateSession = new DateTime(2015, 06, 01), TimeSession = 9, LengthSession = 1, HelpedID = stu7, TutorID = tut7 };
            TutoringSession tgs14 = new TutoringSession() { ID = 113, DateSession = new DateTime(2015, 06, 02), TimeSession = 9, LengthSession = 1, HelpedID = stu11, TutorID = tut7 };
            TutoringSession tgs15 = new TutoringSession() { ID = 114, DateSession = new DateTime(2015, 06, 02), TimeSession = 11, LengthSession = 1, HelpedID = stu2, TutorID = tut7 };
            TutoringSession tgs16 = new TutoringSession() { ID = 115, DateSession = new DateTime(2015, 06, 02), TimeSession = 13, LengthSession = 1, HelpedID = stu5, TutorID = tut1 };
            TutoringSession tgs17 = new TutoringSession() { ID = 116, DateSession = new DateTime(2015, 06, 02), TimeSession = 15, LengthSession = 1, HelpedID = stu9, TutorID = tut4 };
            TutoringSession tgs18 = new TutoringSession() { ID = 117, DateSession = new DateTime(2015, 06, 03), TimeSession = 13, LengthSession = 2, HelpedID = stu7, TutorID = tut3 };

            appContext.TutoringSessions.Add(tgs1);
            appContext.TutoringSessions.Add(tgs2);
            appContext.TutoringSessions.Add(tgs3);
            appContext.TutoringSessions.Add(tgs4);
            appContext.TutoringSessions.Add(tgs5);
            appContext.TutoringSessions.Add(tgs6);
            appContext.TutoringSessions.Add(tgs7);
            appContext.TutoringSessions.Add(tgs8);
            appContext.TutoringSessions.Add(tgs9);
            appContext.TutoringSessions.Add(tgs10);
            appContext.TutoringSessions.Add(tgs11);
            appContext.TutoringSessions.Add(tgs12);
            appContext.TutoringSessions.Add(tgs13);
            appContext.TutoringSessions.Add(tgs14);
            appContext.TutoringSessions.Add(tgs15);
            appContext.TutoringSessions.Add(tgs16);
            appContext.TutoringSessions.Add(tgs17);
            appContext.TutoringSessions.Add(tgs18);

        }
    }
}
