namespace UI_ByteBay.Forms
{
    partial class FrmMiCarrito
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
            flpProductosCarrito = new FlowLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lblTotal = new Label();
            btnPagar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            flpProductosCarrito.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flpProductosCarrito
            // 
            flpProductosCarrito.BackColor = Color.Gray;
            flpProductosCarrito.BorderStyle = BorderStyle.FixedSingle;
            flpProductosCarrito.Controls.Add(iconButton1);
            flpProductosCarrito.Dock = DockStyle.Top;
            flpProductosCarrito.FlowDirection = FlowDirection.RightToLeft;
            flpProductosCarrito.Location = new Point(0, 0);
            flpProductosCarrito.Name = "flpProductosCarrito";
            flpProductosCarrito.Size = new Size(1145, 555);
            flpProductosCarrito.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(1132, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(8, 8);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(20, 25, 25);
            lblTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.Gray;
            lblTotal.Location = new Point(12, 13);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 30);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total:";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(20, 25, 25);
            btnPagar.Dock = DockStyle.Right;
            btnPagar.FlatStyle = FlatStyle.Popup;
            btnPagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.Gray;
            btnPagar.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btnPagar.IconColor = Color.Gray;
            btnPagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPagar.IconSize = 60;
            btnPagar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagar.Location = new Point(935, 0);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(210, 64);
            btnPagar.TabIndex = 0;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(btnPagar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 555);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 64);
            panel1.TabIndex = 2;
            // 
            // FrmMiCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(20, 25, 25);
            ClientSize = new Size(1145, 619);
            Controls.Add(panel1);
            Controls.Add(flpProductosCarrito);
            ForeColor = Color.FloralWhite;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FrmMiCarrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMiCarrito";
            WindowState = FormWindowState.Maximized;
            Load += FrmMiCarrito_Load;
            flpProductosCarrito.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpProductosCarrito;
        private Label lblTotal;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnPagar;
        private Panel panel1;
    }
}