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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClientName.Location = new System.Drawing.Point(12, 9);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(123, 25);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "Ім\'я клієнта";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(12, 39);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(153, 25);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Відіграно годин";
            // 
            // lblTotalZones
            // 
            this.lblTotalZones.AutoSize = true;
            this.lblTotalZones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalZones.Location = new System.Drawing.Point(12, 72);
            this.lblTotalZones.Name = "lblTotalZones";
            this.lblTotalZones.Size = new System.Drawing.Size(162, 25);
            this.lblTotalZones.TabIndex = 2;
            this.lblTotalZones.Text = "Кількість людей";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmountDue.Location = new System.Drawing.Point(12, 107);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(213, 25);
            this.lblAmountDue.TabIndex = 3;
            this.lblAmountDue.Text = "Розрахована вартість";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAmountPaid.Location = new System.Drawing.Point(12, 149);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(100, 30);
            this.txtAmountPaid.TabIndex = 4;
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtComment.Location = new System.Drawing.Point(12, 196);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(399, 60);
            this.txtComment.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(256, 274);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 46);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Отримано коштів";
            // 
            // CalculateForm
            // 
            this.ClientSize = new System.Drawing.Size(423, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.lblTotalZones);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblClientName);
            this.Name = "CalculateForm";
            this.Text = "Оплата сеансу";
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
        private System.Windows.Forms.Label label1;
    }
    }
