using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Carrello
    {
        private string _id; //primary key
        private int numeroprodotti = 0;
        private Prodotto[] prodotti;

        public Carrello(string id1, Prodotto[] arrayp)
        {
            Id = id1;
            prodotti = arrayp;
        }

        public string Id
        {
            set { _id = value; }
            get { return _id; }       
        }

        public void aggiungi(Prodotto p)
        {
            prodotti[numeroprodotti] = p;
            numeroprodotti++;
        }

        public Prodotto rimuovi(Prodotto p)
        {
            for (int i = 0; i < numeroprodotti; i++)
            {
                if (p == prodotti[i])
                {
                    prodotti[i] = null;
                    return p;
                }
            }
            throw new Exception("prodotto insesistente");
        }

        public Prodotto[] svuota()
        {
            Prodotto[] array = new Prodotto[999];
            for (int i = 0; i < numeroprodotti; i++)
            {
                array[i] = prodotti[i];
                prodotti[i] = null;
            }
            return array;
        }

        public Prodotto[] getProdotti()
        {
            return prodotti;
        }
    }
}
