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
    
    public partial class vote_sup : Form
    {

        public vote_sup()
        {
            
            InitializeComponent();
            
        }

        private void vote_sup_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2_TESTDataSet.Dev2sup_Запрос". При необходимости она может быть перемещена или удалена.
            this.dev2sup_ЗапросTableAdapter.Fill(this.database2_TESTDataSet.Dev2sup_Запрос);

            this.dev2sup_ЗапросBindingSource.Filter = "[id_dev] LIKE'" + Data.Value1 + "%'";
            textBox1.Text = Data.Value1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dev2sup_ЗапросDataGridView.RowCount - 1; i++)
            {
                if (Convert.ToString(dev2sup_ЗапросDataGridView[12, i].Value) == "True")
                {


                }


            }
        }








    }
}
