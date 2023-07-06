namespace UI_ByteBay
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            flpContenedor = new FlowLayoutPanel();
            pnlMenu = new Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            pnlInicio = new Panel();
            btnInicio = new FontAwesome.Sharp.IconButton();
            pnlCategorias = new Panel();
            btnCategorias = new FontAwesome.Sharp.IconButton();
            pnlMiCarrito = new Panel();
            btnMiCarrito = new FontAwesome.Sharp.IconButton();
            pnlContactanos = new Panel();
            btnContactanos = new FontAwesome.Sharp.IconButton();
            pnlNosotros = new Panel();
            btnInformes = new FontAwesome.Sharp.IconButton();
            pnlVacioUno = new Panel();
            pnlVacioDos = new Panel();
            btnAdministrador = new FontAwesome.Sharp.IconButton();
            pnlCerrarSesion = new Panel();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnUser = new FontAwesome.Sharp.IconButton();
            flpContenedor.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlInicio.SuspendLayout();
            pnlCategorias.SuspendLayout();
            pnlMiCarrito.SuspendLayout();
            pnlContactanos.SuspendLayout();
            pnlNosotros.SuspendLayout();
            pnlVacioDos.SuspendLayout();
            pnlCerrarSesion.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flpContenedor
            // 
            flpContenedor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpContenedor.BackColor = Color.FromArgb(20, 25, 25);
            flpContenedor.Controls.Add(pnlMenu);
            flpContenedor.Controls.Add(pnlInicio);
            flpContenedor.Controls.Add(pnlCategorias);
            flpContenedor.Controls.Add(pnlMiCarrito);
            flpContenedor.Controls.Add(pnlContactanos);
            flpContenedor.Controls.Add(pnlNosotros);
            flpContenedor.Controls.Add(pnlVacioUno);
            flpContenedor.Controls.Add(pnlVacioDos);
            flpContenedor.Controls.Add(pnlCerrarSesion);
            flpContenedor.Dock = DockStyle.Left;
            flpContenedor.Location = new Point(0, 0);
            flpContenedor.Margin = new Padding(3, 4, 3, 4);
            flpContenedor.Name = "flpContenedor";
            flpContenedor.Size = new Size(66, 854);
            flpContenedor.TabIndex = 5;
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnMenu);
            pnlMenu.Location = new Point(3, 4);
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(206, 85);
            pnlMenu.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Left;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.Gray;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.List;
            btnMenu.IconColor = Color.Gray;
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Margin = new Padding(3, 4, 3, 4);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(206, 85);
            btnMenu.TabIndex = 1;
            btnMenu.Tag = "";
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            btnMenu.MouseEnter += btnMenu_MouseEnter;
            btnMenu.MouseLeave += btnMenu_MouseLeave;
            // 
            // pnlInicio
            // 
            pnlInicio.Controls.Add(btnInicio);
            pnlInicio.Location = new Point(3, 97);
            pnlInicio.Margin = new Padding(3, 4, 3, 4);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(206, 62);
            pnlInicio.TabIndex = 1;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Left;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.Gray;
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            btnInicio.IconColor = Color.Gray;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 0);
            btnInicio.Margin = new Padding(3, 4, 3, 4);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(206, 62);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            btnInicio.MouseEnter += btnInicio_MouseEnter;
            btnInicio.MouseLeave += btnInicio_MouseLeave;
            // 
            // pnlCategorias
            // 
            pnlCategorias.Controls.Add(btnCategorias);
            pnlCategorias.Location = new Point(3, 167);
            pnlCategorias.Margin = new Padding(3, 4, 3, 4);
            pnlCategorias.Name = "pnlCategorias";
            pnlCategorias.Size = new Size(206, 62);
            pnlCategorias.TabIndex = 2;
            // 
            // btnCategorias
            // 
            btnCategorias.Dock = DockStyle.Left;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategorias.ForeColor = Color.Gray;
            btnCategorias.IconChar = FontAwesome.Sharp.IconChar.FolderClosed;
            btnCategorias.IconColor = Color.Gray;
            btnCategorias.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(0, 0);
            btnCategorias.Margin = new Padding(3, 4, 3, 4);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(206, 62);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "   Categorías";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            btnCategorias.MouseEnter += btnCategorias_MouseEnter;
            btnCategorias.MouseLeave += btnCategorias_MouseLeave;
            // 
            // pnlMiCarrito
            // 
            pnlMiCarrito.Controls.Add(btnMiCarrito);
            pnlMiCarrito.Location = new Point(3, 237);
            pnlMiCarrito.Margin = new Padding(3, 4, 3, 4);
            pnlMiCarrito.Name = "pnlMiCarrito";
            pnlMiCarrito.Size = new Size(206, 62);
            pnlMiCarrito.TabIndex = 5;
            // 
            // btnMiCarrito
            // 
            btnMiCarrito.Dock = DockStyle.Left;
            btnMiCarrito.FlatAppearance.BorderSize = 0;
            btnMiCarrito.FlatStyle = FlatStyle.Flat;
            btnMiCarrito.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMiCarrito.ForeColor = Color.Gray;
            btnMiCarrito.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btnMiCarrito.IconColor = Color.Gray;
            btnMiCarrito.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnMiCarrito.ImageAlign = ContentAlignment.MiddleLeft;
            btnMiCarrito.Location = new Point(0, 0);
            btnMiCarrito.Margin = new Padding(3, 4, 3, 4);
            btnMiCarrito.Name = "btnMiCarrito";
            btnMiCarrito.Size = new Size(206, 62);
            btnMiCarrito.TabIndex = 0;
            btnMiCarrito.Text = "Mi carrito";
            btnMiCarrito.UseVisualStyleBackColor = true;
            btnMiCarrito.Click += btnMiCarrito_Click;
            btnMiCarrito.MouseEnter += btnMiCarrito_MouseEnter;
            btnMiCarrito.MouseLeave += btnMiCarrito_MouseLeave;
            // 
            // pnlContactanos
            // 
            pnlContactanos.Controls.Add(btnContactanos);
            pnlContactanos.Location = new Point(3, 307);
            pnlContactanos.Margin = new Padding(3, 4, 3, 4);
            pnlContactanos.Name = "pnlContactanos";
            pnlContactanos.Size = new Size(206, 62);
            pnlContactanos.TabIndex = 6;
            // 
            // btnContactanos
            // 
            btnContactanos.Dock = DockStyle.Left;
            btnContactanos.FlatAppearance.BorderSize = 0;
            btnContactanos.FlatStyle = FlatStyle.Flat;
            btnContactanos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnContactanos.ForeColor = Color.Gray;
            btnContactanos.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            btnContactanos.IconColor = Color.Gray;
            btnContactanos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnContactanos.ImageAlign = ContentAlignment.MiddleLeft;
            btnContactanos.Location = new Point(0, 0);
            btnContactanos.Margin = new Padding(3, 4, 3, 4);
            btnContactanos.Name = "btnContactanos";
            btnContactanos.Size = new Size(206, 62);
            btnContactanos.TabIndex = 0;
            btnContactanos.Text = "     Contáctanos";
            btnContactanos.UseVisualStyleBackColor = true;
            btnContactanos.Click += btnContactanos_Click;
            btnContactanos.MouseEnter += btnContactanos_MouseEnter;
            btnContactanos.MouseLeave += btnContactanos_MouseLeave;
            // 
            // pnlNosotros
            // 
            pnlNosotros.Controls.Add(btnInformes);
            pnlNosotros.Location = new Point(3, 377);
            pnlNosotros.Margin = new Padding(3, 4, 3, 4);
            pnlNosotros.Name = "pnlNosotros";
            pnlNosotros.Size = new Size(206, 62);
            pnlNosotros.TabIndex = 7;
            // 
            // btnInformes
            // 
            btnInformes.Dock = DockStyle.Left;
            btnInformes.FlatAppearance.BorderSize = 0;
            btnInformes.FlatStyle = FlatStyle.Flat;
            btnInformes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInformes.ForeColor = Color.Gray;
            btnInformes.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            btnInformes.IconColor = Color.Gray;
            btnInformes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnInformes.ImageAlign = ContentAlignment.MiddleLeft;
            btnInformes.Location = new Point(0, 0);
            btnInformes.Margin = new Padding(3, 4, 3, 4);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(206, 62);
            btnInformes.TabIndex = 0;
            btnInformes.Text = "Informes";
            btnInformes.UseVisualStyleBackColor = true;
            btnInformes.Click += btnNosotros_Click;
            btnInformes.MouseEnter += btnInformes_MouseEnter;
            btnInformes.MouseLeave += btnInformes_MouseLeave;
            // 
            // pnlVacioUno
            // 
            pnlVacioUno.Dock = DockStyle.Left;
            pnlVacioUno.Location = new Point(3, 447);
            pnlVacioUno.Margin = new Padding(3, 4, 3, 4);
            pnlVacioUno.Name = "pnlVacioUno";
            pnlVacioUno.Size = new Size(206, 0);
            pnlVacioUno.TabIndex = 8;
            // 
            // pnlVacioDos
            // 
            pnlVacioDos.Controls.Add(btnAdministrador);
            pnlVacioDos.Location = new Point(3, 455);
            pnlVacioDos.Margin = new Padding(3, 4, 3, 4);
            pnlVacioDos.Name = "pnlVacioDos";
            pnlVacioDos.Size = new Size(206, 62);
            pnlVacioDos.TabIndex = 9;
            // 
            // btnAdministrador
            // 
            btnAdministrador.Dock = DockStyle.Left;
            btnAdministrador.FlatAppearance.BorderSize = 0;
            btnAdministrador.FlatStyle = FlatStyle.Flat;
            btnAdministrador.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdministrador.ForeColor = Color.Gray;
            btnAdministrador.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            btnAdministrador.IconColor = Color.Gray;
            btnAdministrador.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnAdministrador.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdministrador.Location = new Point(0, 0);
            btnAdministrador.Margin = new Padding(3, 4, 3, 4);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Size = new Size(206, 62);
            btnAdministrador.TabIndex = 1;
            btnAdministrador.Text = "        Administrador";
            btnAdministrador.UseVisualStyleBackColor = true;
            btnAdministrador.Click += btnAdministrador_Click;
            btnAdministrador.MouseEnter += btnAdministrador_MouseEnter;
            btnAdministrador.MouseLeave += btnAdministrador_MouseLeave;
            // 
            // pnlCerrarSesion
            // 
            pnlCerrarSesion.Controls.Add(btnCerrarSesion);
            pnlCerrarSesion.Location = new Point(3, 525);
            pnlCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            pnlCerrarSesion.Name = "pnlCerrarSesion";
            pnlCerrarSesion.Size = new Size(206, 62);
            pnlCerrarSesion.TabIndex = 10;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Dock = DockStyle.Right;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.Gray;
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnCerrarSesion.IconColor = Color.Gray;
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 0);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(206, 62);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "     Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            btnCerrarSesion.MouseEnter += btnCerrarSesion_MouseEnter;
            btnCerrarSesion.MouseLeave += btnCerrarSesion_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 25, 25);
            panel1.Controls.Add(btnUser);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(66, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1286, 89);
            panel1.TabIndex = 7;
            // 
            // btnUser
            // 
            btnUser.Dock = DockStyle.Left;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.ForeColor = Color.Gray;
            btnUser.IconChar = FontAwesome.Sharp.IconChar.User;
            btnUser.IconColor = Color.Gray;
            btnUser.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 0);
            btnUser.Margin = new Padding(3, 4, 3, 4);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(283, 89);
            btnUser.TabIndex = 6;
            btnUser.Tag = "";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.MouseEnter += btnUser_MouseEnter;
            btnUser.MouseLeave += btnUser_MouseLeave;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1352, 854);
            Controls.Add(panel1);
            Controls.Add(flpContenedor);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Byte Bay";
            Load += FrmMain_Load;
            flpContenedor.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlInicio.ResumeLayout(false);
            pnlCategorias.ResumeLayout(false);
            pnlMiCarrito.ResumeLayout(false);
            pnlContactanos.ResumeLayout(false);
            pnlNosotros.ResumeLayout(false);
            pnlVacioDos.ResumeLayout(false);
            pnlCerrarSesion.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpContenedor;
        private Panel pnlMenu;
        private Panel pnlInicio;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnMenu;
        private Panel pnlCategorias;
        private FontAwesome.Sharp.IconButton btnCategorias;
        private Panel pnlMiCarrito;
        private FontAwesome.Sharp.IconButton btnMiCarrito;
        private Panel pnlContactanos;
        private FontAwesome.Sharp.IconButton btnContactanos;
        private Panel pnlNosotros;
        private FontAwesome.Sharp.IconButton btnInformes;
        private Panel pnlVacioUno;
        private Panel pnlCerrarSesion;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private Panel pnlVacioDos;
        private FontAwesome.Sharp.IconButton btnAdministrador;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnUser;
    }
}