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
            this.FromBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DestinationBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FromListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FromBox
            // 
            this.FromBox.Location = new System.Drawing.Point(12, 28);
            this.FromBox.Name = "FromBox";
            this.FromBox.Size = new System.Drawing.Size(132, 22);
            this.FromBox.TabIndex = 0;
            this.FromBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DestinationBox
            // 
            this.DestinationBox.Location = new System.Drawing.Point(173, 28);
            this.DestinationBox.Name = "DestinationBox";
            this.DestinationBox.Size = new System.Drawing.Size(130, 22);
            this.DestinationBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // FromListBox
            // 
            this.FromListBox.FormattingEnabled = true;
            this.FromListBox.ItemHeight = 16;
            this.FromListBox.Location = new System.Drawing.Point(367, 65);
            this.FromListBox.Name = "FromListBox";
            this.FromListBox.Size = new System.Drawing.Size(120, 84);
            this.FromListBox.TabIndex = 4;
            this.FromListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 426);
            this.Controls.Add(this.FromListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DestinationBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FromBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FromBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DestinationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox FromListBox;
    }
}

