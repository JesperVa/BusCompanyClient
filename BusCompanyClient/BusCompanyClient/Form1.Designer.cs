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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PIDBox = new System.Windows.Forms.TextBox();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.TabController.SuspendLayout();
            this.BookingPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.BookingPage);
            this.TabController.Controls.Add(this.tabPage2);
            this.TabController.Controls.Add(this.tabPage3);
            this.TabController.Location = new System.Drawing.Point(1, 0);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(666, 347);
            this.TabController.TabIndex = 0;
            // 
            // BookingPage
            // 
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
            //this.BookingPage.Click += new System.EventHandler(this.BookingPage_Click);
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(658, 321);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add Destination";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(8, 24);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 0;
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
            // PIDBox
            // 
            this.PIDBox.Location = new System.Drawing.Point(114, 24);
            this.PIDBox.Name = "PIDBox";
            this.PIDBox.Size = new System.Drawing.Size(100, 20);
            this.PIDBox.TabIndex = 2;
            // 
            // AdressBox
            // 
            this.AdressBox.Location = new System.Drawing.Point(220, 24);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(100, 20);
            this.AdressBox.TabIndex = 3;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adress";
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
    }
}

