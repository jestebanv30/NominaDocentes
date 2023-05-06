using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioCatedratico : Archivo
    {

        public RepositorioCatedratico(string ruta) : base(ruta)
        {

        }


        public Catedraticos Mappeador(String linea)
        {
            var catedraticos = new Catedraticos();
            string[] aux = linea.Split(';');
            catedraticos.Identificacion = int.Parse(aux[0]);
            catedraticos.Nombres = aux[1];
            catedraticos.Apellidos = aux[2];
            catedraticos.Correo = aux[3];
            catedraticos.Telefono = int.Parse(aux[4]);
            catedraticos.Posgrado = aux[5];
            catedraticos.Semillero = aux[6];


            return catedraticos;
        }

        public List<Catedraticos> ConsultarTodos()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Catedraticos> catedraticos = new List<Catedraticos>();
                while (!sr.EndOfStream)
                {
                    catedraticos.Add(Mappeador(sr.ReadLine()));
                }
                sr.Close();
                return catedraticos;
            }
            catch (Exception)
            {

                return null;
            }
        }

    }
}
