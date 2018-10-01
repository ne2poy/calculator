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
    public partial class del_acc : Form
    {
        public del_acc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    int ind = accessoryDataGridView.SelectedRows[0].Index;
                    accessoryDataGridView.Rows.RemoveAt(ind);
                    accessoryDataGridView.Refresh();
        }

        private void accessoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accessoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);

        }

        private void del_acc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Accessory". При необходимости она может быть перемещена или удалена.
            this.accessoryTableAdapter.Fill(this.database2_TESTDataSet.Accessory);

        }

        private void del_acc_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            { 
            this.accessoryTableAdapter.Update(this.database2_TESTDataSet.Accessory);
            this.accessoryTableAdapter.Fill(this.database2_TESTDataSet.Accessory);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при удалении записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}
    }
}
