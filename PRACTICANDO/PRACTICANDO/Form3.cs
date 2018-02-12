using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICANDO
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            
        }

        private void txtletras_KeyPress(object sender, KeyPressEventArgs e)
        {           
                if(char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if(char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if(char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }                        
        }

        private void txtnumeros_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
