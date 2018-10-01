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
    public partial class del_LLC : Form
    {
        public del_LLC()
        {
            InitializeComponent();
        }

        private void lLCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lLCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);

        }

        private void del_LLC_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.LLC". При необходимости она может быть перемещена или удалена.
            this.lLCTableAdapter.Fill(this.database2_TESTDataSet.LLC);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = lLCDataGridView.SelectedRows[0].Index;
            lLCDataGridView.Rows.RemoveAt(ind);
            lLCDataGridView.Refresh();

        }

        private void del_LLC_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.lLCTableAdapter.Update(this.database2_TESTDataSet.LLC);
                this.lLCTableAdapter.Fill(this.database2_TESTDataSet.LLC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при удалении записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
