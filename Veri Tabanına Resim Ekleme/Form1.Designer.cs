namespace Veri_Tabanına_Resim_Ekleme
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtTur = new System.Windows.Forms.TextBox();
            this.TxtPuan = new System.Windows.Forms.TextBox();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.TxtResim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dbo_FilmArsivDataSet = new Veri_Tabanına_Resim_Ekleme.Dbo_FilmArsivDataSet();
            this.tblFilmlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_FilmlerTableAdapter = new Veri_Tabanına_Resim_Ekleme.Dbo_FilmArsivDataSetTableAdapters.Tbl_FilmlerTableAdapter();
            this.filmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmTurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmPuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmKategoriDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.filmResimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_FilmArsivDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilmlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(67, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film Turu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(91, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(64, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategori:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(83, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resim:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(80, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Film İd:";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(175, 32);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(120, 30);
            this.Txtid.TabIndex = 6;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(175, 80);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(120, 30);
            this.TxtAd.TabIndex = 7;
            // 
            // TxtTur
            // 
            this.TxtTur.Location = new System.Drawing.Point(175, 123);
            this.TxtTur.Name = "TxtTur";
            this.TxtTur.Size = new System.Drawing.Size(120, 30);
            this.TxtTur.TabIndex = 8;
            // 
            // TxtPuan
            // 
            this.TxtPuan.Location = new System.Drawing.Point(175, 164);
            this.TxtPuan.Name = "TxtPuan";
            this.TxtPuan.Size = new System.Drawing.Size(120, 30);
            this.TxtPuan.TabIndex = 9;
            // 
            // TxtKategori
            // 
            this.TxtKategori.Location = new System.Drawing.Point(175, 203);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(120, 30);
            this.TxtKategori.TabIndex = 10;
            // 
            // TxtResim
            // 
            this.TxtResim.Location = new System.Drawing.Point(175, 239);
            this.TxtResim.Name = "TxtResim";
            this.TxtResim.Size = new System.Drawing.Size(120, 30);
            this.TxtResim.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(175, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2.Location = new System.Drawing.Point(175, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button3.Location = new System.Drawing.Point(301, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(347, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmidDataGridViewTextBoxColumn,
            this.filmAdDataGridViewTextBoxColumn,
            this.filmTurDataGridViewTextBoxColumn,
            this.filmPuanDataGridViewTextBoxColumn,
            this.filmKategoriDataGridViewCheckBoxColumn,
            this.filmResimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblFilmlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(777, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dbo_FilmArsivDataSet
            // 
            this.dbo_FilmArsivDataSet.DataSetName = "Dbo_FilmArsivDataSet";
            this.dbo_FilmArsivDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFilmlerBindingSource
            // 
            this.tblFilmlerBindingSource.DataMember = "Tbl_Filmler";
            this.tblFilmlerBindingSource.DataSource = this.dbo_FilmArsivDataSet;
            // 
            // tbl_FilmlerTableAdapter
            // 
            this.tbl_FilmlerTableAdapter.ClearBeforeFill = true;
            // 
            // filmidDataGridViewTextBoxColumn
            // 
            this.filmidDataGridViewTextBoxColumn.DataPropertyName = "Filmid";
            this.filmidDataGridViewTextBoxColumn.HeaderText = "Filmid";
            this.filmidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmidDataGridViewTextBoxColumn.Name = "filmidDataGridViewTextBoxColumn";
            this.filmidDataGridViewTextBoxColumn.ReadOnly = true;
            this.filmidDataGridViewTextBoxColumn.Width = 125;
            // 
            // filmAdDataGridViewTextBoxColumn
            // 
            this.filmAdDataGridViewTextBoxColumn.DataPropertyName = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.HeaderText = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmAdDataGridViewTextBoxColumn.Name = "filmAdDataGridViewTextBoxColumn";
            this.filmAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // filmTurDataGridViewTextBoxColumn
            // 
            this.filmTurDataGridViewTextBoxColumn.DataPropertyName = "FilmTur";
            this.filmTurDataGridViewTextBoxColumn.HeaderText = "FilmTur";
            this.filmTurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmTurDataGridViewTextBoxColumn.Name = "filmTurDataGridViewTextBoxColumn";
            this.filmTurDataGridViewTextBoxColumn.Width = 125;
            // 
            // filmPuanDataGridViewTextBoxColumn
            // 
            this.filmPuanDataGridViewTextBoxColumn.DataPropertyName = "FilmPuan";
            this.filmPuanDataGridViewTextBoxColumn.HeaderText = "FilmPuan";
            this.filmPuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmPuanDataGridViewTextBoxColumn.Name = "filmPuanDataGridViewTextBoxColumn";
            this.filmPuanDataGridViewTextBoxColumn.Width = 125;
            // 
            // filmKategoriDataGridViewCheckBoxColumn
            // 
            this.filmKategoriDataGridViewCheckBoxColumn.DataPropertyName = "FilmKategori";
            this.filmKategoriDataGridViewCheckBoxColumn.HeaderText = "FilmKategori";
            this.filmKategoriDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.filmKategoriDataGridViewCheckBoxColumn.Name = "filmKategoriDataGridViewCheckBoxColumn";
            this.filmKategoriDataGridViewCheckBoxColumn.Width = 125;
            // 
            // filmResimDataGridViewTextBoxColumn
            // 
            this.filmResimDataGridViewTextBoxColumn.DataPropertyName = "FilmResim";
            this.filmResimDataGridViewTextBoxColumn.HeaderText = "FilmResim";
            this.filmResimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmResimDataGridViewTextBoxColumn.Name = "filmResimDataGridViewTextBoxColumn";
            this.filmResimDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtResim);
            this.Controls.Add(this.TxtKategori);
            this.Controls.Add(this.TxtPuan);
            this.Controls.Add(this.TxtTur);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_FilmArsivDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilmlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtTur;
        private System.Windows.Forms.TextBox TxtPuan;
        private System.Windows.Forms.TextBox TxtKategori;
        private System.Windows.Forms.TextBox TxtResim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Dbo_FilmArsivDataSet dbo_FilmArsivDataSet;
        private System.Windows.Forms.BindingSource tblFilmlerBindingSource;
        private Dbo_FilmArsivDataSetTableAdapters.Tbl_FilmlerTableAdapter tbl_FilmlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmTurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmPuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn filmKategoriDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmResimDataGridViewTextBoxColumn;
    }
}

