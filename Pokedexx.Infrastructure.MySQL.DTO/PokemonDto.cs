using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedexx.Application.DTOs
{
    public class PokemonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Base_experience { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Is_default { get; set; }
        public int Order { get; set; }
        public string? Location_area_encounters { get; set; }


        //public MovesDto movimientos { get; set; }
        //Tambien se pueden añadir foraneas, pero en vez de datos primitivos, con el nombre de la clase en el DTO
    }
}
