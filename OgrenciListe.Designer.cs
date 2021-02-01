namespace DersHaneOTM
{
    partial class OgrenciListe
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
            this.dershaneLoginDataSet = new DersHaneOTM.DershaneLoginDataSet();
            this.ogrenciKayıtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciKayıtTableAdapter = new DersHaneOTM.DershaneLoginDataSetTableAdapters.OgrenciKayıtTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciKayıtBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tckimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayıttarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tckimlikDataGridViewTextBoxColumn,
            this.dogumtarihiDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.alanDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.kayıttarihiDataGridViewTextBoxColumn,
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
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1063, 500);
            this.dataGridView1.TabIndex = 2;
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
            this.numaraDataGridViewTextBoxColumn.HeaderText = "Numara";
            this.numaraDataGridViewTextBoxColumn.Name = "numaraDataGridViewTextBoxColumn";
            this.numaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tckimlikDataGridViewTextBoxColumn
            // 
            this.tckimlikDataGridViewTextBoxColumn.DataPropertyName = "tckimlik";
            this.tckimlikDataGridViewTextBoxColumn.HeaderText = "TC Kimlik No";
            this.tckimlikDataGridViewTextBoxColumn.Name = "tckimlikDataGridViewTextBoxColumn";
            this.tckimlikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dogumtarihiDataGridViewTextBoxColumn
            // 
            this.dogumtarihiDataGridViewTextBoxColumn.DataPropertyName = "dogumtarihi";
            this.dogumtarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.dogumtarihiDataGridViewTextBoxColumn.Name = "dogumtarihiDataGridViewTextBoxColumn";
            this.dogumtarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            this.cinsiyetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alanDataGridViewTextBoxColumn
            // 
            this.alanDataGridViewTextBoxColumn.DataPropertyName = "alan";
            this.alanDataGridViewTextBoxColumn.HeaderText = "Alan";
            this.alanDataGridViewTextBoxColumn.Name = "alanDataGridViewTextBoxColumn";
            this.alanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kayıttarihiDataGridViewTextBoxColumn
            // 
            this.kayıttarihiDataGridViewTextBoxColumn.DataPropertyName = "kayıttarihi";
            this.kayıttarihiDataGridViewTextBoxColumn.HeaderText = "Kayıt Tarihi";
            this.kayıttarihiDataGridViewTextBoxColumn.Name = "kayıttarihiDataGridViewTextBoxColumn";
            this.kayıttarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // velitcDataGridViewTextBoxColumn
            // 
            this.velitcDataGridViewTextBoxColumn.DataPropertyName = "velitc";
            this.velitcDataGridViewTextBoxColumn.HeaderText = "Veli TC Kimlik No";
            this.velitcDataGridViewTextBoxColumn.Name = "velitcDataGridViewTextBoxColumn";
            this.velitcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // veliadDataGridViewTextBoxColumn
            // 
            this.veliadDataGridViewTextBoxColumn.DataPropertyName = "veliad";
            this.veliadDataGridViewTextBoxColumn.HeaderText = "Veli Ad";
            this.veliadDataGridViewTextBoxColumn.Name = "veliadDataGridViewTextBoxColumn";
            this.veliadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // velisoyadDataGridViewTextBoxColumn
            // 
            this.velisoyadDataGridViewTextBoxColumn.DataPropertyName = "velisoyad";
            this.velisoyadDataGridViewTextBoxColumn.HeaderText = "Veli Soyad";
            this.velisoyadDataGridViewTextBoxColumn.Name = "velisoyadDataGridViewTextBoxColumn";
            this.velisoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // velitelefonDataGridViewTextBoxColumn
            // 
            this.velitelefonDataGridViewTextBoxColumn.DataPropertyName = "velitelefon";
            this.velitelefonDataGridViewTextBoxColumn.HeaderText = "Veli Telefon";
            this.velitelefonDataGridViewTextBoxColumn.Name = "velitelefonDataGridViewTextBoxColumn";
            this.velitelefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OgrenciListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 500);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OgrenciListe";
            this.Text = "OgrenciListe";
            this.Load += new System.EventHandler(this.OgrenciListe_Load);
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
        private System.Windows.Forms.BindingSource ogrenciKayıtBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tckimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayıttarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velitcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velisoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velitelefonDataGridViewTextBoxColumn;
    }
}