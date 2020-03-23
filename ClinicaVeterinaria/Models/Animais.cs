using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.Models
{

    /// <summary>
    /// Classe representa a tabela dos 'Animais' na base de dados
    /// </summary>
    public class Animais
    {
        public int ID { set; get; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public float Peso { get; set; }
        public string Raca { get; set; }
        public string Foto { get; set; }
            }
}
