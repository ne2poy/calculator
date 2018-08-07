using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------
using Microsoft.Office.Interop.Excel;
using SD = System.Data;
using Excel = Microsoft.Office.Interop.Excel;


namespace SOFT_FOR_ACCESS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vivod". При необходимости она может быть перемещена или удалена.
            this.vivodTableAdapter.Fill(this.database2_TESTDataSet.vivod);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vibor". При необходимости она может быть перемещена или удалена.
            //this.viborTableAdapter.Fill(this.database2_TESTDataSet.vibor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Care_pack". При необходимости она может быть перемещена или удалена.
            this.care_packTableAdapter.Fill(this.database2_TESTDataSet.Care_pack);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < care_packDataGridView.RowCount - 1; i++)
            //{
            //    if (Convert.ToString(care_packDataGridView[6, i].Value) == "True")
            //    {
            //        this.database2_TESTDataSet.vibor.Rows.Add(null, care_packDataGridView[1, i].Value, care_packDataGridView[2, i].Value, care_packDataGridView[3, i].Value, care_packDataGridView[5, i].Value);
            //    }
            //}
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.viborTableAdapter.Update(this.database2_TESTDataSet.vibor);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            //Excel.Application exApp = new Excel.Application();
            //exApp.Workbooks.Add();
            //Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
            //workSheet.Cells[1, 1] = "ID";
            //workSheet.Cells[1, 2] = "Type";
            //workSheet.Cells[1, 3] = "Name";
            //workSheet.Cells[1, 4] = "Duration";
            //workSheet.Cells[1, 5] = "service1";
            //workSheet.Cells[1, 6] = "service2";
            //workSheet.Cells[1, 7] = "service3";
            //workSheet.Cells[1, 8] = "service4";
            //workSheet.Cells[1, 9] = "kol-vo_mono_for_proj";
            //workSheet.Cells[1, 10] = "kol-vo_color_for_proj";
            //workSheet.Cells[1, 11] = "cost_mono_for_proj";
            //workSheet.Cells[1, 12] = "cost_color_for_proj";
            //workSheet.Cells[1, 13] = "kol-vo_mono";
            //workSheet.Cells[1, 14] = "kol-vo_color";

            //int rowExcel = 2; //начать со второй строки.
            //for (int i = 0; i < care_packDataGridView.Rows.Count; i++)
            //{
            //    //заполняем строку
            //    workSheet.Cells[rowExcel, 1] = care_packDataGridView[0, i].Value;
            //    workSheet.Cells[rowExcel, 2] = care_packDataGridView[1, i].Value;
            //    workSheet.Cells[rowExcel, 3] = care_packDataGridView[2, i].Value;
            //    workSheet.Cells[rowExcel, 4] = care_packDataGridView[3, i].Value;
            //    workSheet.Cells[rowExcel, 5] = care_packDataGridView[4, i].Value;
            //    workSheet.Cells[rowExcel, 6] = care_packDataGridView[5, i].Value;
            //    workSheet.Cells[rowExcel, 7] = care_packDataGridView[6, i].Value;
            //    workSheet.Cells[rowExcel, 8] = care_packDataGridView[7, i].Value;
            //    workSheet.Cells[rowExcel, 9] = care_packDataGridView[8, i].Value;
            //    workSheet.Cells[rowExcel, 10] = care_packDataGridView[9, i].Value;
            //    workSheet.Cells[rowExcel, 11] = care_packDataGridView[10, i].Value;
            //    workSheet.Cells[rowExcel, 12] = care_packDataGridView[11, i].Value;
            //    workSheet.Cells[rowExcel, 13] = care_packDataGridView[12, i].Value;
            //    workSheet.Cells[rowExcel, 14] = care_packDataGridView[13, i].Value;
            //    workSheet.Cells[rowExcel, 15] = care_packDataGridView[14, i].Value;
            //    // workSheet.Cells[rowExcel, 6] = care_packDataGridView[6, i].Value;
            //    //workSheet.Cells[rowExcel, "C"] = care_packDataGridView[2, i].Value;
            //    ++rowExcel;
            //}


            //    string pathToXmlFile;
            //    pathToXmlFile = Environment.CurrentDirectory + "\\" + "MyFile.xls";
            //    workSheet.SaveAs(pathToXmlFile);

            //    exApp.Quit();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        

    }

}
