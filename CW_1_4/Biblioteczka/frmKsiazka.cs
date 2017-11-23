using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dane;
namespace Biblioteczka
{
    public partial class frmKsiazka : Form
    {
        Ksiazka ksiazka;
        public frmKsiazka()
        {
            InitializeComponent();
         
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            this.ksiazka = new Ksiazka(tbxTytul.Text, tbxAutor.Text, nudStron.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.FormClosed();
        }

        private new void FormClosed()
        {
            throw new NotImplementedException();
        }
    }
}

