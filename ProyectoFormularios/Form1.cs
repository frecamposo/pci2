using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ReferenciaWEB.ServicioWEBClient WS;
                WS = new ReferenciaWEB.ServicioWEBClient();
                int x = WS.validacion(txtUsuario.Text, txtPass.Text);
                if (x!=0)
                {
                    MessageBox.Show("Credenciales Correctas");
                    FrmMenu MENU = new FrmMenu();
                    MENU.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario / Pass incorrecto");
                    Logger.Mensaje("NO TAAA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Ingreso");
                Logger.Mensaje(ex.Message);                
            }
        }
    }
}
