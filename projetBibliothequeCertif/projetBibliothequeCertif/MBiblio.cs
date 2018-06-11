using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace projetBibliothequeCertif
{
    public class MBiblio
    {
        private ArrayList livres;
        private ArrayList adherents;

        // constructeur
        public MBiblio()
        {
            this.livres = new ArrayList();
            this.adherents = new ArrayList();
        }

        // ajout d'un livre dans la collection
        public void Ajout(MLivres l)
        {
            if (l != null)
            this.livres.Add(l);
        }

        // ajout d'un adhérent dans la collection
        public void InscritPersonne(MAdherents a)
        {
            if (a != null)
                this.adherents.Add(a);
        }
        // recherche d'un livre
        public MLivres RechercheLivre(string isbn)
        {
            foreach (MLivres l in livres)
            {
                if (l.Isbn == isbn) { return l; }
            }
            return null;

        }

        // renvoit un booléen si le livre recherché est disponible ou non
        public bool isBookAvailable(string isbn, bool dispo)
        {
            RechercheLivre(isbn);
            return dispo;
        }
    }
}
