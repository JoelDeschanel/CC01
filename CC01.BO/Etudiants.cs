using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Etudiants
    {
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public byte[] Photo { get; set; }
        public int numeroDeTelephone { get; set; }
        public string email { get; set; }

        public Etudiants()
        {

        }

        public Etudiants(string matricule, string nom, string prenom, byte[] photo, int numeroDeTelephone, string email)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            Photo = photo;
            this.numeroDeTelephone = numeroDeTelephone;
            this.email = email;
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiants etudiants &&
                   Matricule == etudiants.Matricule;
        }

        public override int GetHashCode()
        {
            return 797189699 + EqualityComparer<string>.Default.GetHashCode(Matricule);
        }
    }
}