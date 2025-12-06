namespace Wolf_Rabbit
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.Start = new System.Windows.Forms.Button();
            this.World = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtThoat = new System.Windows.Forms.Button();
            this.chartSoLuong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtSoLuongTho = new System.Windows.Forms.TextBox();
            this.txtSoLuongSoi = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.btnLuuFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Start.Location = new System.Drawing.Point(30, 467);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(86, 43);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // World
            // 
            this.World.BackColor = System.Drawing.Color.ForestGreen;
            this.World.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.World.Location = new System.Drawing.Point(1, 4);
            this.World.Name = "World";
            this.World.Size = new System.Drawing.Size(872, 442);
            this.World.TabIndex = 1;
            this.World.Paint += new System.Windows.Forms.PaintEventHandler(this.World_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(172, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Stop_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.Location = new System.Drawing.Point(322, 469);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 41);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // txtThoat
            // 
            this.txtThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtThoat.Location = new System.Drawing.Point(794, 607);
            this.txtThoat.Name = "txtThoat";
            this.txtThoat.Size = new System.Drawing.Size(79, 43);
            this.txtThoat.TabIndex = 5;
            this.txtThoat.Text = "Thoát";
            this.txtThoat.UseVisualStyleBackColor = false;
            this.txtThoat.Click += new System.EventHandler(this.txtThoat_Click);
            // 
            // chartSoLuong
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSoLuong.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.IsDockedInsideChartArea = false;
            legend2.MaximumAutoSize = 100F;
            legend2.Name = "Legend1";
            legend2.Title = "Biểu Đồ Thể Hiện Số Lượng Sói Và Thỏ";
            this.chartSoLuong.Legends.Add(legend2);
            this.chartSoLuong.Location = new System.Drawing.Point(890, 4);
            this.chartSoLuong.Name = "chartSoLuong";
            this.chartSoLuong.Size = new System.Drawing.Size(575, 617);
            this.chartSoLuong.TabIndex = 6;
            this.chartSoLuong.Text = "Biểu Đồ Số Lượng Theo Thời Gian";
            // 
            // txtSoLuongTho
            // 
            this.txtSoLuongTho.Location = new System.Drawing.Point(817, 467);
            this.txtSoLuongTho.Name = "txtSoLuongTho";
            this.txtSoLuongTho.Size = new System.Drawing.Size(56, 22);
            this.txtSoLuongTho.TabIndex = 7;
            // 
            // txtSoLuongSoi
            // 
            this.txtSoLuongSoi.Location = new System.Drawing.Point(817, 500);
            this.txtSoLuongSoi.Name = "txtSoLuongSoi";
            this.txtSoLuongSoi.Size = new System.Drawing.Size(56, 22);
            this.txtSoLuongSoi.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(689, 469);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Số lượng thỏ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(689, 502);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Số lượng sói";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(671, 540);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Thời gian(ngày)";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Location = new System.Drawing.Point(817, 538);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(56, 22);
            this.txtThoiGian.TabIndex = 12;
            // 
            // btnLuuFile
            // 
            this.btnLuuFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuuFile.Location = new System.Drawing.Point(477, 469);
            this.btnLuuFile.Name = "btnLuuFile";
            this.btnLuuFile.Size = new System.Drawing.Size(147, 41);
            this.btnLuuFile.TabIndex = 14;
            this.btnLuuFile.Text = "Lưu Biểu Đồ";
            this.btnLuuFile.UseVisualStyleBackColor = false;
            this.btnLuuFile.Click += new System.EventHandler(this.btnLuuFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 662);
            this.Controls.Add(this.btnLuuFile);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSoLuongSoi);
            this.Controls.Add(this.txtSoLuongTho);
            this.Controls.Add(this.chartSoLuong);
            this.Controls.Add(this.txtThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.World);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Mô Phỏng Hệ Sinh Thái";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Panel World;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button txtThoat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSoLuong;
        private System.Windows.Forms.TextBox txtSoLuongTho;
        private System.Windows.Forms.TextBox txtSoLuongSoi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.Button btnLuuFile;
    }
}

