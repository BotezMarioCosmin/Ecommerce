using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce
{
    public partial class Form1 : Form
    {
        private Prodotto p;
        private Carrello c;
        public Form1()
        {
            InitializeComponent();

            c = new Carrello("tastiera", prodotti);
            p = new Prodotto("k870t", "ajazz", 80, "epomaker", "bianca");

            listViewProdotti.Items.Clear();
            listViewProdotti.Items.Add();

        }
    }
}
