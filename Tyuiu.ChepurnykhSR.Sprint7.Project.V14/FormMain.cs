using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Tyuiu.ChepurnykhSR.Sprint7.Project.V14.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint7.Project.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void buttonOpen_CSR_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_CSR.ShowDialog();
                openFilePath = openFileDialog_CSR.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridView_CSR.RowCount = rows + 1;
                dataGridView_CSR.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView_CSR.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridView_CSR.AutoResizeColumns();
                dataGridView_CSR.ScrollBars = ScrollBars.Both;
                buttonSave_CSR.Enabled = true;
                buttonAdd_CSR.Enabled = true;
                buttonDelete_CSR.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_CSR_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_CSR.FileName = ".csv";
                saveFileDialog_CSR.InitialDirectory = @":L";
                if (saveFileDialog_CSR.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialog_CSR.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridView_CSR.RowCount;
                    int columns = dataGridView_CSR.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridView_CSR.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(";");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_CSR_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_CSR.Rows.Add();
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_CSR_Click(object sender, EventArgs e)
        {
            if (dataGridView_CSR.RowCount != 0)
            {
                int valueDel = 0;
                var res = MessageBox.Show($"{"Удалить данную строку?"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) valueDel = 1;
                if (valueDel == 1)
                {
                    int del = dataGridView_CSR.CurrentCell.RowIndex;
                    dataGridView_CSR.Rows.Remove(dataGridView_CSR.Rows[del]);
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxBus_CSR_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueFilt = comboBoxBus_CSR.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента ComboBox
            if (!string.IsNullOrEmpty(valueFilt))
            {
                foreach (DataGridViewRow row in dataGridView_CSR.Rows)
                {
                    if (!row.IsNewRow) // проверка новая ли строка
                    {
                        if (row.Cells["Number_CSR"].Value != null && row.Cells["Number_CSR"].Value.ToString() == valueFilt)
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
        }
    }
}
