using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//------------------------------------
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using Access = Microsoft.Office.Interop.Access;
//----------------------
using Microsoft.Office.Interop.Excel;
using SD = System.Data;
using Excel = Microsoft.Office.Interop.Excel;

//------------------------
using ClosedXML.Excel;


namespace SOFT_FOR_ACCESS
{
    



    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void printerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.printerBindingSource.EndEdit();

        }
        string model = null;
        double kol_vo = 0;
        double v_pech_mono = 0;
        double v_pech_color = 0;
        double arenda = 0;
        double copy_mono = 0;
        double copy_color = 0;
        double zatrati_pech_p = 0;
        double zatrati_arenda_p = 0;
        double all_zatrati = 0;
        double absolut_mono = 0;
        double absolut_color = 0;



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.DurForCRF". При необходимости она может быть перемещена или удалена.
            this.durForCRFTableAdapter.Fill(this.database2_TESTDataSet.DurForCRF);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.proc_Запрос". При необходимости она может быть перемещена или удалена.
            this.proc_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.proc_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vivod_itog_2". При необходимости она может быть перемещена или удалена.
            this.vivod_itog_2TableAdapter.Fill(this.database2_TESTDataSet.vivod_itog_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vivod_itog". При необходимости она может быть перемещена или удалена.
            this.vivod_itogTableAdapter.Fill(this.database2_TESTDataSet.vivod_itog);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vivod". При необходимости она может быть перемещена или удалена.
            this.vivodTableAdapter.Fill(this.database2_TESTDataSet.vivod);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2soft_serv_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2soft_serv_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2soft_serv_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2soft_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2soft_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2soft_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Trash". При необходимости она может быть перемещена или удалена.
            this.trashTableAdapter.Fill(this.database2_TESTDataSet.Trash);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2acc_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2acc_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2acc_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2sup_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2sup_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2sup_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2LLC_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2LLC_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2LLC_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2care_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2care_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2care_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vibor1". При необходимости она может быть перемещена или удалена.
            this.vibor1TableAdapter.Fill(this.database2_TESTDataSet.vibor1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Printer". При необходимости она может быть перемещена или удалена.
            this.printerTableAdapter.Fill(this.database2_TESTDataSet.Printer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.proc". При необходимости она может быть перемещена или удалена.
            //this.procTableAdapter.Fill(this.database2_TESTDataSet.proc);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vibor1". При необходимости она может быть перемещена или удалена.
            //this.vibor1TableAdapter.Fill(this.database2_TESTDataSet.vibor1);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.proc_Запрос". При необходимости она может быть перемещена или удалена.
            //this.proc_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.proc_Запрос);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vivod_itog_2". При необходимости она может быть перемещена или удалена.
            //this.vivod_itog_2TableAdapter.Fill(this.database2_TESTDataSet.vivod_itog_2);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vivod_itog". При необходимости она может быть перемещена или удалена.
            //this.vivod_itogTableAdapter.Fill(this.database2_TESTDataSet.vivod_itog);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vivod". При необходимости она может быть перемещена или удалена.
            //this.vivodTableAdapter.Fill(this.database2_TESTDataSet.vivod);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2soft_serv_Запрос". При необходимости она может быть перемещена или удалена.
            //this.dev2soft_serv_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2soft_serv_Запрос);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2soft_Запрос". При необходимости она может быть перемещена или удалена.
            //this.dev2soft_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2soft_Запрос);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Trash". При необходимости она может быть перемещена или удалена.
            //this.trashTableAdapter.Fill(this.database2_TESTDataSet.Trash);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2acc_Запрос". При необходимости она может быть перемещена или удалена.
            //this.dev2acc_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2acc_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2LLC_Запрос". При необходимости она может быть перемещена или удалена.
            //this.dev2LLC_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2LLC_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2sup_Запрос". При необходимости она может быть перемещена или удалена.
            //this.dev2sup_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2sup_Запрос);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2care_Запрос". При необходимости она может быть перемещена или удалена.
            //this.dev2care_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2care_Запрос);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Printer". При необходимости она может быть перемещена или удалена.
            //this.printerTableAdapter.Fill(this.database2_TESTDataSet.Printer);
            ////this.trashTableAdapter.Fill(this.database2_TESTDataSet.Trash);

            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Копия_Printer". При необходимости она может быть перемещена или удалена.
            //this.копия_PrinterTableAdapter.Fill(this.database2_TESTDataSet.Копия_Printer);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Копия_Printer". При необходимости она может быть перемещена или удалена.
            //this.копия_PrinterTableAdapter.Fill(this.database2_TESTDataSet.Копия_Printer);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.matrix". При необходимости она может быть перемещена или удалена.
            //this.matrixTableAdapter.Fill(this.database2_TESTDataSet.matrix);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Accessory". При необходимости она может быть перемещена или удалена.
            //this.accessoryTableAdapter.Fill(this.database2_TESTDataSet.Accessory);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.proc_Запрос". При необходимости она может быть перемещена или удалена.
            //this.proc_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.proc_Запрос);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vivod_itog_2". При необходимости она может быть перемещена или удалена.
            //this.vivod_itog_2TableAdapter.Fill(this.database2_TESTDataSet.vivod_itog_2);


            DateTime curDate = DateTime.Now;
            DateTime date1 = new DateTime(2018, 8, 19);

            if (curDate > date1)
            {
                MessageBox.Show("БЕТА-тест окончен!" + "\n Благодарим за участие в тестировании", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.database2_TESTDataSet.Trash.Rows.Add(null, 1);
                this.trashTableAdapter.Update(this.database2_TESTDataSet.Trash);
                this.trashTableAdapter.Fill(this.database2_TESTDataSet.Trash);
                Environment.Exit(0);
                return;
  
            }

            if (Convert.ToString(trashDataGridView[1, 0].Value) == "1")
            {
                Environment.Exit(0);
                return;
            }


            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vivod_itog". При необходимости она может быть перемещена или удалена.
            //this.vivod_itogTableAdapter.Fill(this.database2_TESTDataSet.vivod_itog);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vivod". При необходимости она может быть перемещена или удалена.
            //this.vivodTableAdapter.Fill(this.database2_TESTDataSet.vivod);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.DurForCRF". При необходимости она может быть перемещена или удалена.
            //this.durForCRFTableAdapter.Fill(this.database2_TESTDataSet.DurForCRF);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vibor1". При необходимости она может быть перемещена или удалена.
            //this.vibor1TableAdapter.Fill(this.database2_TESTDataSet.vibor1);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2acc_Запрос1". При необходимости она может быть перемещена или удалена.
            //this.dev2acc_Запрос1TableAdapter.Fill(this.database2_TESTDataSet.Dev2acc_Запрос1);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vibor". При необходимости она может быть перемещена или удалена.
            //this.viborTableAdapter.Fill(this.database2_TESTDataSet.vibor);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2acc_Запрос". При необходимости она может быть перемещена или удалена.
            //this.dev2acc_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2acc_Запрос);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2LLC_Запрос". При необходимости она может быть перемещена или удалена.
            //this.dev2LLC_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2LLC_Запрос);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2soft_serv_Запрос". При необходимости она может быть перемещена или удалена.
            //this.dev2soft_serv_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2soft_serv_Запрос);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2soft_Запрос". При необходимости она может быть перемещена или удалена.
            //this.dev2soft_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2soft_Запрос);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.soft_serv". При необходимости она может быть перемещена или удалена.
            //this.soft_servTableAdapter.Fill(this.database2_TESTDataSet.soft_serv);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.soft_dev". При необходимости она может быть перемещена или удалена.
            //this.soft_devTableAdapter.Fill(this.database2_TESTDataSet.soft_dev);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2sup_Запрос". При необходимости она может быть перемещена или удалена.
            //this.dev2sup_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2sup_Запрос);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2sup_Запрос". При необходимости она может быть перемещена или удалена.
            //this.dev2sup_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2sup_Запрос);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2care_Запрос". При необходимости она может быть перемещена или удалена.
            //this.dev2care_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2care_Запрос);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Care_pack". При необходимости она может быть перемещена или удалена.
            //this.care_packTableAdapter.Fill(this.database2_TESTDataSet.Care_pack);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Printer". При необходимости она может быть перемещена или удалена.
            //this.printerTableAdapter.Fill(this.database2_TESTDataSet.Printer);
        
            comboBox9.Text = "";
            comboBox11.Text = "";
            comboBox14.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.viborTableAdapter.Update(this.database2_TESTDataSet.vibor);
        }


        private void printer()              //ПОКА НЕ ЮЗАЕМ!!
        {

        }

        private void add_print_Button_Click(object sender, EventArgs e)
        {
            

            double dur_project = 0;
            if (comboBox9.Text.Length > 0)
                dur_project = Convert.ToDouble(comboBox9.Text);
            else
            {
                MessageBox.Show("Не выбран срок контракта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }



            



            if (textBox1.Text.Length < 1 && textBox2.Text.Length < 1 && radioButton13.Checked == true)
            {

                    MessageBox.Show("УКАЖИТЕ ОБЪЁМ ПЕЧАТИ!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            else
                try
                {
                    filtri();
                }
                catch
                {
                    MessageBox.Show("ПРИНТЕР НЕ ДОБАВЛЕН!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            filter_gar();

        }


        void filtri()
        {
            for (int i = 0; i < printerDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(printerDataGridView[11, i].Value) == "True")
                {
                    if (radioButton14.Checked == true)
                    {
                        //v_pech_mono = (Convert.ToDouble(printerDataGridView["format", i].Value) / 100) * Convert.ToDouble(comboBox14.Text);   //FIX IT
                        textBox8.Text = Convert.ToString(v_pech_mono);
                    }
                    else

                    if (Convert.ToString(printerDataGridView[9, i].Value) == "mono" && textBox2.Text != "0")
                    {
                        MessageBox.Show("УКАЖИТЕ КОРРЕКТНЫЙ ОБЪЁМ ПЕЧАТИ!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    this.database2_TESTDataSet.vibor1.Rows.Add(null, printerDataGridView[1, i].Value, printerDataGridView[2, i].Value, printerDataGridView[7, i].Value, printerDataGridView[8, i].Value);
                    comboBox3.Text = Convert.ToString(printerDataGridView[0, i].Value);         // = АКТИВНАЯ МОДЕЛЬ ПРИНТЕРА
                    comboBox4.Text = Convert.ToString(printerDataGridView[2, i].Value);         // = АКТИВНАЯ МОДЕЛЬ ПРИНТЕРА
                    this.dev2care_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
                    this.dev2sup_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
                    this.dev2LLC_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
                    this.dev2acc_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
                    this.dev2soft_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
                    this.dev2soft_serv_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";

                    sup_add();
                    LLC_add();
                }

            }
        }

        private void add_care_pack_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dev2care_ЗапросDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(dev2care_ЗапросDataGridView[8, i].Value) == "True")            //если (vote_gar == true)
                {
                    this.database2_TESTDataSet.vibor1.Rows.Add(null, dev2care_ЗапросDataGridView[2, i].Value, dev2care_ЗапросDataGridView[3, i].Value, dev2care_ЗапросDataGridView[4, i].Value, dev2care_ЗапросDataGridView[6, i].Value);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.vibor1TableAdapter.Update(this.database2_TESTDataSet.vibor1);
            this.vibor1TableAdapter.Fill(this.database2_TESTDataSet.vibor1);

        }

        




        void LLC_add()
        {
            double qty_m = 0;
            double qty_c = 0;
            double copy_m_proj = 0;
            double copy_c_proj = 0;
            if (radioButton13.Checked == true)
            {
                copy_m_proj = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(comboBox9.Text);    //объём_печати_моно_проект = объём_печати_моно * срок_контракта
                copy_c_proj = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(comboBox9.Text);    //объём печати_цвет_проект = объём_печати_цвет * срок_контракта
            }
            else
            {
                copy_m_proj = v_pech_mono * Convert.ToDouble(comboBox9.Text);    //объём_печати_моно_проект = объём_печати_моно * срок_контракта
                copy_c_proj = v_pech_mono * Convert.ToDouble(comboBox9.Text);    //объём печати_цвет_проект = объём_печати_цвет * срок_контракта
            }
            for (int i = 0; i < dev2LLC_ЗапросDataGridView.RowCount - 1; i++)
            {       
                    dev2LLC_ЗапросDataGridView[11, i].Value = "True";       //ставим галку выбора для LLC

                if (Convert.ToString(dev2LLC_ЗапросDataGridView[11, i].Value) == "True")                     //    если используется в MONO
                {
                    qty_m = copy_m_proj / (Convert.ToDouble(dev2LLC_ЗапросDataGridView[8, i].Value));           //кол-во_копий_напечатает_моно_этот_узел = объём_печати_моно_проект/ресурс_узла  
                    absolut_mono = absolut_mono + (Convert.ToDouble(dev2LLC_ЗапросDataGridView[7, i].Value) / Convert.ToDouble(dev2LLC_ЗапросDataGridView[8, i].Value)); //абсолют=цена_ресурса/ресурс_этого_ресурса
                }
                else
                    qty_m = 0;

                if (Convert.ToString(dev2LLC_ЗапросDataGridView[10, i].Value) == "True")                     //  если используется в COLOR
                {
                    qty_c = copy_c_proj / (Convert.ToDouble(dev2LLC_ЗапросDataGridView[8, i].Value));           //кол-во_копий_напечатает_цвет_этот_узел = объём_печати_цвет_проект/ресурс_узла
                    absolut_color = absolut_color + (Convert.ToDouble(dev2LLC_ЗапросDataGridView[7, i].Value) / Convert.ToDouble(dev2LLC_ЗапросDataGridView[8, i].Value));  //абсолют=цена_ресурса/ресурс_этого_ресурса
                }
                else
                    qty_c = 0;

                    this.database2_TESTDataSet.vibor1.Rows.Add(null, dev2LLC_ЗапросDataGridView[4, i].Value, dev2LLC_ЗапросDataGridView[5, i].Value, dev2LLC_ЗапросDataGridView[7, i].Value, dev2LLC_ЗапросDataGridView[12, i].Value, qty_m, qty_c, dev2LLC_ЗапросDataGridView[6, i].Value, dev2LLC_ЗапросDataGridView[9, i].Value, copy_m_proj, copy_c_proj);
            }
            
        }

        void sup_add()
        {
            double qty_m = 0;
            double qty_c = 0;
            double copy_m_proj = 0;
            double copy_c_proj = 0;
            if (radioButton13.Checked == true)
            {
                copy_m_proj = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(comboBox9.Text);    //объём_печати_моно_проект = объём_печати_моно * срок_контракта
                copy_c_proj = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(comboBox9.Text);    //объём печати_цвет_проект = объём_печати_цвет * срок_контракта
            }
            else
            {
                copy_m_proj = v_pech_mono * Convert.ToDouble(comboBox9.Text);    //объём_печати_моно_проект = объём_печати_моно * срок_контракта
                copy_c_proj = v_pech_mono * Convert.ToDouble(comboBox9.Text);    //объём печати_цвет_проект = объём_печати_цвет * срок_контракта
            }

            for (int i = 0; i < dev2sup_ЗапросDataGridView.RowCount - 1; i++)
            {
                    dev2sup_ЗапросDataGridView[12, i].Value = "True";               //ставим галку выбора для supply

                if (Convert.ToString(dev2sup_ЗапросDataGridView[9, i].Value) == "True")                     //  если используется в MONO
                {
                    qty_m = copy_m_proj / (Convert.ToDouble(dev2sup_ЗапросDataGridView[7, i].Value));       //штук(без_округл)_нужно_для_проекта_моно = объём_печати_моно_проект/ресурс_узла
                    absolut_mono = absolut_mono + (Convert.ToDouble(dev2sup_ЗапросDataGridView[6, i].Value) / Convert.ToDouble(dev2sup_ЗапросDataGridView[7, i].Value)); //абсолют=цена_ресурса/ресурс_этого_ресурса

                }
                else
                    qty_m = 0;

                if (Convert.ToString(dev2sup_ЗапросDataGridView[10, i].Value) == "True")                 //  если используется в COLOR
                {
                    qty_c = copy_c_proj / (Convert.ToDouble(dev2sup_ЗапросDataGridView[7, i].Value));       ///штук(без_округл)_нужно_для_проекта_цвет = объём_печати_цвет_проект/ресурс_узла
                    absolut_color = absolut_color + (Convert.ToDouble(dev2sup_ЗапросDataGridView[6, i].Value) / Convert.ToDouble(dev2sup_ЗапросDataGridView[7, i].Value)); //абсолют=цена_ресурса/ресурс_этого_ресурса

                }
                else
                    qty_c = 0;

                    this.database2_TESTDataSet.vibor1.Rows.Add(null, dev2sup_ЗапросDataGridView[3, i].Value, dev2sup_ЗапросDataGridView[4, i].Value, dev2sup_ЗапросDataGridView[6, i].Value, dev2sup_ЗапросDataGridView[11, i].Value, qty_m, qty_c, dev2sup_ЗапросDataGridView[5, i].Value, dev2sup_ЗапросDataGridView[8, i].Value, copy_m_proj, copy_c_proj);
                
            }
        }

        

        private void add_acc_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dev2acc_ЗапросDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(dev2acc_ЗапросDataGridView[9, i].Value) == "True")
                {
                    this.database2_TESTDataSet.vibor1.Rows.Add(null, dev2acc_ЗапросDataGridView[4, i].Value, dev2acc_ЗапросDataGridView[5, i].Value, dev2acc_ЗапросDataGridView[7, i].Value, dev2acc_ЗапросDataGridView[8, i].Value, 0, 0, 0, dev2acc_ЗапросDataGridView[6, i].Value);
                }

            }
        }

        void vivod()
        {
            int z = 0;
            for (int i = 0; i < vibor1DataGridView.RowCount - 1; i++)
            {
                vivodDataGridView[1, i].Value = vibor1DataGridView[1, i].Value;
                vivodDataGridView[2, i].Value = vibor1DataGridView[2, i].Value;
                vivodDataGridView[3, i].Value = vibor1DataGridView[3, i].Value;
                vivodDataGridView[4, i].Value = vibor1DataGridView[4, i].Value;
                vivodDataGridView[5, i].Value = vibor1DataGridView[5, i].Value;
                vivodDataGridView[6, i].Value = vibor1DataGridView[6, i].Value;
                vivodDataGridView[7, i].Value = vibor1DataGridView[7, i].Value;
                vivodDataGridView[8, i].Value = vibor1DataGridView[8, i].Value;
                z = i;
            }

            z++;

            vivodDataGridView[1, z].Value = "---";
            vivodDataGridView[2, z].Value = "кол-во устройств";
            vivodDataGridView[3, z].Value = "объём печати моно в мес";
            //vivodDataGridView[4, z].Value = "объём печати цвет в мес";
            vivodDataGridView[5, z].Value = "аренда в месяц";
            vivodDataGridView[6, z].Value = "цена копии моно";
            //vivodDataGridView[7, z].Value = "цена копии цвет";
            vivodDataGridView[8, z].Value = "затраты на печать проект";
            vivodDataGridView[9, z].Value = "затраты на аренду проект";
            vivodDataGridView[10, z].Value = "всего затрат";

            //workSheet.Cells[rowExcel + 1, 1] = kol_vo;
            //workSheet.Cells[rowExcel + 1, 2] = v_copy_m;
            //workSheet.Cells[rowExcel + 1, 3] = v_copy_c;
            //workSheet.Cells[rowExcel + 1, 4] = arenda_mes;
            //workSheet.Cells[rowExcel + 1, 5] = cost_one_copy_m;
            //workSheet.Cells[rowExcel + 1, 6] = cost_one_c;
            //workSheet.Cells[rowExcel + 1, 7] = cost_all_copy_project;
            //workSheet.Cells[rowExcel + 1, 8] = cost_arenda_project;
            //workSheet.Cells[rowExcel + 1, 9] = cost_all_project;

        }


        private void button9_Click(object sender, EventArgs e)
        {

            double cost_m_proj = 0;
            double cost_c_proj = 0;
            double qty_m = 0;
            double qty_c = 0;
            double qty_m_p2 = 0;
            double qty_c_p2 = 0;
            double qty1 = 0;
            double qty2 = 0;
            double cost1 = 0;
            double cost2 = 0;
            double cost_print = 0;
            double cost_soft = 0;
            double cost_serv_soft = 0;
            double cost_contract = 0;

            double cost_one_m = 0;
            double cost_one_c = 0;
            double trash_2 = 0;
            double dur_project = 0;

                try
                {
                    if (radioButton5.Checked == true && comboBox6.Text.Length > 0)
                        trash_2 = trash_2 + Convert.ToDouble(comboBox6.Text);              //добавили косты нашей работы в АРЕНДУ

                    if (radioButton7.Checked == true && comboBox5.Text.Length > 0)
                        trash_2 = trash_2 + Convert.ToDouble(comboBox5.Text);              //добавили косты подряд работы в АРЕНДУ

                    if ((radioButton9.Checked == true && comboBox7.Text.Length > 0))
                        trash_2 = trash_2 + Convert.ToDouble(comboBox7.Text);                //добавили косты командировочные в АРЕНДУ

                    if ((radioButton11.Checked == true && comboBox8.Text.Length > 0))
                        trash_2 = trash_2 + Convert.ToDouble(comboBox8.Text);                //добавили косты доп услуг в АРЕНДУ

                    if ((radioButton6.Checked == true && comboBox6.Text.Length > 0))
                        cost_contract = cost_contract + Convert.ToDouble(comboBox6.Text);   //добавили косты нашей работы в ОТПЕЧАТОК

                    if ((radioButton8.Checked == true && comboBox5.Text.Length > 0))
                        cost_contract = cost_contract + Convert.ToDouble(comboBox5.Text);    //добавили косты подряд работы в ОТПЕЧАТОК

                    if ((radioButton10.Checked == true && comboBox7.Text.Length > 0))
                        cost_contract = cost_contract + Convert.ToDouble(comboBox7.Text);        //добавили косты командировочные в ОТПЕЧАТОК

                    if ((radioButton12.Checked == true && comboBox8.Text.Length > 0))
                        cost_contract = cost_contract + Convert.ToDouble(comboBox8.Text);        //добавили косты доп услуг в ОТПЕЧАТОК

                    if (comboBox9.Text.Length > 0)
                        dur_project = Convert.ToDouble(comboBox9.Text);
                    else
                    {
                        MessageBox.Show("Не выбран срок контракта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }

                }
                catch
                {
                    MessageBox.Show("Ошибка ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

            //-------------------------------------

            for (int i = 0; i < vibor1DataGridView.RowCount - 1; i++)  
            {

                if (Convert.ToString(vibor1DataGridView[1, i].Value) == "Printer" || Convert.ToString(vibor1DataGridView[1, i].Value) == "accessory" || Convert.ToString(vibor1DataGridView[1, i].Value) == "Garanty")
                    cost_print = cost_print + (Convert.ToDouble(vibor1DataGridView[3, i].Value) * Convert.ToDouble(vibor1DataGridView[4, i].Value) * Convert.ToDouble(comboBox11.Text) * Convert.ToDouble(comboBox9.Text) + (Convert.ToDouble(textBox3.Text)* Convert.ToDouble(comboBox9.Text)));      //* Convert.ToDouble(comboBox9.Text)
                //цена_принт_акса_гарантии = цена_нименов * кол-во(1) * срок_проекта * LRF(coef)                                //ТУТ БАГ???? входная строка неаерного формата (lrf= ,.)

                if (Convert.ToString(vibor1DataGridView[1, i].Value) == "soft")
                    cost_soft = cost_soft + Convert.ToDouble(vibor1DataGridView[3, i].Value);

                if ( Convert.ToString(vibor1DataGridView[1, i].Value) == "soft_serv")
                    cost_serv_soft = cost_serv_soft + Convert.ToDouble(vibor1DataGridView[3, i].Value);


                if (Convert.ToString(vibor1DataGridView[1, i].Value) == "LLC" || Convert.ToString(vibor1DataGridView[1, i].Value) == "supply")
                {

                    qty_m = Math.Ceiling(Convert.ToDouble(vibor1DataGridView[5, i].Value));       ///штук(кругл)_нужно_для_проекта_моно
                    qty_c = Math.Ceiling(Convert.ToDouble(vibor1DataGridView[6, i].Value));        ///штук(округл)_нужно_для_проекта_цвет
                    if (Convert.ToString(vibor1DataGridView[8, i].Value) == "True")                 //если in_box
                    {
                        if (qty_m != 0)
                            qty_m = qty_m - 1;      //minus in_box

                        if (qty_m < 0)
                            qty_m = 0;
                        else
                            qty_c = qty_c - 1;

                        if (qty_c < 0)              //minus in_box
                            qty_c = 0;

                        //in_box1 = 0;        // ТУТ ВОЗМОЖНО БАГ, ОТНИМАЕТСЯ БОЛЬШЕ 1 in_box!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    }
                    qty_m_p2 = qty_m * Convert.ToDouble(vibor1DataGridView[7, i].Value);        //кол-во_моно_для_проекта(с учётом узлов) = kol_vo for proj * QTY v yzle
                    qty_c_p2 = qty_c * Convert.ToDouble(vibor1DataGridView[7, i].Value);        //кол-во_цвет_для_проекта(с учётом узлов) = kol_vo for proj * QTY v yzle
                    vibor1DataGridView[9, i].Value = qty_m_p2;
                    vibor1DataGridView[10, i].Value = qty_c_p2;

                    cost_m_proj = qty_m_p2 * Convert.ToDouble(vibor1DataGridView[3, i].Value);                 //стоимость_моно_проект = кол-во_моно_qty * cost
                    cost_c_proj = qty_c_p2 * Convert.ToDouble(vibor1DataGridView[3, i].Value);                   //стоимость_цвет_проект = кол-во_моно_qty * cost



                    vibor1DataGridView[11, i].Value = cost_m_proj; 
                    vibor1DataGridView[12, i].Value = cost_c_proj;


                    qty1 = qty1 + qty_m_p2;        //кол-во всего моно LLC + supply для проекта
                    qty2 = qty2 + qty_c_p2;        //кол-во всего цвет LLC + supply для проекта
                    cost1 = cost1 + cost_m_proj;    //кол-во всего моно LLC + supply для проекта
                    cost2 = cost2 + cost_c_proj;    //кол-во всего цвет LLC + supply для проекта
                    if (radioButton13.Checked == true)
                    {
                        this.vibor1DataGridView[13, i].Value = cost_m_proj / ((Convert.ToDouble(textBox1.Text) * Convert.ToDouble(comboBox9.Text)));  //стоимость элемента для 1 копии = цена_моно_проект/объём_печати_проект
                        this.vibor1DataGridView[14, i].Value = cost_c_proj / ((Convert.ToDouble(textBox2.Text) * Convert.ToDouble(comboBox9.Text)));  //стоимость элемента для 1 копии = цена_цвет_проект/объём_печати_проект
                    }
                    else
                    {
                        this.vibor1DataGridView[13, i].Value = cost_m_proj / (v_pech_mono * Convert.ToDouble(comboBox9.Text));  //стоимость элемента для 1 копии = цена_моно_проект/объём_печати_проект
                        this.vibor1DataGridView[14, i].Value = cost_c_proj / (v_pech_mono * Convert.ToDouble(comboBox9.Text));  //стоимость элемента для 1 копии = цена_цвет_проект/объём_печати_проект
                    }
                    cost_one_m = cost_one_m + Convert.ToDouble(vibor1DataGridView[13, i].Value);    //собираем цену копии моно
                    cost_one_c = cost_one_c + Convert.ToDouble(vibor1DataGridView[14, i].Value);    //собираем цену копии цвет

                    //this.vibor1DataGridView[13, i].Value = cost_m_proj / ((Convert.ToDouble(textBox1.Text) * Convert.ToDouble(comboBox9.Text)));

                }




            }

            //double arenda_proj = cost_print2 - (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(comboBox9.Text));
            if (radioButton13.Checked == true)
                this.database2_TESTDataSet.vivod_itog_2.Rows.Add(null, vibor1DataGridView[2, 0].Value, vibor1DataGridView[4, 0].Value, textBox1.Text, textBox2.Text, (cost_print - (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(comboBox9.Text)) )/ dur_project, cost_one_m, cost_one_c, cost1 + cost2, cost_print - (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(comboBox9.Text)), cost1 + cost2 + cost_print);
            else
                this.database2_TESTDataSet.vivod_itog_2.Rows.Add(null, vibor1DataGridView[2, 0].Value, vibor1DataGridView[4, 0].Value, v_pech_mono, v_pech_mono, (cost_print - (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(comboBox9.Text))) / dur_project, cost_one_m, cost_one_c, cost1 + cost2, cost_print - (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(comboBox9.Text)), cost1 + cost2 + cost_print);


            double cost_print2 = cost_print + (trash_2 * dur_project);        //* total_copy  //  + накладные расходы на устройство //+ (Convert.ToDouble(textBox3.Text))
            //cost_print2 = cost_print2 + trash_2;      //ПОЗЖЕ
            double total_copy = 0;
            if (radioButton13.Checked == true)
                total_copy = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)) * dur_project;
            else
                total_copy = (v_pech_mono) * dur_project;

            cost_one_m = ((cost_contract * dur_project) / total_copy) + cost_one_m; 
            cost_one_c = (cost_contract * dur_project / total_copy) + cost_one_c;


            cost_print2 = cost_print2 * ((Convert.ToDouble(textBox5.Text) / 100) + 1);                                //наценка на оборудование 15%
            cost_one_m = (cost_one_m * ((Convert.ToDouble(textBox6.Text) / 100) + 1) + (Convert.ToDouble(textBox4.Text)));       //+ накладные расходы на копию (в ПРОЦЕНТАХ)     //(Convert.ToDouble(textBox4.Text) * total_copy)
            cost_one_c = (cost_one_c * ((Convert.ToDouble(textBox7.Text) / 100) + 1) + (Convert.ToDouble(textBox4.Text)));

            if (radioButton2.Checked == true)
            {
                cost_one_m = (cost_soft / total_copy) + cost_one_m;
                cost_one_c = (cost_soft / total_copy) + cost_one_c;
            }
            else
                cost_print2 = cost_print2 + cost_soft;

            if (radioButton4.Checked == true)
            {
                cost_one_m = (cost_serv_soft / total_copy) + cost_one_m;
                cost_one_c = (cost_serv_soft / total_copy) + cost_one_c;
            }
            else
                cost_print2 = cost_print2 + cost_serv_soft;


            //cost_one_m = cost_one_m * Convert.ToDouble(trashDataGridView[2, 0].Value);
            //cost_one_c = cost_one_c * Convert.ToDouble(trashDataGridView[3, 0].Value);

            double arenda_proj = (cost_print2 - (Convert.ToDouble(textBox3.Text)) * Convert.ToDouble(comboBox9.Text));

            MessageBox.Show("АРЕНДА_ПРОЕКТ(dev+acc+gar)*LRF= " + arenda_proj + 
                "\n + В АРЕНДУ_ПРОЕКТ(труд, командир, доп услуги)= " + trash_2 * dur_project +
                "\n + НАКЛАДНЫЕ_месяц(усл_контр)= " + textBox3.Text +
                "\n = ИТОГ АРЕНДА ПРОЕКТ= " + cost_print2 +
                "\n" +
                "\n аренда в месяц= " + cost_print2 / dur_project +
                "\n" +
                "\n kol-vo mono= " + qty1 + 
                "\n cost_mono= " + cost1 + 
                "\n kol-vo color= " + qty2 + 
                "\n cost_color= " + cost2 +
                "\n" +
                "\n cost_one_mono + наценка= " + cost_one_m + 
                "\n cost_one_color + наценка= " + cost_one_c,
                "\n" +
                //"\n ЗАТРАТЫ НА ПРОЕКТ= " + cost_one_m +
                "Рассчитываем...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            try
                
            {    //ВРЕМЕННО!!!!!!!!!!!!!!!!!!!!!!!!!
                //ExportToExcel(1, textBox1.Text, textBox2.Text, last_cost / dur_project, cost_one_m, cost_one_c, cost1 + cost2, cost_print, cost_print + cost1 + cost2);
                //vivod();

                //int i = 0;
                int z = 0;
                for (int i = 0; i < vibor1DataGridView.RowCount - 1; i++)
                {
                    this.database2_TESTDataSet.vivod.Rows.Add(null, vibor1DataGridView[1, i].Value, vibor1DataGridView[2, i].Value, vibor1DataGridView[3, i].Value, vibor1DataGridView[9, i].Value, vibor1DataGridView[10, i].Value, "---", "---");
                    z = i;
                }
                //this.database2_TESTDataSet.vivod.Rows.Add();
                z++;
                this.database2_TESTDataSet.vivod.Rows.Add(null, "---", "---", "---", "---", "---", "---", "---");

                //this.database2_TESTDataSet.vivod.Rows.Add(null, "---", "кол-во устройств", "объём печати моно в мес", "аренда в месяц", "цена копии моно", "затраты на печать проект");

                if (radioButton13.Checked == true)          //НАЦЕНКИ
                    this.database2_TESTDataSet.vivod_itog.Rows.Add(null, vibor1DataGridView[2, 0].Value, vibor1DataGridView[4, 0].Value, textBox1.Text, textBox2.Text, arenda_proj / dur_project, cost_one_m, cost_one_c, "test", arenda_proj, cost1 + cost2 + arenda_proj);
                else
                    this.database2_TESTDataSet.vivod_itog.Rows.Add(null, vibor1DataGridView[2, 0].Value, vibor1DataGridView[4, 0].Value, v_pech_mono, v_pech_mono, "тест", cost_one_m, cost_one_c, "test", arenda_proj, cost1 + cost2 + arenda_proj);

                //this.database2_TESTDataSet.vivod.Rows.Add(null, "---", "кол-во устройств", "объём печати моно в мес", "аренда в месяц", "цена копии моно", "затраты на печать проект");

                //this.database2_TESTDataSet.vivod_itog_2.Rows.Add(null, vibor1DataGridView[2, 0].Value, vibor1DataGridView[4, 0].Value, textBox1.Text, textBox2.Text, cost_print / dur_project, cost_one_m, cost_one_c, cost1 + cost2, arenda_proj, cost1 + cost2 + arenda_proj);

            }
            catch
            {
                MessageBox.Show("файл не создан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

        }


       


        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            this.dev2care_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
            this.dev2sup_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
            this.dev2LLC_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
            this.dev2acc_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
            this.dev2soft_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
            this.dev2soft_serv_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            this.dev2care_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
            this.dev2sup_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
            this.dev2LLC_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
            this.dev2acc_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
            this.dev2soft_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
            this.dev2soft_serv_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dev2soft_ЗапросDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(dev2soft_ЗапросDataGridView[9, i].Value) == "True")
                {
                    this.database2_TESTDataSet.vibor1.Rows.Add(null, dev2soft_ЗапросDataGridView[4, i].Value, dev2soft_ЗапросDataGridView[5, i].Value, dev2soft_ЗапросDataGridView[6, i].Value, dev2soft_ЗапросDataGridView[8, i].Value);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dev2soft_ЗапросDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(dev2soft_serv_ЗапросDataGridView[9, i].Value) == "True")
                {
                    this.database2_TESTDataSet.vibor1.Rows.Add(null, dev2soft_serv_ЗапросDataGridView[4, i].Value, dev2soft_serv_ЗапросDataGridView[5, i].Value, dev2soft_serv_ЗапросDataGridView[6, i].Value, dev2soft_serv_ЗапросDataGridView[8, i].Value);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            Access.Application oAccess = null;

            string sAccPath = null; //path to msaccess.exe
            Process p = null;

            // Start a new instance of Access for Automation:
            oAccess = new Access.ApplicationClass();         //ApplicationClass();

            // Open a database in exclusive mode:
            oAccess.OpenCurrentDatabase(
               "C:\\Users\\evgeniy.barabash\\source\\repos\\SOFT_FOR_ACCESS\\SOFT_FOR_ACCESS\\Database2_TEST.accdb", //filepath
               true //Exclusive
               );


            // Preview a report named Sales:
            oAccess.DoCmd.OpenReport(
               "Access", //ReportName
               Access.AcView.acViewPreview, //View
               System.Reflection.Missing.Value, //FilterName
               System.Reflection.Missing.Value //WhereCondition
               );



            //// Select the Employees report in the database window:
            //oAccess.DoCmd.SelectObject(
            //   Access.AcObjectType.acReport, //ObjectType
            //   "LAST_EZ", //ObjectName
            //   true //InDatabaseWindow
            //   );



            //// Print 2 copies of the active object: 
            //oAccess.DoCmd.PrintOut(
            //   Access.AcPrintRange.acPrintAll, //PrintRange
            //   System.Reflection.Missing.Value, //PageFrom
            //   System.Reflection.Missing.Value, //PageTo
            //   Access.AcPrintQuality.acHigh, //PrintQuality
            //   2, //Copies
            //   false //CollateCopies
            //   );






        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Excel.Application exApp = new Excel.Application();
            //Создаём приложение.
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            //Открываем книгу.                                                                                                                                                        
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(@"C:\file.xls", 0, true, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            //Выбираем таблицу(лист).
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
            //ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
            //string[,] Telephons = new string[100];
            //Выбираем первые сто записей из столбца.
            Worksheet workSheet = (Worksheet)ObjExcel.ActiveSheet;

            for (int i = 1; i < 4; i++)
            {

                //exApp.Workbooks.Open();

                //workSheet.Cells[1, 1]


                //Выбираем область таблицы. (в нашем случае просто ячейку)
                //Microsoft.Office.Interop.Excel.Range range = ObjWorkSheet.get_Range(1 + i, 1 + i);
                //Microsoft.Office.Interop.Excel.Range range2 = ObjWorkSheet.get_Range(1, 1);
                //get_Range(2 + i.ToString(), 2 + i.ToString());
                //Microsoft.Office.Interop.Excel.Range range3 = ObjWorkSheet.get_Range(3 + i.ToString(), 3 + i.ToString());
                //Microsoft.Office.Interop.Excel.Range range4 = ObjWorkSheet.get_Range(4 + i.ToString(), 4 + i.ToString());
                //care_packTableAdapter
                //Microsoft.Office.Interop.Excel.Range range = 
                //Добавляем полученный из ячейки текст.
                //Telephons[i - 1] = range.Text.ToString();
                //this.database2_TESTDataSet.Care_pack.Rows.Add(null, workSheet.Cells[1, 1], workSheet.Cells[2, 1], workSheet.Cells[3, 1], workSheet.Cells[4, 1]);
                //this.database2_TESTDataSet2.Care_pack.Rows.Add()

               // this.dev2care_ЗапросDataGridView[1, i].Value = workSheet.Cells[i, 1];
               // this.dev2care_ЗапросDataGridView[2, i].Value = workSheet.Cells[i, 2];
               // this.dev2care_ЗапросDataGridView[3, i].Value = workSheet.Cells[i, 3];
                //this.dev2care_ЗапросDataGridView[4, i].Value = workSheet.Cells[i, 4];
                //this.dev2care_ЗапросDataGridView[5, i].Value = workSheet.Cells[i, 5];
                //this.dev2care_ЗапросDataGridView[6, i].Value = workSheet.Cells[i, 6];
            }
        }




        private void button16_Click(object sender, EventArgs e)
        {
            //ExportToExcel();
        }

        private void ExportToExcel(double kol_vo, string v_copy_m, string v_copy_c, double arenda_mes, double cost_one_copy_m, double cost_one_c, double cost_all_copy_project, double cost_arenda_project, double cost_all_project)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
            workSheet.Cells[1, 1] = "ID";
            workSheet.Cells[1, 2] = "Type";
            workSheet.Cells[1, 3] = "Name";
            workSheet.Cells[1, 4] = "Duration";
            workSheet.Cells[1, 5] = "service1";
            workSheet.Cells[1, 6] = "service2";
            workSheet.Cells[1, 7] = "service3";
            workSheet.Cells[1, 8] = "service4";
            workSheet.Cells[1, 9] = "kol-vo_mono_for_proj";
            workSheet.Cells[1, 10] = "kol-vo_color_for_proj";
            workSheet.Cells[1, 11] = "cost_mono_for_proj";
            workSheet.Cells[1, 12] = "cost_color_for_proj";
            workSheet.Cells[1, 13] = "kol-vo_mono";
            workSheet.Cells[1, 14] = "kol-vo_color";

            //

            int rowExcel = 2; //начать со второй строки.
                              //Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
                              //while (workSheet.Cells[rowExcel, 1] != "---")
                              //rowExcel++;

            //rowExcel = workSheet.Cells.Find("*", workSheet.Cells[1, 1], Excel.XlFindLookIn.xlFormulas, Excel.XlLookAt.xlPart, Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious).Row + 1;


            for (int i = 0; i < vibor1DataGridView.Rows.Count; i++)
            {
                //заполняем строку
                workSheet.Cells[rowExcel, 1] = vibor1DataGridView[0, i].Value;
                workSheet.Cells[rowExcel, 2] = vibor1DataGridView[1, i].Value;
                workSheet.Cells[rowExcel, 3] = vibor1DataGridView[2, i].Value;
                workSheet.Cells[rowExcel, 4] = vibor1DataGridView[3, i].Value;
                workSheet.Cells[rowExcel, 5] = vibor1DataGridView[4, i].Value;
                workSheet.Cells[rowExcel, 6] = vibor1DataGridView[5, i].Value;
                workSheet.Cells[rowExcel, 7] = vibor1DataGridView[6, i].Value;
                workSheet.Cells[rowExcel, 8] = vibor1DataGridView[7, i].Value;
                workSheet.Cells[rowExcel, 9] = vibor1DataGridView[8, i].Value;
                workSheet.Cells[rowExcel, 10] = vibor1DataGridView[9, i].Value;
                workSheet.Cells[rowExcel, 11] = vibor1DataGridView[10, i].Value;
                workSheet.Cells[rowExcel, 12] = vibor1DataGridView[11, i].Value;
                workSheet.Cells[rowExcel, 13] = vibor1DataGridView[12, i].Value;
                workSheet.Cells[rowExcel, 14] = vibor1DataGridView[13, i].Value;
                workSheet.Cells[rowExcel, 15] = vibor1DataGridView[14, i].Value;
                // workSheet.Cells[rowExcel, 6] = care_packDataGridView[6, i].Value;
                //workSheet.Cells[rowExcel, "C"] = care_packDataGridView[2, i].Value;
                ++rowExcel;
            }

            //MessageBox.Show("Аренда= " + cost_print + " + " + trash_2 + " = " + last_cost + "\n kol-vo mono= " + qty1 + "\n cost_mono= " + cost1 + "\n kol-vo color= " + qty2 + "\n cost_color= " + cost2 + "\n cost_one_mono= " + cost_one_m + "\n cost_one_color= " + cost_one_c, "Рассчитываем...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            workSheet.Cells[rowExcel, 1] = "кол-во устройств";
            workSheet.Cells[rowExcel, 2] = "объём печати моно в мес";
            workSheet.Cells[rowExcel, 3] = "объём печати цвет в мес";
            workSheet.Cells[rowExcel, 4] = "аренда в месяц";
            workSheet.Cells[rowExcel, 5] = "цена копии моно";
            workSheet.Cells[rowExcel, 6] = "цена копии цвет";
            workSheet.Cells[rowExcel, 7] = "затраты на печать проект";
            workSheet.Cells[rowExcel, 8] = "затраты на аренду проект";
            workSheet.Cells[rowExcel, 9] = "всего затрат";

            workSheet.Cells[rowExcel + 1, 1] = kol_vo;
            workSheet.Cells[rowExcel + 1, 2] = v_copy_m;
            workSheet.Cells[rowExcel + 1, 3] = v_copy_c;
            workSheet.Cells[rowExcel + 1, 4] = arenda_mes;
            workSheet.Cells[rowExcel + 1, 5] = cost_one_copy_m;
            workSheet.Cells[rowExcel + 1, 6] = cost_one_c;
            workSheet.Cells[rowExcel + 1, 7] = cost_all_copy_project;
            workSheet.Cells[rowExcel + 1, 8] = cost_arenda_project;
            workSheet.Cells[rowExcel + 1, 9] = cost_all_project;



            string pathToXmlFile;
            pathToXmlFile = Environment.CurrentDirectory + "\\" + "MyFile.xls";
            workSheet.SaveAs(pathToXmlFile);

            exApp.Quit();

        }



        static IEnumerable<Metric> EnumerateMetrics(string xlsxpath)
        {
            // Открываем книгу
            using (var workbook = new XLWorkbook(xlsxpath))
            // Берем в ней первый лист
            using (var worksheet = workbook.Worksheets.Worksheet(1))
            {
                // Перебираем диапазон нужных строк
                for (int row = 2; row <= 3; ++row)
                {
                    // По каждой строке формируем объект
                    var metric = new Metric
                    {
                        Alpha = worksheet.Cell(row, 1).GetValue<int>(),
                        Beta = worksheet.Cell(row, 2).GetValue<int>(),
                        Gamma = worksheet.Cell(row, 3).GetValue<int>(),
                        Delta = worksheet.Cell(row, 4).GetValue<int>(),
                    };
                    // И возвращаем его
                    yield return metric;
                }
            }
        }




        private void button18_Click(object sender, EventArgs e)
        {
            var metrics = EnumerateMetrics("Data.xlsx");
            //foreach (var m in metrics)
               // Console.WriteLine("Альфа: {0}; Бета: {1}; Гамма: {2}; Дельта: {3}", m.Alpha, m.Beta, m.Gamma, m.Delta);
            //Console.ReadKey();
        }

        private void printerDataGridView_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(printerDataGridView[9, printerDataGridView.CurrentRow.Index].Value) == "mono")
            {
                comboBox2.Enabled = false;
                comboBox2.Text = "0";
                textBox2.Enabled = false;
                textBox2.Text = "0";
                //MessageBox.Show("УКАЖИТЕ КОРРЕКТНЫЙ ОБЪЁМ ПЕЧАТИ!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
            else
            {
                comboBox2.Enabled = true;
                textBox2.Enabled = true;
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < vibor1DataGridView.RowCount - 1; i++)
            {

               // if (Convert.ToString(vibor1DataGridView[1, i].Value) == "LLC" || Convert.ToString(vibor1DataGridView[1, i].Value) == "supply")
                {
                    textBox9.Text = Convert.ToString(absolut_mono);
                    textBox10.Text = Convert.ToString(absolut_color);



                }

                //цена_принт_акса_гарантии = цена_нименов * кол-во(1) * срок_проекта * LRF(coef)  

            }


        }

        private void comboBox10_TextChanged(object sender, EventArgs e)
        {
            this.proc_ЗапросBindingSource.Filter = "[proc] LIKE'" + comboBox10.Text + "'";
        }

        void filter_gar()
        {
            //double boofer = Convert.ToDouble(comboBox9.Text) / 12;
            double boofer = Convert.ToDouble(comboBox9.Text) / 12;
            this.dev2care_ЗапросBindingSource.Filter = "[dlit_gar] >='" + boofer + "%' and [id_dev] LIKE'" + comboBox3.Text + "%'";

            //this.dev2care_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
        }

        private void comboBox9_TextChanged(object sender, EventArgs e)
        {
            //filter_gar();
            //double boofer = Convert.ToDouble(comboBox9.Text) / 12;
            //this.dev2care_ЗапросBindingSource.Filter = "[dlit_gar] LIKE'" + boofer + "%'";


        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;

                comboBox14.Text = "";
                comboBox14.Enabled = false;
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox14.Enabled = true;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //this.vibor1DataGridView.Rows.Clear();
            //this.vibor1BindingSource.Clear();

            //this.vibor1TableAdapter.Update(this.database2_TESTDataSet.vibor1);
            //this.vibor1TableAdapter.Fill(this.database2_TESTDataSet.vibor1);

            while (vibor1DataGridView.Rows.Count > 1)
                for (int i = 0; i < vibor1DataGridView.Rows.Count - 1; i++)
                    vibor1DataGridView.Rows.Remove(vibor1DataGridView.Rows[i]);

            this.vibor1TableAdapter.Update(this.database2_TESTDataSet.vibor1);
            this.vibor1TableAdapter.Fill(this.database2_TESTDataSet.vibor1);
        }

        private void printerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.printerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);

        }

        private void printerBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.printerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);

        }
    }



    public class Metric
    {
        public int Alpha { get; set; }
        public int Beta { get; set; }
        public int Gamma { get; set; }
        public int Delta { get; set; }
    }




}
