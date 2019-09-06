using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TP_Aplicaciones_Visuales.Clases
{
    class Libro
    {
        private int id_libro;
        private string titulo;
        private int añoEdicion;
        private int id_genero;
        private int id_autor;
        private int id_editorial;
        private string sector;
        private int estante;
        private bool estado;

        public int Id_libro { get { return id_libro; } set { id_libro = value;} }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public int AñoEdicion { get { return añoEdicion; } set { añoEdicion = value; } }
        public int Id_genero { get { return id_genero; } set { id_genero = value; } }
        public int Id_autor { get { return id_autor; } set { id_autor = value; } }
        public int Id_editorial { get { return id_editorial; } set { id_editorial = value; } }
        public string Sector { get { return sector; } set { sector = value; } }
        public int Estante { get { return estante; } set { estante = value; }}

      


  
        public DataTable recuperarLibros()
        {
            return DBConexion.GetDBConexion().ConsultaSQL("Select * from Libro");
        }
      
        public void grabarLibro()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO Libro VALUES ('" +
                         this.titulo + "', '" +
                         this.añoEdicion.ToString() + "', '" +
                         this.id_genero.ToString() + "', " +
                         this.id_autor.ToString() +
                         this.id_editorial.ToString() + "', " +
                         this.sector + "', " +
                         this.estante.ToString() + "', " + ")";

            DBConexion.GetDBConexion().ConsultaSQL(sqlInsert);
        }
        public void actualizarLibro()
        {
            string sqlUpDate = "";
            sqlUpDate = @"UPDATE Libro SET titulo='" + this.titulo + "'," +
                                         "añoEdicion='" + this.añoEdicion.ToString() + "'," +
                                         "idGenero='" + this.id_genero.ToString() + "'," +
                                         "idAutor=" + this.id_autor.ToString() +
                                         "idEditorial="+ this.id_editorial.ToString() + "', " +
                                         "sector=" + this.sector + "', " +
                                         "estante" + this.estante.ToString() + "', " + 
                                         "WHERE idLibro=" + this.id_libro + ")"; 
            DBConexion.GetDBConexion().actualizarEliminar(sqlUpDate);
        }
        public void eliminarLibro()
        {
            string sqlDelete = @"DELETE FROM Libro WHERE idLibro=" + this.id_libro;
            DBConexion.GetDBConexion().actualizarEliminar(sqlDelete);
        }

        public DataTable recuperarLibroID(int id)
        {
            return DBConexion.GetDBConexion().ConsultaSQL(@"SELECT * FROM Libro WHERE idLibro=" + id);
        }
    }
}
