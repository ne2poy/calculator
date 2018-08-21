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
    public partial class care_pack : Form
    {
        public care_pack()
        {
            InitializeComponent();
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void printerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.printerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);

        }

        private void care_pack_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Care_pack". При необходимости она может быть перемещена или удалена.
            this.care_packTableAdapter.Fill(this.database2_TESTDataSet.Care_pack);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2care_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2care_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2care_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2care". При необходимости она может быть перемещена или удалена.
            this.dev2careTableAdapter.Fill(this.database2_TESTDataSet.Dev2care);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Printer". При необходимости она может быть перемещена или удалена.
            this.printerTableAdapter.Fill(this.database2_TESTDataSet.Printer);

        }

        private void add_new_gar_button_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < care_packDataGridView.RowCount - 1; i++)
                {
                    if (Convert.ToString(care_packDataGridView[0, i].Value) == textBox_id_gar.Text)
                    {
                        care_packDataGridView[0, i].Value = textBox_id_gar.Text;
                        care_packDataGridView[2, i].Value = textBox_tip_gar.Text;
                        care_packDataGridView[3, i].Value = textBox_cost_gar.Text;
                        care_packDataGridView[4, i].Value = textBox_dlit_gar.Text;
                        this.care_packTableAdapter.Update(this.database2_TESTDataSet.Care_pack);
                        this.care_packTableAdapter.Fill(this.database2_TESTDataSet.Care_pack);


                        MessageBox.Show("garanty запись изменена!", "успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        return;
                    }
                }
                this.database2_TESTDataSet.Care_pack.Rows.Add(textBox_id_gar.Text, "Garanty", textBox_tip_gar.Text, textBox_cost_gar.Text, textBox_dlit_gar.Text, 1);
                this.care_packTableAdapter.Update(this.database2_TESTDataSet.Care_pack);

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
                        for (int j = 0; j < dev2care_ЗапросDataGridView.RowCount - 1; j++)
                        {
                            if (Convert.ToString(dev2care_ЗапросDataGridView[7, j].Value) == Convert.ToString(printerDataGridView[0, i].Value) && Convert.ToString(dev2care_ЗапросDataGridView[1, j].Value) == comboBox1.Text)
                                ch = 1;
                        }

                        if (ch == 0)
                        {
                            this.database2_TESTDataSet.Dev2care.Rows.Add(null, printerDataGridView[0, i].Value, comboBox1.Text);
                            this.dev2careTableAdapter.Update(this.database2_TESTDataSet.Dev2care);
                            this.dev2care_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2care_Запрос);
                        }

                    }
                    else
                    {
                        for (int j = 0; j < dev2careDataGridView.RowCount - 1; j++)
                        {
                            if (Convert.ToString(dev2careDataGridView[1, j].Value) == Convert.ToString(printerDataGridView[0, i].Value) && Convert.ToString(dev2careDataGridView[2, j].Value) == comboBox1.Text)
                            {


                                this.database2_TESTDataSet.Dev2care.Rows[j].Delete();
                                this.dev2careTableAdapter.Update(this.database2_TESTDataSet.Dev2care);
                                this.dev2care_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2care_Запрос);
                            }
                        }
                    }


                }
                MessageBox.Show("Успех!", "Найс", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                load_care_table();
            }
            catch
            {
                MessageBox.Show("Не добавлена связь!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void load_care_table()
        {
            this.care_packTableAdapter.Update(this.database2_TESTDataSet.Care_pack);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2gar_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2care_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2care_Запрос);
            this.dev2care_ЗапросBindingSource.Filter = "[Care_pack_id_gar] LIKE'" + comboBox1.Text + "'";


            for (int i = 0; i < printerDataGridView.RowCount - 1; i++)
            {
                printerDataGridView[9, i].Value = "False";
                for (int j = 0; j < dev2care_ЗапросDataGridView.RowCount - 1; j++)
                {

                    if (Convert.ToString(printerDataGridView[0, i].Value) == Convert.ToString(dev2care_ЗапросDataGridView[7, j].Value))
                        printerDataGridView[9, i].Value = "True";

                }
            }
        }

        private void textBox_id_gar_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < care_packDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(care_packDataGridView[0, i].Value) == textBox_id_gar.Text)
                {
                    MessageBox.Show("care_pack с таким id уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox_tip_gar.Text = Convert.ToString(care_packDataGridView[2, i].Value);
                    textBox_cost_gar.Text = Convert.ToString(care_packDataGridView[3, i].Value);
                    textBox_dlit_gar.Text = Convert.ToString(care_packDataGridView[4, i].Value);
                    return;
                }
            }
        }

        private void add_gar_CheckedChanged(object sender, EventArgs e)
        {
            if (add_gar.Checked == true)
            {
                printerDataGridView.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                button3.Enabled = false;


                add_new_gar_button.Enabled = true;
                textBox_id_gar.Enabled = true;
                textBox_tip_gar.Enabled = true;
                textBox_cost_gar.Enabled = true;
                textBox_dlit_gar.Enabled = true;
                load_care_table();
            }
            else
            {
                printerDataGridView.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                button3.Enabled = true;


                add_new_gar_button.Enabled = false;
                textBox_id_gar.Enabled = false;
                textBox_tip_gar.Enabled = false;
                textBox_cost_gar.Enabled = false;
                textBox_dlit_gar.Enabled = false;
                load_care_table();
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            load_care_table();
        }
    }
}
