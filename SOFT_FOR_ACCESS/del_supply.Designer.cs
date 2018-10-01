namespace SOFT_FOR_ACCESS
{
    partial class del_supply
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
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyTableAdapter = new SOFT_FOR_ACCESS.Database2_TESTDataSetTableAdapters.supplyTableAdapter();
            this.tableAdapterManager = new SOFT_FOR_ACCESS.Database2_TESTDataSetTableAdapters.TableAdapterManager();
            this.supplyDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
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
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database2_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database2_TESTDataSet
            // 
            this.database2_TESTDataSet.DataSetName = "Database2_TESTDataSet";
            this.database2_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplyBindingSource
            // 
            this.supplyBindingSource.DataMember = "supply";
            this.supplyBindingSource.DataSource = this.database2_TESTDataSet;
            // 
            // supplyTableAdapter
            // 
            this.supplyTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LLCTableAdapter = null;
            this.tableAdapterManager.matrixTableAdapter = null;
            this.tableAdapterManager.OB_SVTableAdapter = null;
            this.tableAdapterManager.PrinterTableAdapter = null;
            this.tableAdapterManager.procTableAdapter = null;
            this.tableAdapterManager.soft_devTableAdapter = null;
            this.tableAdapterManager.soft_servTableAdapter = null;
            this.tableAdapterManager.supplyTableAdapter = this.supplyTableAdapter;
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
            // supplyDataGridView
            // 
            this.supplyDataGridView.AllowUserToAddRows = false;
            this.supplyDataGridView.AllowUserToDeleteRows = false;
            this.supplyDataGridView.AutoGenerateColumns = false;
            this.supplyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.supplyDataGridView.DataSource = this.supplyBindingSource;
            this.supplyDataGridView.Location = new System.Drawing.Point(0, 0);
            this.supplyDataGridView.MultiSelect = false;
            this.supplyDataGridView.Name = "supplyDataGridView";
            this.supplyDataGridView.ReadOnly = true;
            this.supplyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplyDataGridView.Size = new System.Drawing.Size(973, 373);
            this.supplyDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_sup";
            this.dataGridViewTextBoxColumn1.FillWeight = 70.83154F;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn2.FillWeight = 70.83154F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name_sup";
            this.dataGridViewTextBoxColumn3.FillWeight = 387.4546F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Название";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QTY_sup";
            this.dataGridViewTextBoxColumn4.HeaderText = "QTY_sup";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cost_sup";
            this.dataGridViewTextBoxColumn5.FillWeight = 70.83154F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "res_sup";
            this.dataGridViewTextBoxColumn6.FillWeight = 70.83154F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Ресурс";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "inbox_sup";
            this.dataGridViewCheckBoxColumn1.HeaderText = "inbox_sup";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "for_sup_mono";
            this.dataGridViewCheckBoxColumn2.FillWeight = 47.23397F;
            this.dataGridViewCheckBoxColumn2.HeaderText = "Моно";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "for_sup_color";
            this.dataGridViewCheckBoxColumn3.FillWeight = 45.97208F;
            this.dataGridViewCheckBoxColumn3.HeaderText = "Цвет";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "kol-vo";
            this.dataGridViewTextBoxColumn7.FillWeight = 44.64269F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "vote_supl";
            this.dataGridViewCheckBoxColumn4.HeaderText = "vote_supl";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            this.dataGridViewCheckBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "manufacturer";
            this.dataGridViewTextBoxColumn8.FillWeight = 91.37056F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_color";
            this.dataGridViewTextBoxColumn9.HeaderText = "id_color";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // del_supply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.supplyDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "del_supply";
            this.Text = "del_supply";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.del_supply_FormClosed);
            this.Load += new System.EventHandler(this.del_supply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database2_TESTDataSet database2_TESTDataSet;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private Database2_TESTDataSetTableAdapters.supplyTableAdapter supplyTableAdapter;
        private Database2_TESTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView supplyDataGridView;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}