namespace SOFT_FOR_ACCESS
{
    partial class del_LLC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.database2_TESTDataSet = new SOFT_FOR_ACCESS.Database2_TESTDataSet();
            this.lLCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lLCTableAdapter = new SOFT_FOR_ACCESS.Database2_TESTDataSetTableAdapters.LLCTableAdapter();
            this.tableAdapterManager = new SOFT_FOR_ACCESS.Database2_TESTDataSetTableAdapters.TableAdapterManager();
            this.lLCDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database2_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLCDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database2_TESTDataSet
            // 
            this.database2_TESTDataSet.DataSetName = "Database2_TESTDataSet";
            this.database2_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lLCBindingSource
            // 
            this.lLCBindingSource.DataMember = "LLC";
            this.lLCBindingSource.DataSource = this.database2_TESTDataSet;
            // 
            // lLCTableAdapter
            // 
            this.lLCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._123TableAdapter = null;
            this.tableAdapterManager.AccessoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Care_packTableAdapter = null;
            this.tableAdapterManager.Dev2accTableAdapter = null;
            this.tableAdapterManager.Dev2careTableAdapter = null;
            this.tableAdapterManager.Dev2LLCTableAdapter = null;
            this.tableAdapterManager.Dev2soft_servTableAdapter = null;
            this.tableAdapterManager.Dev2softTableAdapter = null;
            this.tableAdapterManager.Dev2supTableAdapter = null;
            this.tableAdapterManager.DurForCRFTableAdapter = null;
            this.tableAdapterManager.LASTTableAdapter = null;
            this.tableAdapterManager.LLCTableAdapter = this.lLCTableAdapter;
            this.tableAdapterManager.matrixTableAdapter = null;
            this.tableAdapterManager.OB_SVTableAdapter = null;
            this.tableAdapterManager.PrinterTableAdapter = null;
            this.tableAdapterManager.procTableAdapter = null;
            this.tableAdapterManager.soft_devTableAdapter = null;
            this.tableAdapterManager.soft_servTableAdapter = null;
            this.tableAdapterManager.supplyTableAdapter = null;
            this.tableAdapterManager.svyaz1TableAdapter = null;
            this.tableAdapterManager.svyaz2kol_voTableAdapter = null;
            this.tableAdapterManager.Trash_2TableAdapter = null;
            this.tableAdapterManager.TrashTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SOFT_FOR_ACCESS.Database2_TESTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vibor1TableAdapter = null;
            this.tableAdapterManager.viborTableAdapter = null;
            this.tableAdapterManager.vivod_itog_2TableAdapter = null;
            this.tableAdapterManager.vivod_itogTableAdapter = null;
            this.tableAdapterManager.vivodTableAdapter = null;
            this.tableAdapterManager.Копия_PrinterTableAdapter = null;
            this.tableAdapterManager.Ошибки_вставкиTableAdapter = null;
            // 
            // lLCDataGridView
            // 
            this.lLCDataGridView.AutoGenerateColumns = false;
            this.lLCDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lLCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lLCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn4});
            this.lLCDataGridView.DataSource = this.lLCBindingSource;
            this.lLCDataGridView.Location = new System.Drawing.Point(0, 0);
            this.lLCDataGridView.MultiSelect = false;
            this.lLCDataGridView.Name = "lLCDataGridView";
            this.lLCDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lLCDataGridView.Size = new System.Drawing.Size(903, 394);
            this.lLCDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_LLC";
            this.dataGridViewTextBoxColumn1.FillWeight = 68.31059F;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn2.FillWeight = 68.04178F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name_LLC";
            this.dataGridViewTextBoxColumn3.FillWeight = 319.797F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Название";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QTY_LLC";
            this.dataGridViewTextBoxColumn4.HeaderText = "QTY_LLC";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cost_LLC";
            this.dataGridViewTextBoxColumn5.FillWeight = 70.68958F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "res_LLC";
            this.dataGridViewTextBoxColumn6.FillWeight = 68.55212F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Ресурс";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "inbox_LLC";
            this.dataGridViewCheckBoxColumn1.HeaderText = "inbox_LLC";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "for_color_LLC";
            this.dataGridViewCheckBoxColumn2.FillWeight = 53.03212F;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Цвет";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "for_mono_LLC";
            this.dataGridViewCheckBoxColumn3.FillWeight = 51.57684F;
            this.dataGridViewCheckBoxColumn3.HeaderText = "Моно";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "kol-vo";
            this.dataGridViewTextBoxColumn7.HeaderText = "kol-vo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "vote_gar";
            this.dataGridViewCheckBoxColumn4.HeaderText = "vote_gar";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // del_LLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lLCDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "del_LLC";
            this.Text = "del_LLC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.del_LLC_FormClosed);
            this.Load += new System.EventHandler(this.del_LLC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLCDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database2_TESTDataSet database2_TESTDataSet;
        private System.Windows.Forms.BindingSource lLCBindingSource;
        private Database2_TESTDataSetTableAdapters.LLCTableAdapter lLCTableAdapter;
        private Database2_TESTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView lLCDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.Button button1;
    }
}