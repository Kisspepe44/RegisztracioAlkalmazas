using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class RegisztracioAlkalmazas : Form
    {
        public RegisztracioAlkalmazas()
        {
            InitializeComponent();
            
           
        }

        private void hozzaad_Click(object sender, EventArgs e)
        {

            if (tb_newhobbi.Text != "")
            {
                if (tb_newhobbi.Text.ToString() == "Úszás")
                {
                    MessageBox.Show("Ez a hobbi már létezik kérem adjon meg egy másikat.");
                }
                else if (tb_newhobbi.Text.ToString() == "Horgászat")
                {
                    MessageBox.Show("Ez a hobbi már létezik kérem adjon meg egy másikat.");
                }
                else if (tb_newhobbi.Text.ToString() == "Futás")
                {
                    MessageBox.Show("Ez a hobbi már létezik kérem adjon meg egy másikat.");
                }
                else
                {
                    lb_hobbi.Items.Add(tb_newhobbi.Text.ToString());
                }



            }
            else
            {
                MessageBox.Show("Kérem adjon meg egy hobbit!");
            }
                
            }
        }
    }

