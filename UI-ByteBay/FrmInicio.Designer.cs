namespace UI_ByteBay
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            lblDireccion = new Label();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblDireccion.ForeColor = Color.FromArgb(20, 25, 25);
            lblDireccion.Location = new Point(375, 40);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(359, 45);
            lblDireccion.TabIndex = 43;
            lblDireccion.Text = "Bienvenidos a ByteBay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(103, 198);
            label2.Name = "label2";
            label2.Size = new Size(896, 75);
            label2.TabIndex = 45;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(103, 315);
            label3.Name = "label3";
            label3.Size = new Size(896, 113);
            label3.TabIndex = 47;
            label3.Text = resources.GetString("label3.Text");
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(20, 25, 25);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 533);
            panel4.Name = "panel4";
            panel4.Size = new Size(1145, 86);
            panel4.TabIndex = 52;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1145, 619);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblDireccion);
            ForeColor = SystemColors.ControlText;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInicio";
            WindowState = FormWindowState.Minimized;
            Load += FrmInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDireccion;
        private Label label2;
        private Label label3;
        private Panel panel4;
    }
}