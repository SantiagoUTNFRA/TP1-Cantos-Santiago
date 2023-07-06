namespace UI_ByteBay
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnIniciarSesion = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnIniciarSesionInvitado = new FontAwesome.Sharp.IconButton();
            btnRegistrarse = new FontAwesome.Sharp.IconButton();
            tbcAll = new TabControl();
            tpIniciar = new TabPage();
            btnAutoComplete = new FontAwesome.Sharp.IconButton();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            txtContrasenia = new TextBox();
            txtUsuario = new TextBox();
            label5 = new Label();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            label6 = new Label();
            btnIniciar = new FontAwesome.Sharp.IconButton();
            tpRegistrarse = new TabPage();
            btnRegistro = new FontAwesome.Sharp.IconButton();
            txtDniRegistro = new TextBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtContraseniaRegistro = new TextBox();
            txtUsuarioRegistro = new TextBox();
            label1 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            tbcAll.SuspendLayout();
            tpIniciar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            tpRegistrarse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(20, 25, 25);
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnIniciarSesion, "btnIniciarSesion");
            btnIniciarSesion.ForeColor = Color.Gray;
            btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            btnIniciarSesion.IconColor = Color.Gray;
            btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Tag = "";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            btnIniciarSesion.MouseEnter += btnIniciarSesion_MouseEnter;
            btnIniciarSesion.MouseLeave += btnIniciarSesion_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 25, 25);
            panel1.Controls.Add(btnIniciarSesionInvitado);
            panel1.Controls.Add(btnRegistrarse);
            panel1.Controls.Add(btnIniciarSesion);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // btnIniciarSesionInvitado
            // 
            btnIniciarSesionInvitado.BackColor = Color.FromArgb(20, 25, 25);
            btnIniciarSesionInvitado.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnIniciarSesionInvitado, "btnIniciarSesionInvitado");
            btnIniciarSesionInvitado.ForeColor = Color.Gray;
            btnIniciarSesionInvitado.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            btnIniciarSesionInvitado.IconColor = Color.Gray;
            btnIniciarSesionInvitado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnIniciarSesionInvitado.Name = "btnIniciarSesionInvitado";
            btnIniciarSesionInvitado.Tag = "";
            btnIniciarSesionInvitado.UseVisualStyleBackColor = false;
            btnIniciarSesionInvitado.Click += btnIniciarSesionInvitado_Click;
            btnIniciarSesionInvitado.MouseEnter += btnIniciarSesionInvitado_MouseEnter;
            btnIniciarSesionInvitado.MouseLeave += btnIniciarSesionInvitado_MouseLeave;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.FromArgb(20, 25, 25);
            btnRegistrarse.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnRegistrarse, "btnRegistrarse");
            btnRegistrarse.ForeColor = Color.Gray;
            btnRegistrarse.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnRegistrarse.IconColor = Color.Gray;
            btnRegistrarse.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Tag = "";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            btnRegistrarse.MouseEnter += btnRegistrarse_MouseEnter;
            btnRegistrarse.MouseLeave += btnRegistrarse_MouseLeave;
            // 
            // tbcAll
            // 
            tbcAll.AccessibleRole = AccessibleRole.None;
            resources.ApplyResources(tbcAll, "tbcAll");
            tbcAll.Controls.Add(tpIniciar);
            tbcAll.Controls.Add(tpRegistrarse);
            tbcAll.Multiline = true;
            tbcAll.Name = "tbcAll";
            tbcAll.SelectedIndex = 0;
            // 
            // tpIniciar
            // 
            tpIniciar.BackColor = Color.Gray;
            tpIniciar.BorderStyle = BorderStyle.FixedSingle;
            tpIniciar.Controls.Add(btnAutoComplete);
            tpIniciar.Controls.Add(iconPictureBox5);
            tpIniciar.Controls.Add(txtContrasenia);
            tpIniciar.Controls.Add(txtUsuario);
            tpIniciar.Controls.Add(label5);
            tpIniciar.Controls.Add(iconPictureBox6);
            tpIniciar.Controls.Add(label6);
            tpIniciar.Controls.Add(btnIniciar);
            resources.ApplyResources(tpIniciar, "tpIniciar");
            tpIniciar.Name = "tpIniciar";
            // 
            // btnAutoComplete
            // 
            resources.ApplyResources(btnAutoComplete, "btnAutoComplete");
            btnAutoComplete.ForeColor = Color.FromArgb(20, 25, 25);
            btnAutoComplete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAutoComplete.IconColor = Color.Black;
            btnAutoComplete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAutoComplete.Name = "btnAutoComplete";
            btnAutoComplete.UseVisualStyleBackColor = true;
            btnAutoComplete.Click += btnAutoComplete_Click;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.Gray;
            iconPictureBox5.ForeColor = Color.FromArgb(20, 25, 25);
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox5.IconColor = Color.FromArgb(20, 25, 25);
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 52;
            resources.ApplyResources(iconPictureBox5, "iconPictureBox5");
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.TabStop = false;
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = Color.Gray;
            txtContrasenia.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtContrasenia, "txtContrasenia");
            txtContrasenia.ForeColor = SystemColors.ControlText;
            txtContrasenia.Name = "txtContrasenia";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Gray;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtUsuario, "txtUsuario");
            txtUsuario.ForeColor = SystemColors.ControlText;
            txtUsuario.Name = "txtUsuario";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.FromArgb(20, 25, 25);
            label5.Name = "label5";
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.Gray;
            iconPictureBox6.ForeColor = Color.FromArgb(20, 25, 25);
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPictureBox6.IconColor = Color.FromArgb(20, 25, 25);
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 52;
            resources.ApplyResources(iconPictureBox6, "iconPictureBox6");
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.FromArgb(20, 25, 25);
            label6.Name = "label6";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Gray;
            btnIniciar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnIniciar, "btnIniciar");
            btnIniciar.ForeColor = Color.FromArgb(20, 25, 25);
            btnIniciar.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            btnIniciar.IconColor = Color.FromArgb(20, 25, 25);
            btnIniciar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Tag = "";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            btnIniciar.MouseEnter += btnIniciar_MouseEnter;
            btnIniciar.MouseLeave += btnIniciar_MouseLeave;
            // 
            // tpRegistrarse
            // 
            tpRegistrarse.BackColor = Color.Gray;
            tpRegistrarse.Controls.Add(btnRegistro);
            tpRegistrarse.Controls.Add(txtDniRegistro);
            tpRegistrarse.Controls.Add(iconPictureBox3);
            tpRegistrarse.Controls.Add(label3);
            tpRegistrarse.Controls.Add(iconPictureBox1);
            tpRegistrarse.Controls.Add(txtContraseniaRegistro);
            tpRegistrarse.Controls.Add(txtUsuarioRegistro);
            tpRegistrarse.Controls.Add(label1);
            tpRegistrarse.Controls.Add(iconPictureBox2);
            tpRegistrarse.Controls.Add(label2);
            resources.ApplyResources(tpRegistrarse, "tpRegistrarse");
            tpRegistrarse.Name = "tpRegistrarse";
            // 
            // btnRegistro
            // 
            btnRegistro.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnRegistro, "btnRegistro");
            btnRegistro.ForeColor = Color.FromArgb(20, 25, 25);
            btnRegistro.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            btnRegistro.IconColor = Color.FromArgb(20, 25, 25);
            btnRegistro.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Tag = "";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            btnRegistro.MouseEnter += btnRegistro_MouseEnter;
            btnRegistro.MouseLeave += btnRegistro_MouseLeave;
            // 
            // txtDniRegistro
            // 
            txtDniRegistro.BackColor = Color.Gray;
            txtDniRegistro.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtDniRegistro, "txtDniRegistro");
            txtDniRegistro.ForeColor = SystemColors.ControlText;
            txtDniRegistro.Name = "txtDniRegistro";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Gray;
            iconPictureBox3.ForeColor = Color.FromArgb(20, 25, 25);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            iconPictureBox3.IconColor = Color.FromArgb(20, 25, 25);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 52;
            resources.ApplyResources(iconPictureBox3, "iconPictureBox3");
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.ControlText;
            label3.Name = "label3";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Gray;
            iconPictureBox1.ForeColor = Color.FromArgb(20, 25, 25);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.FromArgb(20, 25, 25);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 52;
            resources.ApplyResources(iconPictureBox1, "iconPictureBox1");
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.TabStop = false;
            // 
            // txtContraseniaRegistro
            // 
            txtContraseniaRegistro.BackColor = Color.Gray;
            txtContraseniaRegistro.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtContraseniaRegistro, "txtContraseniaRegistro");
            txtContraseniaRegistro.ForeColor = SystemColors.ControlText;
            txtContraseniaRegistro.Name = "txtContraseniaRegistro";
            // 
            // txtUsuarioRegistro
            // 
            txtUsuarioRegistro.BackColor = Color.Gray;
            txtUsuarioRegistro.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(txtUsuarioRegistro, "txtUsuarioRegistro");
            txtUsuarioRegistro.ForeColor = SystemColors.ControlText;
            txtUsuarioRegistro.Name = "txtUsuarioRegistro";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ControlText;
            label1.Name = "label1";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Gray;
            iconPictureBox2.ForeColor = Color.FromArgb(20, 25, 25);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPictureBox2.IconColor = Color.FromArgb(20, 25, 25);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 52;
            resources.ApplyResources(iconPictureBox2, "iconPictureBox2");
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.ControlText;
            label2.Name = "label2";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 25, 25);
            Controls.Add(tbcAll);
            Controls.Add(panel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Login";
            panel1.ResumeLayout(false);
            tbcAll.ResumeLayout(false);
            tpIniciar.ResumeLayout(false);
            tpIniciar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            tpRegistrarse.ResumeLayout(false);
            tpRegistrarse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnIniciarSesion;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnRegistrarse;
        private FontAwesome.Sharp.IconButton btnIniciarSesionInvitado;
        private TabControl tbcAll;
        private TabPage tpIniciar;
        private TabPage tpRegistrarse;
        private FontAwesome.Sharp.IconButton btnIniciar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtContraseniaRegistro;
        private TextBox txtUsuarioRegistro;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label2;
        private TextBox txtDniRegistro;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private TextBox txtContrasenia;
        private TextBox txtUsuario;
        private Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnRegistro;
        private FontAwesome.Sharp.IconButton btnAutoComplete;
    }
}