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
        [Required(ErrorMessage ="O Nome é de preenchimento obrigatório")]
        [StringLength(40,ErrorMessage ="O {0} não deve ter mais de {1} carateres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A Cédula é de preenchimento obrigatório")]
        public string NumCedulaProf { get; set; }
        [Required(ErrorMessage = "A Fotografia é de preenchimento obrigatório")]
        public string Foto { get; set; }

        //Lista de Consultas

        public ICollection<Consultas> ListaDeConsultas { get; set; }


    }
}
