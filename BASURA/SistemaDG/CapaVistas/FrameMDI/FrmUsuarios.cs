using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaVistas.FrameMDI
{
    public partial class FrmUsuarios : Form
    {
        int renglon1, renglon2;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtId.Text = " ";
            txtId_Rol.Text = " ";
            txtUser.Text = " ";
            txtPass.Text = " ";
        }

        private void MostrarTablas()
        {
            //Tabla de Rol
            dgvRoles.DataSource = null;
            dgvRoles.DataSource = Rol_Controller.ViewDataRol();

            //Tabla de Usuarios
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Usuario_Controller.ViewDataUsuario();
        }
        
        private void TblUser()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Usuario_Controller.ViewDataUsuario();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarTablas();
        }

        //TABLAS
        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon1 = e.RowIndex;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon2 = e.RowIndex;
        }

        private void dgvRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            if (e.RowIndex >= 0) {
                id = dgvRoles.Rows[renglon1].Cells["Id"].Value.ToString();
                txtId_Rol.Text = id;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila de la Tabla");
                return;
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, user, pass, rol;

            if (e.RowIndex >= 0)
            {
                id = dgvUsuarios.Rows[renglon2].Cells["Id"].Value.ToString();
                txtId.Text = id;
                user = dgvUsuarios.Rows[renglon2].Cells["Usuario"].Value.ToString();
                txtUser.Text = user;
                pass = dgvUsuarios.Rows[renglon2].Cells["Contraseña"].Value.ToString();
                txtPass.Text = pass;
                rol = dgvUsuarios.Rows[renglon2].Cells["Id Rol"].Value.ToString();
                txtId_Rol.Text = rol;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila de la Tabla");
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string user, pass;
            int rol;

            if (txtUser.Text == " " || txtPass.Text == " " || txtId_Rol.Text == " ")
            {
                MessageBox.Show("Error de Campos");
                return;
            }
            else
            {
                user = txtUser.Text;
                pass = txtPass.Text;
                rol = Convert.ToInt32(txtId_Rol.Text);

                Usuario_Controller.InsertDataUsuario(user, pass, rol);
                TblUser();
                Clear();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id;
            string user, pass;
            int rol;

            if (txtUser.Text == " " || txtPass.Text == " " || txtId_Rol.Text == " ")
            {
                MessageBox.Show("Error de Campos");
                return;
            }
            else
            {
                user = txtUser.Text;
                pass = txtPass.Text;
                rol = Convert.ToInt32(txtId_Rol.Text);
                id = Convert.ToInt32(txtId.Text);

                Usuario_Controller.UpdateDataUsuario(id, user, pass, rol);   
                TblUser();
                Clear();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(txtId.Text);

            if (txtId.Text == " ")
            {
                MessageBox.Show("Debe seleccionar un Id");
                return;
            }
            else
            {
                Usuario_Controller.UnsubScribeDataUsuario(id);   
                TblUser();
                Clear();
            }
        }

    }//Final 
}
