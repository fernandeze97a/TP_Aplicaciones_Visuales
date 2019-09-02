using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Aplicaciones_Visuales.Formularios
{
    public partial class frmConsultarLibros : Form
    {
        public frmConsultarLibros()
        {
            InitializeComponent();
        }

        private void ConsultarLibros_Load(object sender, EventArgs e)
        {
            cargarComboBox(cboAutor, "Autor");
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
    }
}
