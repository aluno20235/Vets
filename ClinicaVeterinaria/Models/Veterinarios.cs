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
        [RegularExpression("[A-ZÁÉÍÓÚÂ][a-záéíóúàèìòùäëïöüãõâêîôûçñ]+(( | e | de | d[ao](s)? |-|'| d')[A-ZÁÉÍÓÚÂ][a-záéíóúàèìòùäëïöüãõâêîôûçñ]+){1,3}", ErrorMessage = "Deve introduzir o nome corretamente")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "A Cédula é de preenchimento obrigatório")]
        [RegularExpression("vet-[0-9]{6}", ErrorMessage ="Deve introduzir a palavra 'vet-' (em minúsculas), seguida de 6 dígitos.")]
        [StringLength(10, ErrorMessage = "O {0} não deve ter mais de {1} carateres")]
        [Display(Name ="Nº de Cédula Profissional")]
        public string NumCedulaProf { get; set; }


        [Required(ErrorMessage = "A Fotografia é de preenchimento obrigatório")]
        public string Foto { get; set; }

        //Lista de Consultas

        public ICollection<Consultas> ListaDeConsultas { get; set; }


    }
}
