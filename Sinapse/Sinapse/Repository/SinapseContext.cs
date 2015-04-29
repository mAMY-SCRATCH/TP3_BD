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
        public DbSet<Employe> Employes { get; set; }

        public DbSet<Affectation> Affectations { get; set; }

        public DbSet<Projet> Projets { get; set; }

        public DbSet<Client> Clients { get; set; }
    }

    public class SinapseInitializer : DropCreateDatabaseIfModelChanges<SinapseContext>
    {
        protected override void Seed(SinapseContext appContext)
        {
            base.Seed(appContext);

            Employe emp1 = new Employe() { EmployeID = 100, NAS = 123456789, Nom = "Bond", Prenom = "James", Salaire = 120000 };
            Employe emp2 = new Employe() { EmployeID = 101, NAS = 234567890, Nom = "Frost", Prenom = "Miranda", Salaire = 110000 };
            Employe emp3 = new Employe() { EmployeID = 102, NAS = 345678901, Nom = "Lynd", Prenom = "Vesper", Salaire = 99000 };
            Employe emp4 = new Employe() { EmployeID = 103, NAS = 456789012, Nom = "King", Prenom = "Elektra", Salaire = 1500000 };
            Employe emp5 = new Employe() { EmployeID = 104, NAS = 567890123, Nom = "Jones", Prenom = "Christmas", Salaire = 88000 };

            Client cl1 = new Client() { ClientID = 10, NomClient = "Secret Client 1" };
            Client cl2 = new Client() { ClientID = 11, NomClient = "Secret Client 2" };
            Projet p1 = new Projet() { ProjetID = 10, Nom = "BrightDiamond", ClientID = cl1 };
            Projet p2 = new Projet() { ProjetID = 11, Nom = "InvisibleArctica", ClientID = cl1 };
            Projet p3 = new Projet() { ProjetID = 12, Nom = "GoldenEye", ClientID = cl2 };
            Projet p4 = new Projet() { ProjetID = 13, Nom = "TomorrowNeverDies", ClientID = cl2 };
            Projet p5 = new Projet() { ProjetID = 13, Nom = "TheWorldIsNotEnough", ClientID = cl2 };

            appContext.Employes.Add(emp1);
            appContext.Employes.Add(emp2);
            appContext.Employes.Add(emp3);
            appContext.Employes.Add(emp4);
            appContext.Employes.Add(emp5);
            appContext.Employes.Add(new Employe() { EmployeID = 105, NAS = 678901234, Nom = "Jonhson", Prenom = "Jinx", Salaire = 100000 });
            appContext.Employes.Add(new Employe() { EmployeID = 106, NAS = 789012345, Nom = "Onatopp", Prenom = "Xenia", Salaire = 1900000 });

            appContext.Clients.Add(cl1);
            appContext.Clients.Add(cl2);
            appContext.Projets.Add(p1);
            appContext.Projets.Add(p2);
            appContext.Projets.Add(p3);
            appContext.Projets.Add(p4);
            appContext.Projets.Add(p5);

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
