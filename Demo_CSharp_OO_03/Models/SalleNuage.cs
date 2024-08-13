using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_OO_03.Models
{
    internal class SalleNuage
    {
        private List<Personne> _Personnes = [];

        public IEnumerable<Personne> Personnes 
        { 
            get {  return _Personnes.AsReadOnly(); }
        }

        public void Ajouter(Personne person)
        {
            _Personnes.Add(person);
        }

        public void AfficherPersonne()
        {
            foreach (Personne personne in _Personnes)
            {
                //string role = "N/A";
                //if(personne is Formateur formateur)
                //{
                //    //Formateur formateur = (Formateur)personne;
                //    role = "Formateur";
                //}
                //
                //if(personne is Apprenant apprenant)
                //{
                //    role = "Apprenant";
                //}
                //
                //Console.WriteLine($"({role}) {personne.Nom} {personne.Prenom[0]}.");

                Console.WriteLine(personne.GetPresentation()) ;
            }
        }

    }
}
