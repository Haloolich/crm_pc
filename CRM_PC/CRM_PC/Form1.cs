using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_PC
{
        public partial class Form1 : Form
        {
            private DataGridView dataGridView1;
            private Button btnSave;

            public Form1()
            {
                InitializeComponent();
                InitializeDataGridView();
                InitializeButton();
                LoadData();
                this.Resize += new EventHandler(Form1_Resize);
                this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            }

            private void InitializeDataGridView()
            {
                dataGridView1 = new DataGridView();
                dataGridView1.Location = new Point(10, 10);
                dataGridView1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 50);
                dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                // Ініціалізація колонок DataGridView
                dataGridView1.Columns.Add("Zone", "Zone");
                for (int i = 12; i <= 22; i++)
                {
                    dataGridView1.Columns.Add(i.ToString(), i + ":00");
                }

                // Додавання рядків з номерами зон
                for (int i = 1; i <= 5; i++)
                {
                    dataGridView1.Rows.Add("Zone " + i);
                }

                // Фіксована ширина першої колонки
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView1.Columns[0].Width = 100;

                // Налаштування автозаповнення колонок
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.Index != 0)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }

                // Додавання обробника події кліку на клітинці
                dataGridView1.CellMouseClick += DataGridView1_CellMouseClick;

                this.Controls.Add(dataGridView1);
            }

            private void InitializeButton()
            {
                btnSave = new Button();
                btnSave.Location = new Point(this.ClientSize.Width / 2 - 50, this.ClientSize.Height - 30);
                btnSave.Size = new Size(100, 30);
                btnSave.Anchor = AnchorStyles.Bottom;
                btnSave.Text = "Save";
                btnSave.Click += new EventHandler(btnSave_Click);

                this.Controls.Add(btnSave);
            }

            private void Form1_Resize(object sender, EventArgs e)
            {
                dataGridView1.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 50);
                btnSave.Location = new Point(this.ClientSize.Width / 2 - 50, this.ClientSize.Height - 30);
            }

            private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex > 0)
                {
                    var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    if (e.Button == MouseButtons.Left)
                    {
                        if (cell.Style.BackColor == Color.Blue || cell.Style.BackColor == Color.Green)
                        {
                            // Видалення сеансу
                            if (MessageBox.Show("Ви впевнені, що хочете видалити цей сеанс?", "Підтвердження видалення", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                // Знаходження клієнта для видалення всіх його сеансів
                                string clientName = cell.Value.ToString();
                                for (int i = 0; i < dataGridView1.Rows[e.RowIndex].Cells.Count; i++)
                                {
                                    if (dataGridView1.Rows[e.RowIndex].Cells[i].Value?.ToString() == clientName)
                                    {
                                        dataGridView1.Rows[e.RowIndex].Cells[i].Style.BackColor = Color.White;
                                        dataGridView1.Rows[e.RowIndex].Cells[i].Value = null;
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Додавання нового сеансу
                            BookingForm taskForm = new BookingForm();
                            if (taskForm.ShowDialog() == DialogResult.OK)
                            {
                                string clientName = taskForm.ClientName;
                                int startHour = taskForm.StartHour;
                                int endHour = taskForm.EndHour;
                                int zoneIndex = e.RowIndex;
                                int totalZones = taskForm.TotalZones;

                                for (int i = startHour; i < endHour; i++)
                                {
                                    for (int j = 0; j < totalZones; j++)
                                    {
                                        int columnIndex = i - 12 + 1;
                                        if (zoneIndex + j < dataGridView1.Rows.Count)
                                        {
                                            dataGridView1.Rows[zoneIndex + j].Cells[columnIndex].Style.BackColor = Color.Blue;
                                            dataGridView1.Rows[zoneIndex + j].Cells[columnIndex].Value = clientName;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        if (cell.Style.BackColor == Color.Blue || cell.Style.BackColor == Color.Green)
                        {
                            // Розрахунок клієнта
                            string clientName = cell.Value.ToString();
                            int startHour = e.ColumnIndex + 11;
                            int endHour = startHour + 1;
                            int totalZones = 1;

                            for (int i = e.ColumnIndex + 1; i < dataGridView1.Columns.Count; i++)
                            {
                                if (dataGridView1.Rows[e.RowIndex].Cells[i].Value?.ToString() == clientName)
                                {
                                    endHour++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            CalculateForm calculateForm = new CalculateForm(clientName, startHour, endHour, totalZones);
                            if (calculateForm.ShowDialog() == DialogResult.OK)
                            {
                                string comment = calculateForm.Comment;
                                decimal amountPaid = calculateForm.AmountPaid;

                                if (amountPaid >= 200)
                                {
                                    for (int i = startHour; i < endHour; i++)
                                    {
                                        int columnIndex = i - 12 + 1;
                                        dataGridView1.Rows[e.RowIndex].Cells[columnIndex].Style.BackColor = Color.Green;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                SaveData();
            }

            private void SaveData()
            {
                using (StreamWriter writer = new StreamWriter("data.txt"))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 1; i < row.Cells.Count; i++)
                        {
                            var cellValue = row.Cells[i].Value;
                            if (cellValue != null)
                            {
                                string colorName = row.Cells[i].Style.BackColor.Name;
                                writer.WriteLine($"{row.Index},{i},{cellValue},{colorName}");
                            }
                        }
                    }
                }
            }

            private void LoadData()
            {
                if (File.Exists("data.txt"))
                {
                    using (StreamReader reader = new StreamReader("data.txt"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var parts = line.Split(',');
                            if (parts.Length == 4)
                            {
                                int rowIndex = int.Parse(parts[0]);
                                int columnIndex = int.Parse(parts[1]);
                                string clientName = parts[2];
                                string colorName = parts[3];

                                dataGridView1.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.FromName(colorName);
                                dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = clientName;
                            }
                        }
                    }
                }
            }

            private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                SaveData();
            }
        }
    }
