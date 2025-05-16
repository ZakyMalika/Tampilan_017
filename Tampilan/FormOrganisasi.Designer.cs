namespace Tampilan
{
    partial class FormOrganisasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamaOrganisasi = new System.Windows.Forms.TextBox();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.txtTahunBerdiri = new System.Windows.Forms.TextBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.txtJumlahDana = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvOrganisasi = new System.Windows.Forms.DataGridView();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganisasi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Organisasi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deskrripsi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jumlah Dana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tahun Berdiri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Keterangan";
            // 
            // txtNamaOrganisasi
            // 
            this.txtNamaOrganisasi.Location = new System.Drawing.Point(306, 53);
            this.txtNamaOrganisasi.Name = "txtNamaOrganisasi";
            this.txtNamaOrganisasi.Size = new System.Drawing.Size(536, 31);
            this.txtNamaOrganisasi.TabIndex = 5;
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(306, 113);
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(536, 31);
            this.txtDeskripsi.TabIndex = 6;
            // 
            // txtTahunBerdiri
            // 
            this.txtTahunBerdiri.Location = new System.Drawing.Point(306, 175);
            this.txtTahunBerdiri.Name = "txtTahunBerdiri";
            this.txtTahunBerdiri.Size = new System.Drawing.Size(536, 31);
            this.txtTahunBerdiri.TabIndex = 7;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(306, 281);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(536, 31);
            this.txtKeterangan.TabIndex = 9;
            // 
            // txtJumlahDana
            // 
            this.txtJumlahDana.Location = new System.Drawing.Point(306, 219);
            this.txtJumlahDana.Name = "txtJumlahDana";
            this.txtJumlahDana.Size = new System.Drawing.Size(536, 31);
            this.txtJumlahDana.TabIndex = 8;
            this.txtJumlahDana.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1103, 81);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(172, 31);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1103, 141);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(172, 31);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1103, 247);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(172, 31);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1103, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 31);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvOrganisasi
            // 
            this.dgvOrganisasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganisasi.Location = new System.Drawing.Point(61, 354);
            this.dgvOrganisasi.Name = "dgvOrganisasi";
            this.dgvOrganisasi.RowHeadersWidth = 82;
            this.dgvOrganisasi.RowTemplate.Height = 33;
            this.dgvOrganisasi.Size = new System.Drawing.Size(1404, 514);
            this.dgvOrganisasi.TabIndex = 14;
            this.dgvOrganisasi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrganisasi_CellClick);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(69, 897);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(100, 25);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.Text = "Message";
            // 
            // FormOrganisasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1735, 1049);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dgvOrganisasi);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.txtJumlahDana);
            this.Controls.Add(this.txtTahunBerdiri);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.txtNamaOrganisasi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOrganisasi";
            this.Text = "FormOrganisasi";
            this.Load += new System.EventHandler(this.FormOrganisasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganisasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamaOrganisasi;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.TextBox txtTahunBerdiri;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.TextBox txtJumlahDana;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvOrganisasi;
        private System.Windows.Forms.Label lblMessage;
        

        }

    }