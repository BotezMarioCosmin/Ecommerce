namespace Ecommerce
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxId = new System.Windows.Forms.ListBox();
            this.listBoxNome = new System.Windows.Forms.ListBox();
            this.listBoxPrezzo = new System.Windows.Forms.ListBox();
            this.listBoxProduttore = new System.Windows.Forms.ListBox();
            this.listBoxDescrizione = new System.Windows.Forms.ListBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelPrezzo = new System.Windows.Forms.Label();
            this.labelProduttore = new System.Windows.Forms.Label();
            this.labelDescrizione = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxId
            // 
            this.listBoxId.FormattingEnabled = true;
            this.listBoxId.Location = new System.Drawing.Point(12, 66);
            this.listBoxId.Name = "listBoxId";
            this.listBoxId.Size = new System.Drawing.Size(140, 277);
            this.listBoxId.TabIndex = 1;
            this.listBoxId.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxId_MouseDoubleClick);
            // 
            // listBoxNome
            // 
            this.listBoxNome.FormattingEnabled = true;
            this.listBoxNome.Location = new System.Drawing.Point(158, 66);
            this.listBoxNome.Name = "listBoxNome";
            this.listBoxNome.Size = new System.Drawing.Size(141, 277);
            this.listBoxNome.TabIndex = 2;
            this.listBoxNome.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxNome_MouseDoubleClick);
            // 
            // listBoxPrezzo
            // 
            this.listBoxPrezzo.FormattingEnabled = true;
            this.listBoxPrezzo.Location = new System.Drawing.Point(305, 66);
            this.listBoxPrezzo.Name = "listBoxPrezzo";
            this.listBoxPrezzo.Size = new System.Drawing.Size(141, 277);
            this.listBoxPrezzo.TabIndex = 3;
            this.listBoxPrezzo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPrezzo_MouseDoubleClick);
            // 
            // listBoxProduttore
            // 
            this.listBoxProduttore.FormattingEnabled = true;
            this.listBoxProduttore.Location = new System.Drawing.Point(452, 66);
            this.listBoxProduttore.Name = "listBoxProduttore";
            this.listBoxProduttore.Size = new System.Drawing.Size(141, 277);
            this.listBoxProduttore.TabIndex = 4;
            this.listBoxProduttore.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxProduttore_MouseDoubleClick);
            // 
            // listBoxDescrizione
            // 
            this.listBoxDescrizione.FormattingEnabled = true;
            this.listBoxDescrizione.Location = new System.Drawing.Point(599, 66);
            this.listBoxDescrizione.Name = "listBoxDescrizione";
            this.listBoxDescrizione.Size = new System.Drawing.Size(141, 277);
            this.listBoxDescrizione.TabIndex = 5;
            this.listBoxDescrizione.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxDescrizione_MouseDoubleClick);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(66, 39);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(29, 24);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "ID";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(194, 39);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(72, 24);
            this.labelNome.TabIndex = 7;
            this.labelNome.Text = "NOME";
            // 
            // labelPrezzo
            // 
            this.labelPrezzo.AutoSize = true;
            this.labelPrezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrezzo.Location = new System.Drawing.Point(329, 39);
            this.labelPrezzo.Name = "labelPrezzo";
            this.labelPrezzo.Size = new System.Drawing.Size(93, 24);
            this.labelPrezzo.TabIndex = 8;
            this.labelPrezzo.Text = "PREZZO";
            // 
            // labelProduttore
            // 
            this.labelProduttore.AutoSize = true;
            this.labelProduttore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduttore.Location = new System.Drawing.Point(448, 39);
            this.labelProduttore.Name = "labelProduttore";
            this.labelProduttore.Size = new System.Drawing.Size(151, 24);
            this.labelProduttore.TabIndex = 9;
            this.labelProduttore.Text = "PRODUTTORE";
            // 
            // labelDescrizione
            // 
            this.labelDescrizione.AutoSize = true;
            this.labelDescrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescrizione.Location = new System.Drawing.Point(595, 39);
            this.labelDescrizione.Name = "labelDescrizione";
            this.labelDescrizione.Size = new System.Drawing.Size(147, 24);
            this.labelDescrizione.TabIndex = 10;
            this.labelDescrizione.Text = "DESCRIZIONE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDescrizione);
            this.Controls.Add(this.labelProduttore);
            this.Controls.Add(this.labelPrezzo);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.listBoxDescrizione);
            this.Controls.Add(this.listBoxProduttore);
            this.Controls.Add(this.listBoxPrezzo);
            this.Controls.Add(this.listBoxNome);
            this.Controls.Add(this.listBoxId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxId;
        private System.Windows.Forms.ListBox listBoxNome;
        private System.Windows.Forms.ListBox listBoxPrezzo;
        private System.Windows.Forms.ListBox listBoxProduttore;
        private System.Windows.Forms.ListBox listBoxDescrizione;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelPrezzo;
        private System.Windows.Forms.Label labelProduttore;
        private System.Windows.Forms.Label labelDescrizione;
    }
}

