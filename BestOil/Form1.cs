using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        string first, second;
        public PictureBox pictureBox { get; set; }
        public List<string> AllPricesInCafe { get; set; }
        public Form1()
        {
            InitializeComponent();
            PriceTxtbox.Enabled = false;
            totalTxtbox.Enabled = false;
            HamburgerMaskedBox.Enabled = false;
            FreeMaskedBox.Enabled = false;
            BeerMaskedBox.Enabled = false;
            CapucinoMaskedBox.Enabled = false;
            HotDogMaskedBox.Enabled = false;
            //pictureBox = new PictureBox();
            // pictureBox.Image = Properties.Resources.Vollet;
            //    PictureBox vollet = new PictureBox();
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox.Size = new Size(100,100);
            //pictureBox.Location = new Point(15,480);
            //this.Controls.Add(pictureBox);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Oil> oils = new List<Oil> {
                new Oil{Name="Diesel",Price="0.8" },
                new Oil{Name="i 92",Price="1" },
                new Oil{Name="i 95",Price="1.2" },
                new Oil{Name="i 98",Price="1.5" }
            };
            OilsTypesCombo.Items.Add(oils);
            OilsTypesCombo.DisplayMember = "Name";
            OilsTypesCombo.DataSource = oils;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OilsTypesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            PriceLbl.Text = (OilsTypesCombo.SelectedItem as Oil)?.Price;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            totalTxtbox.Text = "";
            if (radioButton1.Checked == true)
            {
                PriceTxtbox.Enabled = true;
            }
            else
            {
                PriceTxtbox.Enabled = false;
            }
        }



        private void PriceTxtbox_TextChanged(object sender, EventArgs e)
        {

            AZN.Text = "AZN";
            try
            {
                first = PriceTxtbox.Text;
                second = PriceLbl.Text;
                double a;
                a = Convert.ToDouble(first) * Convert.ToDouble(second);
                TotalPriceLib.Text = a.ToString();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void totalTxtbox_TextChanged(object sender, EventArgs e)
        {
            AZN.Text = "Litr";
            try
            {
                first = PriceLbl.Text;
                second = totalTxtbox.Text;
                double a;
                a = Convert.ToDouble(second) / Convert.ToDouble(first);
                TotalPriceLib.Text = a.ToString();
            }
            catch (Exception)
            {


            }
        }


        private void HotDogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HotDogCheckBox.Checked == true)
            {
                HotDogMaskedBox.Enabled = true;
            }
            else
            {
                HotDogMaskedBox.Enabled = false;
                HotDogMaskedBox.Text = "0";
            }
        }

        private void CapucinoCheckedBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CapucinoCheckedBox.Checked == true)
            {
                CapucinoMaskedBox.Enabled = true;
            }
            else
            {
                CapucinoMaskedBox.Enabled = false; CapucinoMaskedBox.Text = "0";
            }
        }

        private void FreeCheckedBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FreeCheckedBox.Checked == true)
            {
                FreeMaskedBox.Enabled = true;
            }
            else { FreeMaskedBox.Text = "0"; FreeMaskedBox.Enabled = false; }
        }

        private void HamburgerCheckedBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HamburgerCheckedBox.Checked == true)
            {
                HamburgerMaskedBox.Enabled = true;
            }
            else { HamburgerMaskedBox.Enabled = false; HamburgerMaskedBox.Text = "0"; }
        }

        private void BeerCheckedBox_CheckedChanged(object sender, EventArgs e)
        {

            if (BeerCheckedBox.Checked == true)
            {
                BeerMaskedBox.Enabled = true;
            }
            else { BeerMaskedBox.Enabled = false; BeerMaskedBox.Text = "0"; }

        }

        private void Total_in_Cafe_TextChanged(object sender, EventArgs e)
        {





        }



        private void HotDogMaskedBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a = 0;
                first = HotDogPrice.Text;
                second = HotDogMaskedBox.Text;
                if (first != "0")
                {

                    a = Convert.ToDouble(second) * Convert.ToDouble(first);
                    Total_in_Cafe.Text = a.ToString();
                }
                else
                {
                    a -= Convert.ToDouble(second) * Convert.ToDouble(first);
                    Total_in_Cafe.Text = a.ToString();

                }



                a = 0;
                first = CapucinoPrice.Text;
                second = CapucinoMaskedBox.Text;
                if (first != "0")
                {
                    a = Convert.ToDouble(second) * Convert.ToDouble(first);
                    Total_in_Cafe.Text = a.ToString();
                }
                else
                {
                    a -= Convert.ToDouble(second) * Convert.ToDouble(first);
                    Total_in_Cafe.Text = a.ToString();
                }
            }
            catch (Exception)
            {


            }

          //  AllPricesInCafe.Add(a.ToString());
            if (HotDogCheckBox.Checked == false)
            {
                // AllPricesInCafe.Remove(a.ToString());
            }
            //Total_in_Cafe.Text = AllPricesInCafe.ToString();


            //if (HotDogCheckBox.Checked == false)
            //{
            //        double.TryParse(Total_in_Cafe,out double total);

        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
         

        }

       

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PriceTxtbox.Text = "";
            if (radioButton2.Checked == true)
            {
                totalTxtbox.Enabled = true;
            }
            else totalTxtbox.Enabled = false;
        }
    }
}