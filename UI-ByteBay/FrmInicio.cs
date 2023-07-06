namespace UI_ByteBay
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            ListBoxLogger.Instance.Log("Inicio de la aplicación");
        }
    
        private void ConfigurarFormulario()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.Manual;
            ShowInTaskbar = false;
            ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }
    }
}
