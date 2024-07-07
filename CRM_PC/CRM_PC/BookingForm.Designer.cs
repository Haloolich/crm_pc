namespace CRM_PC
{
    partial class BookingForm
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
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownZones = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(82, 62);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(100, 22);
            this.txtClientName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter number people";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Start session";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "End session";
            // 
            // numericUpDownZones
            // 
            this.numericUpDownZones.Location = new System.Drawing.Point(82, 102);
            this.numericUpDownZones.Name = "numericUpDownZones";
            this.numericUpDownZones.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownZones.TabIndex = 13;
            // 
            // numericUpDownStart
            // 
            this.numericUpDownStart.Location = new System.Drawing.Point(82, 161);
            this.numericUpDownStart.Name = "numericUpDownStart";
            this.numericUpDownStart.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownStart.TabIndex = 14;
            // 
            // numericUpDownEnd
            // 
            this.numericUpDownEnd.Location = new System.Drawing.Point(82, 199);
            this.numericUpDownEnd.Name = "numericUpDownEnd";
            this.numericUpDownEnd.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownEnd.TabIndex = 15;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownEnd);
            this.Controls.Add(this.numericUpDownStart);
            this.Controls.Add(this.numericUpDownZones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtClientName);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownZones;
        private System.Windows.Forms.NumericUpDown numericUpDownStart;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd;
    }
}