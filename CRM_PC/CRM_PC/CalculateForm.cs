using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_PC
{
        public partial class CalculateForm : Form
        {
            public string ClientName { get; set; }
            public int StartHour { get; set; }
            public int EndHour { get; set; }
            public int TotalZones { get; set; }
            public string Comment { get; set; }
            public decimal AmountPaid { get; set; }

            public CalculateForm(string clientName, int startHour, int endHour, int totalZones)
            {
                InitializeComponent();
                ClientName = clientName;
                StartHour = startHour;
                EndHour = endHour;
                TotalZones = totalZones;

                lblClientName.Text = $"Client: {ClientName}";
                lblTime.Text = $"Time: {StartHour}:00 - {EndHour}:00";
                lblTotalZones.Text = $"Zones: {TotalZones}";
                lblAmountDue.Text = $"Amount Due: {(EndHour - StartHour) * TotalZones * 200}";

                Comment = string.Empty;
                AmountPaid = 0;
            }

            private void btnCalculate_Click(object sender, EventArgs e)
            {
                Comment = txtComment.Text;
                if (decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid))
                {
                    AmountPaid = amountPaid;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount.");
                }
            }
        }
    }

