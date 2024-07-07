namespace CRM_PC
{
        partial class CalculateForm
        {
            private System.ComponentModel.IContainer components = null;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

        private void InitializeComponent()
        {
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTotalZones = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(12, 9);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(68, 13);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "Client Name";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 32);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time";
            // 
            // lblTotalZones
            // 
            this.lblTotalZones.AutoSize = true;
            this.lblTotalZones.Location = new System.Drawing.Point(12, 55);
            this.lblTotalZones.Name = "lblTotalZones";
            this.lblTotalZones.Size = new System.Drawing.Size(64, 13);
            this.lblTotalZones.TabIndex = 2;
            this.lblTotalZones.Text = "Total Zones";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(12, 78);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(67, 13);
            this.lblAmountDue.TabIndex = 3;
            this.lblAmountDue.Text = "Amount Due";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(12, 104);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(100, 20);
            this.txtAmountPaid.TabIndex = 4;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(12, 130);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(260, 60);
            this.txtComment.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(197, 196);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // CalculateForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.lblTotalZones);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblClientName);
            this.Name = "CalculateForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTotalZones;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnCalculate;
    }
    }
