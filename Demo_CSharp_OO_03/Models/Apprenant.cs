using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_OO_03.Models
{
    internal class Apprenant : Personne
    {
        public string RegNat { get; set; }


        public void Jouer(string jeu)
        {
            Console.WriteLine($"{NomComplet} joue à {jeu}");
        }

        public void SuivreCours(string matiere)
        {
            Console.WriteLine($"{NomComplet} suit le cours de {matiere}");
        }

        public override void Dormir(int nbHeure)
        {
            int nbHeureJeu = Random.Shared.Next(nbHeure) + 1;

            if( nbHeureJeu > 0 )
            {
                Jouer("Mario Kart 8");
            }

            if(nbHeure - nbHeureJeu > 0 )
            {
                base.Dormir(nbHeure - nbHeureJeu);
            }
        }

        public override string GetPresentation()
        {
            return "(Apprenant) " + base.GetPresentation();
        }
    }
}
