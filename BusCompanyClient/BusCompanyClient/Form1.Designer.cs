namespace BusCompanyClient
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
            this.TabController = new System.Windows.Forms.TabControl();
            this.BookingPage = new System.Windows.Forms.TabPage();
            this.BookPackageButton = new System.Windows.Forms.Button();
            this.PackageList = new System.Windows.Forms.ListBox();
            this.BookedLabel = new System.Windows.Forms.Label();
            this.PackageButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.TimeBox = new System.Windows.Forms.ListBox();
            this.ToLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToDestinationList = new System.Windows.Forms.ListBox();
            this.FromDestinationList = new System.Windows.Forms.ListBox();
            this.PassengerLabel = new System.Windows.Forms.Label();
            this.PassengerList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.PIDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DestinationBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CurrencyBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LanguageBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddDestination = new System.Windows.Forms.Button();
            this.AddDestinationLabel = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TripToBox = new System.Windows.Forms.ListBox();
            this.TripFromBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.PackagepriceLabel = new System.Windows.Forms.Label();
            this.TabController.SuspendLayout();
            this.BookingPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.BookingPage);
            this.TabController.Controls.Add(this.tabPage2);
            this.TabController.Controls.Add(this.tabPage3);
            this.TabController.Controls.Add(this.tabPage1);
            this.TabController.Location = new System.Drawing.Point(1, 0);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(666, 347);
            this.TabController.TabIndex = 0;
            // 
            // BookingPage
            // 
            this.BookingPage.Controls.Add(this.PackagepriceLabel);
            this.BookingPage.Controls.Add(this.Pricelabel);
            this.BookingPage.Controls.Add(this.BookPackageButton);
            this.BookingPage.Controls.Add(this.PackageList);
            this.BookingPage.Controls.Add(this.BookedLabel);
            this.BookingPage.Controls.Add(this.PackageButton);
            this.BookingPage.Controls.Add(this.BookButton);
            this.BookingPage.Controls.Add(this.TimeBox);
            this.BookingPage.Controls.Add(this.ToLabel);
            this.BookingPage.Controls.Add(this.label1);
            this.BookingPage.Controls.Add(this.ToDestinationList);
            this.BookingPage.Controls.Add(this.FromDestinationList);
            this.BookingPage.Controls.Add(this.PassengerLabel);
            this.BookingPage.Controls.Add(this.PassengerList);
            this.BookingPage.Location = new System.Drawing.Point(4, 22);
            this.BookingPage.Name = "BookingPage";
            this.BookingPage.Padding = new System.Windows.Forms.Padding(3);
            this.BookingPage.Size = new System.Drawing.Size(658, 321);
            this.BookingPage.TabIndex = 0;
            this.BookingPage.Text = "Booking";
            this.BookingPage.UseVisualStyleBackColor = true;
            // 
            // BookPackageButton
            // 
            this.BookPackageButton.Location = new System.Drawing.Point(512, 49);
            this.BookPackageButton.Name = "BookPackageButton";
            this.BookPackageButton.Size = new System.Drawing.Size(98, 23);
            this.BookPackageButton.TabIndex = 13;
            this.BookPackageButton.Text = "Book Package";
            this.BookPackageButton.UseVisualStyleBackColor = true;
            this.BookPackageButton.Click += new System.EventHandler(this.BookPackageButton_Click);
            // 
            // PackageList
            // 
            this.PackageList.Enabled = false;
            this.PackageList.FormattingEnabled = true;
            this.PackageList.Location = new System.Drawing.Point(259, 164);
            this.PackageList.Name = "PackageList";
            this.PackageList.Size = new System.Drawing.Size(247, 121);
            this.PackageList.TabIndex = 12;
            this.PackageList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // BookedLabel
            // 
            this.BookedLabel.AutoSize = true;
            this.BookedLabel.Location = new System.Drawing.Point(11, 287);
            this.BookedLabel.Name = "BookedLabel";
            this.BookedLabel.Size = new System.Drawing.Size(121, 13);
            this.BookedLabel.TabIndex = 11;
            this.BookedLabel.Text = "You have booked a trip!";
            this.BookedLabel.Visible = false;
            // 
            // PackageButton
            // 
            this.PackageButton.Location = new System.Drawing.Point(512, 78);
            this.PackageButton.Name = "PackageButton";
            this.PackageButton.Size = new System.Drawing.Size(98, 23);
            this.PackageButton.TabIndex = 10;
            this.PackageButton.Text = "Add to Package";
            this.PackageButton.UseVisualStyleBackColor = true;
            this.PackageButton.Click += new System.EventHandler(this.PackageButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(512, 20);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(98, 23);
            this.BookButton.TabIndex = 9;
            this.BookButton.Text = "Book";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Location = new System.Drawing.Point(386, 20);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(120, 95);
            this.TimeBox.TabIndex = 6;
            this.TimeBox.SelectedIndexChanged += new System.EventHandler(this.TimeBox_SelectedIndexChanged);
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(256, 4);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(20, 13);
            this.ToLabel.TabIndex = 5;
            this.ToLabel.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // ToDestinationList
            // 
            this.ToDestinationList.FormattingEnabled = true;
            this.ToDestinationList.Location = new System.Drawing.Point(259, 20);
            this.ToDestinationList.Name = "ToDestinationList";
            this.ToDestinationList.Size = new System.Drawing.Size(120, 95);
            this.ToDestinationList.TabIndex = 3;
            this.ToDestinationList.SelectedIndexChanged += new System.EventHandler(this.ToDestinationList_SelectedIndexChanged);
            // 
            // FromDestinationList
            // 
            this.FromDestinationList.FormattingEnabled = true;
            this.FromDestinationList.Location = new System.Drawing.Point(133, 20);
            this.FromDestinationList.Name = "FromDestinationList";
            this.FromDestinationList.Size = new System.Drawing.Size(120, 95);
            this.FromDestinationList.TabIndex = 2;
            this.FromDestinationList.SelectedIndexChanged += new System.EventHandler(this.FromDestinationList_SelectedIndexChanged);
            // 
            // PassengerLabel
            // 
            this.PassengerLabel.AutoSize = true;
            this.PassengerLabel.Location = new System.Drawing.Point(8, 4);
            this.PassengerLabel.Name = "PassengerLabel";
            this.PassengerLabel.Size = new System.Drawing.Size(57, 13);
            this.PassengerLabel.TabIndex = 1;
            this.PassengerLabel.Text = "Passenger";
            // 
            // PassengerList
            // 
            this.PassengerList.FormattingEnabled = true;
            this.PassengerList.Location = new System.Drawing.Point(7, 20);
            this.PassengerList.Name = "PassengerList";
            this.PassengerList.Size = new System.Drawing.Size(120, 95);
            this.PassengerList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SignUpLabel);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.AdressBox);
            this.tabPage2.Controls.Add(this.PIDBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.NameBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(658, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sign Up";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Location = new System.Drawing.Point(11, 180);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(35, 13);
            this.SignUpLabel.TabIndex = 7;
            this.SignUpLabel.Text = "label5";
            this.SignUpLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personal-ID";
            // 
            // AdressBox
            // 
            this.AdressBox.Location = new System.Drawing.Point(220, 24);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(100, 20);
            this.AdressBox.TabIndex = 3;
            // 
            // PIDBox
            // 
            this.PIDBox.Location = new System.Drawing.Point(114, 24);
            this.PIDBox.Name = "PIDBox";
            this.PIDBox.Size = new System.Drawing.Size(100, 20);
            this.PIDBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(8, 24);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.AddDestinationLabel);
            this.tabPage3.Controls.Add(this.AddDestination);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.LanguageBox);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.CurrencyBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.CountryBox);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.DestinationBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(658, 321);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Destination";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DestinationBox
            // 
            this.DestinationBox.Location = new System.Drawing.Point(7, 29);
            this.DestinationBox.Name = "DestinationBox";
            this.DestinationBox.Size = new System.Drawing.Size(100, 20);
            this.DestinationBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Destination";
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(128, 29);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(100, 20);
            this.CountryBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Country";
            // 
            // CurrencyBox
            // 
            this.CurrencyBox.Location = new System.Drawing.Point(253, 29);
            this.CurrencyBox.Name = "CurrencyBox";
            this.CurrencyBox.Size = new System.Drawing.Size(100, 20);
            this.CurrencyBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Currency";
            // 
            // LanguageBox
            // 
            this.LanguageBox.Location = new System.Drawing.Point(378, 29);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.Size = new System.Drawing.Size(100, 20);
            this.LanguageBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Language";
            // 
            // AddDestination
            // 
            this.AddDestination.Location = new System.Drawing.Point(500, 26);
            this.AddDestination.Name = "AddDestination";
            this.AddDestination.Size = new System.Drawing.Size(104, 23);
            this.AddDestination.TabIndex = 8;
            this.AddDestination.Text = "Add Destination";
            this.AddDestination.UseVisualStyleBackColor = true;
            this.AddDestination.Click += new System.EventHandler(this.AddDestination_Click);
            // 
            // AddDestinationLabel
            // 
            this.AddDestinationLabel.AutoSize = true;
            this.AddDestinationLabel.Location = new System.Drawing.Point(7, 178);
            this.AddDestinationLabel.Name = "AddDestinationLabel";
            this.AddDestinationLabel.Size = new System.Drawing.Size(156, 13);
            this.AddDestinationLabel.TabIndex = 9;
            this.AddDestinationLabel.Text = "You need to fill in all the values ";
            this.AddDestinationLabel.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.TripFromBox);
            this.tabPage1.Controls.Add(this.TripToBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(658, 321);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Add trip";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TripToBox
            // 
            this.TripToBox.FormattingEnabled = true;
            this.TripToBox.Location = new System.Drawing.Point(45, 33);
            this.TripToBox.Name = "TripToBox";
            this.TripToBox.Size = new System.Drawing.Size(120, 95);
            this.TripToBox.TabIndex = 0;
            // 
            // TripFromBox
            // 
            this.TripFromBox.FormattingEnabled = true;
            this.TripFromBox.Location = new System.Drawing.Point(201, 33);
            this.TripFromBox.Name = "TripFromBox";
            this.TripFromBox.Size = new System.Drawing.Size(120, 95);
            this.TripFromBox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(435, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "label10";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(435, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(435, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "label11";
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Location = new System.Drawing.Point(11, 134);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(46, 13);
            this.Pricelabel.TabIndex = 14;
            this.Pricelabel.Text = "Price : 0";
            // 
            // PackagepriceLabel
            // 
            this.PackagepriceLabel.AutoSize = true;
            this.PackagepriceLabel.Location = new System.Drawing.Point(513, 271);
            this.PackagepriceLabel.Name = "PackagepriceLabel";
            this.PackagepriceLabel.Size = new System.Drawing.Size(94, 13);
            this.PackagepriceLabel.TabIndex = 15;
            this.PackagepriceLabel.Text = "Package price : 0 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 346);
            this.Controls.Add(this.TabController);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabController.ResumeLayout(false);
            this.BookingPage.ResumeLayout(false);
            this.BookingPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabController;
        private System.Windows.Forms.TabPage BookingPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label PassengerLabel;
        private System.Windows.Forms.ListBox PassengerList;
        private System.Windows.Forms.ListBox ToDestinationList;
        private System.Windows.Forms.ListBox FromDestinationList;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TimeBox;
        private System.Windows.Forms.Button PackageButton;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Label BookedLabel;
        private System.Windows.Forms.ListBox PackageList;
        private System.Windows.Forms.Button BookPackageButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.TextBox PIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Button AddDestination;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LanguageBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CurrencyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CountryBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DestinationBox;
        private System.Windows.Forms.Label AddDestinationLabel;
        private System.Windows.Forms.Label PackagepriceLabel;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox TripFromBox;
        private System.Windows.Forms.ListBox TripToBox;
    }
}

