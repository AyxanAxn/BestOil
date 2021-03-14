
namespace BestOil
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OilsTypesCombo = new System.Windows.Forms.ComboBox();
            this.Priceelbl = new System.Windows.Forms.Label();
            this.OilLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalTxtbox = new System.Windows.Forms.MaskedTextBox();
            this.PriceTxtbox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AZN = new System.Windows.Forms.Label();
            this.TotalPriceLib = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.HamburgerMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.FreeMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.BeerMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.CapucinoMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.HotDogMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.BeerPrice = new System.Windows.Forms.Label();
            this.HamburgerPrice = new System.Windows.Forms.Label();
            this.FreePrice = new System.Windows.Forms.Label();
            this.CapucinoPrice = new System.Windows.Forms.Label();
            this.HotDogPrice = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Total_in_Cafe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BeerCheckedBox = new System.Windows.Forms.CheckBox();
            this.HamburgerCheckedBox = new System.Windows.Forms.CheckBox();
            this.FreeCheckedBox = new System.Windows.Forms.CheckBox();
            this.CapucinoCheckedBox = new System.Windows.Forms.CheckBox();
            this.HotDogCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // OilsTypesCombo
            // 
            this.OilsTypesCombo.FormattingEnabled = true;
            this.OilsTypesCombo.Location = new System.Drawing.Point(11, 63);
            this.OilsTypesCombo.Name = "OilsTypesCombo";
            this.OilsTypesCombo.Size = new System.Drawing.Size(155, 28);
            this.OilsTypesCombo.TabIndex = 0;
            this.OilsTypesCombo.SelectedIndexChanged += new System.EventHandler(this.OilsTypesCombo_SelectedIndexChanged);
            // 
            // Priceelbl
            // 
            this.Priceelbl.AutoSize = true;
            this.Priceelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Priceelbl.Location = new System.Drawing.Point(110, 105);
            this.Priceelbl.Name = "Priceelbl";
            this.Priceelbl.Size = new System.Drawing.Size(0, 25);
            this.Priceelbl.TabIndex = 1;
            // 
            // OilLbl
            // 
            this.OilLbl.AutoSize = true;
            this.OilLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OilLbl.Location = new System.Drawing.Point(11, 35);
            this.OilLbl.Name = "OilLbl";
            this.OilLbl.Size = new System.Drawing.Size(38, 25);
            this.OilLbl.TabIndex = 2;
            this.OilLbl.Text = "Oil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price    -";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 28);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Volume";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(6, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 28);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Total";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalTxtbox);
            this.groupBox1.Controls.Add(this.PriceTxtbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(11, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 120);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // totalTxtbox
            // 
            this.totalTxtbox.Location = new System.Drawing.Point(149, 71);
            this.totalTxtbox.Mask = "00000";
            this.totalTxtbox.Name = "totalTxtbox";
            this.totalTxtbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalTxtbox.Size = new System.Drawing.Size(67, 26);
            this.totalTxtbox.TabIndex = 11;
            this.totalTxtbox.ValidatingType = typeof(int);
           // this.totalTxtbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.totalTxtbox_MaskInputRejected);
            this.totalTxtbox.TextChanged += new System.EventHandler(this.totalTxtbox_TextChanged);
            // 
            // PriceTxtbox
            // 
            this.PriceTxtbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PriceTxtbox.Location = new System.Drawing.Point(149, 38);
            this.PriceTxtbox.Mask = "0000000";
            this.PriceTxtbox.Name = "PriceTxtbox";
            this.PriceTxtbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PriceTxtbox.Size = new System.Drawing.Size(67, 26);
            this.PriceTxtbox.TabIndex = 10;
            this.PriceTxtbox.TextChanged += new System.EventHandler(this.PriceTxtbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(222, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "L";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "AZN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AZN);
            this.groupBox2.Controls.Add(this.TotalPriceLib);
            this.groupBox2.Location = new System.Drawing.Point(11, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 112);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total price before pay";
            // 
            // AZN
            // 
            this.AZN.AutoSize = true;
            this.AZN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AZN.Location = new System.Drawing.Point(181, 77);
            this.AZN.Name = "AZN";
            this.AZN.Size = new System.Drawing.Size(37, 18);
            this.AZN.TabIndex = 10;
            this.AZN.Text = "AZN";
            // 
            // TotalPriceLib
            // 
            this.TotalPriceLib.AutoSize = true;
            this.TotalPriceLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLib.Location = new System.Drawing.Point(84, 35);
            this.TotalPriceLib.Name = "TotalPriceLib";
            this.TotalPriceLib.Size = new System.Drawing.Size(91, 42);
            this.TotalPriceLib.TabIndex = 9;
            this.TotalPriceLib.Text = "0.00";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(108, 105);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(58, 29);
            this.PriceLbl.TabIndex = 9;
            this.PriceLbl.Text = "0.00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(18, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(615, 124);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(556, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 24);
            this.label15.TabIndex = 14;
            this.label15.Text = "AZN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(363, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 55);
            this.label14.TabIndex = 13;
            this.label14.Text = "0.00";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(160, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BestOil.Properties.Resources.Vollet;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.OilsTypesCombo);
            this.groupBox4.Controls.Add(this.PriceLbl);
            this.groupBox4.Controls.Add(this.Priceelbl);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.OilLbl);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(18, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 437);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gas station";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.HamburgerMaskedBox);
            this.groupBox5.Controls.Add(this.FreeMaskedBox);
            this.groupBox5.Controls.Add(this.BeerMaskedBox);
            this.groupBox5.Controls.Add(this.CapucinoMaskedBox);
            this.groupBox5.Controls.Add(this.HotDogMaskedBox);
            this.groupBox5.Controls.Add(this.BeerPrice);
            this.groupBox5.Controls.Add(this.HamburgerPrice);
            this.groupBox5.Controls.Add(this.FreePrice);
            this.groupBox5.Controls.Add(this.CapucinoPrice);
            this.groupBox5.Controls.Add(this.HotDogPrice);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.BeerCheckedBox);
            this.groupBox5.Controls.Add(this.HamburgerCheckedBox);
            this.groupBox5.Controls.Add(this.FreeCheckedBox);
            this.groupBox5.Controls.Add(this.CapucinoCheckedBox);
            this.groupBox5.Controls.Add(this.HotDogCheckBox);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(351, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(292, 437);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mini cafe";
            // 
            // HamburgerMaskedBox
            // 
            this.HamburgerMaskedBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.HamburgerMaskedBox.Location = new System.Drawing.Point(227, 169);
            this.HamburgerMaskedBox.Mask = "0000000";
            this.HamburgerMaskedBox.Name = "HamburgerMaskedBox";
            this.HamburgerMaskedBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HamburgerMaskedBox.Size = new System.Drawing.Size(59, 26);
            this.HamburgerMaskedBox.TabIndex = 23;
            // 
            // FreeMaskedBox
            // 
            this.FreeMaskedBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.FreeMaskedBox.Location = new System.Drawing.Point(227, 132);
            this.FreeMaskedBox.Mask = "0000000";
            this.FreeMaskedBox.Name = "FreeMaskedBox";
            this.FreeMaskedBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FreeMaskedBox.Size = new System.Drawing.Size(59, 26);
            this.FreeMaskedBox.TabIndex = 22;
            // 
            // BeerMaskedBox
            // 
            this.BeerMaskedBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BeerMaskedBox.Location = new System.Drawing.Point(227, 205);
            this.BeerMaskedBox.Mask = "0000000";
            this.BeerMaskedBox.Name = "BeerMaskedBox";
            this.BeerMaskedBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BeerMaskedBox.Size = new System.Drawing.Size(59, 26);
            this.BeerMaskedBox.TabIndex = 21;
            // 
            // CapucinoMaskedBox
            // 
            this.CapucinoMaskedBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CapucinoMaskedBox.Location = new System.Drawing.Point(227, 99);
            this.CapucinoMaskedBox.Mask = "0000000";
            this.CapucinoMaskedBox.Name = "CapucinoMaskedBox";
            this.CapucinoMaskedBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CapucinoMaskedBox.Size = new System.Drawing.Size(59, 26);
            this.CapucinoMaskedBox.TabIndex = 20;
            // 
            // HotDogMaskedBox
            // 
            this.HotDogMaskedBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.HotDogMaskedBox.Location = new System.Drawing.Point(227, 63);
            this.HotDogMaskedBox.Mask = "00000";
            this.HotDogMaskedBox.Name = "HotDogMaskedBox";
            this.HotDogMaskedBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HotDogMaskedBox.Size = new System.Drawing.Size(59, 26);
            this.HotDogMaskedBox.TabIndex = 19;
            this.HotDogMaskedBox.TextChanged += new System.EventHandler(this.HotDogMaskedBox_TextChanged);
            // 
            // BeerPrice
            // 
            this.BeerPrice.AutoSize = true;
            this.BeerPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeerPrice.Location = new System.Drawing.Point(133, 213);
            this.BeerPrice.Name = "BeerPrice";
            this.BeerPrice.Size = new System.Drawing.Size(36, 18);
            this.BeerPrice.TabIndex = 18;
            this.BeerPrice.Text = "9.99";
            // 
            // HamburgerPrice
            // 
            this.HamburgerPrice.AutoSize = true;
            this.HamburgerPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HamburgerPrice.Location = new System.Drawing.Point(133, 177);
            this.HamburgerPrice.Name = "HamburgerPrice";
            this.HamburgerPrice.Size = new System.Drawing.Size(36, 18);
            this.HamburgerPrice.TabIndex = 17;
            this.HamburgerPrice.Text = "8.90";
            // 
            // FreePrice
            // 
            this.FreePrice.AutoSize = true;
            this.FreePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreePrice.Location = new System.Drawing.Point(133, 136);
            this.FreePrice.Name = "FreePrice";
            this.FreePrice.Size = new System.Drawing.Size(36, 18);
            this.FreePrice.TabIndex = 16;
            this.FreePrice.Text = "7.15";
            // 
            // CapucinoPrice
            // 
            this.CapucinoPrice.AutoSize = true;
            this.CapucinoPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapucinoPrice.Location = new System.Drawing.Point(133, 99);
            this.CapucinoPrice.Name = "CapucinoPrice";
            this.CapucinoPrice.Size = new System.Drawing.Size(36, 18);
            this.CapucinoPrice.TabIndex = 15;
            this.CapucinoPrice.Text = "6.20";
            // 
            // HotDogPrice
            // 
            this.HotDogPrice.AutoSize = true;
            this.HotDogPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotDogPrice.Location = new System.Drawing.Point(133, 67);
            this.HotDogPrice.Name = "HotDogPrice";
            this.HotDogPrice.Size = new System.Drawing.Size(36, 18);
            this.HotDogPrice.TabIndex = 14;
            this.HotDogPrice.Text = "4.00";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.Total_in_Cafe);
            this.groupBox6.Location = new System.Drawing.Point(11, 294);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(272, 137);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Total price before pay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "AZN";
            // 
            // Total_in_Cafe
            // 
            this.Total_in_Cafe.AutoSize = true;
            this.Total_in_Cafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_in_Cafe.Location = new System.Drawing.Point(84, 35);
            this.Total_in_Cafe.Name = "Total_in_Cafe";
            this.Total_in_Cafe.Size = new System.Drawing.Size(91, 42);
            this.Total_in_Cafe.TabIndex = 9;
            this.Total_in_Cafe.Text = "0.00";
            this.Total_in_Cafe.TextChanged += new System.EventHandler(this.Total_in_Cafe_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // BeerCheckedBox
            // 
            this.BeerCheckedBox.AutoSize = true;
            this.BeerCheckedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeerCheckedBox.Location = new System.Drawing.Point(6, 213);
            this.BeerCheckedBox.Name = "BeerCheckedBox";
            this.BeerCheckedBox.Size = new System.Drawing.Size(101, 20);
            this.BeerCheckedBox.TabIndex = 4;
            this.BeerCheckedBox.Text = "Beer + chips";
            this.BeerCheckedBox.UseVisualStyleBackColor = true;
            this.BeerCheckedBox.CheckedChanged += new System.EventHandler(this.BeerCheckedBox_CheckedChanged);
            // 
            // HamburgerCheckedBox
            // 
            this.HamburgerCheckedBox.AutoSize = true;
            this.HamburgerCheckedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HamburgerCheckedBox.Location = new System.Drawing.Point(6, 175);
            this.HamburgerCheckedBox.Name = "HamburgerCheckedBox";
            this.HamburgerCheckedBox.Size = new System.Drawing.Size(95, 20);
            this.HamburgerCheckedBox.TabIndex = 3;
            this.HamburgerCheckedBox.Text = "Hamburger";
            this.HamburgerCheckedBox.UseVisualStyleBackColor = true;
            this.HamburgerCheckedBox.CheckedChanged += new System.EventHandler(this.HamburgerCheckedBox_CheckedChanged);
            // 
            // FreeCheckedBox
            // 
            this.FreeCheckedBox.AutoSize = true;
            this.FreeCheckedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreeCheckedBox.Location = new System.Drawing.Point(6, 137);
            this.FreeCheckedBox.Name = "FreeCheckedBox";
            this.FreeCheckedBox.Size = new System.Drawing.Size(55, 20);
            this.FreeCheckedBox.TabIndex = 2;
            this.FreeCheckedBox.Text = "Free";
            this.FreeCheckedBox.UseVisualStyleBackColor = true;
            this.FreeCheckedBox.CheckedChanged += new System.EventHandler(this.FreeCheckedBox_CheckedChanged);
            // 
            // CapucinoCheckedBox
            // 
            this.CapucinoCheckedBox.AutoSize = true;
            this.CapucinoCheckedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapucinoCheckedBox.Location = new System.Drawing.Point(6, 100);
            this.CapucinoCheckedBox.Name = "CapucinoCheckedBox";
            this.CapucinoCheckedBox.Size = new System.Drawing.Size(92, 20);
            this.CapucinoCheckedBox.TabIndex = 1;
            this.CapucinoCheckedBox.Text = "Capucinoo";
            this.CapucinoCheckedBox.UseVisualStyleBackColor = true;
            this.CapucinoCheckedBox.CheckedChanged += new System.EventHandler(this.CapucinoCheckedBox_CheckedChanged);
            // 
            // HotDogCheckBox
            // 
            this.HotDogCheckBox.AutoSize = true;
            this.HotDogCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotDogCheckBox.Location = new System.Drawing.Point(6, 65);
            this.HotDogCheckBox.Name = "HotDogCheckBox";
            this.HotDogCheckBox.Size = new System.Drawing.Size(75, 20);
            this.HotDogCheckBox.TabIndex = 0;
            this.HotDogCheckBox.Text = "Hot dog";
            this.HotDogCheckBox.UseVisualStyleBackColor = true;
            this.HotDogCheckBox.CheckedChanged += new System.EventHandler(this.HotDogCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(656, 621);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox OilsTypesCombo;
        private System.Windows.Forms.Label Priceelbl;
        private System.Windows.Forms.Label OilLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label AZN;
        private System.Windows.Forms.Label TotalPriceLib;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.MaskedTextBox totalTxtbox;
        private System.Windows.Forms.MaskedTextBox PriceTxtbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Total_in_Cafe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox BeerCheckedBox;
        private System.Windows.Forms.CheckBox HamburgerCheckedBox;
        private System.Windows.Forms.CheckBox FreeCheckedBox;
        private System.Windows.Forms.CheckBox CapucinoCheckedBox;
        private System.Windows.Forms.CheckBox HotDogCheckBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label BeerPrice;
        private System.Windows.Forms.Label HamburgerPrice;
        private System.Windows.Forms.Label FreePrice;
        private System.Windows.Forms.Label CapucinoPrice;
        private System.Windows.Forms.Label HotDogPrice;
        private System.Windows.Forms.MaskedTextBox HamburgerMaskedBox;
        private System.Windows.Forms.MaskedTextBox FreeMaskedBox;
        private System.Windows.Forms.MaskedTextBox BeerMaskedBox;
        private System.Windows.Forms.MaskedTextBox CapucinoMaskedBox;
        private System.Windows.Forms.MaskedTextBox HotDogMaskedBox;
    }
}

