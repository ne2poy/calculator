namespace SOFT_FOR_ACCESS
{
    partial class import_print
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_sup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_print = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kol_vo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vote_dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip_print = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nagryzka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database2_TESTDataSet = new SOFT_FOR_ACCESS.Database2_TESTDataSet();
            this.printerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printerTableAdapter = new SOFT_FOR_ACCESS.Database2_TESTDataSetTableAdapters.PrinterTableAdapter();
            this.tableAdapterManager = new SOFT_FOR_ACCESS.Database2_TESTDataSetTableAdapters.TableAdapterManager();
            this.printerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_dev,
            this.type,
            this.name_dev,
            this.id_sup,
            this.format,
            this.speed,
            this.type_print,
            this.cost,
            this.kol_vo,
            this.vote_dev,
            this.tip_print,
            this.nagryzka});
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1250, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_dev
            // 
            this.id_dev.HeaderText = "id";
            this.id_dev.Name = "id_dev";
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.Name = "type";
            // 
            // name_dev
            // 
            this.name_dev.HeaderText = "Название";
            this.name_dev.Name = "name_dev";
            // 
            // id_sup
            // 
            this.id_sup.HeaderText = "id_sup";
            this.id_sup.Name = "id_sup";
            this.id_sup.Visible = false;
            // 
            // format
            // 
            this.format.HeaderText = "Формат";
            this.format.Name = "format";
            // 
            // speed
            // 
            this.speed.HeaderText = "Скорость";
            this.speed.Name = "speed";
            // 
            // type_print
            // 
            this.type_print.HeaderText = "Тип";
            this.type_print.Name = "type_print";
            // 
            // cost
            // 
            this.cost.HeaderText = "Цена";
            this.cost.Name = "cost";
            // 
            // kol_vo
            // 
            this.kol_vo.HeaderText = "Кол-во";
            this.kol_vo.Name = "kol_vo";
            // 
            // vote_dev
            // 
            this.vote_dev.HeaderText = "Выбрать";
            this.vote_dev.Name = "vote_dev";
            // 
            // tip_print
            // 
            this.tip_print.HeaderText = "tip_print";
            this.tip_print.Name = "tip_print";
            this.tip_print.Visible = false;
            // 
            // nagryzka
            // 
            this.nagryzka.HeaderText = "nagryzka";
            this.nagryzka.Name = "nagryzka";
            this.nagryzka.Visible = false;
            // 
            // database2_TESTDataSet
            // 
            this.database2_TESTDataSet.DataSetName = "Database2_TESTDataSet";
            this.database2_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printerBindingSource
            // 
            this.printerBindingSource.DataMember = "Printer";
            this.printerBindingSource.DataSource = this.database2_TESTDataSet;
            // 
            // printerTableAdapter
            // 
            this.printerTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PrinterTableAdapter = this.printerTableAdapter;
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
            // printerDataGridView
            // 
            this.printerDataGridView.AutoGenerateColumns = false;
            this.printerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.printerDataGridView.DataSource = this.printerBindingSource;
            this.printerDataGridView.Location = new System.Drawing.Point(12, 167);
            this.printerDataGridView.Name = "printerDataGridView";
            this.printerDataGridView.Size = new System.Drawing.Size(1228, 148);
            this.printerDataGridView.TabIndex = 2;
            this.printerDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_dev";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_dev";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn2.HeaderText = "type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name_dev";
            this.dataGridViewTextBoxColumn3.HeaderText = "name_dev";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_sup";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_sup";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "format";
            this.dataGridViewTextBoxColumn5.HeaderText = "format";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "speed";
            this.dataGridViewTextBoxColumn6.HeaderText = "speed";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "type_print";
            this.dataGridViewTextBoxColumn7.HeaderText = "type_print";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn8.HeaderText = "cost";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "kol-vo";
            this.dataGridViewTextBoxColumn9.HeaderText = "kol-vo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "vote_dev";
            this.dataGridViewCheckBoxColumn1.HeaderText = "vote_dev";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "tip_print";
            this.dataGridViewTextBoxColumn10.HeaderText = "tip_print";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "nagryzka";
            this.dataGridViewTextBoxColumn11.HeaderText = "nagryzka";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Обзор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Импорт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // import_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 391);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.printerDataGridView);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "import_print";
            this.Text = "import_print";
            this.Load += new System.EventHandler(this.import_print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database2_TESTDataSet database2_TESTDataSet;
        private System.Windows.Forms.BindingSource printerBindingSource;
        private Database2_TESTDataSetTableAdapters.PrinterTableAdapter printerTableAdapter;
        private Database2_TESTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView printerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn format;
        private System.Windows.Forms.DataGridViewTextBoxColumn speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_print;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn kol_vo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vote_dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip_print;
        private System.Windows.Forms.DataGridViewTextBoxColumn nagryzka;
    }
}