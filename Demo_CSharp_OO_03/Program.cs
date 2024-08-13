using Demo_CSharp_OO_03.Models;

Apprenant a1 = new Apprenant();
a1.Prenom = "Riri";
a1.Nom = "Duck";
a1.RegNat = "03.02.01-123.45";

Personne a2 = new Apprenant();
a2.Prenom = "Zaza";
a2.Nom = "Vanderquack";
((Apprenant)a2).RegNat = "03.11.01-456.12";

Formateur f = new Formateur();
f.Prenom = "Balthazar";
f.Nom = "Picsou";

SalleNuage salle =  new SalleNuage();
salle.Ajouter(a1);
salle.Ajouter(f);
salle.Ajouter(a2);

salle.AfficherPersonne();

a1.Dormir(8);
f.Dormir(8);
a2.Dormir(8);

