using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFT_FOR_ACCESS
{
    public partial class import_acc : Form
    {
        public import_acc()
        {
            InitializeComponent();
        }

        private void accessoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accessoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);

        }

        private void import_acc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2acc". При необходимости она может быть перемещена или удалена.
            this.dev2accTableAdapter.Fill(this.database2_TESTDataSet.Dev2acc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Accessory". При необходимости она может быть перемещена или удалена.
            this.accessoryTableAdapter.Fill(this.database2_TESTDataSet.Accessory);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str;
                int rCnt;
                int cCnt;

                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Файл Excel|*.XLSX;*.XLS";
                opf.ShowDialog();
                System.Data.DataTable tb1 = new System.Data.DataTable();
                string filename = opf.FileName;

                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
                Microsoft.Office.Interop.Excel.Range ExcelRange;

                ExcelWorkBook = ExcelApp.Workbooks.Open(filename, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

                ExcelRange = ExcelWorkSheet.UsedRange;
                for (rCnt = 1; rCnt <= ExcelRange.Rows.Count; rCnt++)
                {
                    dataGridView1.Rows.Add(1);
                    for (cCnt = 3; cCnt <= 7; cCnt++)
                    {
                        str = (string)(ExcelRange.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range).Text;
                        dataGridView1.Rows[rCnt - 1].Cells[cCnt - 3].Value = str;
                    }


                    dataGridView2.Rows.Add(1);
                    for (cCnt = 1; cCnt <= 3; cCnt++)
                    {
                        str = (string)(ExcelRange.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range).Text;
                        dataGridView2.Rows[rCnt - 1].Cells[cCnt - 1].Value = str;
                    }

                }
                ExcelWorkBook.Close(true, null, null);
                ExcelApp.Quit();

                releaseObject(ExcelWorkSheet);
                releaseObject(ExcelWorkBook);
                releaseObject(ExcelApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при считывании excel файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
                {
                    this.database2_TESTDataSet.Accessory.Rows.Add(dataGridView1[0, i].Value, dataGridView1[1, i].Value, dataGridView1[2, i].Value, dataGridView1[3, i].Value, dataGridView1[4, i].Value, 1);
                    this.accessoryTableAdapter.Update(this.database2_TESTDataSet.Accessory);
                }

                for (int i = 0; i < (dataGridView2.RowCount - 1); i++)
                {
                    this.database2_TESTDataSet.Dev2acc.Rows.Add(null, dataGridView2[1, i].Value, dataGridView2[2, i].Value);
                    this.dev2accTableAdapter.Update(this.database2_TESTDataSet.Dev2acc);
                }

                MessageBox.Show("Записи добавлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Validate();
                //this.printerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);
            }
            catch
            {
                MessageBox.Show("Не добавлено/отредактировано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
    }
}
