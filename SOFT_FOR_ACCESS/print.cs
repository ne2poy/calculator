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
    public partial class print : Form
    {
        public print()
        {
            InitializeComponent();
        }

        private void add_print_button_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= printerDataGridView.RowCount - 1; i++)
                {
                    if (Convert.ToString(printerDataGridView[0, i].Value) == textBox_id_dev.Text)
                    {
                        printerDataGridView[0, i].Value = textBox_id_dev.Text;
                        printerDataGridView[2, i].Value = textBox_name_dev.Text;
                        //printerDataGridView[3, i].Value = textBox_qty_dev.Text;
                        printerDataGridView[4, i].Value = textBox_format.Text;
                        printerDataGridView[5, i].Value = textBox_speed.Text;
                        //printerDataGridView[6, i].Value = textBox_type_print.Text;
                        printerDataGridView[7, i].Value = textBox_cost.Text;
                        //printerDataGridView[8, i].Value = textBox_speed.Text;
                        printerDataGridView[10, i].Value = textBox_tip_print.Text;
                        printerDataGridView[11, i].Value = textBox_nagryzka.Text;

                        this.printerTableAdapter.Update(this.database2_TESTDataSet.Printer);
                        this.printerTableAdapter.Fill(this.database2_TESTDataSet.Printer);

                        MessageBox.Show("printer запись изменена!", "успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }





                this.database2_TESTDataSet.Printer.Rows.Add(textBox_id_dev.Text, "Printer", textBox_name_dev.Text, 0, textBox_format.Text, Convert.ToDouble(textBox_speed.Text), 0, textBox_cost.Text, 1, null, textBox_tip_print.Text, Convert.ToDouble(textBox_nagryzka.Text) );
                this.printerTableAdapter.Update(this.database2_TESTDataSet.Printer);

                MessageBox.Show("Запись добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Validate();
                this.printerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);
            }
            catch
            {
                MessageBox.Show("Не добавлено/отредактировано!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void printerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.printerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);

        }

        private void print_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Printer". При необходимости она может быть перемещена или удалена.
            this.printerTableAdapter.Fill(this.database2_TESTDataSet.Printer);

        }

        private void textBox_id_dev_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= printerDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(printerDataGridView[0, i].Value) == textBox_id_dev.Text)
                {
                    MessageBox.Show("printer с таким id уже существует!", "info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox_name_dev.Text = Convert.ToString(printerDataGridView[0, i].Value);
                    textBox_name_dev.Text = Convert.ToString(printerDataGridView[2, i].Value);
                    textBox_format.Text = Convert.ToString(printerDataGridView[4, i].Value);
                    textBox_speed.Text = Convert.ToString(printerDataGridView[5, i].Value);
                    textBox_cost.Text = Convert.ToString(printerDataGridView[7, i].Value);
                    textBox_tip_print.Text = Convert.ToString(printerDataGridView[10, i].Value);
                    textBox_nagryzka.Text = Convert.ToString(printerDataGridView[11, i].Value);
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.printerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);
        }
    }
}
