using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Autor
    {
        private string alias;
        private string nombre;
        private int documento;
        private bool sexo;

        public string pAlias
        { get { return alias; } set { alias = value; } }
        public string pNombre
        { get { return nombre; } set { nombre = value; } }
        public int pDocumento
        { get { return documento; } set { documento = value; } }
        public bool pSexo
        { get { return sexo; } set { sexo = value; } }

        public Autor()
        {
            alias = nombre = string.Empty;
            documento = 0;
            sexo = false;
        }
        public Autor(string alias, string nombre, int documento, bool sexo)
        {
            this.alias = alias;
            this.nombre = nombre;
            this.documento = documento;
            this.sexo = sexo;
        }  
        public string MostrarAutor()
        {
            return "\n Alias: " + alias
                    + "\n Nombre: " + nombre
                    + "\n Documento: " + documento
                    + "\n Sexo: " + this.MostrarSexo();
        }
        public string MostrarSexo()
        {
            string aux = "Femenino";
            if (sexo)   //(sexo==true)
                aux = "Masculino";
            return aux;
        }
    }
}
