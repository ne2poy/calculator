namespace SOFT_FOR_ACCESS
{
    partial class Form2
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
            this.carepackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2_TESTDataSet = new SOFT_FOR_ACCESS.Database2_TESTDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idvibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typevibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namevibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viborBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.care_packTableAdapter = new SOFT_FOR_ACCESS.Database2_TESTDataSetTableAdapters.Care_packTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new SOFT_FOR_ACCESS.Database2_TESTDataSetTableAdapters.TableAdapterManager();
            this.vivodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vivodTableAdapter = new SOFT_FOR_ACCESS.Database2_TESTDataSetTableAdapters.vivodTableAdapter();
            this.vivodDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carepackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viborBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vivodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vivodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // carepackBindingSource
            // 
            this.carepackBindingSource.DataMember = "Care_pack";
            this.carepackBindingSource.DataSource = this.database2_TESTDataSet;
            // 
            // database2_TESTDataSet
            // 
            this.database2_TESTDataSet.DataSetName = "Database2_TESTDataSet";
            this.database2_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvibDataGridViewTextBoxColumn,
            this.typevibDataGridViewTextBoxColumn,
            this.namevibDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.kolvoDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.viborBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // idvibDataGridViewTextBoxColumn
            // 
            this.idvibDataGridViewTextBoxColumn.DataPropertyName = "id_vib";
            this.idvibDataGridViewTextBoxColumn.HeaderText = "id_vib";
            this.idvibDataGridViewTextBoxColumn.Name = "idvibDataGridViewTextBoxColumn";
            // 
            // typevibDataGridViewTextBoxColumn
            // 
            this.typevibDataGridViewTextBoxColumn.DataPropertyName = "type_vib";
            this.typevibDataGridViewTextBoxColumn.HeaderText = "type_vib";
            this.typevibDataGridViewTextBoxColumn.Name = "typevibDataGridViewTextBoxColumn";
            // 
            // namevibDataGridViewTextBoxColumn
            // 
            this.namevibDataGridViewTextBoxColumn.DataPropertyName = "name_vib";
            this.namevibDataGridViewTextBoxColumn.HeaderText = "name_vib";
            this.namevibDataGridViewTextBoxColumn.Name = "namevibDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // kolvoDataGridViewTextBoxColumn1
            // 
            this.kolvoDataGridViewTextBoxColumn1.DataPropertyName = "kol-vo";
            this.kolvoDataGridViewTextBoxColumn1.HeaderText = "kol-vo";
            this.kolvoDataGridViewTextBoxColumn1.Name = "kolvoDataGridViewTextBoxColumn1";
            // 
            // viborBindingSource
            // 
            this.viborBindingSource.DataMember = "vibor";
            this.viborBindingSource.DataSource = this.database2_TESTDataSet;
            // 
            // care_packTableAdapter
            // 
            this.care_packTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(887, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "ЗАПОЛНИТЬ2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.tableAdapterManager.OB_SVTableAdapter = null;
            this.tableAdapterManager.PrinterTableAdapter = null;
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
            this.tableAdapterManager.vivodTableAdapter = null;
            this.tableAdapterManager.Копия_PrinterTableAdapter = null;
            // 
            // vivodBindingSource
            // 
            this.vivodBindingSource.DataMember = "vivod";
            this.vivodBindingSource.DataSource = this.database2_TESTDataSet;
            // 
            // vivodTableAdapter
            // 
            this.vivodTableAdapter.ClearBeforeFill = true;
            // 
            // vivodDataGridView
            // 
            this.vivodDataGridView.AutoGenerateColumns = false;
            this.vivodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vivodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.vivodDataGridView.DataSource = this.vivodBindingSource;
            this.vivodDataGridView.Location = new System.Drawing.Point(1, -2);
            this.vivodDataGridView.Name = "vivodDataGridView";
            this.vivodDataGridView.Size = new System.Drawing.Size(967, 200);
            this.vivodDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_vivod";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_vivod";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type_viv";
            this.dataGridViewTextBoxColumn2.HeaderText = "type_viv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name_viv";
            this.dataGridViewTextBoxColumn3.HeaderText = "name_viv";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn4.HeaderText = "cost";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "kol-vo";
            this.dataGridViewTextBoxColumn5.HeaderText = "kol-vo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "service1";
            this.dataGridViewTextBoxColumn6.HeaderText = "service1";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "service2";
            this.dataGridViewTextBoxColumn7.HeaderText = "service2";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "service3";
            this.dataGridViewTextBoxColumn8.HeaderText = "service3";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "service4";
            this.dataGridViewCheckBoxColumn1.HeaderText = "service4";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(474, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.vivodDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carepackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viborBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vivodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vivodDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database2_TESTDataSet database2_TESTDataSet;
        private System.Windows.Forms.BindingSource carepackBindingSource;
        private Database2_TESTDataSetTableAdapters.Care_packTableAdapter care_packTableAdapter;
        private System.Windows.Forms.BindingSource viborBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typevibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namevibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Database2_TESTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vivodBindingSource;
        private Database2_TESTDataSetTableAdapters.vivodTableAdapter vivodTableAdapter;
        private System.Windows.Forms.DataGridView vivodDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button button3;
    }
}