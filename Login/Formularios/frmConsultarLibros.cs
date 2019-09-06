using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Aplicaciones_Visuales.Clases;

namespace TP_Aplicaciones_Visuales.Formularios
{
    public partial class frmConsultarLibros : Form
    {

        Libro oLibro = new Libro();
        public frmConsultarLibros()
        {
            InitializeComponent();
        }

        private void ConsultarLibros_Load(object sender, EventArgs e)
        {
            cargarComboBox(cboAutor, "Autor");
            cargarComboBox(cboEditorial, "Editorial");
            cargarComboBox(cboGenero, "Genero");
            grdLibros.DataSource = DBConexion.GetDBConexion().storeProcedureSql("listarLibros");

        //    actualizarCampos(Convert.ToInt32(grdLibros.CurrentRow.Cells[0].Value));

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void cargarComboBox(ComboBox cbo, string NombreTabla)
        {
            DataTable tabla = new DataTable();
            string consulta = "SELECT * FROM " + NombreTabla;
            tabla = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            cbo.DataSource = tabla;
            cbo.DisplayMember = tabla.Columns[1].ColumnName;
            cbo.ValueMember = tabla.Columns[0].ColumnName;
        }
        private void habilitar(bool x)
        {   

            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
        }
        private void actualizarCampos(int id)
        {
            DataTable tabla = new DataTable();
            tabla = oLibro.recuperarLibroID(id);
            txtTitulo.Text = tabla.Rows[0]["titulo"].ToString();
            txtAño.Text = tabla.Rows[0]["añoEdicion"].ToString();
            txtSector.Text = tabla.Rows[0]["sector"].ToString();
            txtEstante.Text = tabla.Rows[0]["estante"].ToString();
            cboGenero.SelectedValue = tabla.Rows[0]["idGenero"];
            cboAutor.SelectedValue = tabla.Rows[0]["idAutor"];
            cboEditorial.SelectedValue = tabla.Rows[0]["idEditorial"];
        }
        //private void actualizarCampos(int id)
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = oUsuario.recuperarUsuarioID(id);
        //    txtId.Text = tabla.Rows[0]["id_usuario"].ToString();
        //    txtNombre.Text = tabla.Rows[0]["n_usuario"].ToString();
        //    txtPassword.Text = tabla.Rows[0]["password"].ToString();
        //    txtEmail.Text = tabla.Rows[0]["email"].ToString();
        //    cboPerfil.SelectedValue = tabla.Rows[0]["id_perfil"];
        //}



        private void GrdLibros_SelectionChanged(object sender, EventArgs e)
        {
            actualizarCampos(Convert.ToInt32(grdLibros.CurrentRow.Cells[0].Value));
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}

