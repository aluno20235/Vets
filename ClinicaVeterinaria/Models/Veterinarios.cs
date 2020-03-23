using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.Models
{
    public class Veterinarios
    {
        public Veterinarios()
        {
            ListaDeConsultas = new HashSet<Consultas>();
        }

        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string NumCedulaProf { get; set; }
        public string Foto { get; set; }

        //Lista de Consultas

        public ICollection<Consultas> ListaDeConsultas { get; set; }


    }
}
