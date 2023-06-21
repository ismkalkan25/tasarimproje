using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManningEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Formuladan gerekli formülleri çeker.
        Formula _formula = new Formula();

        //Rh formülünü hesaplar
        private void btnRhCalculate_Click(object sender, EventArgs e)
        {
            //yanlış bir şey veya boş bırakılırsa program çökmemesi için.
            try
            {
            //Formula.RhFormul'e textBoxlara girilen sayılar yollanır.
            float Hydraulic = _formula.RhFormul(Convert.ToSingle(tbxA.Text), Convert.ToSingle(tbxP.Text));
            //Formülden gelen bilgiler tekrar textBoxa yazdırılır.
            tbxRh.Text = Hydraulic.ToString();
            tbxRh2.Text = Hydraulic.ToString();
            tbxA2.Text = tbxA.Text;

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Sayı Girin!");
            }

        }
        //V formülünü hesaplar
        private void btnVCalculate_Click(object sender, EventArgs e)
        {
            try
            {
            //Formula.VFormul'e textBoxlara girilen sayılar yollanır.
            float Water = _formula.VFormul(Convert.ToSingle(tbxS.Text), Convert.ToSingle(tbxN.Text));
            tbxV.Text = Water.ToString();
            tbxV2.Text = Water.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Sayı Girin!");
            }

        }

        
        //Q formülünü hesaplar.
        private void btnQCalculate_Click(object sender, EventArgs e)
        {
            try
            {
            //Formula.QFormul'e textBoxlara girilen sayılar yollanır.
            float Manning = _formula.QFormul(Convert.ToSingle(tbxA2.Text), Convert.ToSingle(tbxV2.Text));
            tbxQ.Text = Manning.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Sayı Girin!");
            }

        }

        //textBoxlara girilen bilgileri boşalatır.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbxA.Text = ""; 
            tbxA2.Text = "";
            tbxN.Text = "";
            tbxP.Text = "";
            tbxQ.Text = "";
            tbxRh.Text = "";
            tbxRh2.Text = "";
            tbxS.Text = "";
            tbxV.Text = "";
            tbxV2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
