namespace Latihan_2_1
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
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.domain = new System.Windows.Forms.DomainUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // numeric
            // 
            this.numeric.Location = new System.Drawing.Point(46, 38);
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(120, 20);
            this.numeric.TabIndex = 10;
            this.numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric.ValueChanged += new System.EventHandler(this.numeric_ValueChanged_1);
            // 
            // domain
            // 
            this.domain.Items.Add("Januari");
            this.domain.Items.Add("Februari");
            this.domain.Items.Add("Maret");
            this.domain.Items.Add("April");
            this.domain.Items.Add("Mei");
            this.domain.Items.Add("Juni");
            this.domain.Items.Add("Juli");
            this.domain.Items.Add("Agustus");
            this.domain.Items.Add("September");
            this.domain.Items.Add("Oktober");
            this.domain.Items.Add("November");
            this.domain.Items.Add("Desember");
            this.domain.Location = new System.Drawing.Point(185, 38);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(120, 20);
            this.domain.TabIndex = 11;
            this.domain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.domain.SelectedItemChanged += new System.EventHandler(this.domain_SelectedItemChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(46, 108);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ScrollChange = 4;
            this.monthCalendar1.TabIndex = 12;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 448);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.domain);
            this.Controls.Add(this.numeric);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numeric;
        private System.Windows.Forms.DomainUpDown domain;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

