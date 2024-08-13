using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_OO_03.Models
{
    internal class Personne
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }

        public virtual string NomComplet
        {
            get { return $"{Prenom} {Nom}"; }
        }

        public virtual void Dormir(int nbHeure)
        {
            Console.WriteLine($"{NomComplet} dort {nbHeure} heures.");
        }

        public void Manger(string repas)
        {
            Console.WriteLine($"{NomComplet} mange {repas}.");
        }

        public virtual string GetPresentation()
        {
            return $"{this.Nom} {this.Prenom[0]}.";
        }
    }
}
