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
    public partial class sup : Form
    {
        public sup()
        {
            InitializeComponent();
        }

        private void printerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.printerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);

        }

        private void sup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.supply". При необходимости она может быть перемещена или удалена.
            this.supplyTableAdapter.Fill(this.database2_TESTDataSet.supply);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2sup_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2sup_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2sup_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2sup". При необходимости она может быть перемещена или удалена.
            this.dev2supTableAdapter.Fill(this.database2_TESTDataSet.Dev2sup);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Printer". При необходимости она может быть перемещена или удалена.
            this.printerTableAdapter.Fill(this.database2_TESTDataSet.Printer);
        }


        private void clear_field()
        {
            textBox_id_sup.Text = "";
            textBox_name_sup.Text = "";
            textBox_qty_sup.Text = "";
            textBox_cost_sup.Text = "";
            textBox_res_sup.Text = "";
            textBox1.Text = "";
            comboBox3.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }



        private void add_new_sup_button_Click(object sender, EventArgs e)
        {
            if (textBox_id_sup.Text.Length > 0 && textBox_name_sup.Text.Length > 0 && textBox_qty_sup.Text.Length > 0 && textBox_cost_sup.Text.Length > 0 && textBox_res_sup.Text.Length > 0 && textBox1.Text.Length > 0 && comboBox3.Text.Length > 0)
            try
            {
                for (int i = 0; i <= supplyDataGridView.RowCount - 1; i++)
                {
                    if (Convert.ToString(supplyDataGridView[0, i].Value) == textBox_id_sup.Text)
                    {
                            //supplyDataGridView[2, i].Value = textBox_name_sup.Text;
                            //supplyDataGridView[3, i].Value = textBox_qty_sup.Text;
                            //supplyDataGridView[4, i].Value = textBox_cost_sup.Text;
                            //supplyDataGridView[5, i].Value = textBox_res_sup.Text;
                            //supplyDataGridView[6, i].Value = checkBox1.Checked;
                            //supplyDataGridView[7, i].Value = checkBox2.Checked;
                            //supplyDataGridView[8, i].Value = checkBox3.Checked;
                            //this.supplyTableAdapter.Update(this.database2_TESTDataSet.supply);
                            //this.supplyTableAdapter.Fill(this.database2_TESTDataSet.supply);
                            //MessageBox.Show("sup запись изменена!", "успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            MessageBox.Show("Запись с таким id уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            clear_field();
                            return;
                    }
                }
                this.database2_TESTDataSet.supply.Rows.Add(textBox_id_sup.Text, "supply", textBox_name_sup.Text, Convert.ToDouble(textBox_qty_sup.Text), textBox_cost_sup.Text, Convert.ToDouble(textBox_res_sup.Text), checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, 1, null, textBox1.Text, comboBox3.Text);
                this.supplyTableAdapter.Update(this.database2_TESTDataSet.supply);

                MessageBox.Show("Запись добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    comboBox1.Text = textBox_id_sup.Text;
                    comboBox2.Text = textBox_name_sup.Text;
                    clear_field();

                }
                catch
            {
                MessageBox.Show("Не добавлено/отредактировано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("Заполните все поля!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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
                        for (int j = 0; j <= dev2sup_ЗапросDataGridView.RowCount - 1; j++)
                        {
                            if (Convert.ToString(dev2sup_ЗапросDataGridView[1, j].Value) == Convert.ToString(printerDataGridView[0, i].Value) && Convert.ToString(dev2sup_ЗапросDataGridView[2, j].Value) == comboBox1.Text)
                                ch = 1;
                        }

                        if (ch == 0)
                        {
                            this.database2_TESTDataSet.Dev2sup.Rows.Add(null, printerDataGridView[0, i].Value, comboBox1.Text);
                            this.dev2supTableAdapter.Update(this.database2_TESTDataSet.Dev2sup);
                            this.dev2sup_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2sup_Запрос);
                        }

                    }
                    else
                    {
                        for (int j = 0; j <= dev2supDataGridView.RowCount - 1; j++)
                        {
                            if (Convert.ToString(dev2supDataGridView[1, j].Value) == Convert.ToString(printerDataGridView[0, i].Value) && Convert.ToString(dev2supDataGridView[2, j].Value) == comboBox1.Text)
                            {


                                this.database2_TESTDataSet.Dev2sup.Rows[j].Delete();
                                this.dev2supTableAdapter.Update(this.database2_TESTDataSet.Dev2sup);
                                this.dev2sup_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2sup_Запрос);
                            }
                        }
                    }


                }
                MessageBox.Show("Успех!", "Найс", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                load_sup_table();
            }
            catch
            {
                MessageBox.Show("Не добавлена связь!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void load_sup_table()
        {
            this.supplyTableAdapter.Update(this.database2_TESTDataSet.supply);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2sup_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2sup_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2sup_Запрос);
            this.dev2sup_ЗапросBindingSource.Filter = "[id_sup] LIKE'" + comboBox1.Text + "'";


            for (int i = 0; i <= printerDataGridView.RowCount - 1; i++)
            {
                printerDataGridView[9, i].Value = "False";
                for (int j = 0; j <= dev2sup_ЗапросDataGridView.RowCount - 1; j++)
                {

                    if (Convert.ToString(printerDataGridView[0, i].Value) == Convert.ToString(dev2sup_ЗапросDataGridView[1, j].Value))
                        printerDataGridView[9, i].Value = "True";

                }
            }
        }


        private void add_sup_CheckedChanged(object sender, EventArgs e)
        {
            if (add_sup.Checked == true)
            {
                printerDataGridView.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                button3.Enabled = false;

                add_new_sup_button.Enabled = true;
                textBox_id_sup.Enabled = true;
                textBox_name_sup.Enabled = true;
                textBox_qty_sup.Enabled = true;
                textBox_cost_sup.Enabled = true;
                textBox_res_sup.Enabled = true;
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
            load_sup_table();
        }

        private void connect_sup_CheckedChanged(object sender, EventArgs e)
        {
            if (connect_sup.Checked == true)
            {
                printerDataGridView.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                button3.Enabled = true;

                add_new_sup_button.Enabled = false;
                textBox_id_sup.Enabled = false;
                textBox_name_sup.Enabled = false;
                textBox_qty_sup.Enabled = false;
                textBox_cost_sup.Enabled = false;
                textBox_res_sup.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                load_sup_table();
            }

        }

        private void textBox_id_sup_Leave(object sender, EventArgs e)
        {
            if (textBox_id_sup.Text.Length > 0)
                for (int i = 0; i <= supplyDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(supplyDataGridView[0, i].Value) == textBox_id_sup.Text)
                {
                    MessageBox.Show("supply с таким id уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        clear_field();
                    return;
                }
            }

        }
    }
}
