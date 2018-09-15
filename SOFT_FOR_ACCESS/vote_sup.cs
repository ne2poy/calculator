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
    
    public partial class vote_sup : Form
    {

        public vote_sup()
        {
            
            InitializeComponent();
            
        }

        private void vote_sup_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2sup_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2sup_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2sup_Запрос);
            
            

            this.dev2sup_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + Data.Value1 + "%'";
            textBox1.Text = Data.Value1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dev2sup_ЗапросDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(dev2sup_ЗапросDataGridView[12, i].Value) == "True")
                {
                    Data.zap1 = Convert.ToString(dev2sup_ЗапросDataGridView[1, i].Value);



                }


            }
            //void sup_add(double copy_m_proj, double copy_c_proj)
            //{
            //    double qty_m = 0;
            //    double qty_c = 0;
            //    //double copy_m_proj = 0;
            //    //double copy_c_proj = 0;
            //        //copy_m_proj = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(comboBox9.Text);    //объём_печати_моно_проект = объём_печати_моно * срок_контракта
            //        //copy_c_proj = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(comboBox9.Text);    //объём печати_цвет_проект = объём_печати_цвет * срок_контракта
            //    for (int i = 0; i < dev2sup_ЗапросDataGridView.RowCount - 1; i++)
            //    {
            //        if (Convert.ToString(dev2sup_ЗапросDataGridView[9, i].Value) == "True")                     //  если используется в MONO
            //        {
            //            qty_m = copy_m_proj / (Convert.ToDouble(dev2sup_ЗапросDataGridView[7, i].Value));       //штук(без_округл)_нужно_для_проекта_моно = объём_печати_моно_проект/ресурс_узла
            //            absolut_mono = absolut_mono + (Convert.ToDouble(dev2sup_ЗапросDataGridView[6, i].Value) / Convert.ToDouble(dev2sup_ЗапросDataGridView[7, i].Value)); //абсолют=цена_ресурса/ресурс_этого_ресурса
            //        }
            //        else
            //            qty_m = 0;

            //        if (Convert.ToString(dev2sup_ЗапросDataGridView[10, i].Value) == "True")                 //  если используется в COLOR
            //        {
            //            qty_c = copy_c_proj / (Convert.ToDouble(dev2sup_ЗапросDataGridView[7, i].Value));       ///штук(без_округл)_нужно_для_проекта_цвет = объём_печати_цвет_проект/ресурс_узла
            //            absolut_color = absolut_color + (Convert.ToDouble(dev2sup_ЗапросDataGridView[6, i].Value) / Convert.ToDouble(dev2sup_ЗапросDataGridView[7, i].Value)); //абсолют=цена_ресурса/ресурс_этого_ресурса
            //        }
            //        else
            //            qty_c = 0;

            //        this.database2_TESTDataSet.vibor1.Rows.Add(null, dev2sup_ЗапросDataGridView[3, i].Value, dev2sup_ЗапросDataGridView[4, i].Value, dev2sup_ЗапросDataGridView[6, i].Value, dev2sup_ЗапросDataGridView[11, i].Value, qty_m, qty_c, dev2sup_ЗапросDataGridView[5, i].Value, dev2sup_ЗапросDataGridView[8, i].Value, copy_m_proj, copy_c_proj);
            //        Notes.Add(new Note(Convert.ToString(dev2sup_ЗапросDataGridView[3, i].Value), Convert.ToString(dev2sup_ЗапросDataGridView[4, i].Value), Convert.ToString(dev2sup_ЗапросDataGridView[6, i].Value), Convert.ToString(dev2sup_ЗапросDataGridView[11, i].Value), Convert.ToString(qty_m), Convert.ToString(qty_c), Convert.ToString(dev2sup_ЗапросDataGridView[5, i].Value), Convert.ToString(dev2sup_ЗапросDataGridView[8, i].Value), Convert.ToString(copy_m_proj), Convert.ToString(copy_c_proj), null, null, null, null));

            //    }
           // }

        }








    }
}
