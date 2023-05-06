using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioCatedratico : Interface1<Catedraticos>
    {
        RepositorioCatedratico repositorioCatedratico = new RepositorioCatedratico("catedraticos.txt");
        List<Catedraticos> catedraticos;
        

        public List<Catedraticos> GetAll()
        {
            if (catedraticos.Count == 0) return null;

            return catedraticos;
        }

        public string Save(Catedraticos profesor)
        {
            try
            {
                if (profesor == null) { return $"Error al guardar el contacto ..."; }

                var respuesta = repositorioCatedratico.Guardar(profesor);

                return $"Guardado correctamente";

            }
            catch (Exception)
            {
                return $"No se guardó";
            }
        }
        public double CalcularSalario(Catedraticos profesor)
        {
            double salarioBase = profesor.NumHoras * profesor.ValorHoras;
            double salarioconPosgrado = salarioBase;

            Console.WriteLine(profesor.Posgrado);

            if (profesor.Posgrado == "Especializacion")
            {
                salarioconPosgrado *= 0.10;
            }
            if (profesor.Posgrado == "Maestria")
            {
                salarioconPosgrado *= 0.45;
            }
            if (profesor.Posgrado == "Doctorado")
            {
                salarioconPosgrado *= 0.90;
            }
            if (profesor.Posgrado == "Postdoctorado")
            {
                salarioconPosgrado *= 0;
            }

            double salarioSemillero = salarioBase;

            if (profesor.Semillero == "A1")
            {
                salarioSemillero *= 0.56;
            }
            if (profesor.Semillero == "A")
            {
                salarioSemillero *= 0.47;
            }
            if (profesor.Semillero == "B")
            {
                salarioSemillero *= 0.42;
            }
            if (profesor.Semillero == "C")
            {
                salarioSemillero *= 0.38;
            }
            if (profesor.Semillero == "Reconocido por Colciencias")
            {
                salarioSemillero *= 0.33;
            }
            if (profesor.Semillero == "Semillero")
            {
                salarioSemillero *= 0.19;
            }
            double salarioTotalCatedratico = +salarioBase + salarioconPosgrado + salarioSemillero;
            profesor.Nomina = salarioTotalCatedratico;
            return profesor.Nomina;
        }
    }
}
