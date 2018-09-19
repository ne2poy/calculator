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
    public partial class import_LLC : Form
    {
        public import_LLC()
        {
            InitializeComponent();
        }

        private void import_LLC_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.LLC". При необходимости она может быть перемещена или удалена.
            this.lLCTableAdapter.Fill(this.database2_TESTDataSet.LLC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2LLC". При необходимости она может быть перемещена или удалена.
            this.dev2LLCTableAdapter.Fill(this.database2_TESTDataSet.Dev2LLC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2LLC_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2LLC_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2LLC_Запрос);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < (dataGridView1.RowCount - 1); i++)

                {

                    this.database2_TESTDataSet.LLC.Rows.Add(dataGridView1[0, i].Value, dataGridView1[1, i].Value, dataGridView1[2, i].Value, dataGridView1[3, i].Value, dataGridView1[4, i].Value, dataGridView1[5, i].Value, dataGridView1[6, i].Value, dataGridView1[7, i].Value, dataGridView1[8, i].Value, 1);     //, dataGridView1[6, i].Value, dataGridView1[7, i].Value, dataGridView1[8, i].Value, dataGridView1[9, i].Value
                    this.lLCTableAdapter.Update(this.database2_TESTDataSet.LLC);

                    this.database2_TESTDataSet.Dev2LLC.Rows.Add(null, dataGridView3[1, i].Value, dataGridView3[2, i].Value);      //, 0, 


                    this.dev2LLCTableAdapter.Update(this.database2_TESTDataSet.Dev2LLC);
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

        private void button2_Click(object sender, EventArgs e)
        {
            string str;
            int rCnt;
            int cCnt;

            OpenFileDialog opf1 = new OpenFileDialog();
            opf1.Filter = "Excel (*.XLSX)|*.XLSX";
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
                for (cCnt = 3; cCnt <= 11; cCnt++)
                {
                        str = (string)(ExcelRange.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range).Text;
                        dataGridView1.Rows[rCnt - 1].Cells[cCnt - 3].Value = str;
                }


                dataGridView3.Rows.Add(1);
                for (cCnt = 1; cCnt <= 3; cCnt++)
                {
                    str = (string)(ExcelRange.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range).Text;
                    dataGridView3.Rows[rCnt - 1].Cells[cCnt - 1].Value = str;
                }



            }
            ExcelWorkBook.Close(true, null, null);
            ExcelApp.Quit();

            releaseObject(ExcelWorkSheet);
            releaseObject(ExcelWorkBook);
            releaseObject(ExcelApp);
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




    }
}
