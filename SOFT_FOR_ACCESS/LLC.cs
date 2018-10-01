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
    public partial class LLC : Form
    {
        public LLC()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "LLC". При необходимости она может быть перемещена или удалена.
            this.llcTableAdapter1.Fill(this.database2_TESTDataSet.LLC);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Printer". При необходимости она может быть перемещена или удалена.
            this.printerTableAdapter.Fill(this.database2_TESTDataSet.Printer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2LLC_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2LLC_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2LLC_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2LLC". При необходимости она может быть перемещена или удалена.
            this.dev2LLCTableAdapter.Fill(this.database2_TESTDataSet.Dev2LLC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2LLC_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2LLC_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2LLC_Запрос);
        }


        private void clear_field()
        {
            textBox_id_LLC.Text = "";
            textBox_name_LLC.Text = "";
            textBox_qty_LLC.Text = "";
            textBox_cost_LLC.Text = "";
            textBox_res_LLC.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }



        private void load_LLC_table()
        {
            this.llcTableAdapter1.Update(this.database2_TESTDataSet.LLC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2LLC_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2LLC_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2LLC_Запрос);
            this.dev2LLC_ЗапросBindingSource.Filter = "[Dev2LLC_id_LLC] LIKE'" + comboBox1.Text + "'";


            for (int i = 0; i <= printerDataGridView.RowCount - 1; i++)
            {
                printerDataGridView[9, i].Value = "False";
                for (int j = 0; j <= dev2LLC_ЗапросDataGridView.RowCount - 1; j++)
                {
                    
                    if (Convert.ToString(printerDataGridView[0, i].Value) == Convert.ToString(dev2LLC_ЗапросDataGridView[1, j].Value))
                        printerDataGridView[9, i].Value = "True";

                }
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            //ТУТ БАГ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //ЕСЛИ ДОБАВИТЬ и сразу удлаить одну и ту галку, то она не удаляется. хз поч.
            try
            {
                double ch = 0;
                for (int i = 0; i <= printerDataGridView.RowCount - 1; i++)
                {
                    if (Convert.ToString(printerDataGridView[9, i].Value) == "True")
                    {
                        ch = 0;
                        for (int j = 0; j <= dev2LLC_ЗапросDataGridView.RowCount - 1; j++)
                        {
                            if (Convert.ToString(dev2LLC_ЗапросDataGridView[1, j].Value) == Convert.ToString(printerDataGridView[0, i].Value) && Convert.ToString(dev2LLC_ЗапросDataGridView[2, j].Value) == comboBox1.Text)
                                ch = 1;
                        }

                        if (ch == 0)
                        {
                            this.database2_TESTDataSet.Dev2LLC.Rows.Add(null, printerDataGridView[0, i].Value, comboBox1.Text);
                            this.dev2LLCTableAdapter.Update(this.database2_TESTDataSet.Dev2LLC);
                            this.dev2LLC_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2LLC_Запрос);
                        }

                    }
                    else
                    {
                        for (int j = 0; j <= dev2LLCDataGridView.RowCount - 1; j++)
                        {
                            if (Convert.ToString(dev2LLCDataGridView[1, j].Value) == Convert.ToString(printerDataGridView[0, i].Value) && Convert.ToString(dev2LLCDataGridView[2, j].Value) == comboBox1.Text)
                            {
                                // Convert.ToString(dev2LLC_ЗапросDataGridView[1, j].Value)


                                this.database2_TESTDataSet.Dev2LLC.Rows[j].Delete();
                                this.dev2LLCTableAdapter.Update(this.database2_TESTDataSet.Dev2LLC);
                                this.dev2LLC_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2LLC_Запрос);
                            }
                        }
                    }


                }
                MessageBox.Show("Успех!", "Найс", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                load_LLC_table();
            }
            catch
            {
                MessageBox.Show("Не добавлена связь!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void textBox_id_LLC_TextChanged(object sender, EventArgs e) //удалить
        {
        }


        private void add_new_LLC_button_Click(object sender, EventArgs e)
        {
            if (textBox_id_LLC.Text.Length > 0 && textBox_name_LLC.Text.Length > 0 && textBox_qty_LLC.Text.Length > 0 && textBox_cost_LLC.Text.Length > 0 && textBox_res_LLC.Text.Length > 0)
                try
                {
                for (int i = 0; i <= lLCDataGridView.RowCount - 1; i++)
                {
                    if (Convert.ToString(lLCDataGridView[0, i].Value) == textBox_id_LLC.Text)
                    {
                            //lLCDataGridView[2, i].Value = textBox_name_LLC.Text;
                            //lLCDataGridView[3, i].Value = textBox_qty_LLC.Text;
                            //lLCDataGridView[4, i].Value = textBox_cost_LLC.Text;
                            //lLCDataGridView[5, i].Value = textBox_res_LLC.Text;
                            //lLCDataGridView[6, i].Value = checkBox1.Checked;
                            //lLCDataGridView[7, i].Value = checkBox2.Checked;
                            //lLCDataGridView[8, i].Value = checkBox3.Checked;
                            //this.llcTableAdapter1.Update(this.database2_TESTDataSet.LLC);
                            //this.llcTableAdapter1.Fill(this.database2_TESTDataSet.LLC);

                            //MessageBox.Show("LLC запись изменена!", "успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            //textBox_id_LLC.Clear();
                            //textBox_name_LLC.Clear();
                            //textBox_qty_LLC.Clear();
                            //textBox_cost_LLC.Clear();
                            //textBox_res_LLC.Clear();
                            //checkBox2.Checked = true;

                            MessageBox.Show("Запись с таким id уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            clear_field();
                            return;
                    }
                }

                this.database2_TESTDataSet.LLC.Rows.Add(textBox_id_LLC.Text, "LLC", textBox_name_LLC.Text, Convert.ToDouble(textBox_qty_LLC.Text), textBox_cost_LLC.Text, Convert.ToDouble(textBox_res_LLC.Text), checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, 1);
                this.llcTableAdapter1.Update(this.database2_TESTDataSet.LLC);
                //checkBox2.Checked = true;
                MessageBox.Show("Запись добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    comboBox1.Text = textBox_id_LLC.Text;
                    comboBox2.Text = textBox_name_LLC.Text;
                    clear_field();

                }
            catch
            {
                MessageBox.Show("Не добавлено/отредактировано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("Заполните все поля!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void add_LLC_CheckedChanged(object sender, EventArgs e)
        {
            if (add_LLC.Checked == true)
            {
                printerDataGridView.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                button3.Enabled = false;


                add_new_LLC_button.Enabled = true;
                textBox_id_LLC.Enabled = true;
                textBox_name_LLC.Enabled = true;
                textBox_qty_LLC.Enabled = true;
                textBox_cost_LLC.Enabled = true;
                textBox_res_LLC.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                clear_field();

                // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Printer". При необходимости она может быть перемещена или удалена.
                this.printerTableAdapter.Fill(this.database2_TESTDataSet.Printer);

            }

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            load_LLC_table();
        }

        private void connect_LLC_CheckedChanged(object sender, EventArgs e)
        {
            if (connect_LLC.Checked == true)
            {
                printerDataGridView.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                button3.Enabled = true;

                add_new_LLC_button.Enabled = false;
                textBox_id_LLC.Enabled = false;
                textBox_name_LLC.Enabled = false;
                textBox_qty_LLC.Enabled = false;
                textBox_cost_LLC.Enabled = false;
                textBox_res_LLC.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                load_LLC_table();
            }


        }

        private void textBox_id_LLC_Leave(object sender, EventArgs e)
        {
            if (textBox_id_LLC.Text.Length > 0)
                for (int i = 0; i <= lLCDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(lLCDataGridView[0, i].Value) == textBox_id_LLC.Text)
                {
                    MessageBox.Show("LLC с таким id уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    clear_field();
                    return;
                }
            }

        }
    }
}
