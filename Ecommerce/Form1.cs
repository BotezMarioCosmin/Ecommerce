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
        Prodotto[] prodotti = new Prodotto[999];
        public Form1()
        {
            InitializeComponent();

            p = new Prodotto("k870t", "ajazz", 80, "epomaker", "bianca");
            prodotti[0] = p;
            c = new Carrello("tastiera", prodotti);

            listBoxId.Items.Add(prodotti[0].toStringId());
            listBoxNome.Items.Add(prodotti[0].toStringNome());
            listBoxPrezzo.Items.Add(prodotti[0].toStringPrezzo());
            listBoxProduttore.Items.Add(prodotti[0].toStringProduttore());
            listBoxDescrizione.Items.Add(prodotti[0].toStringDescrizione());
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
    }
}
