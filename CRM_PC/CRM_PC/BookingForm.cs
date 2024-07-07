using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CRM_PC
{
        public partial class BookingForm : Form
        {
        public string ClientName { get; private set; }
        public int StartHour { get; private set; }
        public int EndHour { get; private set; }
        public int TotalZones { get; private set; }

        public BookingForm()
            {
                InitializeComponent();
            }
            private void btnSave_Click(object sender, EventArgs e)
            {
                ClientName = txtClientName.Text;
                StartHour = (int)numericUpDownStart.Value;
                EndHour = (int)numericUpDownEnd.Value;
                TotalZones = (int)numericUpDownZones.Value;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }


