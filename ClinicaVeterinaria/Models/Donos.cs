using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.Models
{
    public class Donos
    {
        public Donos()
        {
            ListaDeAnimais = new HashSet<Animais>();
        }

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório")]
        [StringLength(40, ErrorMessage = "O {0} não deve ter mais de {1} carateres")]
        [RegularExpression("[A-ZÁÉÍÓÚÂ][a-záéíóúàèìòùäëïöüãõâêîôûçñ]+(( | e | de | d[ao](s)? |-|'| d')[A-ZÁÉÍÓÚÂ][a-záéíóúàèìòùäëïöüãõâêîôûçñ]+){1,3}", ErrorMessage = "Deve introduzir o nome corretamente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O NIF é de preenchimento obrigatório")]
        [StringLength(9, ErrorMessage = "O {0} não deve ter mais de {1} carateres")]
        [RegularExpression("[1-9][0-9]{8}", ErrorMessage = "Deve introduzir o NIF corretamente e deverá introduzir 9 algarismos.")]
        public string NIF { get; set; }

        //Lista dos animais que o Dono tem
        public ICollection<Animais> ListaDeAnimais { get; set; }

    }
}
