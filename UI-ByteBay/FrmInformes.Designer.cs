namespace UI_ByteBay
{
    partial class FrmInformes
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
            btnExportJson = new FontAwesome.Sharp.IconButton();
            btnExportPdf = new FontAwesome.Sharp.IconButton();
            btnExportCsv = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            listBox1 = new ListBox();
            panel1 = new Panel();
            panel4 = new Panel();
            lblMovimientos = new Label();
            panel3 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnExportJson
            // 
            btnExportJson.Dock = DockStyle.Right;
            btnExportJson.FlatStyle = FlatStyle.Flat;
            btnExportJson.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportJson.ForeColor = Color.Gray;
            btnExportJson.IconChar = FontAwesome.Sharp.IconChar.FileCode;
            btnExportJson.IconColor = Color.Gray;
            btnExportJson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportJson.IconSize = 40;
            btnExportJson.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportJson.Location = new Point(506, 0);
            btnExportJson.Margin = new Padding(3, 4, 3, 4);
            btnExportJson.Name = "btnExportJson";
            btnExportJson.Size = new Size(213, 57);
            btnExportJson.TabIndex = 29;
            btnExportJson.Text = "Exportar a JSON";
            btnExportJson.UseVisualStyleBackColor = true;
            btnExportJson.Click += btnExportJson_Click;
            btnExportJson.MouseEnter += btnExportJson_MouseEnter;
            btnExportJson.MouseLeave += btnExportJson_MouseLeave;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Dock = DockStyle.Right;
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportPdf.ForeColor = Color.Gray;
            btnExportPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnExportPdf.IconColor = Color.Gray;
            btnExportPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportPdf.IconSize = 40;
            btnExportPdf.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportPdf.Location = new Point(932, 0);
            btnExportPdf.Margin = new Padding(3, 4, 3, 4);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(213, 57);
            btnExportPdf.TabIndex = 28;
            btnExportPdf.Text = "Exportar a PDF";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            btnExportPdf.MouseEnter += btnExportPdf_MouseEnter;
            btnExportPdf.MouseLeave += btnExportPdf_MouseLeave;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Dock = DockStyle.Right;
            btnExportCsv.FlatStyle = FlatStyle.Flat;
            btnExportCsv.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportCsv.ForeColor = Color.Gray;
            btnExportCsv.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            btnExportCsv.IconColor = Color.Gray;
            btnExportCsv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportCsv.IconSize = 40;
            btnExportCsv.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportCsv.Location = new Point(719, 0);
            btnExportCsv.Margin = new Padding(3, 4, 3, 4);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(213, 57);
            btnExportCsv.TabIndex = 27;
            btnExportCsv.Text = "Exportar a CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            btnExportCsv.MouseEnter += btnExportCsv_MouseEnter;
            btnExportCsv.MouseLeave += btnExportCsv_MouseLeave;
            // 
            // panel2
            // 
            panel2.Controls.Add(cartesianChart1);
            panel2.Controls.Add(listBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(1145, 511);
            panel2.TabIndex = 26;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(783, 6);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(349, 468);
            cartesianChart1.TabIndex = 1;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Gray;
            listBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(777, 504);
            listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 45);
            panel1.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblMovimientos);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1145, 41);
            panel4.TabIndex = 20;
            // 
            // lblMovimientos
            // 
            lblMovimientos.AutoSize = true;
            lblMovimientos.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblMovimientos.Location = new Point(12, 9);
            lblMovimientos.Name = "lblMovimientos";
            lblMovimientos.Size = new Size(313, 25);
            lblMovimientos.TabIndex = 19;
            lblMovimientos.Text = "Movimientos actuales del usuario:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(20, 25, 25);
            panel3.Controls.Add(btnExportJson);
            panel3.Controls.Add(btnExportCsv);
            panel3.Controls.Add(btnExportPdf);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 562);
            panel3.Name = "panel3";
            panel3.Size = new Size(1145, 57);
            panel3.TabIndex = 30;
            // 
            // FrmInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1145, 619);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmInformes";
            Text = "FrmInformes";
            Load += FrmInformes_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnExportJson;
        private FontAwesome.Sharp.IconButton btnExportPdf;
        private FontAwesome.Sharp.IconButton btnExportCsv;
        private Panel panel2;
        private Panel panel1;
        private Label lblMovimientos;
        private Panel panel3;
        private ListBox listBox1;
        private Panel panel4;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}