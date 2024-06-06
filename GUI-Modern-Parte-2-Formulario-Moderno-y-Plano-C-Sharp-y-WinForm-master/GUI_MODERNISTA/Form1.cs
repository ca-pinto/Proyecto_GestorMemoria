using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI_MODERNISTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btninicio_Click(null ,e);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
           
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            PanelOptimo panelOptimo = new PanelOptimo();
            AbrirFormEnPanel(panelOptimo);
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelSegundaOp SegundaOportunidad = new PanelSegundaOp();
            AbrirFormEnPanel(SegundaOportunidad);
        }

        private void BTNventas_Click(object sender, EventArgs e)
        {
            PanelFIFO panelFIFO = new PanelFIFO();
            AbrirFormEnPanel(panelFIFO);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelNRU panelNRU = new PanelNRU();
            AbrirFormEnPanel(panelNRU);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PanelReloj panelReloj = new PanelReloj();
            AbrirFormEnPanel(panelReloj);
        }
    }
}
