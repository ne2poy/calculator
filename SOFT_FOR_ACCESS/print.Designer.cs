namespace SOFT_FOR_ACCESS
{
    partial class print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(print));
            this.add_print_button = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox_nagryzka = new System.Windows.Forms.TextBox();
            this.textBox_tip_print = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox_speed = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox_format = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox_name_dev = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox_id_dev = new System.Windows.Forms.TextBox();
            this.database2_TESTDataSet = new SOFT_FOR_ACCESS.Database2_TESTDataSet();
            this.printerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printerTableAdapter = new SOFT_FOR_ACCESS.Database2_TESTDataSetTableAdapters.PrinterTableAdapter();
            this.tableAdapterManager = new SOFT_FOR_ACCESS.Database2_TESTDataSetTableAdapters.TableAdapterManager();
            this.printerDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database2_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // add_print_button
            // 
            this.add_print_button.Location = new System.Drawing.Point(1163, 24);
            this.add_print_button.Name = "add_print_button";
            this.add_print_button.Size = new System.Drawing.Size(85, 23);
            this.add_print_button.TabIndex = 56;
            this.add_print_button.Text = "Добавить";
            this.add_print_button.UseVisualStyleBackColor = true;
            this.add_print_button.Click += new System.EventHandler(this.add_print_button_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(1086, 11);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(55, 13);
            this.label36.TabIndex = 55;
            this.label36.Text = "Нагрузка";
            // 
            // textBox_nagryzka
            // 
            this.textBox_nagryzka.Location = new System.Drawing.Point(1053, 27);
            this.textBox_nagryzka.Name = "textBox_nagryzka";
            this.textBox_nagryzka.Size = new System.Drawing.Size(104, 20);
            this.textBox_nagryzka.TabIndex = 54;
            // 
            // textBox_tip_print
            // 
            this.textBox_tip_print.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBox_tip_print.FormattingEnabled = true;
            this.textBox_tip_print.Items.AddRange(new object[] {
            "color",
            "mono"});
            this.textBox_tip_print.Location = new System.Drawing.Point(937, 27);
            this.textBox_tip_print.Name = "textBox_tip_print";
            this.textBox_tip_print.Size = new System.Drawing.Size(109, 21);
            this.textBox_tip_print.TabIndex = 53;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(964, 12);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(63, 13);
            this.label35.TabIndex = 52;
            this.label35.Text = "Тип печати";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(860, 12);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(33, 13);
            this.label34.TabIndex = 51;
            this.label34.Text = "Цена";
            // 
            // textBox_cost
            // 
            this.textBox_cost.Location = new System.Drawing.Point(827, 27);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(104, 20);
            this.textBox_cost.TabIndex = 50;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(638, 12);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(55, 13);
            this.label33.TabIndex = 49;
            this.label33.Text = "Скорость";
            // 
            // textBox_speed
            // 
            this.textBox_speed.Location = new System.Drawing.Point(605, 27);
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.Size = new System.Drawing.Size(104, 20);
            this.textBox_speed.TabIndex = 48;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(528, 12);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 13);
            this.label32.TabIndex = 47;
            this.label32.Text = "Формат";
            // 
            // textBox_format
            // 
            this.textBox_format.Location = new System.Drawing.Point(495, 27);
            this.textBox_format.Name = "textBox_format";
            this.textBox_format.Size = new System.Drawing.Size(104, 20);
            this.textBox_format.TabIndex = 46;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(291, 11);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(57, 13);
            this.label31.TabIndex = 45;
            this.label31.Text = "Название";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(101, 11);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(15, 13);
            this.label30.TabIndex = 44;
            this.label30.Text = "id";
            // 
            // textBox_name_dev
            // 
            this.textBox_name_dev.Location = new System.Drawing.Point(172, 27);
            this.textBox_name_dev.Name = "textBox_name_dev";
            this.textBox_name_dev.Size = new System.Drawing.Size(317, 20);
            this.textBox_name_dev.TabIndex = 43;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 30);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 13);
            this.label29.TabIndex = 42;
            this.label29.Text = "Принтер:";
            // 
            // textBox_id_dev
            // 
            this.textBox_id_dev.Location = new System.Drawing.Point(61, 27);
            this.textBox_id_dev.Name = "textBox_id_dev";
            this.textBox_id_dev.Size = new System.Drawing.Size(104, 20);
            this.textBox_id_dev.TabIndex = 41;
            this.textBox_id_dev.Leave += new System.EventHandler(this.textBox_id_dev_Leave);
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
            this.printerDataGridView.AllowUserToAddRows = false;
            this.printerDataGridView.AllowUserToDeleteRows = false;
            this.printerDataGridView.AutoGenerateColumns = false;
            this.printerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn1});
            this.printerDataGridView.DataSource = this.printerBindingSource;
            this.printerDataGridView.Location = new System.Drawing.Point(2, 66);
            this.printerDataGridView.Name = "printerDataGridView";
            this.printerDataGridView.Size = new System.Drawing.Size(1255, 409);
            this.printerDataGridView.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 109;
            this.label1.Text = "Тип принтера";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Laser",
            "PW"});
            this.comboBox1.Location = new System.Drawing.Point(715, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 110;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_dev";
            this.dataGridViewTextBoxColumn1.FillWeight = 82.08122F;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn2.FillWeight = 82.08122F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name_dev";
            this.dataGridViewTextBoxColumn3.FillWeight = 279.1878F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Название";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_sup";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_sup";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "format";
            this.dataGridViewTextBoxColumn5.FillWeight = 82.08122F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Формат";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "speed";
            this.dataGridViewTextBoxColumn6.FillWeight = 82.08122F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Скорость";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "type_print";
            this.dataGridViewTextBoxColumn7.FillWeight = 82.08122F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Тип принт";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn8.FillWeight = 82.08122F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "kol-vo";
            this.dataGridViewTextBoxColumn9.FillWeight = 82.08122F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "tip_print";
            this.dataGridViewTextBoxColumn10.FillWeight = 82.08122F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Тип печати";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "nagryzka";
            this.dataGridViewTextBoxColumn11.FillWeight = 82.08122F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Нагрузка";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "vote_dev";
            this.dataGridViewCheckBoxColumn1.FillWeight = 82.08122F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Выбрать";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 477);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printerDataGridView);
            this.Controls.Add(this.add_print_button);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.textBox_nagryzka);
            this.Controls.Add(this.textBox_tip_print);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.textBox_cost);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.textBox_speed);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.textBox_format);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.textBox_name_dev);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.textBox_id_dev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "print";
            this.Text = "print";
            this.Load += new System.EventHandler(this.print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_print_button;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBox_nagryzka;
        private System.Windows.Forms.ComboBox textBox_tip_print;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox_speed;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox_format;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox_name_dev;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox_id_dev;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}