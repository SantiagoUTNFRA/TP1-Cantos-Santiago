namespace UI_ByteBay.Forms
{
    partial class FrmContactanos
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
            lblDireccion = new Label();
            lblTelefono = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMensaje = new TextBox();
            txtNombre = new TextBox();
            txtCorreoElectronico = new TextBox();
            label3 = new Label();
            btnGoInstagram = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            btnGoReddit = new FontAwesome.Sharp.IconButton();
            btnGoTwitter = new FontAwesome.Sharp.IconButton();
            btnGoTikTok = new FontAwesome.Sharp.IconButton();
            btnGoFacebook = new FontAwesome.Sharp.IconButton();
            btnEnviar = new FontAwesome.Sharp.IconButton();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblDireccion.ForeColor = Color.FromArgb(20, 25, 25);
            lblDireccion.Location = new Point(482, 29);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(205, 45);
            lblDireccion.TabIndex = 42;
            lblDireccion.Text = "Contáctenos";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefono.Location = new Point(319, 123);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(91, 25);
            lblTelefono.TabIndex = 43;
            lblTelefono.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(227, 184);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 44;
            label2.Text = "Correo electrónico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(320, 245);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 45;
            label1.Text = "Mensaje:";
            // 
            // txtMensaje
            // 
            txtMensaje.BackColor = Color.Gray;
            txtMensaje.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMensaje.ForeColor = Color.FromArgb(25, 25, 25);
            txtMensaje.Location = new Point(443, 245);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.PlaceholderText = "Ingrese su mensaje aquí";
            txtMensaje.Size = new Size(333, 137);
            txtMensaje.TabIndex = 46;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Gray;
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.Location = new Point(443, 123);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese su nombre aquí";
            txtNombre.Size = new Size(333, 37);
            txtNombre.TabIndex = 47;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.BackColor = Color.Gray;
            txtCorreoElectronico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtCorreoElectronico.Location = new Point(443, 184);
            txtCorreoElectronico.Multiline = true;
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.PlaceholderText = "Ingrese su correo electronico aquí";
            txtCorreoElectronico.Size = new Size(333, 37);
            txtCorreoElectronico.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 452);
            label3.Name = "label3";
            label3.Size = new Size(371, 25);
            label3.TabIndex = 49;
            label3.Text = "Encuentranos en nuestras redes sociales:";
            // 
            // btnGoInstagram
            // 
            btnGoInstagram.FlatStyle = FlatStyle.Flat;
            btnGoInstagram.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoInstagram.ForeColor = Color.Gray;
            btnGoInstagram.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            btnGoInstagram.IconColor = Color.Gray;
            btnGoInstagram.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGoInstagram.IconSize = 50;
            btnGoInstagram.ImageAlign = ContentAlignment.MiddleLeft;
            btnGoInstagram.Location = new Point(12, 13);
            btnGoInstagram.Name = "btnGoInstagram";
            btnGoInstagram.Size = new Size(154, 61);
            btnGoInstagram.TabIndex = 50;
            btnGoInstagram.Text = "Instagram";
            btnGoInstagram.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGoInstagram.UseVisualStyleBackColor = true;
            btnGoInstagram.Click += btnGoInstagram_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(20, 25, 25);
            panel4.Controls.Add(btnGoReddit);
            panel4.Controls.Add(btnGoTwitter);
            panel4.Controls.Add(btnGoTikTok);
            panel4.Controls.Add(btnGoFacebook);
            panel4.Controls.Add(btnGoInstagram);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 533);
            panel4.Name = "panel4";
            panel4.Size = new Size(1145, 86);
            panel4.TabIndex = 51;
            // 
            // btnGoReddit
            // 
            btnGoReddit.FlatStyle = FlatStyle.Flat;
            btnGoReddit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoReddit.ForeColor = Color.Gray;
            btnGoReddit.IconChar = FontAwesome.Sharp.IconChar.Reddit;
            btnGoReddit.IconColor = Color.Gray;
            btnGoReddit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGoReddit.IconSize = 50;
            btnGoReddit.ImageAlign = ContentAlignment.MiddleLeft;
            btnGoReddit.Location = new Point(655, 13);
            btnGoReddit.Name = "btnGoReddit";
            btnGoReddit.Size = new Size(154, 61);
            btnGoReddit.TabIndex = 54;
            btnGoReddit.Text = "Reddit";
            btnGoReddit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGoReddit.UseVisualStyleBackColor = true;
            btnGoReddit.Click += btnGoReddit_Click;
            // 
            // btnGoTwitter
            // 
            btnGoTwitter.FlatStyle = FlatStyle.Flat;
            btnGoTwitter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoTwitter.ForeColor = Color.Gray;
            btnGoTwitter.IconChar = FontAwesome.Sharp.IconChar.Twitter;
            btnGoTwitter.IconColor = Color.Gray;
            btnGoTwitter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGoTwitter.IconSize = 50;
            btnGoTwitter.ImageAlign = ContentAlignment.MiddleLeft;
            btnGoTwitter.Location = new Point(495, 13);
            btnGoTwitter.Name = "btnGoTwitter";
            btnGoTwitter.Size = new Size(154, 61);
            btnGoTwitter.TabIndex = 53;
            btnGoTwitter.Text = "Twitter";
            btnGoTwitter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGoTwitter.UseVisualStyleBackColor = true;
            btnGoTwitter.Click += btnGoTwitter_Click;
            // 
            // btnGoTikTok
            // 
            btnGoTikTok.FlatStyle = FlatStyle.Flat;
            btnGoTikTok.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoTikTok.ForeColor = Color.Gray;
            btnGoTikTok.IconChar = FontAwesome.Sharp.IconChar.Tiktok;
            btnGoTikTok.IconColor = Color.Gray;
            btnGoTikTok.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGoTikTok.IconSize = 50;
            btnGoTikTok.ImageAlign = ContentAlignment.MiddleLeft;
            btnGoTikTok.Location = new Point(332, 13);
            btnGoTikTok.Name = "btnGoTikTok";
            btnGoTikTok.Size = new Size(154, 61);
            btnGoTikTok.TabIndex = 52;
            btnGoTikTok.Text = "TikTok";
            btnGoTikTok.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGoTikTok.UseVisualStyleBackColor = true;
            btnGoTikTok.Click += btnGoTikTok_Click;
            // 
            // btnGoFacebook
            // 
            btnGoFacebook.FlatStyle = FlatStyle.Flat;
            btnGoFacebook.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoFacebook.ForeColor = Color.Gray;
            btnGoFacebook.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            btnGoFacebook.IconColor = Color.Gray;
            btnGoFacebook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGoFacebook.IconSize = 50;
            btnGoFacebook.ImageAlign = ContentAlignment.MiddleLeft;
            btnGoFacebook.Location = new Point(172, 13);
            btnGoFacebook.Name = "btnGoFacebook";
            btnGoFacebook.Size = new Size(154, 61);
            btnGoFacebook.TabIndex = 51;
            btnGoFacebook.Text = "Facebook";
            btnGoFacebook.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGoFacebook.UseVisualStyleBackColor = true;
            btnGoFacebook.Click += btnGoFacebook_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviar.ForeColor = Color.FromArgb(20, 25, 25);
            btnEnviar.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            btnEnviar.IconColor = Color.FromArgb(20, 25, 25);
            btnEnviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEnviar.IconSize = 50;
            btnEnviar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnviar.Location = new Point(533, 388);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(154, 61);
            btnEnviar.TabIndex = 55;
            btnEnviar.Text = "Enviar";
            btnEnviar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // FrmContactanos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1145, 619);
            Controls.Add(btnEnviar);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(txtNombre);
            Controls.Add(txtMensaje);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Name = "FrmContactanos";
            Text = "FrmContactanos";
            Load += FrmContactanos_Load;
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDireccion;
        private Label lblTelefono;
        private Label label2;
        private Label label1;
        private TextBox txtMensaje;
        private TextBox txtNombre;
        private TextBox txtCorreoElectronico;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnGoInstagram;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnGoFacebook;
        private FontAwesome.Sharp.IconButton btnGoTikTok;
        private FontAwesome.Sharp.IconButton btnGoTwitter;
        private FontAwesome.Sharp.IconButton btnGoReddit;
        private FontAwesome.Sharp.IconButton btnEnviar;
    }
}