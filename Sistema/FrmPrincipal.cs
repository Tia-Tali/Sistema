using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            //cria uma thread para rodar o form splash
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            t.Interrupt();
            CloseForm();
            InitializeComponent();
            InitializeComponent();
        }
        public void StartForm()
        {
            Application.Run(new FrmSplashScreen());
        }
        public void CloseForm()
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresa frmEmpresa = new FrmEmpresa();
            frmEmpresa.MdiParent = this;
            frmEmpresa.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
