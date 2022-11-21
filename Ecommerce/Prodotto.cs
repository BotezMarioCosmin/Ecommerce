using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Prodotto
    {
        private string _id; //primary key
        private string _nome;
        private float _prezzo;
        private string _produttore;
        private string _descrizione;

        public Prodotto(string id1, string nome1, float prezzo1, string produttore1, string descrizione1)
        {
            Id = id1;
            Nome = nome1;
            Prezzo = prezzo1;
            Produttore = produttore1;
            Descrizione = descrizione1;
        }

        public string Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public string Nome
        {
            set { _nome = value; }
            get { return _nome; }
        }

        public float Prezzo
        {
            set { _prezzo = value; }
            get { return _prezzo; }
        }

        public string Produttore
        {
            set { _produttore = value; }
            get { return _produttore; }
        }

        public string Descrizione
        {
            set { _descrizione = value; }
            get { return _descrizione; }
        }
    }
}
