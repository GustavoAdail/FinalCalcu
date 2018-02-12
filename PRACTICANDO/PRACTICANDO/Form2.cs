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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
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
        private void txt1_Validating(object sender, CancelEventArgs e)
        {
            if(txt1.Text == "")
            {
                e.Cancel = true;
            }
            else
            {
                txt1.Enabled = false;
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
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

        

        private void txt2_Validating(object sender, CancelEventArgs e)
        {
            if(txt2.Text == "")
            {
                e.Cancel = true;
            }
            else
            {
                txt2.Enabled = false;
            }
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            int multiplicar;
            multiplicar = int.Parse(txt1.Text) * int.Parse(txt2.Text);
            txtresultado.Text = multiplicar.ToString();
            lstpromedio.Items.Clear();
                        
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            int resta;
            resta = int.Parse(txt1.Text) - int.Parse(txt2.Text);
            txtresultado.Text = resta.ToString();
            lstpromedio.Items.Clear();
        }

        private void btnsuma_Click_1(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            int suma;
            suma = int.Parse(txt1.Text) + int.Parse(txt2.Text);
            txtresultado.Text = suma.ToString();
            lstpromedio.Items.Clear();
        }


        private void btnsuma_Click(object sender, EventArgs e)
        {
            float total, promedio;
            total = float.Parse(txt1.Text) + float.Parse(txt2.Text);
            promedio = total / 2;
            txtresultado.Text = (total.ToString());
            if (promedio > 5)
            {
                lstpromedio.Items.Add("Aprobado: " + promedio);
            }
            else
            {
                lstpromedio.Items.Add("Reprobado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";

            lstpromedio.Items.Clear();
            
        }

        private void lstpromedio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
