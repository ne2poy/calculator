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
    public partial class del_care_pack : Form
    {
        public del_care_pack()
        {
            InitializeComponent();
        }

        private void care_packBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.care_packBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2_TESTDataSet);

        }

        private void del_print_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Care_pack". При необходимости она может быть перемещена или удалена.
            this.care_packTableAdapter.Fill(this.database2_TESTDataSet.Care_pack);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int ind = care_packDataGridView.SelectedRows[0].Index;
            care_packDataGridView.Rows.RemoveAt(ind);
            care_packDataGridView.Refresh();

        }

        private void del_care_pack_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.care_packTableAdapter.Update(this.database2_TESTDataSet.Care_pack);
                this.care_packTableAdapter.Fill(this.database2_TESTDataSet.Care_pack);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка при удалении записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
