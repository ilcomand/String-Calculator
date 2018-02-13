using ClassLibrary1;
using System;
using System.Windows.Forms;

namespace Esercizio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var calc = new Calculator();

            int risultato = calc.Calculate(txtStringa.Text);
            txtRis.Text = risultato.ToString();
            txtStringa.Clear();
            txtStringa.Focus();
        }

       
    }

   
    
}
