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
        private Prodotto p1;
        private Carrello c;
        Prodotto[] prodotti = new Prodotto[999];
        public Form1()
        {
            InitializeComponent();

            p = new Prodotto("k870t", "tastiera", 80, "ajazz", "bianca");
            p1 = new Prodotto("SMA71", "Samsung", 299, "A71", "nero");
            prodotti[0] = p;
            c = new Carrello("tastiera", prodotti);
            c.aggiungi(p);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < prodotti.Length; i++)
            {
                if (prodotti[i] == null)
                {
                    return;
                }
                else
                {
                    listBoxId.Items.Add(prodotti[i].toStringId());
                    listBoxNome.Items.Add(prodotti[i].toStringNome());
                    listBoxPrezzo.Items.Add(prodotti[i].toStringPrezzo());
                    listBoxProduttore.Items.Add(prodotti[i].toStringProduttore());
                    listBoxDescrizione.Items.Add(prodotti[i].toStringDescrizione());
                }

            }
        }

        private void listBoxId_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxId.SelectedItem != null)
            {
                if (MessageBox.Show("Eliminare?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Eliminato");
                }
                else
                {
                    MessageBox.Show("Non Eliminato");
                }
            }
        }

        private void listBoxNome_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxNome.SelectedItem != null)
            {
                if (MessageBox.Show("Eliminare?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Eliminato");
                }
                else
                {
                    MessageBox.Show("Non Eliminato");
                }
            }
        }

        private void listBoxPrezzo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxPrezzo.SelectedItem != null)
            {
                if (MessageBox.Show("Eliminare?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Eliminato");
                }
                else
                {
                    MessageBox.Show("Non Eliminato");
                }
            }
        }

        private void listBoxProduttore_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxProduttore.SelectedItem != null)
            {
                if (MessageBox.Show("Eliminare?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Eliminato");
                }
                else
                {
                    MessageBox.Show("Non Eliminato");
                }
            }
        }

        private void listBoxDescrizione_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxDescrizione.SelectedItem != null)
            {
                if (MessageBox.Show("Eliminare?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Eliminato");
                }
                else
                {
                    MessageBox.Show("Non Eliminato");
                }
            }
        }

        private void buttonSvuotaCarrello_Click(object sender, EventArgs e)
        {
            //c.svuota();
            Form1_Load(sender, e);
        }
    }
}
