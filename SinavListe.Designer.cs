namespace DersHaneOTM
{
    partial class SinavListe
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
            this.dershaneLoginDataSet3 = new DersHaneOTM.DershaneLoginDataSet3();
            this.sinavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinavTableAdapter = new DersHaneOTM.DershaneLoginDataSet3TableAdapters.SinavTableAdapter();
            this.numaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numaraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinavDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneLoginDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numaraDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.alanDataGridViewTextBoxColumn,
            this.puanDataGridViewTextBoxColumn,
            this.sinavDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sinavBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // dershaneLoginDataSet3
            // 
            this.dershaneLoginDataSet3.DataSetName = "DershaneLoginDataSet3";
            this.dershaneLoginDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinavBindingSource
            // 
            this.sinavBindingSource.DataMember = "Sinav";
            this.sinavBindingSource.DataSource = this.dershaneLoginDataSet3;
            // 
            // sinavTableAdapter
            // 
            this.sinavTableAdapter.ClearBeforeFill = true;
            // 
            // numaraDataGridViewTextBoxColumn
            // 
            this.numaraDataGridViewTextBoxColumn.DataPropertyName = "numara";
            this.numaraDataGridViewTextBoxColumn.HeaderText = "numara";
            this.numaraDataGridViewTextBoxColumn.Name = "numaraDataGridViewTextBoxColumn";
            this.numaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alanDataGridViewTextBoxColumn
            // 
            this.alanDataGridViewTextBoxColumn.DataPropertyName = "alan";
            this.alanDataGridViewTextBoxColumn.HeaderText = "alan";
            this.alanDataGridViewTextBoxColumn.Name = "alanDataGridViewTextBoxColumn";
            this.alanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // puanDataGridViewTextBoxColumn
            // 
            this.puanDataGridViewTextBoxColumn.DataPropertyName = "puan";
            this.puanDataGridViewTextBoxColumn.HeaderText = "puan";
            this.puanDataGridViewTextBoxColumn.Name = "puanDataGridViewTextBoxColumn";
            this.puanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sinavDataGridViewTextBoxColumn
            // 
            this.sinavDataGridViewTextBoxColumn.DataPropertyName = "sinav";
            this.sinavDataGridViewTextBoxColumn.HeaderText = "sinav";
            this.sinavDataGridViewTextBoxColumn.Name = "sinavDataGridViewTextBoxColumn";
            this.sinavDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numaraDataGridViewTextBoxColumn1,
            this.adDataGridViewTextBoxColumn1,
            this.soyadDataGridViewTextBoxColumn1,
            this.alanDataGridViewTextBoxColumn1,
            this.sinavDataGridViewTextBoxColumn1,
            this.puanDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.sinavBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(800, 450);
            this.dataGridView2.TabIndex = 3;
            // 
            // numaraDataGridViewTextBoxColumn1
            // 
            this.numaraDataGridViewTextBoxColumn1.DataPropertyName = "numara";
            this.numaraDataGridViewTextBoxColumn1.HeaderText = "numara";
            this.numaraDataGridViewTextBoxColumn1.Name = "numaraDataGridViewTextBoxColumn1";
            this.numaraDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn1
            // 
            this.adDataGridViewTextBoxColumn1.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn1.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn1.Name = "adDataGridViewTextBoxColumn1";
            this.adDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn1
            // 
            this.soyadDataGridViewTextBoxColumn1.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn1.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn1.Name = "soyadDataGridViewTextBoxColumn1";
            this.soyadDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // alanDataGridViewTextBoxColumn1
            // 
            this.alanDataGridViewTextBoxColumn1.DataPropertyName = "alan";
            this.alanDataGridViewTextBoxColumn1.HeaderText = "alan";
            this.alanDataGridViewTextBoxColumn1.Name = "alanDataGridViewTextBoxColumn1";
            this.alanDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sinavDataGridViewTextBoxColumn1
            // 
            this.sinavDataGridViewTextBoxColumn1.DataPropertyName = "sinav";
            this.sinavDataGridViewTextBoxColumn1.HeaderText = "sinav";
            this.sinavDataGridViewTextBoxColumn1.Name = "sinavDataGridViewTextBoxColumn1";
            this.sinavDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // puanDataGridViewTextBoxColumn1
            // 
            this.puanDataGridViewTextBoxColumn1.DataPropertyName = "puan";
            this.puanDataGridViewTextBoxColumn1.HeaderText = "puan";
            this.puanDataGridViewTextBoxColumn1.Name = "puanDataGridViewTextBoxColumn1";
            this.puanDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // SinavListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SinavListe";
            this.Text = "SinavListe";
            this.Load += new System.EventHandler(this.SinavListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dershaneLoginDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DershaneLoginDataSet3 dershaneLoginDataSet3;
        private System.Windows.Forms.BindingSource sinavBindingSource;
        private DershaneLoginDataSet3TableAdapters.SinavTableAdapter sinavTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numaraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinavDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn puanDataGridViewTextBoxColumn1;
    }
}