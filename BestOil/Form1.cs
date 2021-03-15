using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        string Something, Something1, Something2, Something3;
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
            // BeerMaskedBox.Enabled = false;
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
            double a;
            PriceLbl.Text = (OilsTypesCombo.SelectedItem as Oil)?.Price;
            // MessageBox.Show(sender.ToString());

            if (PriceTxtbox.Text != string.Empty)
            {
                first = PriceLbl.Text;
                second = PriceTxtbox.Text;
                double.TryParse(first, out double firstD);
                double.TryParse(second, out double secondD);
                a = firstD * secondD;
                TotalPriceLib.Text = a.ToString();
                button1.Enabled = true;
            }
            else if (totalTxtbox.Text != string.Empty)
            {
                first = PriceLbl.Text;
                second = totalTxtbox.Text;
                double.TryParse(first, out double firstD);
                double.TryParse(second, out double secondD);
                a = secondD / firstD;
                TotalPriceLib.Text = a.ToString();
                button1.Enabled = true;
            }

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
                button1.Enabled = true;
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
                button1.Enabled = true;
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



        private void Total_in_Cafe_TextChanged(object sender, EventArgs e)
        {





        }



        private void HotDogMaskedBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                double a;
                first = HotDogPrice.Text;
                second = HotDogMaskedBox.Text;
                // double a = 0;

                //string first1 = CapucinoPrice.Text;
                //string second1 = CapucinoMaskedBox.Text;

                double.TryParse(Total_in_Cafe.Text, out double d);
                double.TryParse(first, out double firstD);
                int.TryParse(second, out int secondD);
                double.TryParse(Something1, out double b);
                a = firstD * secondD + d;
                a -= (b * firstD);
                Total_in_Cafe.Text = a.ToString();
                Something1 = HotDogMaskedBox.Text;

                button1.Enabled = true;


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

        private void HotDogMaskedBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int AA;
            button1.Enabled = true;
            if (TotalPriceLib.Text != "0" || Total_in_Cafe.Text != "0")
            {

                double a;
                string first1 = TotalPriceLib.Text;
                string second1 = Total_in_Cafe.Text;
                double.TryParse(second1, out double secondD);
                double.TryParse(first1, out double firstD);
                a = firstD + secondD;
                TotalTotalLbl.Text = a.ToString();

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|.pdf", ValidateNames = true })
                {

                    if (sfd.ShowDialog()==DialogResult.OK)
                    {
                        iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                        try
                        {
                            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.OpenOrCreate));
                            doc.Open();
                            doc.Add(new iTextSharp.text.Paragraph("Total price : \n"));
                            doc.Add(new iTextSharp.text.Paragraph(TotalTotalLbl.Text));
                            doc.Add(new iTextSharp.text.Paragraph("\nEnd!"));

                            //doc.Pages.Add
                            //    doc.Add(new iTextSharp.text.Paragraph(DateTime.Now));
                            //Image image = new Image(@"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ9zJZcEV_YhZbsxSPbG8asz92NCpzao9r9pw&usqp=CAU", 0, 0);
                          //  page.Elements.Add(image);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally {
                            doc.Close();
                        }
                    }


                }
                

                
                // button1.Enabled=false;


               // button1.Enabled = false;
            }
            if(TotalPriceLib.Text == "0" || Total_in_Cafe.Text == "0")
            {
                button1.Enabled = true;
            }
            button1.Enabled = false;
            //TotalTotalLbl.Text;
            //TotalPriceLib

            //Total_in_Cafe



        }

        private void PriceTxtbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void HamburgerMaskedBox_TextChanged(object sender, EventArgs e)
        {

            double a;

            string first1 = HamburgerPrice.Text;
            string second1 = HamburgerMaskedBox.Text;

            double.TryParse(Total_in_Cafe.Text, out double d);
            double.TryParse(first1, out double firstD);
            int.TryParse(second1, out int secondD);
            double.TryParse(Something, out double b);
            a = firstD * secondD + d;
            a -= (b * firstD);
            Total_in_Cafe.Text = a.ToString();
            Something = HamburgerMaskedBox.Text;
            button1.Enabled = true;



        }

        private void CapucinoMaskedBox_TextChanged(object sender, EventArgs e)
        {
            double a;

            string first1 = CapucinoPrice.Text;
            string second1 = CapucinoMaskedBox.Text;

            double.TryParse(Total_in_Cafe.Text, out double d);
            double.TryParse(first1, out double firstD);
            int.TryParse(second1, out int secondD);
            double.TryParse(Something3, out double b);
            a = firstD * secondD + d;
            a -= (b * firstD);
            Total_in_Cafe.Text = a.ToString();
            Something3 = CapucinoMaskedBox.Text;

            button1.Enabled = true;




        }

        private void FreeMaskedBox_TextChanged(object sender, EventArgs e)
        {
            double a;
            string first2 = FreePrice.Text;
            string second2 = FreeMaskedBox.Text;

            double.TryParse(Total_in_Cafe.Text, out double d);
            double.TryParse(first2, out double firstD);
            int.TryParse(second2, out int secondD);
            double.TryParse(Something2, out double b);
            a = firstD * secondD + d;
            a -= (b * firstD);
            Total_in_Cafe.Text = a.ToString();
            Something2 = FreeMaskedBox.Text;
            button1.Enabled = true;
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