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
                for (int i = 0; i < 1; i++)
                {
                    for (int x = 0; x < lb_hobbi.Items.Count; x++)
                    {
                        if (lb_hobbi.Items[x].ToString() == tb_newhobbi.Text.ToString())
                        {
                            MessageBox.Show("Ez az elem már létezik. Kérem adjon  meg egy másikat");
                        }
                        else { lb_hobbi.Items.Add((tb_newhobbi.Text).ToString()); }

                    }
                    


                }
                
            }
        }
    }
}
