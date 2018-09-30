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
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.IO;

//------------------------------------
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using Access = Microsoft.Office.Interop.Access;
//----------------------
using Microsoft.Office.Interop.Excel;
using SD = System.Data;
using Excel = Microsoft.Office.Interop.Excel;
//using Excel = Microsoft.Office.Interop.Excel;
//using Word = Microsoft.Office.Interop.Word;
using ExcelObj = Microsoft.Office.Interop.Excel;

//------------------------
using ClosedXML.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;

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
        bool tab_ch = false;
        double count_sup = 0;
        double first_print_check = 0;
        bool pdf_file = false;

        public List<Note> Notes = new List<Note>();



        private void Form1_Load(object sender, EventArgs e)
        {
            textBox12.Text = System.Environment.UserName;
            textBox13.Text = System.Environment.MachineName;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Care_pack". При необходимости она может быть перемещена или удалена.
            this.care_packTableAdapter.Fill(this.database2_TESTDataSet.Care_pack);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2LLC". При необходимости она может быть перемещена или удалена.
            this.dev2LLCTableAdapter.Fill(this.database2_TESTDataSet.Dev2LLC);
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

            //trashDataGridView.Rows.Remove(trashDataGridView.Rows[0]);
            //this.trashTableAdapter.Update(this.database2_TESTDataSet.Trash);

            DateTime curDate = DateTime.Now;
            DateTime date1 = new DateTime(2018, 10, 19);
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
            comboBox9.Text = "";                    //срок проекта
            comboBox11.Text = "";                   //LRF
            comboBox14.Enabled = false;             //% нагрузки для матрицы


            Notes.Add(new Note(null, null, null, null, null, null, null, null, null, null, null, null, null, null ));
            Notes.Add(new Note(null, null, null, null, null, null, null, null, null, null, null, null, null, null ));
            //Notes.Add(new Note(Convert.ToString(dev2care_ЗапросDataGridView[2, i].Value), Convert.ToString(dev2care_ЗапросDataGridView[3, i].Value), Convert.ToString(dev2care_ЗапросDataGridView[4, i].Value), Convert.ToString(dev2care_ЗапросDataGridView[6, i].Value), null, null, null, null, null, null, null, null, null, null));

            clear_vibor();
        }

        private void printer()              //ПОКА НЕ ЮЗАЕМ!!
        {

        }

        private void add_print_Button_Click(object sender, EventArgs e)
        {
            clear_vibor();
            double dur_project = 0;

            int counter = 0;
            for (int i = 0; i <= printerDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(printerDataGridView[11, i].Value) == "True") counter++;
            }
            if (counter != 1)
            {
                MessageBox.Show("Выберите 1 принтер!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



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
            for (int i = 0; i <= printerDataGridView.RowCount - 1; i++)
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

                    if (Convert.ToString(printerDataGridView[9, i].Value) == "mono") count_sup = 1;
                    if (Convert.ToString(printerDataGridView[9, i].Value) == "color") count_sup = 4;
                    Data.Value3 = Convert.ToString(count_sup);
                    this.database2_TESTDataSet.vibor1.Rows.Add(null, printerDataGridView[1, i].Value, printerDataGridView[2, i].Value, printerDataGridView[7, i].Value, printerDataGridView[8, i].Value);



                    //Notes.Add(new Note(Convert.ToString(printerDataGridView[1, i].Value), Convert.ToString(printerDataGridView[2, i].Value), Convert.ToString(printerDataGridView[7, i].Value), Convert.ToString(printerDataGridView[8, i].Value), Convert.ToString(quantity_textBox.Text), null, null, null, null, null, null, null, null, null));

                    comboBox3.Text = Convert.ToString(printerDataGridView[0, i].Value);         // = АКТИВНАЯ МОДЕЛЬ ПРИНТЕРА
                    comboBox4.Text = Convert.ToString(printerDataGridView[2, i].Value);         // = АКТИВНАЯ МОДЕЛЬ ПРИНТЕРА
                    this.dev2care_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
                    this.dev2sup_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
                    this.dev2LLC_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
                    this.dev2acc_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
                    this.dev2soft_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";
                    this.dev2soft_serv_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + comboBox3.Text + "%'";

                    first_print_check = 1;

                    LLC_add();

                    if (dev2sup_ЗапросDataGridView.RowCount - 1 > count_sup)
                        sup_add1();
                    else
                        sup_add();
                    
                }
            }
        }

        private void add_care_pack_Button_Click(object sender, EventArgs e)
        {
            if (first_print_check != 1)
            {
                MessageBox.Show("Сначала выберите принтер!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            for (int i = 0; i <= dev2care_ЗапросDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(dev2care_ЗапросDataGridView[8, i].Value) == "True")            //если (vote_gar == true)
                {

                    this.database2_TESTDataSet.vibor1.Rows.Add(null, dev2care_ЗапросDataGridView[2, i].Value, dev2care_ЗапросDataGridView[3, i].Value, dev2care_ЗапросDataGridView[4, i].Value, dev2care_ЗапросDataGridView[6, i].Value);

                    //Notes.Add(new Note ( Convert.ToString(dev2care_ЗапросDataGridView[2, i].Value), Convert.ToString(dev2care_ЗапросDataGridView[3, i].Value), Convert.ToString(dev2care_ЗапросDataGridView[4, i].Value), Convert.ToString(dev2care_ЗапросDataGridView[6, i].Value), null, null, null, null, null, null, null, null, null, null));

                }

            }
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
            for (int i = 0; i <= dev2LLC_ЗапросDataGridView.RowCount - 1; i++)
            {       
                dev2LLC_ЗапросDataGridView[13, i].Value = "True";       //ставим галку выбора для LLC

                if (Convert.ToString(dev2LLC_ЗапросDataGridView[11, i].Value) == "True")                     //    если используется в MONO
                {
                    qty_m = copy_m_proj / (Convert.ToDouble(dev2LLC_ЗапросDataGridView[8, i].Value));           //кол-во_копий_напечатает_моно_этот_узел = объём_печати_моно_проект/ресурс_узла  
                    absolut_mono = absolut_mono + ((Convert.ToDouble(dev2LLC_ЗапросDataGridView[7, i].Value) / Convert.ToDouble(dev2LLC_ЗапросDataGridView[8, i].Value))* Convert.ToDouble(dev2LLC_ЗапросDataGridView[6, i].Value)); //абсолют=цена_ресурса/ресурс_этого_ресурса* qty
                }
                else
                    qty_m = 0;

                if (Convert.ToString(dev2LLC_ЗапросDataGridView[10, i].Value) == "True")                     //  если используется в COLOR
                {
                    qty_c = copy_c_proj / (Convert.ToDouble(dev2LLC_ЗапросDataGridView[8, i].Value));           //кол-во_копий_напечатает_цвет_этот_узел = объём_печати_цвет_проект/ресурс_узла
                    absolut_color = absolut_color + ((Convert.ToDouble(dev2LLC_ЗапросDataGridView[7, i].Value) / Convert.ToDouble(dev2LLC_ЗапросDataGridView[8, i].Value)) * Convert.ToDouble(dev2LLC_ЗапросDataGridView[6, i].Value));  //абсолют=цена_ресурса/ресурс_этого_ресурса* qty
                }
                else
                    qty_c = 0;

                this.database2_TESTDataSet.vibor1.Rows.Add(null, dev2LLC_ЗапросDataGridView[4, i].Value, dev2LLC_ЗапросDataGridView[5, i].Value, dev2LLC_ЗапросDataGridView[7, i].Value, dev2LLC_ЗапросDataGridView[12, i].Value, qty_m, qty_c, dev2LLC_ЗапросDataGridView[6, i].Value, dev2LLC_ЗапросDataGridView[9, i].Value, copy_m_proj, copy_c_proj);
       
                //Notes.Add(new Note( Convert.ToString(dev2LLC_ЗапросDataGridView[4, i].Value), Convert.ToString(dev2LLC_ЗапросDataGridView[5, i].Value), Convert.ToString(dev2LLC_ЗапросDataGridView[7, i].Value), Convert.ToString(dev2LLC_ЗапросDataGridView[12, i].Value), Convert.ToString(qty_m), Convert.ToString(qty_c), Convert.ToString(dev2LLC_ЗапросDataGridView[6, i].Value), Convert.ToString(dev2LLC_ЗапросDataGridView[9, i].Value), Convert.ToString(copy_m_proj), Convert.ToString(copy_c_proj), Convert.ToString(textBox1.Text), Convert.ToString(textBox2.Text), null, null ));

            }

        }


        void sup_add1()
        {
            Data.copy_m_proj = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(comboBox9.Text);    //объём_печати_моно_проект = объём_печати_моно * срок_контракта
            Data.copy_c_proj = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(comboBox9.Text);    //объём печати_цвет_проект = объём_печати_цвет * срок_контракта
            this.vibor1TableAdapter.Update(this.database2_TESTDataSet.vibor1);
            this.vibor1TableAdapter.Fill(this.database2_TESTDataSet.vibor1);
            Data.Value1 = comboBox3.Text;
            Data.Value2 = comboBox4.Text;          
            vote_sup vote_sup = new vote_sup();
            vote_sup.ShowDialog();
            if (vote_sup.DialogResult == DialogResult.OK)
            {
                this.vibor1TableAdapter.Update(this.database2_TESTDataSet.vibor1);
                this.vibor1TableAdapter.Fill(this.database2_TESTDataSet.vibor1);
            }
            else
                 MessageBox.Show("Ничего не добавлено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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

            for (int i = 0; i <= dev2sup_ЗапросDataGridView.RowCount - 1; i++)
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

                //Notes.Add(new Note(Convert.ToString(dev2sup_ЗапросDataGridView[3, i].Value), Convert.ToString(dev2sup_ЗапросDataGridView[4, i].Value), Convert.ToString(dev2sup_ЗапросDataGridView[6, i].Value), Convert.ToString(dev2sup_ЗапросDataGridView[11, i].Value), Convert.ToString(qty_m), Convert.ToString(qty_c), Convert.ToString(dev2sup_ЗапросDataGridView[5, i].Value), Convert.ToString(dev2sup_ЗапросDataGridView[8, i].Value), Convert.ToString(copy_m_proj), Convert.ToString(copy_c_proj), null, null, null, null));

            }
        }

        

        private void add_acc_Button_Click(object sender, EventArgs e)           //добавить акс
        {
            if (first_print_check != 1)
            {
                MessageBox.Show("Сначала выберите принтер!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i <= dev2acc_ЗапросDataGridView.RowCount - 1; i++)
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
            for (int i = 0; i <= vibor1DataGridView.RowCount - 1; i++)
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
            vivodDataGridView[5, z].Value = "аренда в месяц";
            vivodDataGridView[6, z].Value = "цена копии моно";
            vivodDataGridView[8, z].Value = "затраты на печать проект";
            vivodDataGridView[9, z].Value = "затраты на аренду проект";
            vivodDataGridView[10, z].Value = "всего затрат";
        }


        private void CALCULATE ()
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
            double straxovka = 0;
            double strax = 0;
            double cost_vith_LRF = 0;
            double LRF = 0;
            double nacenka_oboryd_p = 0;


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

            for (int i = 0; i <= vibor1DataGridView.RowCount - 1; i++)
            {

                if (Convert.ToString(vibor1DataGridView[1, i].Value) == "Printer" || Convert.ToString(vibor1DataGridView[1, i].Value) == "accessory" || Convert.ToString(vibor1DataGridView[1, i].Value) == "Garanty")
                {                                   //36*(0,1/12)

                    straxovka = Convert.ToDouble(comboBox9.Text) * (Convert.ToDouble(textBox11.Text) / 12);

                    //цена_принт_акса_гарантии = цена_нименов * кол-во(1) * срок_проекта + наценка_оборудов_месяц * срок контракта
                    cost_print = cost_print + (Convert.ToDouble(vibor1DataGridView[3, i].Value) * Convert.ToDouble(vibor1DataGridView[4, i].Value));
                    //цена_принт_акса_гарантии = цена_нименов * кол-во(1) * срок_проекта * LRf * dur_proj
                    cost_vith_LRF = cost_vith_LRF + (Convert.ToDouble(vibor1DataGridView[3, i].Value) * Convert.ToDouble(vibor1DataGridView[4, i].Value) * Convert.ToDouble(comboBox11.Text) * Convert.ToDouble(comboBox9.Text));

                    //ТУТ БАГ???? входная строка неверного формата (lrf= ,.)
                    //straxovka = (Convert.ToDouble(textBox11.Text) * cost_print );
                    //strax = strax + (cost_print * straxovka);
                    //strax_na_vivod = strax_na_vivod + test_strax;

                    //cost_print = cost_print + test_strax;
                }
                strax = cost_print * straxovka;

                //LRF = цена_с_ЛРФ - цена_без_ЛРФ
                LRF = (cost_vith_LRF - cost_print);


                if (Convert.ToString(vibor1DataGridView[1, i].Value) == "soft")
                    cost_soft = cost_soft + Convert.ToDouble(vibor1DataGridView[3, i].Value);

                if (Convert.ToString(vibor1DataGridView[1, i].Value) == "soft_serv")
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

            //ВЫВОД В БЕЗ НАЦЕНКИ
            if (radioButton13.Checked == true)

            {
                //for (int i = 0; i < Convert.ToDouble(quantity_textBox.Text); i++)
                //   name                                      kol-vo          v_pech_mono    v_pech_color     cost_pech_month        цена_моно    цена_цвет  затраты_печать_п  затраты_аренд_п                 все_затраты
                this.database2_TESTDataSet.vivod_itog_2.Rows.Add(null, vibor1DataGridView[2, 0].Value, Convert.ToDouble(quantity_textBox.Text), textBox1.Text, textBox2.Text, cost_print / dur_project, cost_one_m, cost_one_c, cost1 + cost2, cost_print, LRF, strax, cost1 + cost2 + cost_vith_LRF + strax);

            }
            else
                this.database2_TESTDataSet.vivod_itog_2.Rows.Add(null, vibor1DataGridView[2, 0].Value, vibor1DataGridView[4, 0].Value, v_pech_mono, v_pech_mono, (cost_print - (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(comboBox9.Text))) / dur_project, cost_one_m, cost_one_c, cost1 + cost2, cost_print - (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(comboBox9.Text)), cost1 + cost2 + cost_print);


            double cost_print2 = cost_vith_LRF + strax + (trash_2 * dur_project);        //* total_copy  //  + накладные расходы на устройство //+ (Convert.ToDouble(textBox3.Text))
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


            //наценка_оборуд_проект = наценка_оборудов_месяц * срок контракта
            nacenka_oboryd_p = (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(comboBox9.Text));
            double arenda_proj = cost_print2 - nacenka_oboryd_p;



            //DialogResult dialogResult = MessageBox.Show("Сформировать коммерческое предложение?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    PDF();
            //}




            DialogResult dialogResult = MessageBox.Show("АРЕНДА_ПРОЕКТ(dev+acc+gar)*LRF= " + arenda_proj +
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
                "\n cost_one_color + наценка= " + cost_one_c +
                "\n страховка= " + strax+
                "\n" +
                "\n" +
                "\n" +
                "\n СФОРМИРОВАТЬ PDF файл??? ", 
                "PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            try

            {    //ВРЕМЕННО!!!!!!!!!!!!!!!!!!!!!!!!!
                //ExportToExcel(1, textBox1.Text, textBox2.Text, last_cost / dur_project, cost_one_m, cost_one_c, cost1 + cost2, cost_print, cost_print + cost1 + cost2);
                //vivod();

                //int i = 0;
                int z = 0;
                for (int i = 0; i <= vibor1DataGridView.RowCount - 1; i++)
                {
                    this.database2_TESTDataSet.vivod.Rows.Add(null, vibor1DataGridView[1, i].Value, vibor1DataGridView[2, i].Value, vibor1DataGridView[3, i].Value, vibor1DataGridView[9, i].Value, vibor1DataGridView[10, i].Value, "---", "---");
                    z = i;
                }
                //this.database2_TESTDataSet.vivod.Rows.Add();
                z++;
                this.database2_TESTDataSet.vivod.Rows.Add(null, "---", "---", "---", "---", "---", "---", "---");



                double zatrati_print_nac = (cost1 * ((Convert.ToDouble(textBox6.Text) / 100) + 1) + (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox1.Text))) + (cost2 * ((Convert.ToDouble(textBox7.Text) / 100) + 1) + (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox2.Text)));
                //this.database2_TESTDataSet.vivod.Rows.Add(null, "---", "кол-во устройств", "объём печати моно в мес", "аренда в месяц", "цена копии моно", "затраты на печать проект");

                if (radioButton13.Checked == true)          //НАЦЕНКИ
                {
                    this.database2_TESTDataSet.vivod_itog.Rows.Add(null, vibor1DataGridView[2, 0].Value, quantity_textBox.Text, textBox1.Text, textBox2.Text, arenda_proj / dur_project, cost_one_m, cost_one_c, Convert.ToString(zatrati_print_nac), arenda_proj, (zatrati_print_nac + arenda_proj), vibor1DataGridView[1, 0].Value);
                    for (int i = 0; i <= vibor1DataGridView.RowCount - 1; i++)
                    {
                        if (Convert.ToString(vibor1DataGridView[1, i].Value) == "accessory")
                        {

                            this.database2_TESTDataSet.vivod_itog.Rows.Add(null, vibor1DataGridView[2, i].Value, vibor1DataGridView[4, i].Value, 0, 0, 0, 0, 0, 0, vibor1DataGridView[3, i].Value, 0, vibor1DataGridView[1, i].Value);   //, 0, 0, 0, 0, 0, 0, 0
                        }
                    }
                }
                else
                    this.database2_TESTDataSet.vivod_itog.Rows.Add(null, vibor1DataGridView[2, 0].Value, vibor1DataGridView[4, 0].Value, v_pech_mono, v_pech_mono, "тест", cost_one_m, cost_one_c, "test", arenda_proj, cost1 + cost2 + arenda_proj);

                //this.database2_TESTDataSet.vivod.Rows.Add(null, "---", "кол-во устройств", "объём печати моно в мес", "аренда в месяц", "цена копии моно", "затраты на печать проект");

                //this.database2_TESTDataSet.vivod_itog_2.Rows.Add(null, vibor1DataGridView[2, 0].Value, vibor1DataGridView[4, 0].Value, textBox1.Text, textBox2.Text, cost_print / dur_project, cost_one_m, cost_one_c, cost1 + cost2, arenda_proj, cost1 + cost2 + arenda_proj);

                if (dialogResult == DialogResult.Yes)
                {
                    PDF();
                }

            }
            catch
            {
                MessageBox.Show("файл не создан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            clear_vibor();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2LLC". При необходимости она может быть перемещена или удалена.
            this.dev2LLCTableAdapter.Fill(this.database2_TESTDataSet.Dev2LLC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.DurForCRF". При необходимости она может быть перемещена или удалена.
            this.durForCRFTableAdapter.Fill(this.database2_TESTDataSet.DurForCRF);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.proc_Запрос". При необходимости она может быть перемещена или удалена.
            this.proc_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.proc_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vivod_itog_2". При необходимости она может быть перемещена или удалена.
            //this.vivod_itog_2TableAdapter.Fill(this.database2_TESTDataSet.vivod_itog_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vivod_itog". При необходимости она может быть перемещена или удалена.
            //this.vivod_itogTableAdapter.Fill(this.database2_TESTDataSet.vivod_itog);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.vivod". При необходимости она может быть перемещена или удалена.
            //this.vivodTableAdapter.Fill(this.database2_TESTDataSet.vivod);
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


            textBox1.Clear();
            textBox2.Clear();
            comboBox9.Text = "";

        }


        private void button9_Click(object sender, EventArgs e)          //кнопка РАСЧЁТ
        {
            CALCULATE();
 


        }





        private void button11_Click(object sender, EventArgs e)
        {
            int my_work = 0;
            int contract_work = 0;
            int komandir = 0;
            int more_service = 0;
            if (comboBox6.Text.Length > 0)
            {
                if (radioButton5.Checked == true) my_work = 1;
                if (radioButton6.Checked == true) my_work = 2;
            }
            if (comboBox5.Text.Length > 0)
            {
                if (radioButton7.Checked == true) contract_work = 1;
                if (radioButton8.Checked == true) contract_work = 2;
            }
            if (comboBox7.Text.Length > 0)
            {
                if (radioButton9.Checked == true) komandir = 1;
                if (radioButton10.Checked == true) komandir = 2;
            }
            if (comboBox8.Text.Length > 0)
            {
                if (radioButton11.Checked == true) more_service = 1;
                if (radioButton12.Checked == true) more_service = 2;
            }

            // все условия + срок_контракта
            Notes[0].n1 = Convert.ToString(textBox5.Text);
            Notes[0].n2 = Convert.ToString(textBox6.Text);
            Notes[0].n3 = Convert.ToString(textBox7.Text);
            Notes[0].n4 = Convert.ToString(textBox11.Text);
            Notes[0].n5 = Convert.ToString(textBox3.Text);
            Notes[0].n6 = Convert.ToString(textBox4.Text);
            Notes[0].n7 = Convert.ToString(textBox9.Text);


            // все условия контракта
            Notes[1].n1 = Convert.ToString(my_work);
            Notes[1].n2 = Convert.ToString(comboBox6.Text);
            Notes[1].n3 = Convert.ToString(contract_work);
            Notes[1].n4 = Convert.ToString(comboBox5.Text);
            Notes[1].n5 = Convert.ToString(komandir);
            Notes[1].n6 = Convert.ToString(comboBox7.Text);
            Notes[1].n7 = Convert.ToString(more_service);
            Notes[1].n8 = Convert.ToString(comboBox8.Text);



            FileStream file1 = new FileStream("1.txt", FileMode.Open); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file1); // создаем «потоковый читатель» и связываем его с файловым потоком

            for (int i = 0; i < 2; i++)
            {

                writer.WriteLine(Notes[i].n1 + "_" + Notes[i].n2 + "_" + Notes[i].n3 + "_" + Notes[i].n4 + "_" + Notes[i].n5 + "_" + Notes[i].n6 + "_" + Notes[i].n7 + "_" + Notes[i].n8 + "_" + Notes[i].n9);
                //Notes[i].n1
            }

            writer.Close(); //закрываем поток



            //List<Note> Notes;

            //Notes = new List<Note>();

            //File.Create("new_file.txt");
            //char[] array = {'h', 'e', 'l'};
            //string str =  new string(array);


            //for (int i = 0; i < printerDataGridView.RowCount - 1; i++)
            {

                //if (Convert.ToString(printerDataGridView[11, i].Value) == "True")



                //Notes.Add(new Note(Convert.ToString(printerDataGridView[1, i].Value), Convert.ToString(printerDataGridView[2, i].Value), Convert.ToString(printerDataGridView[3, i].Value)));
            }


            ////FileStream file1 = new FileStream("new_file.txt", FileMode.Open); //открытие существующего файла
            ////StreamReader reader = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком 


            //listBox1.Items.Add(reader.ReadLine());//считываем все данные с потока и выводим на экран
            
            //listBox1.Items.Add(reader.Read());//считываем все данные с потока и выводим на экран
            //listBox1.Items.Add(reader.Read(array, 0, 3));//считываем все данные с потока и выводим на экран
            ////reader.Read(array, 0, 3);//считываем все данные с потока и выводим на экран

            //reader.Read(str);//считываем все данные с потока и выводим на экран

            ////listBox1.Items.Add(str);//считываем все данные с потока и выводим на экран                //+ array[2] + array[4]
            //listBox1.Items.Add(array[2]);//считываем все данные с потока и выводим на экран
            //listBox1.Items.Add(array[4]);//считываем все данные с потока и выводим на экран
            //listBox1.Items.Add(array[3]);//считываем все данные с потока и выводим на экран
            //listBox1.Items.Add(array[3]);//считываем все данные с потока и выводим на экран

            //listBox1.Items.Add(reader.Read(array, 0, 4));//считываем все данные с потока и выводим на экран
            ////reader.Close(); //закрываем поток

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
            if (first_print_check != 1)
            {
                MessageBox.Show("Сначала выберите принтер!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i <= dev2soft_ЗапросDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(dev2soft_ЗапросDataGridView[9, i].Value) == "True")
                {
                    this.database2_TESTDataSet.vibor1.Rows.Add(null, dev2soft_ЗапросDataGridView[4, i].Value, dev2soft_ЗапросDataGridView[5, i].Value, dev2soft_ЗапросDataGridView[6, i].Value, dev2soft_ЗапросDataGridView[8, i].Value);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (first_print_check != 1)
            {
                MessageBox.Show("Сначала выберите принтер!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            for (int i = 0; i <= dev2soft_ЗапросDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(dev2soft_serv_ЗапросDataGridView[9, i].Value) == "True")
                {
                    this.database2_TESTDataSet.vibor1.Rows.Add(null, dev2soft_serv_ЗапросDataGridView[4, i].Value, dev2soft_serv_ЗапросDataGridView[5, i].Value, dev2soft_serv_ЗапросDataGridView[6, i].Value, dev2soft_serv_ЗапросDataGridView[8, i].Value);
                }
            }
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
            
            clear_vibor();
            textBox1.Clear();
            textBox2.Clear();
            comboBox9.Text = "";

            
        }

        void clear_vibor()
        {
            first_print_check = 0;
            //for (int i = vibor1DataGridView.Rows.Count; i > 0; i++)
                //Notes.RemoveAt(i);

            while (vibor1DataGridView.Rows.Count >= 1)
                for (int i = 0; i <= vibor1DataGridView.Rows.Count - 1; i++)
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


        private void printerDataGridView_Click_1(object sender, EventArgs e)
        {
            int i = printerDataGridView.CurrentCell.RowIndex;
            comboBox3.Text = Convert.ToString(printerDataGridView[0, i].Value);         // = АКТИВНАЯ МОДЕЛЬ ПРИНТЕРА
            comboBox4.Text = Convert.ToString(printerDataGridView[2, i].Value);         // = АКТИВНАЯ МОДЕЛЬ ПРИНТЕРА
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }




        public class Note
        {
            //public int x, y, z;
            public string n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14;
            public Note (string n1, string n2, string n3, string n4, string n5, string n6, string n7, string n8, string n9, string n10, string n11, string n12, string n13, string n14)
            {
                this.n1 = n1;
                this.n2 = n2;
                this.n3 = n3;
                this.n4 = n4;
                this.n5 = n5;
                this.n6 = n6;
                this.n7 = n7;
                this.n8 = n8;
                this.n9 = n9;
                this.n10 = n10;
                this.n11 = n11;
                this.n12 = n12;
                this.n13 = n13;
                this.n14 = n14;

            }
            //public List<Note> Notes = new List<Note>();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
        }








        private static void AppendToDocument(string sourcePdfPath1, string sourcePdfPath2, string outputPdfPath)
        {
            using (var sourceDocumentStream1 = new FileStream(sourcePdfPath1, FileMode.Open))
            {
                using (var sourceDocumentStream2 = new FileStream(sourcePdfPath2, FileMode.Open))
                {
                    using (var destinationDocumentStream = new FileStream(outputPdfPath, FileMode.Create ))
                    {
                        var pdfConcat = new PdfConcatenate(destinationDocumentStream);
                        var pdfReader = new PdfReader(sourceDocumentStream1);

                        var pages = new List<int>();
                        //for (int i = 0; i < pdfReader.NumberOfPages; i++)
                        {
                            pages.Add(0);
                            pages.Add(1);
                            pages.Add(2);
                            pages.Add(3);
                            pages.Add(4);
                            pages.Add(5);
                            pages.Add(6);
                            pages.Add(7);
                            pages.Add(8);
                        }

                        pdfReader.SelectPages(pages);
                        pdfConcat.AddPages(pdfReader);

                        pdfReader = new PdfReader(sourceDocumentStream2);

                        pages = new List<int>();
                        //for (int i = 0; i < pdfReader.NumberOfPages; i++)
                        {
                            //pages.Add(i);
                            pages.Add(0);
                            pages.Add(1);

                        }

                        pdfReader.SelectPages(pages);
                        pdfConcat.AddPages(pdfReader);

                        pdfReader.Close();
                        pdfConcat.Close();
                    }
                }
            }
        }

       

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != 2 && tab_ch == true)
            {
                tabControl1.SelectTab(2);
                MessageBox.Show("Сначала выберите расходники!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);              
            }
        }

        private void printerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print print = new print();
            print.Show();
        }

        private void supplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sup sup = new sup();
            sup.Show();
        }

        private void lLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void carepackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            care_pack care_pack = new care_pack();
            care_pack.Show();
        }

        private void accessoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acc acc = new acc();
            acc.Show();
        }

        private void dev2acc_ЗапросDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void PDF ()
        {
            //PdfWriter.GetInstance(doc, new FileStream(path + "/Doc2.pdf", FileMode.Create));
            string myFont = @"C:\\Windows\\Fonts\\arial.ttf";
            iTextSharp.text.pdf.BaseFont bfR;
            bfR = iTextSharp.text.pdf.BaseFont.CreateFont(myFont, iTextSharp.text.pdf.BaseFont.IDENTITY_H, iTextSharp.text.pdf.BaseFont.EMBEDDED);
            // var doc = new Document();
            //var doc = new Document(PageSize.A4, 0, 0, 20, 20);
            //var doc = new Document( 0, 0, 20, 20);
            var pgSize = new iTextSharp.text.Rectangle(960, 540);
            var doc = new iTextSharp.text.Document(pgSize, -70, -70, 0, 0);
            //doc.SetPageSize(PageSize.A4.Rotate());      //albom arientation
            //doc.SetPageSize(PageSize.A4, 0, 0, 0, 0);


            SaveFileDialog savef = new SaveFileDialog();
            savef.Filter = "pdf|*.*";       
            savef.Title = "Сохранить КП как...";
            savef.DefaultExt = ".pdf";      
            savef.OverwritePrompt = true;
            savef.ShowDialog();
            string filename = savef.FileName;
            PdfWriter.GetInstance(doc, new FileStream(System.Windows.Forms.Application.StartupPath + @"\Document.pdf", FileMode.Create));
            doc.Open();
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(System.Windows.Forms.Application.StartupPath + @"/prim_ras.jpg");
            jpg.Alignment = Element.ALIGN_CENTER;
            doc.Add(jpg);
            PdfPTable table = new PdfPTable(12);     //col-vo stolbov
            PdfPCell cell01 = new PdfPCell(new Phrase("№", new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
            PdfPCell cell0 = new PdfPCell(new Phrase("Тип", new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
            PdfPCell cell1 = new PdfPCell(new Phrase("Название", new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
            PdfPCell cell2 = new PdfPCell(new Phrase("Кол-во", new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
            PdfPCell cell3 = new PdfPCell(new Phrase("Объём моно печати", new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
            PdfPCell cell4 = new PdfPCell(new Phrase("Объём цвет печати", new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
            PdfPCell cell5 = new PdfPCell(new Phrase("Абон в месяц", new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
            PdfPCell cell6 = new PdfPCell(new Phrase("Цена моно копии", new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
            PdfPCell cell7 = new PdfPCell(new Phrase("Цена цвет копии", new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
            PdfPCell cell8 = new PdfPCell(new Phrase("Затраты на печать", new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
            PdfPCell cell9 = new PdfPCell(new Phrase("Затраты на аренду", new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
            PdfPCell cell10 = new PdfPCell(new Phrase("Все затраты", new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)));
            //iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfR, 12, iTextSharp.text.Font.NORMAL, clrBlack);
            //cell.BackgroundColor = new BaseColor(Color.Red);
            //cell.Padding = 5;               //visota in pix
            //cell.Colspan = 4;               //shirina in cells
            //cell.HorizontalAlignment = Element.ALIGN_CENTER;
            //table.TotalWidth = 800;
            //cell.MinimumHeight = LAST_CELL_HEIGHT;
            //table.AddCell(cell);        //vstavili 1 simple_table
            float[] widths = new float[] { 4, 10, 30, 7, 10, 10, 10, 10, 10, 10, 10, 10 };
            table.SetWidths(widths);

            table.AddCell(cell01);
            table.AddCell(cell0);
            table.AddCell(cell1);
            table.AddCell(cell2);
            table.AddCell(cell3);
            table.AddCell(cell4);
            table.AddCell(cell5);
            table.AddCell(cell6);
            table.AddCell(cell7);
            table.AddCell(cell8);
            table.AddCell(cell9);
            table.AddCell(cell10);
            //table.AddCell("type_dev");
            //table.AddCell("kol-vo");
            //table.AddCell("v_pech_mono");
            //table.AddCell("v_pech_color");
            //table.AddCell("abon in month");
            //table.AddCell("cost mono copy");
            //table.AddCell("cost color copy");
            //table.AddCell("zatrati pech_p");
            //table.AddCell("zatrati arend_p");
            //table.AddCell("all cost");

            //Math.Round(Convert.ToDouble(vivod_itogDataGridView[1, 0].Value), 2);
            int k = 1;
            for (int i = 0; i <= vivod_itogDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(vivod_itogDataGridView[1, i].Value) == "Printer")
                    table.AddCell(Convert.ToString(k++));
                else
                    table.AddCell("");

                table.AddCell(Convert.ToString(vivod_itogDataGridView[1, i].Value));
                table.AddCell(Convert.ToString(vivod_itogDataGridView[2, i].Value));
                table.AddCell(Convert.ToString(Math.Round(Convert.ToDouble(vivod_itogDataGridView[3, i].Value), 0)));
                table.AddCell(Convert.ToString(Math.Round(Convert.ToDouble(vivod_itogDataGridView[4, i].Value), 0)));
                table.AddCell(Convert.ToString(Math.Round(Convert.ToDouble(vivod_itogDataGridView[5, i].Value), 0)));
                table.AddCell(Convert.ToString(Math.Round(Convert.ToDouble(vivod_itogDataGridView[6, i].Value), 2)));
                table.AddCell(Convert.ToString(Math.Round(Convert.ToDouble(vivod_itogDataGridView[7, i].Value), 2)));
                table.AddCell(Convert.ToString(Math.Round(Convert.ToDouble(vivod_itogDataGridView[8, i].Value), 0)));
                table.AddCell(Convert.ToString(Math.Round(Convert.ToDouble(vivod_itogDataGridView[9, i].Value), 0)));
                table.AddCell(Convert.ToString(Math.Round(Convert.ToDouble(vivod_itogDataGridView[10, i].Value), 0)));
                table.AddCell(Convert.ToString(Math.Round(Convert.ToDouble(vivod_itogDataGridView[11, i].Value), 0)));
            }

            //jpg = iTextSharp.text.Image.GetInstance(System.Windows.Forms.Application.StartupPath + @"/left.jpg");
            //cell = new PdfPCell(jpg);
            //cell.Padding = 5;
            //cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            //table.AddCell(cell);
            //cell = new PdfPCell(new Phrase("Col 2 Row 3"));
            //cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            //cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            //table.AddCell(cell);
            //jpg = iTextSharp.text.Image.GetInstance(System.Windows.Forms.Application.StartupPath + @"/right.jpg");
            //cell = new PdfPCell(jpg);
            //cell.Padding = 5;
            //cell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
            //table.AddCell(cell);
            doc.Add(table);
            doc.Close();

            // Document document = new Document();
            //PdfCopy copy = new PdfSmartCopy(document, new FileStream("1.pdf", FileMode.Create));
            //document.Open();
            //PdfReader reader;
            //String line = readLine();
            //// loop over readers
            //// add the PDF to PdfCopy
            //reader = new PdfReader(baos.toByteArray());
            //copy.addDocument(reader);
            //reader.close();
            //// end loop
            //document.close();

            AppendToDocument("2.pdf", "Document.pdf", "TEST.pdf");
            AppendToDocument("TEST.pdf", "3.pdf", filename);            // + ".pdf"

            MessageBox.Show("commercial offer was created!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PDF();
        }


        private void printerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            import_print import_print = new import_print();
            import_print.Show();
        }

        private void lLCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            import_LLC import_LLC = new import_LLC();
            import_LLC.Show();
        }

        private void supplyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            import_sup import_sup = new import_sup();
            import_sup.Show();
        }

        private void accessoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            import_acc import_acc = new import_acc();
            import_acc.Show();
        }

        private void carepackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            import_care_pack import_care_pack = new import_care_pack();
            import_care_pack.Show();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = null;
            // File.Create("test.txt");
            FileStream file1 = new FileStream("2_test.txt", FileMode.Open); //создаем файловый поток
            StreamReader reader = new StreamReader(file1); // создаем «потоковый читатель» и связываем его с файловым потоком
            for (int i = 0; i < 10; i++)
            {
                s1 = reader.ReadLine();
                String[] words = s1.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

                if (words[0] == "Printer" && i != 0)
                    CALCULATE();
                //for (int j = 0; j < 2; j++)
                {
                    if (words[0] == "Printer")
                        this.database2_TESTDataSet.vibor1.Rows.Add(null, words[0], words[1], words[2], words[3], words[4]);
                    else
                    this.database2_TESTDataSet.vibor1.Rows.Add(null, words[0], words[1], words[2], words[3], words[4], words[5], words[6], words[7], words[8]);
                }
            }
            reader.Close(); //закрываем поток
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream file1 = new FileStream("1.txt", FileMode.Append); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file1); // создаем «потоковый читатель» и связываем его с файловым потоком
            for (int i = 2; i <= vibor1DataGridView.RowCount + 1; i++)
            {

                writer.WriteLine(Notes[i].n1 + "_" + Notes[i].n2 + "_" + Notes[i].n3 + "_" + Notes[i].n4 + "_" + Notes[i].n5 + "_" + Notes[i].n6 + "_" + Notes[i].n7 + "_" + Notes[i].n8 + "_" + Notes[i].n9);
                //Notes[i].n1
            }
            writer.Close(); //закрываем поток


        }
    }







    public class Metric
    {
        public int Alpha { get; set; }
        public int Beta { get; set; }
        public int Gamma { get; set; }
        public int Delta { get; set; }
    }


    static class Data
    {
        public static string Value1 { get; set; }
        public static string Value2 { get; set; }
        public static string Value3 { get; set; }
        public static double copy_m_proj { get; set; }
        public static double copy_c_proj { get; set; }

    }




}
