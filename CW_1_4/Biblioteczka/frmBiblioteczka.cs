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
    public partial class frmBiblioteczka : Form
    {
        private Kontekst kontekst;
        public frmBiblioteczka()
        {
            InitializeComponent();
            this.kontekst = new Kontekst();
            lbKsiazki.DataSource = kontekst.KolekcjaKsiazek;
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }

     
    }
}
