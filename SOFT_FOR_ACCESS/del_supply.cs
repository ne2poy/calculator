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
    public partial class del_supply : Form
    {
        public del_supply()
        {
            InitializeComponent();
        }

        private void supplyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);

        }

        private void del_supply_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.supply". При необходимости она может быть перемещена или удалена.
            this.supplyTableAdapter.Fill(this.database2_TESTDataSet.supply);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = supplyDataGridView.SelectedRows[0].Index;
            supplyDataGridView.Rows.RemoveAt(ind);
            supplyDataGridView.Refresh();

        }


        private void del_supply_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.supplyTableAdapter.Update(this.database2_TESTDataSet.supply);
                this.supplyTableAdapter.Fill(this.database2_TESTDataSet.supply);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при удалении записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
