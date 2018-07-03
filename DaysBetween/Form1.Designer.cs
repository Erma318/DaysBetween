namespace DaysBetween
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.resShow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstPick = new System.Windows.Forms.DateTimePicker();
            this.secondPick = new System.Windows.Forms.DateTimePicker();
            this.calculate = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days Between:";
            // 
            // resShow
            // 
            this.resShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resShow.Location = new System.Drawing.Point(299, 55);
            this.resShow.Name = "resShow";
            this.resShow.Size = new System.Drawing.Size(91, 34);
            this.resShow.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "1st Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "2nd Date";
            // 
            // firstPick
            // 
            this.firstPick.Location = new System.Drawing.Point(208, 116);
            this.firstPick.Name = "firstPick";
            this.firstPick.Size = new System.Drawing.Size(281, 22);
            this.firstPick.TabIndex = 4;
            this.firstPick.ValueChanged += new System.EventHandler(this.firstPick_ValueChanged);
            // 
            // secondPick
            // 
            this.secondPick.Location = new System.Drawing.Point(208, 192);
            this.secondPick.Name = "secondPick";
            this.secondPick.Size = new System.Drawing.Size(281, 22);
            this.secondPick.TabIndex = 5;
            this.secondPick.ValueChanged += new System.EventHandler(this.secondPick_ValueChanged);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(99, 268);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(81, 23);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(333, 268);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 7;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 386);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.secondPick);
            this.Controls.Add(this.firstPick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resShow);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculate Day Numbers Between Two Days";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker firstPick;
        private System.Windows.Forms.DateTimePicker secondPick;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button reset;
    }
}

