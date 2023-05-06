using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioOcasional : Archivo
    {

        public RepositorioOcasional(string ruta) : base(ruta)
        {

        }


        public Ocasionales Mappeador(String linea)
        {
            var ocasional = new Ocasionales();
            string[] aux = linea.Split(';');
            ocasional.Identificacion = int.Parse(aux[0]);
            ocasional.Nombres = aux[1];
            ocasional.Apellidos = aux[2];
            ocasional.Correo = aux[3];
            ocasional.Telefono = int.Parse(aux[4]);
            ocasional.Posgrado = aux[5];
            ocasional.Semillero = aux[6];
            ocasional.Time = aux[7];

            return ocasional;
        }

        public List<Ocasionales> ConsultarTodos()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Ocasionales> ocasionales = new List<Ocasionales>();
                while (!sr.EndOfStream)
                {
                    ocasionales.Add(Mappeador(sr.ReadLine()));
                }
                sr.Close();
                return ocasionales;
            }
            catch (Exception)
            {

                return null;
            }
        }

    }
}
