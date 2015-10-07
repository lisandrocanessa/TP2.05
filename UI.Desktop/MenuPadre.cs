using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;

namespace UI.Desktop
{
    public partial class MenuPadre : ApplicationForm
    {
        public MenuPadre()
        {
            InitializeComponent();
        }

        private void MenuPadre_Load(object sender, EventArgs e)
        {
            iniciarSesion();
        }

        private void iniciarSesion()
        {
            if (UsuarioSesion.Sesion == null)
            {
                Login l = new Login();
                l.ShowDialog();
                if (l.DialogResult != DialogResult.OK)
                {
                    this.Dispose();
                }
                else
                {
                    this.lblApellido.Text = UsuarioSesion.Sesion.Apellido;
                    this.lblNombre.Text = UsuarioSesion.Sesion.Nombre;
                    this.lblTipo.Text = UsuarioSesion.Sesion.TipoPersona.ToString();
                }
            }
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioSesion.Sesion = null;
            this.iniciarSesion();
            
        }

        private void verDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Show();            
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarContraseña cc = new CambiarContraseña();
            cc.Show();
        }

        private void planesYMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanMaterias p = new PlanMaterias();
            p.Show();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }



    }
}
