namespace UI_ByteBay
{
    partial class FrmCategorias
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
            components = new System.ComponentModel.Container();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            btnProcesadores = new FontAwesome.Sharp.IconButton();
            btnAlmacenamiento = new FontAwesome.Sharp.IconButton();
            btnGraficas = new FontAwesome.Sharp.IconButton();
            btnMemorias = new FontAwesome.Sharp.IconButton();
            btnPerifericos = new FontAwesome.Sharp.IconButton();
            btnMother = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnMostrarTodo = new FontAwesome.Sharp.IconButton();
            btnGabinetes = new FontAwesome.Sharp.IconButton();
            tmrTiempoParaSeleccionar = new System.Windows.Forms.Timer(components);
            lvwProductos = new ListView();
            flpProductos = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // btnProcesadores
            // 
            btnProcesadores.Dock = DockStyle.Left;
            btnProcesadores.FlatAppearance.BorderSize = 0;
            btnProcesadores.FlatStyle = FlatStyle.Popup;
            btnProcesadores.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnProcesadores.ForeColor = Color.Gray;
            btnProcesadores.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            btnProcesadores.IconColor = Color.Gray;
            btnProcesadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProcesadores.IconSize = 35;
            btnProcesadores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProcesadores.Location = new Point(675, 0);
            btnProcesadores.Margin = new Padding(3, 4, 3, 4);
            btnProcesadores.Name = "btnProcesadores";
            btnProcesadores.Size = new Size(135, 55);
            btnProcesadores.TabIndex = 34;
            btnProcesadores.Text = "Procesadores";
            btnProcesadores.TextAlign = ContentAlignment.MiddleRight;
            btnProcesadores.UseVisualStyleBackColor = true;
            btnProcesadores.Click += btnProcesadores_Click;
            btnProcesadores.MouseEnter += btnProcesadores_MouseEnter;
            btnProcesadores.MouseLeave += btnProcesadores_MouseLeave;
            // 
            // btnAlmacenamiento
            // 
            btnAlmacenamiento.Dock = DockStyle.Left;
            btnAlmacenamiento.FlatAppearance.BorderSize = 0;
            btnAlmacenamiento.FlatStyle = FlatStyle.Popup;
            btnAlmacenamiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlmacenamiento.ForeColor = Color.Gray;
            btnAlmacenamiento.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnAlmacenamiento.IconColor = Color.Gray;
            btnAlmacenamiento.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnAlmacenamiento.IconSize = 35;
            btnAlmacenamiento.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlmacenamiento.Location = new Point(405, 0);
            btnAlmacenamiento.Margin = new Padding(3, 4, 3, 4);
            btnAlmacenamiento.Name = "btnAlmacenamiento";
            btnAlmacenamiento.Size = new Size(135, 55);
            btnAlmacenamiento.TabIndex = 35;
            btnAlmacenamiento.Text = "Discos";
            btnAlmacenamiento.TextAlign = ContentAlignment.MiddleRight;
            btnAlmacenamiento.UseVisualStyleBackColor = true;
            btnAlmacenamiento.Click += btnAlmacenamiento_Click;
            btnAlmacenamiento.MouseEnter += btnAlmacenamiento_MouseEnter;
            btnAlmacenamiento.MouseLeave += btnAlmacenamiento_MouseLeave;
            // 
            // btnGraficas
            // 
            btnGraficas.Dock = DockStyle.Left;
            btnGraficas.FlatAppearance.BorderSize = 0;
            btnGraficas.FlatStyle = FlatStyle.Popup;
            btnGraficas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGraficas.ForeColor = Color.Gray;
            btnGraficas.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt;
            btnGraficas.IconColor = Color.Gray;
            btnGraficas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnGraficas.IconSize = 35;
            btnGraficas.ImageAlign = ContentAlignment.MiddleLeft;
            btnGraficas.Location = new Point(135, 0);
            btnGraficas.Margin = new Padding(3, 4, 3, 4);
            btnGraficas.Name = "btnGraficas";
            btnGraficas.Size = new Size(135, 55);
            btnGraficas.TabIndex = 36;
            btnGraficas.Text = "Graficas";
            btnGraficas.TextAlign = ContentAlignment.MiddleRight;
            btnGraficas.UseVisualStyleBackColor = true;
            btnGraficas.Click += btnGraficas_Click;
            btnGraficas.MouseEnter += btnGraficas_MouseEnter;
            btnGraficas.MouseLeave += btnGraficas_MouseLeave;
            // 
            // btnMemorias
            // 
            btnMemorias.Dock = DockStyle.Left;
            btnMemorias.FlatAppearance.BorderColor = Color.DimGray;
            btnMemorias.FlatAppearance.BorderSize = 0;
            btnMemorias.FlatStyle = FlatStyle.Popup;
            btnMemorias.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMemorias.ForeColor = Color.Gray;
            btnMemorias.IconChar = FontAwesome.Sharp.IconChar.Memory;
            btnMemorias.IconColor = Color.Gray;
            btnMemorias.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnMemorias.IconSize = 35;
            btnMemorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnMemorias.Location = new Point(0, 0);
            btnMemorias.Margin = new Padding(3, 4, 3, 4);
            btnMemorias.Name = "btnMemorias";
            btnMemorias.Size = new Size(135, 55);
            btnMemorias.TabIndex = 37;
            btnMemorias.Text = "Memorias";
            btnMemorias.TextAlign = ContentAlignment.MiddleRight;
            btnMemorias.UseVisualStyleBackColor = true;
            btnMemorias.Click += btnMemorias_Click;
            btnMemorias.MouseEnter += btnMemorias_MouseEnter;
            btnMemorias.MouseLeave += btnMemorias_MouseLeave;
            // 
            // btnPerifericos
            // 
            btnPerifericos.Dock = DockStyle.Left;
            btnPerifericos.FlatAppearance.BorderSize = 0;
            btnPerifericos.FlatStyle = FlatStyle.Popup;
            btnPerifericos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnPerifericos.ForeColor = Color.Gray;
            btnPerifericos.IconChar = FontAwesome.Sharp.IconChar.Headphones;
            btnPerifericos.IconColor = Color.Gray;
            btnPerifericos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnPerifericos.IconSize = 35;
            btnPerifericos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPerifericos.Location = new Point(270, 0);
            btnPerifericos.Margin = new Padding(3, 4, 3, 4);
            btnPerifericos.Name = "btnPerifericos";
            btnPerifericos.Size = new Size(135, 55);
            btnPerifericos.TabIndex = 38;
            btnPerifericos.Text = "Perifericos";
            btnPerifericos.TextAlign = ContentAlignment.MiddleRight;
            btnPerifericos.UseVisualStyleBackColor = true;
            btnPerifericos.Click += btnPerifericos_Click;
            btnPerifericos.MouseEnter += btnPerifericos_MouseEnter;
            btnPerifericos.MouseLeave += btnPerifericos_MouseLeave;
            // 
            // btnMother
            // 
            btnMother.Dock = DockStyle.Left;
            btnMother.FlatAppearance.BorderSize = 0;
            btnMother.FlatStyle = FlatStyle.Popup;
            btnMother.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMother.ForeColor = Color.Gray;
            btnMother.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            btnMother.IconColor = Color.Gray;
            btnMother.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnMother.IconSize = 35;
            btnMother.ImageAlign = ContentAlignment.MiddleLeft;
            btnMother.Location = new Point(540, 0);
            btnMother.Margin = new Padding(3, 4, 3, 4);
            btnMother.Name = "btnMother";
            btnMother.Size = new Size(135, 55);
            btnMother.TabIndex = 39;
            btnMother.Text = "Mother";
            btnMother.TextAlign = ContentAlignment.MiddleRight;
            btnMother.UseVisualStyleBackColor = true;
            btnMother.Click += btnMother_Click;
            btnMother.MouseEnter += btnMother_MouseEnter;
            btnMother.MouseLeave += btnMother_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 25, 25);
            panel1.Controls.Add(btnMostrarTodo);
            panel1.Controls.Add(btnGabinetes);
            panel1.Controls.Add(btnProcesadores);
            panel1.Controls.Add(btnMother);
            panel1.Controls.Add(btnAlmacenamiento);
            panel1.Controls.Add(btnPerifericos);
            panel1.Controls.Add(btnGraficas);
            panel1.Controls.Add(btnMemorias);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 564);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 55);
            panel1.TabIndex = 40;
            // 
            // btnMostrarTodo
            // 
            btnMostrarTodo.Dock = DockStyle.Right;
            btnMostrarTodo.FlatAppearance.BorderSize = 0;
            btnMostrarTodo.FlatStyle = FlatStyle.Popup;
            btnMostrarTodo.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnMostrarTodo.ForeColor = Color.Gray;
            btnMostrarTodo.IconChar = FontAwesome.Sharp.IconChar.Cube;
            btnMostrarTodo.IconColor = Color.Gray;
            btnMostrarTodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostrarTodo.IconSize = 50;
            btnMostrarTodo.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarTodo.Location = new Point(977, 0);
            btnMostrarTodo.Margin = new Padding(3, 4, 3, 4);
            btnMostrarTodo.Name = "btnMostrarTodo";
            btnMostrarTodo.Size = new Size(168, 55);
            btnMostrarTodo.TabIndex = 41;
            btnMostrarTodo.Text = "Productos";
            btnMostrarTodo.TextAlign = ContentAlignment.MiddleRight;
            btnMostrarTodo.UseVisualStyleBackColor = true;
            btnMostrarTodo.Click += btnMostrarTodo_Click;
            btnMostrarTodo.MouseEnter += btnMostrarTodo_MouseEnter;
            btnMostrarTodo.MouseLeave += btnMostrarTodo_MouseLeave;
            // 
            // btnGabinetes
            // 
            btnGabinetes.Dock = DockStyle.Left;
            btnGabinetes.FlatAppearance.BorderSize = 0;
            btnGabinetes.FlatStyle = FlatStyle.Popup;
            btnGabinetes.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGabinetes.ForeColor = Color.Gray;
            btnGabinetes.IconChar = FontAwesome.Sharp.IconChar.Cube;
            btnGabinetes.IconColor = Color.Gray;
            btnGabinetes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGabinetes.IconSize = 35;
            btnGabinetes.ImageAlign = ContentAlignment.MiddleLeft;
            btnGabinetes.Location = new Point(810, 0);
            btnGabinetes.Margin = new Padding(3, 4, 3, 4);
            btnGabinetes.Name = "btnGabinetes";
            btnGabinetes.Size = new Size(135, 55);
            btnGabinetes.TabIndex = 40;
            btnGabinetes.Text = "Gabinetes";
            btnGabinetes.TextAlign = ContentAlignment.MiddleRight;
            btnGabinetes.UseVisualStyleBackColor = true;
            btnGabinetes.Click += btnGabinetes_Click;
            btnGabinetes.MouseEnter += btnGabinetes_MouseEnter;
            btnGabinetes.MouseLeave += btnGabinetes_MouseLeave;
            // 
            // tmrTiempoParaSeleccionar
            // 
            tmrTiempoParaSeleccionar.Interval = 5000;
            // 
            // lvwProductos
            // 
            lvwProductos.Location = new Point(847, 37);
            lvwProductos.Name = "lvwProductos";
            lvwProductos.Size = new Size(190, 38);
            lvwProductos.TabIndex = 53;
            lvwProductos.UseCompatibleStateImageBehavior = false;
            // 
            // flpProductos
            // 
            flpProductos.AutoScroll = true;
            flpProductos.BackColor = Color.Gray;
            flpProductos.Dock = DockStyle.Top;
            flpProductos.Location = new Point(0, 0);
            flpProductos.Name = "flpProductos";
            flpProductos.Size = new Size(1145, 558);
            flpProductos.TabIndex = 54;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Gray;
            ClientSize = new Size(1145, 619);
            Controls.Add(panel1);
            Controls.Add(flpProductos);
            Controls.Add(lvwProductos);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FrmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCategorias";
            WindowState = FormWindowState.Maximized;
            Load += FrmCategorias_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private FontAwesome.Sharp.IconButton btnProcesadores;
        private FontAwesome.Sharp.IconButton btnAlmacenamiento;
        private FontAwesome.Sharp.IconButton btnGraficas;
        private FontAwesome.Sharp.IconButton btnMemorias;
        private FontAwesome.Sharp.IconButton btnPerifericos;
        private FontAwesome.Sharp.IconButton btnMother;
        private FontAwesome.Sharp.IconButton btnGabinetes;
        private System.Windows.Forms.Timer tmrTiempoParaSeleccionar;
        private FontAwesome.Sharp.IconButton btnMostrarTodo;
        private ListView lvwProductos;
        private FlowLayoutPanel flpProductos;
    }
}