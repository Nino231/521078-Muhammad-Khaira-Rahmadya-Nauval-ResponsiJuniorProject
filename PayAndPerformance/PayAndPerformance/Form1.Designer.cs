namespace PayAndPerformance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            Subtitle = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtNamaDeveloper = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ddProyek = new ComboBox();
            ddStatusKontrak = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtFiturSelesai = new TextBox();
            label5 = new Label();
            txtJumlahBug = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            groupBox3 = new GroupBox();
            label7 = new Label();
            gridPerformaTim = new DataGridView();
            label6 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPerformaTim).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(311, 9);
            Title.Name = "Title";
            Title.Size = new Size(246, 32);
            Title.TabIndex = 0;
            Title.Text = "Pay and Performane";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Subtitle
            // 
            Subtitle.AutoSize = true;
            Subtitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Subtitle.Location = new Point(270, 41);
            Subtitle.Name = "Subtitle";
            Subtitle.Size = new Size(324, 25);
            Subtitle.TabIndex = 1;
            Subtitle.Text = "Developer Team Performance Tracker";
            Subtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ddStatusKontrak);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ddProyek);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNamaDeveloper);
            groupBox1.Location = new Point(12, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(843, 142);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATA DEVELOPER";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtJumlahBug);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtFiturSelesai);
            groupBox2.Location = new Point(12, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(843, 105);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATA KINERJA";
            // 
            // txtNamaDeveloper
            // 
            txtNamaDeveloper.Location = new Point(119, 22);
            txtNamaDeveloper.Name = "txtNamaDeveloper";
            txtNamaDeveloper.Size = new Size(391, 23);
            txtNamaDeveloper.TabIndex = 0;
            txtNamaDeveloper.TextChanged += txtNamaDeveloper_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 27);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 1;
            label1.Text = "Nama Developer :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 61);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 3;
            label2.Text = "Pilih Proyek          :";
            // 
            // ddProyek
            // 
            ddProyek.FormattingEnabled = true;
            ddProyek.Location = new Point(119, 58);
            ddProyek.Name = "ddProyek";
            ddProyek.Size = new Size(391, 23);
            ddProyek.TabIndex = 4;
            // 
            // ddStatusKontrak
            // 
            ddStatusKontrak.FormattingEnabled = true;
            ddStatusKontrak.Location = new Point(119, 96);
            ddStatusKontrak.Name = "ddStatusKontrak";
            ddStatusKontrak.Size = new Size(391, 23);
            ddStatusKontrak.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 99);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 5;
            label3.Text = "Status Kontrak     :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 27);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 8;
            label4.Text = "Fitur Selesai         :";
            // 
            // txtFiturSelesai
            // 
            txtFiturSelesai.Location = new Point(117, 22);
            txtFiturSelesai.Name = "txtFiturSelesai";
            txtFiturSelesai.Size = new Size(392, 23);
            txtFiturSelesai.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 67);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 10;
            label5.Text = "Jumlah Bug         :";
            // 
            // txtJumlahBug
            // 
            txtJumlahBug.Location = new Point(118, 62);
            txtJumlahBug.Name = "txtJumlahBug";
            txtJumlahBug.Size = new Size(391, 23);
            txtJumlahBug.TabIndex = 9;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(23, 349);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(256, 28);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(303, 349);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(256, 28);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(583, 349);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(256, 28);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(gridPerformaTim);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(12, 387);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(843, 183);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "DAFTAR PERFORMA TIM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 27);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 8;
            // 
            // gridPerformaTim
            // 
            gridPerformaTim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPerformaTim.Location = new Point(6, 22);
            gridPerformaTim.Name = "gridPerformaTim";
            gridPerformaTim.Size = new Size(831, 150);
            gridPerformaTim.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(515, 25);
            label6.Name = "label6";
            label6.Size = new Size(165, 15);
            label6.TabIndex = 11;
            label6.Text = "(Jumlah fitur yang dikerjakan)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(515, 67);
            label8.Name = "label8";
            label8.Size = new Size(167, 15);
            label8.TabIndex = 12;
            label8.Text = "(Jumlah bug yang ditemukan)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 574);
            Controls.Add(groupBox3);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Subtitle);
            Controls.Add(Title);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "GroupDeveloper";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPerformaTim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Subtitle;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox ddProyek;
        private Label label2;
        private Label label1;
        private TextBox txtNamaDeveloper;
        private ComboBox ddStatusKontrak;
        private Label label3;
        private Label label5;
        private TextBox txtJumlahBug;
        private Label label4;
        private TextBox txtFiturSelesai;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox groupBox3;
        private DataGridView gridPerformaTim;
        private Label label7;
        private Label label6;
        private Label label8;
    }
}
