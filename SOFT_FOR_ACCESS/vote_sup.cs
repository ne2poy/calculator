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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vibor1". При необходимости она может быть перемещена или удалена.
            this.vibor1TableAdapter.Fill(this.database2_TESTDataSet.vibor1);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2sup_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2sup_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2sup_Запрос);

            this.dev2sup_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + Data.Value1 + "%'";
            textBox1.Text = Data.Value1;
            textBox2.Text = Data.Value2;
        }

        void sup_add2(double copy_m_proj, double copy_c_proj)
        {
            double qty_m = 0;
            double qty_c = 0;
            for (int i = 0; i <= dev2sup_ЗапросDataGridView.RowCount - 1; i++)   
            {
                if (Convert.ToString(dev2sup_ЗапросDataGridView[14, i].Value) == "True")
                {

                    if (Convert.ToString(dev2sup_ЗапросDataGridView[9, i].Value) == "True")                     //  если используется в MONO
                    {
                        qty_m = copy_m_proj / (Convert.ToDouble(dev2sup_ЗапросDataGridView[7, i].Value));       //штук(без_округл)_нужно_для_проекта_моно = объём_печати_моно_проект/ресурс_узла
                                                                                                                //absolut_mono = absolut_mono + (Convert.ToDouble(dev2sup_ЗапросDataGridView[6, i].Value) / Convert.ToDouble(dev2sup_ЗапросDataGridView[7, i].Value)); //абсолют=цена_ресурса/ресурс_этого_ресурса
                    }
                    else
                        qty_m = 0;

                    if (Convert.ToString(dev2sup_ЗапросDataGridView[10, i].Value) == "True")                 //  если используется в COLOR
                    {
                        qty_c = copy_c_proj / (Convert.ToDouble(dev2sup_ЗапросDataGridView[7, i].Value));       ///штук(без_округл)_нужно_для_проекта_цвет = объём_печати_цвет_проект/ресурс_узла
                    //absolut_color = absolut_color + (Convert.ToDouble(dev2sup_ЗапросDataGridView[6, i].Value) / Convert.ToDouble(dev2sup_ЗапросDataGridView[7, i].Value)); //абсолют=цена_ресурса/ресурс_этого_ресурса
                    }
                    else
                        qty_c = 0;

                    this.database2_TESTDataSet.vibor1.Rows.Add(null, dev2sup_ЗапросDataGridView[3, i].Value, dev2sup_ЗапросDataGridView[5, i].Value, dev2sup_ЗапросDataGridView[7, i].Value, dev2sup_ЗапросDataGridView[12, i].Value, qty_m, qty_c, dev2sup_ЗапросDataGridView[6, i].Value, dev2sup_ЗапросDataGridView[9, i].Value, copy_m_proj, copy_c_proj);
                    //Notes.Add(new Note(Convert.ToString(dev2sup_ЗапросDataGridView[3, i].Value), Convert.ToString(dev2sup_ЗапросDataGridView[4, i].Value), Convert.ToString(dev2sup_ЗапросDataGridView[6, i].Value), Convert.ToString(dev2sup_ЗапросDataGridView[11, i].Value), Convert.ToString(qty_m), Convert.ToString(qty_c), Convert.ToString(dev2sup_ЗапросDataGridView[5, i].Value), Convert.ToString(dev2sup_ЗапросDataGridView[8, i].Value), Convert.ToString(copy_m_proj), Convert.ToString(copy_c_proj), null, null, null, null));
                }
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            double C = 0;
            double M = 0;
            double Y = 0;
            double B = 0;

            string[] CMYB;
            int check = 0;
            for (int i = 0; i <= dev2sup_ЗапросDataGridView.RowCount - 1; i++)  
            {
                if (Convert.ToString(dev2sup_ЗапросDataGridView[14, i].Value) == "True")
                {
                    if (Convert.ToString(dev2sup_ЗапросDataGridView[13, i].Value) == "C") C++;
                    if (Convert.ToString(dev2sup_ЗапросDataGridView[13, i].Value) == "M") M++;
                    if (Convert.ToString(dev2sup_ЗапросDataGridView[13, i].Value) == "Y") Y++;
                    if (Convert.ToString(dev2sup_ЗапросDataGridView[13, i].Value) == "B") B++;                   
                    check++;                  
                }
                               
            }

            if (Convert.ToString(check) == Data.Value3)
            {
                if ((Data.Value3 == "4" && C == 1 && M == 1 && Y == 1 && B == 1) || (Data.Value3 == "1" && C == 0 && M == 0 && Y == 0 && B == 1))
                {
                    sup_add2(Data.copy_m_proj, Data.copy_c_proj);
                    this.vibor1TableAdapter.Update(this.database2_TESTDataSet.vibor1);
                    this.vibor1TableAdapter.Fill(this.database2_TESTDataSet.vibor1);
                    this.DialogResult = DialogResult.OK;
                    //this.Close();
                }
                else
                    MessageBox.Show("Выберите правильно supply!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            else
                MessageBox.Show("Выберите supply!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);



        }

    }
}
