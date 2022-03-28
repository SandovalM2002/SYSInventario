using CapaVistas.FrameMDI;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CapaVistas
{
    public partial class FrmMenu : Form
    {

        //Varibles para redimiensionar
        private int locationX;
        private int locationY;
        //Variables para Regresar
        static FrmMenu _obj;
        //Constructor
        public FrmMenu()
        {
            InitializeComponent();
            PantallaOk();
           // btnRegresar.Visible = false;
            _obj = this;
        }
        
        public static FrmMenu Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FrmMenu();
                }
                return _obj;
            }
        }

        //Metodos Creadors
        private void PantallaOk()
        {
            locationX = this.Location.X;
            locationY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        //Seguir al Boton
        private void SeguirBoton(Bunifu.Framework.UI.BunifuTileButton sender)
        {
            Flecha.Top = sender.Bottom;
        }
     
        //Agregar una Nueva Pestana
        private void AddWindow<CustomForm>() where CustomForm : Form, new()
        {
            Form window = pnlContenedor.Controls.OfType<CustomForm>().FirstOrDefault();
            
               window = new CustomForm();
               window.TopLevel = false;
               window.Dock = DockStyle.Fill;
               pnlContenedor.Controls.Add(window);
               pnlContenedor.Tag = window;
               window.Show();
               window.BringToFront();   
        }
       
        //----------Metodos Generados
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            PantallaOk();
            AddWindow<FrmHome>();
            Flecha.Visible = true;
        }

        //-----------------BOTONES PRINCIPALES DEL FRAME
        private void btnHome_Click(object sender, EventArgs e)
        {
            SeguirBoton(btnHome);
            AddWindow<FrmHome>();
            Flecha.Visible = true;
        }
    
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AddWindow<FrmClientes>();
            SeguirBoton(btnClientes);
            Flecha.Visible = true;
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            AddWindow<FrmConfiguracion>();
            Flecha.Visible = false;
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            AddWindow<FrmProductos>();
            SeguirBoton(btnProducto);
            Flecha.Visible = true;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AddWindow<FrmInventario>();
            SeguirBoton(btnInventario);
            Flecha.Visible = true;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AddWindow<FrmCompra>();
            SeguirBoton(btnCompras);
            Flecha.Visible = true;
        }
 
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SeguirBoton(btnUsuarios);
            AddWindow<FrmUsuarios>();
            Flecha.Visible = true;
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            AddWindow<FrmEmpleado>();
            SeguirBoton(btnEmpleado);
            Flecha.Visible = true;
        }
        
        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            AddWindow<FrmOrdenes>();
            SeguirBoton(btnOrdenes);
            Flecha.Visible = true;
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AddWindow<FrmProveedor>();
            SeguirBoton(btnProveedor);
            Flecha.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }//---------------------------------------
}//-------------------------------------------
