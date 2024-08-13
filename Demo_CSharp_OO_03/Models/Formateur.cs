using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_OO_03.Models
{
    internal class Formateur : Personne
    {
        public override string NomComplet
        {
            get { return $"{Prenom}"; }
        }

        public void DonnerCours(string matiere, IEnumerable<Apprenant > apprenants)
        {
            Console.WriteLine($"{NomComplet} donne cours de {matiere}");
            foreach (Apprenant a in apprenants)
            {
                a.SuivreCours(matiere);
            }
        }

        public override void Dormir(int nbHeure)
        {
            base.Dormir(Math.Max(nbHeure - 3, 1));
        }

        public override string GetPresentation()
        {
            return "(Formateur) " + base.GetPresentation();
        } 
    }
}
