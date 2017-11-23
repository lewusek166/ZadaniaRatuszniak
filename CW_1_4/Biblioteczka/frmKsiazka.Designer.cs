namespace Biblioteczka
{
    partial class frmKsiazka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAutor = new System.Windows.Forms.TextBox();
            this.tbxTytul = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.nudStron = new System.Windows.Forms.TextBox();
            this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(41, 51);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tutuł:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stron:";
            // 
            // tbxAutor
            // 
            this.tbxAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAutor.Location = new System.Drawing.Point(104, 46);
            this.tbxAutor.Name = "tbxAutor";
            this.tbxAutor.Size = new System.Drawing.Size(205, 22);
            this.tbxAutor.TabIndex = 3;
            // 
            // tbxTytul
            // 
            this.tbxTytul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTytul.Location = new System.Drawing.Point(104, 93);
            this.tbxTytul.Name = "tbxTytul";
            this.tbxTytul.Size = new System.Drawing.Size(205, 22);
            this.tbxTytul.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(44, 193);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(97, 34);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(222, 193);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(87, 34);
            this.btnAnuluj.TabIndex = 7;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // nudStron
            // 
            this.nudStron.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ksiazkaBindingSource, "IloscStron", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.nudStron.Location = new System.Drawing.Point(104, 142);
            this.nudStron.Name = "nudStron";
            this.nudStron.Size = new System.Drawing.Size(205, 22);
            this.nudStron.TabIndex = 8;
            // 
            // ksiazkaBindingSource
            // 
            this.ksiazkaBindingSource.DataSource = typeof(Dane.Ksiazka);
            // 
            // frmKsiazka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 239);
            this.Controls.Add(this.nudStron);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbxTytul);
            this.Controls.Add(this.tbxAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Name = "frmKsiazka";
            this.Text = "frmKsiazka";
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAutor;
        private System.Windows.Forms.TextBox tbxTytul;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.TextBox nudStron;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource;
    }
}