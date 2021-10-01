using System;
using System.Collections.Generic;
using System.Text;

namespace pokemonapp.Models
{
    public class Pokemons
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public static List<Pokemons> GetPokemons()
        {
            return new List<Pokemons>()
            {
                new Pokemons() { Id=4, Name="Charmander", Type="Fire", Height=4 , Weight=6 },
                new Pokemons() { Id=5, Name="Charmeleon", Type="Fire", Height=5 , Weight=11 },
                new Pokemons() { Id=7, Name="Squirtle", Type="Water", Height=7 , Weight=5 },
                new Pokemons() { Id=8, Name="Wartortle", Type="Water", Height=8 , Weight=10 },
                new Pokemons() { Id=9, Name="Blastoise", Type="Water", Height=9 , Weight=16 },
                new Pokemons() { Id=19, Name="Rattata", Type="Normal", Height=19 , Weight=3 },
                new Pokemons() { Id=20, Name="Raticate", Type="Normal", Height=20 , Weight=7 },
                new Pokemons() { Id=23, Name="Ekans", Type="Poison", Height=23 , Weight=20 },
                new Pokemons() { Id=24, Name="Arbok", Type="Poison", Height=24 , Weight=35 },
                new Pokemons() { Id=27, Name="Sandshrew", Type="Ground", Height=27 , Weight=6 },
                new Pokemons() { Id=28, Name="Sandslash", Type="Ground", Height=28 , Weight=10 },
                new Pokemons() { Id=30, Name="Nidorina", Type="Poison", Height=30 , Weight=8 },
                new Pokemons() { Id=33, Name="Nidorino", Type="Poison", Height=33 , Weight=9 },
                new Pokemons() { Id=37, Name="Vulpix", Type="Fire", Height=37 , Weight=6 },
                new Pokemons() { Id=38, Name="Ninetales", Type="Fire", Height=38 , Weight=11 },
                new Pokemons() { Id=50, Name="Diglett", Type="Ground", Height=50 , Weight=2 },
                new Pokemons() { Id=51, Name="Dugtrio", Type="Ground", Height=51 , Weight=7 },
                new Pokemons() { Id=52, Name="Meowth", Type="Normal", Height=52 , Weight=4 },
                new Pokemons() { Id=53, Name="Persian", Type="Normal", Height=53 , Weight=10 },
                new Pokemons() { Id=54, Name="Psyduck", Type="Water", Height=54 , Weight=8 },
                new Pokemons() { Id=55, Name="Golduck", Type="Water", Height=55 , Weight=17 },
                new Pokemons() { Id=58, Name="Growlithe", Type="Fire", Height=58 , Weight=7 },
                new Pokemons() { Id=59, Name="Arcanine", Type="Fire", Height=59 , Weight=19 },
                new Pokemons() { Id=60, Name="Poliwag", Type="Water", Height=60 , Weight=6 },
                new Pokemons() { Id=61, Name="Poliwhirl", Type="Water", Height=61 , Weight=10 },
                new Pokemons() { Id=77, Name="Ponyta", Type="Fire", Height=77 , Weight=10 },
                new Pokemons() { Id=78, Name="Rapidash", Type="Fire", Height=78 , Weight=17 },
                new Pokemons() { Id=86, Name="Seel", Type="Water", Height=86 , Weight=11 },
                new Pokemons() { Id=88, Name="Grimer", Type="Poison", Height=88 , Weight=9 },
                new Pokemons() { Id=89, Name="Muk", Type="Poison", Height=89 , Weight=12 },
                new Pokemons() { Id=90, Name="Shellder", Type="Water", Height=90 , Weight=3 },
                new Pokemons() { Id=98, Name="Krabby", Type="Water", Height=98 , Weight=4 },
                new Pokemons() { Id=99, Name="Kingler", Type="Water", Height=99 , Weight=13 },
                new Pokemons() { Id=104, Name="Cubone", Type="Ground", Height=104 , Weight=4 },
                new Pokemons() { Id=105, Name="Marowak", Type="Ground", Height=105 , Weight=10 },
                new Pokemons() { Id=108, Name="Lickitung", Type="Normal", Height=108 , Weight=12 },
                new Pokemons() { Id=109, Name="Koffing", Type="Poison", Height=109 , Weight=6 },
                new Pokemons() { Id=110, Name="Weezing", Type="Poison", Height=110 , Weight=12 },
                new Pokemons() { Id=113, Name="Chansey", Type="Normal", Height=113 , Weight=11 },
                new Pokemons() { Id=115, Name="Kangaskhan", Type="Normal", Height=115 , Weight=22 },
                new Pokemons() { Id=116, Name="Horsea", Type="Water", Height=116 , Weight=4 },
                new Pokemons() { Id=117, Name="Seadra", Type="Water", Height=117 , Weight=12 },
                new Pokemons() { Id=118, Name="Goldeen", Type="Water", Height=118 , Weight=6 },
                new Pokemons() { Id=119, Name="Seaking", Type="Water", Height=119 , Weight=13 },
                new Pokemons() { Id=120, Name="Staryu", Type="Water", Height=120 , Weight=8 },
                new Pokemons() { Id=126, Name="Magmar", Type="Fire", Height=126 , Weight=13 },
                new Pokemons() { Id=128, Name="Tauros", Type="Normal", Height=128 , Weight=14 },
                new Pokemons() { Id=129, Name="Magikarp", Type="Water", Height=129 , Weight=9 },
                new Pokemons() { Id=132, Name="Ditto", Type="Normal", Height=132 , Weight=3 },
                new Pokemons() { Id=133, Name="Eevee", Type="Normal", Height=133 , Weight=3 },
                new Pokemons() { Id=134, Name="Vaporeon", Type="Water", Height=134 , Weight=10 },
                new Pokemons() { Id=136, Name="Flareon", Type="Fire", Height=136 , Weight=9 },
                new Pokemons() { Id=137, Name="Porygon", Type="Normal", Height=137 , Weight=8 },
                new Pokemons() { Id=143, Name="Snorlax", Type="Normal", Height=143 , Weight=21 }

            };
        }
        public static List<Pokemons> GetPokemonsByType()
        {
            return new List<Pokemons>()
            {
            };
        }
    }
}
