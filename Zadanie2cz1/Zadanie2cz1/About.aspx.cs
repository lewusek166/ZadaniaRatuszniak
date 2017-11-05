using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadanie2cz1
{

        public partial class About : Page
        {
            string pomoc, pomoc2;
            protected void Page_Load(object sender, EventArgs e)
            {

            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                int test = 0;
                if (TextBox1.Text == "")
                {
                    Label2.Text = "Nie wprowadzono danych";
                    test++;
                }
                if (TextBox2.Text == "")
                {
                    Label3.Text = "Nie wprowadzono danych";
                    test++;
                }
                ListItem item = DropDownList1.SelectedItem;
                if (item != null)
                {
                    if (item.Text == "Kobieta")
                    {
                        pomoc = "Mężatka";
                    }
                    if (item.Text == "Mężczyzna")
                    {
                        pomoc = "Żonaty";

                    }
                    if (item.Text == "Nieznana")
                    {
                        pomoc = "To trochę dziwne";

                    }
                    if (item.Text == "")
                    {
                        Label4.Text = "Nie wprowadzono danych";
                        test++;
                    }
                }


                if (CheckBox1.Checked == false)
                {
                    pomoc2 = "nie";
                }
                else
                {
                    pomoc2 = " ";
                }
                if (test == 0)
                {
                    Label1.ForeColor = System.Drawing.Color.Blue;
                    Label1.Text = "Witaj " + TextBox1.Text + " Masz " + TextBox2.Text + " lat/a, jesteś " + DropDownList1.SelectedValue + " i " + pomoc2 + " jesteś " + " " + pomoc;
                    Label2.Text = "";
                    Label3.Text = "";
                    Label4.Text = "";
                }
                else
                {
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = " Uzupełnij dane";
                }

            }
        }
    }