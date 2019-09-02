using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Clases
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

        public int Id_libro { get { return id_libro; } set { id_libro = value;} }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public int AñoEdicion { get { return añoEdicion; } set { añoEdicion = value; } }
        public int Id_genero { get { return id_genero; } set { id_genero = value; } }
        public int Id_autor { get { return id_autor; } set { id_autor = value; } }
        public int Id_editorial { get { return id_editorial; } set { id_editorial = value; } }
        public string Sector { get { return sector; } set { sector = value; } }
        public int Estante { get { return estante; } set { estante = value; }}


    }
}
