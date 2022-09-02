using System.Runtime.InteropServices; 

namespace BibliotecaAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text= "";
                txtUsuario.ForeColor = Color.LightGray; 
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray; 
            }
        }

        private void txtcontrase�a_Leave(object sender, EventArgs e)
        {
            if (txtcontrase�a.Text == "")
            {
                txtcontrase�a.Text = "Contrase�a";
                txtcontrase�a.ForeColor = Color.DimGray;
                txtcontrase�a.UseSystemPasswordChar = false;
            }
        }

        private void txtcontrase�a_Enter(object sender, EventArgs e)
        {
            if (txtcontrase�a.Text == "Contrase�a")
            {
                txtcontrase�a.Text = " ";
                txtcontrase�a.ForeColor = Color.LightGray;
                txtcontrase�a.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0); 
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}