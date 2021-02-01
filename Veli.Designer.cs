namespace DersHaneOTM
{
    partial class Veli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dershaneLoginDataSet = new DersHaneOTM.DershaneLoginDataSet();
            this.ogrenciKayıtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciKayıtTableAdapter = new DersHaneOTM.DershaneLoginDataSetTableAdapters.OgrenciKayıtTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciKayıtBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velitcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velisoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velitelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciKayıtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciKayıtBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dershaneLoginDataSet
            // 
            this.dershaneLoginDataSet.DataSetName = "DershaneLoginDataSet";
            this.dershaneLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciKayıtBindingSource
            // 
            this.ogrenciKayıtBindingSource.DataMember = "OgrenciKayıt";
            this.ogrenciKayıtBindingSource.DataSource = this.dershaneLoginDataSet;
            // 
            // ogrenciKayıtTableAdapter
            // 
            this.ogrenciKayıtTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numaraDataGridViewTextBoxColumn,
            this.velitcDataGridViewTextBoxColumn,
            this.veliadDataGridViewTextBoxColumn,
            this.velisoyadDataGridViewTextBoxColumn,
            this.velitelefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciKayıtBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrenciKayıtBindingSource1
            // 
            this.ogrenciKayıtBindingSource1.DataMember = "OgrenciKayıt";
            this.ogrenciKayıtBindingSource1.DataSource = this.dershaneLoginDataSet;
            // 
            // numaraDataGridViewTextBoxColumn
            // 
            this.numaraDataGridViewTextBoxColumn.DataPropertyName = "numara";
            this.numaraDataGridViewTextBoxColumn.HeaderText = "Öğrenci Numarası";
            this.numaraDataGridViewTextBoxColumn.Name = "numaraDataGridViewTextBoxColumn";
            this.numaraDataGridViewTextBoxColumn.ReadOnly = true;
            this.numaraDataGridViewTextBoxColumn.Width = 150;
            // 
            // velitcDataGridViewTextBoxColumn
            // 
            this.velitcDataGridViewTextBoxColumn.DataPropertyName = "velitc";
            this.velitcDataGridViewTextBoxColumn.HeaderText = "Veli TC Kimlik No";
            this.velitcDataGridViewTextBoxColumn.Name = "velitcDataGridViewTextBoxColumn";
            this.velitcDataGridViewTextBoxColumn.ReadOnly = true;
            this.velitcDataGridViewTextBoxColumn.Width = 200;
            // 
            // veliadDataGridViewTextBoxColumn
            // 
            this.veliadDataGridViewTextBoxColumn.DataPropertyName = "veliad";
            this.veliadDataGridViewTextBoxColumn.HeaderText = "Veli Adı";
            this.veliadDataGridViewTextBoxColumn.Name = "veliadDataGridViewTextBoxColumn";
            this.veliadDataGridViewTextBoxColumn.ReadOnly = true;
            this.veliadDataGridViewTextBoxColumn.Width = 150;
            // 
            // velisoyadDataGridViewTextBoxColumn
            // 
            this.velisoyadDataGridViewTextBoxColumn.DataPropertyName = "velisoyad";
            this.velisoyadDataGridViewTextBoxColumn.HeaderText = "Veli Soyad";
            this.velisoyadDataGridViewTextBoxColumn.Name = "velisoyadDataGridViewTextBoxColumn";
            this.velisoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.velisoyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // velitelefonDataGridViewTextBoxColumn
            // 
            this.velitelefonDataGridViewTextBoxColumn.DataPropertyName = "velitelefon";
            this.velitelefonDataGridViewTextBoxColumn.HeaderText = "Veli Telefon";
            this.velitelefonDataGridViewTextBoxColumn.Name = "velitelefonDataGridViewTextBoxColumn";
            this.velitelefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.velitelefonDataGridViewTextBoxColumn.Width = 150;
            // 
            // Veli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Veli";
            this.Text = "Veli";
            this.Load += new System.EventHandler(this.Veli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dershaneLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciKayıtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciKayıtBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DershaneLoginDataSet dershaneLoginDataSet;
        private System.Windows.Forms.BindingSource ogrenciKayıtBindingSource;
        private DershaneLoginDataSetTableAdapters.OgrenciKayıtTableAdapter ogrenciKayıtTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velitcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velisoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velitelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ogrenciKayıtBindingSource1;
    }
}