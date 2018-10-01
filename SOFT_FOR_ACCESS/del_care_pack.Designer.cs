namespace SOFT_FOR_ACCESS
{
    partial class del_care_pack
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
            this.care_packBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.care_packTableAdapter = new SOFT_FOR_ACCESS.Database2_TESTDataSetTableAdapters.Care_packTableAdapter();
            this.tableAdapterManager = new SOFT_FOR_ACCESS.Database2_TESTDataSetTableAdapters.TableAdapterManager();
            this.care_packDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database2_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.care_packBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.care_packDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database2_TESTDataSet
            // 
            this.database2_TESTDataSet.DataSetName = "Database2_TESTDataSet";
            this.database2_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // care_packBindingSource
            // 
            this.care_packBindingSource.DataMember = "Care_pack";
            this.care_packBindingSource.DataSource = this.database2_TESTDataSet;
            // 
            // care_packTableAdapter
            // 
            this.care_packTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._123TableAdapter = null;
            this.tableAdapterManager.AccessoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Care_packTableAdapter = this.care_packTableAdapter;
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
            // care_packDataGridView
            // 
            this.care_packDataGridView.AllowUserToAddRows = false;
            this.care_packDataGridView.AllowUserToDeleteRows = false;
            this.care_packDataGridView.AutoGenerateColumns = false;
            this.care_packDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.care_packDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.care_packDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.care_packDataGridView.DataSource = this.care_packBindingSource;
            this.care_packDataGridView.Location = new System.Drawing.Point(0, 0);
            this.care_packDataGridView.MultiSelect = false;
            this.care_packDataGridView.Name = "care_packDataGridView";
            this.care_packDataGridView.ReadOnly = true;
            this.care_packDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.care_packDataGridView.Size = new System.Drawing.Size(788, 405);
            this.care_packDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_gar";
            this.dataGridViewTextBoxColumn1.FillWeight = 84.76043F;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn2.FillWeight = 60.36769F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tip_gar";
            this.dataGridViewTextBoxColumn3.FillWeight = 274.1117F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Название";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cost_gar";
            this.dataGridViewTextBoxColumn4.FillWeight = 62.26461F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dlit_gar";
            this.dataGridViewTextBoxColumn5.FillWeight = 70.14912F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Длительность";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "kol-vo";
            this.dataGridViewTextBoxColumn6.FillWeight = 48.34648F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "vote_gar";
            this.dataGridViewCheckBoxColumn1.HeaderText = "vote_gar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // del_care_pack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.care_packDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "del_care_pack";
            this.Text = "Удалить гарантию";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.del_care_pack_FormClosed);
            this.Load += new System.EventHandler(this.del_print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.care_packBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.care_packDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database2_TESTDataSet database2_TESTDataSet;
        private System.Windows.Forms.BindingSource care_packBindingSource;
        private Database2_TESTDataSetTableAdapters.Care_packTableAdapter care_packTableAdapter;
        private Database2_TESTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView care_packDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}