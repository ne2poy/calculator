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
    public partial class del_printer : Form
    {
        public del_printer()
        {
            InitializeComponent();
        }

        private void printerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.printerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);

        }

        private void del_printer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Printer". При необходимости она может быть перемещена или удалена.
            this.printerTableAdapter.Fill(this.database2_TESTDataSet.Printer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = printerDataGridView.SelectedRows[0].Index;
            printerDataGridView.Rows.RemoveAt(ind);
            printerDataGridView.Refresh();

        }

        private void del_printer_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.printerTableAdapter.Update(this.database2_TESTDataSet.Printer);
                this.printerTableAdapter.Fill(this.database2_TESTDataSet.Printer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при удалении записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
