using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.Models
{
    public class Consultas
    {
        [Key]
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public string Observacoes { get; set; }

        //criar as chaves forasteiras
        [ForeignKey(nameof(Veterinario))]
        public int VeterinarioFK { get; set; }
        public Veterinarios Veterinario { get; set; }

        [ForeignKey(nameof(Animal))]
        public int AnimalFK { get; set; }
        public Animais Animal { get; set; }
    }
}
