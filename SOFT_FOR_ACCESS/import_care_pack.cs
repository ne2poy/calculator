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
    public partial class import_care_pack : Form
    {
        public import_care_pack()
        {
            InitializeComponent();
        }

        private void care_packBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.care_packBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);

        }

        private void import_care_pack_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2care". При необходимости она может быть перемещена или удалена.
            this.dev2careTableAdapter.Fill(this.database2_TESTDataSet.Dev2care);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Care_pack". При необходимости она может быть перемещена или удалена.
            this.care_packTableAdapter.Fill(this.database2_TESTDataSet.Care_pack);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            string str;
            int rCnt;
            int cCnt;

            OpenFileDialog opf1 = new OpenFileDialog();
            opf1.Filter = "Файл Excel|*.XLSX;*.XLS";
            opf1.ShowDialog();
            System.Data.DataTable tb1 = new System.Data.DataTable();
            string filename = opf1.FileName;

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
                    this.database2_TESTDataSet.Care_pack.Rows.Add(dataGridView1[0, i].Value, dataGridView1[1, i].Value, dataGridView1[2, i].Value, dataGridView1[3, i].Value, dataGridView1[4, i].Value, 1);
                    this.care_packTableAdapter.Update(this.database2_TESTDataSet.Care_pack);
                }

                for (int i = 0; i < (dataGridView2.RowCount - 1); i++)
                {
                    this.database2_TESTDataSet.Dev2care.Rows.Add(null, dataGridView2[1, i].Value, dataGridView2[2, i].Value);
                    this.dev2careTableAdapter.Update(this.database2_TESTDataSet.Dev2care);
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
