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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PassengerLabel = new System.Windows.Forms.Label();
            this.PassengerList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.FromDestinationList = new System.Windows.Forms.ListBox();
            this.ToDestinationList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.ListBox();
            this.ArrivalLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DateLabel);
            this.tabPage1.Controls.Add(this.ArrivalLabel);
            this.tabPage1.Controls.Add(this.TimeBox);
            this.tabPage1.Controls.Add(this.ToLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ToDestinationList);
            this.tabPage1.Controls.Add(this.FromDestinationList);
            this.tabPage1.Controls.Add(this.PassengerLabel);
            this.tabPage1.Controls.Add(this.PassengerList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Booking";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // FromDestinationList
            // 
            this.FromDestinationList.FormattingEnabled = true;
            this.FromDestinationList.Location = new System.Drawing.Point(133, 20);
            this.FromDestinationList.Name = "FromDestinationList";
            this.FromDestinationList.Size = new System.Drawing.Size(120, 95);
            this.FromDestinationList.TabIndex = 2;
            this.FromDestinationList.SelectedIndexChanged += new System.EventHandler(this.FromDestinationList_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
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
            // TimeBox
            // 
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Location = new System.Drawing.Point(386, 20);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(120, 95);
            this.TimeBox.TabIndex = 6;
            this.TimeBox.SelectedIndexChanged += new System.EventHandler(this.TimeBox_SelectedIndexChanged);
            // 
            // ArrivalLabel
            // 
            this.ArrivalLabel.AutoSize = true;
            this.ArrivalLabel.Location = new System.Drawing.Point(513, 55);
            this.ArrivalLabel.Name = "ArrivalLabel";
            this.ArrivalLabel.Size = new System.Drawing.Size(68, 13);
            this.ArrivalLabel.TabIndex = 7;
            this.ArrivalLabel.Text = "Arrival Time: ";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(513, 38);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(83, 13);
            this.DateLabel.TabIndex = 8;
            this.DateLabel.Text = "Depature Date: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 346);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label PassengerLabel;
        private System.Windows.Forms.ListBox PassengerList;
        private System.Windows.Forms.ListBox ToDestinationList;
        private System.Windows.Forms.ListBox FromDestinationList;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TimeBox;
        private System.Windows.Forms.Label ArrivalLabel;
        private System.Windows.Forms.Label DateLabel;
    }
}

