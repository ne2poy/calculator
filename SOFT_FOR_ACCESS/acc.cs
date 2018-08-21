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
    public partial class acc : Form
    {
        public acc()
        {
            InitializeComponent();
        }




        private void printerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.printerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);

        }

        private void acc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Accessory". При необходимости она может быть перемещена или удалена.
            this.accessoryTableAdapter.Fill(this.database2_TESTDataSet.Accessory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2acc_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2acc_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2acc_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2acc". При необходимости она может быть перемещена или удалена.
            this.dev2accTableAdapter.Fill(this.database2_TESTDataSet.Dev2acc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Printer". При необходимости она может быть перемещена или удалена.
            this.printerTableAdapter.Fill(this.database2_TESTDataSet.Printer);

        }

        private void add_new_acc_button_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < accessoryDataGridView.RowCount - 1; i++)
                {
                    if (Convert.ToString(accessoryDataGridView[0, i].Value) == textBox_id_acc.Text)
                    {
                        accessoryDataGridView[0, i].Value = textBox_id_acc.Text;
                        accessoryDataGridView[2, i].Value = textBox_name_dop.Text;
                        accessoryDataGridView[3, i].Value = checkBox1.Checked;
                        accessoryDataGridView[4, i].Value = textBox_cost.Text;
                        this.accessoryTableAdapter.Update(this.database2_TESTDataSet.Accessory);
                        this.accessoryTableAdapter.Fill(this.database2_TESTDataSet.Accessory);

                        MessageBox.Show("accessory запись изменена!", "успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        return;
                    }
                }

                this.database2_TESTDataSet.Accessory.Rows.Add(textBox_id_acc.Text, "accessory", textBox_name_dop.Text, checkBox1.Checked, textBox_cost.Text, 1);
                this.accessoryTableAdapter.Update(this.database2_TESTDataSet.Accessory);

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
                for (int i = 0; i < printerDataGridView.RowCount - 1; i++)
                {
                    if (Convert.ToString(printerDataGridView[9, i].Value) == "True")
                    {
                        ch = 0;
                        for (int j = 0; j < dev2acc_ЗапросDataGridView.RowCount - 1; j++)
                        {
                            if (Convert.ToString(dev2acc_ЗапросDataGridView[1, j].Value) == Convert.ToString(printerDataGridView[0, i].Value) && Convert.ToString(dev2acc_ЗапросDataGridView[2, j].Value) == comboBox1.Text)
                                ch = 1;
                        }

                        if (ch == 0)
                        {
                            this.database2_TESTDataSet.Dev2acc.Rows.Add(null, printerDataGridView[0, i].Value, comboBox1.Text);
                            this.dev2accTableAdapter.Update(this.database2_TESTDataSet.Dev2acc);
                            this.dev2acc_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2acc_Запрос);
                        }

                    }
                    else
                    {
                        for (int j = 0; j < dev2accDataGridView.RowCount - 1; j++)
                        {
                            if (Convert.ToString(dev2accDataGridView[1, j].Value) == Convert.ToString(printerDataGridView[0, i].Value) && Convert.ToString(dev2accDataGridView[2, j].Value) == comboBox1.Text)
                            {


                                this.database2_TESTDataSet.Dev2acc.Rows[j].Delete();
                                this.dev2accTableAdapter.Update(this.database2_TESTDataSet.Dev2acc);
                                this.dev2acc_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2acc_Запрос);
                            }
                        }
                    }


                }
                MessageBox.Show("Успех!", "Найс", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                load_acc_table();
            }
            catch
            {
                MessageBox.Show("Не добавлена связь!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }


        private void load_acc_table()
        {
            this.accessoryTableAdapter.Update(this.database2_TESTDataSet.Accessory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2acc_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2acc_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2acc_Запрос);
            this.dev2acc_ЗапросBindingSource.Filter = "[dev2acc_id_acc] LIKE'" + comboBox1.Text + "'";


            for (int i = 0; i < printerDataGridView.RowCount - 1; i++)
            {
                printerDataGridView[9, i].Value = "False";
                for (int j = 0; j < dev2acc_ЗапросDataGridView.RowCount - 1; j++)
                {

                    if (Convert.ToString(printerDataGridView[0, i].Value) == Convert.ToString(dev2acc_ЗапросDataGridView[1, j].Value))
                        printerDataGridView[9, i].Value = "True";

                }
            }
        }

        private void textBox_id_acc_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < accessoryDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(accessoryDataGridView[0, i].Value) == textBox_id_acc.Text)
                {
                    MessageBox.Show("accessory с таким id уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox_name_dop.Text = Convert.ToString(accessoryDataGridView[2, i].Value);
                    if (Convert.ToString(accessoryDataGridView[3, i].Value) == "True") checkBox1.Checked = true;
                    else checkBox1.Checked = false;
                    textBox_cost.Text = Convert.ToString(accessoryDataGridView[4, i].Value);
                    return;
                }
            }
        }

       

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            load_acc_table();

        }

        private void add_acc_CheckedChanged(object sender, EventArgs e)
        {
            if (add_acc.Checked == true)
            {
                printerDataGridView.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                button3.Enabled = false;

                //printerDataGridView.DefaultCellStyle.BackColor = "ControlDark";

                add_new_acc_button.Enabled = true;
                textBox_id_acc.Enabled = true;
                textBox_name_dop.Enabled = true;
                textBox_cost.Enabled = true;
                checkBox1.Enabled = true;
                load_acc_table();
            }
            else
            {
                printerDataGridView.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                button3.Enabled = true;


                add_new_acc_button.Enabled = false;
                textBox_id_acc.Enabled = false;
                textBox_name_dop.Enabled = false;
                textBox_cost.Enabled = false;
                checkBox1.Enabled = false;
                load_acc_table();
            }
        }
    }
}
