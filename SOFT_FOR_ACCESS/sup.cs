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

        private void add_new_sup_button_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= supplyDataGridView.RowCount - 1; i++)
                {
                    if (Convert.ToString(supplyDataGridView[0, i].Value) == textBox_id_sup.Text)
                    {
                        supplyDataGridView[2, i].Value = textBox_name_sup.Text;
                        supplyDataGridView[3, i].Value = textBox_qty_sup.Text;
                        supplyDataGridView[4, i].Value = textBox_cost_sup.Text;
                        supplyDataGridView[5, i].Value = textBox_res_sup.Text;
                        supplyDataGridView[6, i].Value = checkBox1.Checked;
                        supplyDataGridView[7, i].Value = checkBox2.Checked;
                        supplyDataGridView[8, i].Value = checkBox3.Checked;
                        this.supplyTableAdapter.Update(this.database2_TESTDataSet.supply);
                        this.supplyTableAdapter.Fill(this.database2_TESTDataSet.supply);


                        MessageBox.Show("sup запись изменена!", "успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        return;
                    }
                }



                //id_svyaz,     id_dev,     id_sup,             id_sup,              type,      name_sup,       QTY_sup,                             cost_sup,       res_sup,                       inbox_sup, for_color_sup, for_mono_sup, kol-vo, vote_gar


                this.database2_TESTDataSet.supply.Rows.Add(textBox_id_sup.Text, "supply", textBox_name_sup.Text, Convert.ToDouble(textBox_qty_sup.Text), textBox_cost_sup.Text, Convert.ToDouble(textBox_res_sup.Text), checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, 1);
                this.supplyTableAdapter.Update(this.database2_TESTDataSet.supply);

                MessageBox.Show("Запись добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
                MessageBox.Show("Не добавлено/отредактировано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void textBox_id_sup_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= supplyDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(supplyDataGridView[0, i].Value) == textBox_id_sup.Text)
                {
                    MessageBox.Show("supply с таким id уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox_name_sup.Text = Convert.ToString(supplyDataGridView[2, i].Value);
                    textBox_qty_sup.Text = Convert.ToString(supplyDataGridView[3, i].Value);
                    textBox_cost_sup.Text = Convert.ToString(supplyDataGridView[4, i].Value);
                    textBox_res_sup.Text = Convert.ToString(supplyDataGridView[5, i].Value);
                    if (Convert.ToString(supplyDataGridView[6, i].Value) == "True") checkBox1.Checked = true;
                    else checkBox1.Checked = false;
                    if (Convert.ToString(supplyDataGridView[7, i].Value) == "True") checkBox2.Checked = true;
                    else checkBox2.Checked = false;
                    if (Convert.ToString(supplyDataGridView[8, i].Value) == "True") checkBox3.Checked = true;
                    else checkBox2.Checked = false;
                    return;
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

                //printerDataGridView.DefaultCellStyle.BackColor = "ControlDark";

                add_new_sup_button.Enabled = true;
                textBox_id_sup.Enabled = true;
                textBox_name_sup.Enabled = true;
                textBox_qty_sup.Enabled = true;
                textBox_cost_sup.Enabled = true;
                textBox_res_sup.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                load_sup_table();
            }
            else
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

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            load_sup_table();
        }

        private void connect_sup_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
