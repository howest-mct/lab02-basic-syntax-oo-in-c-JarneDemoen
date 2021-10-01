using pokemonapp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pokemonapp
{
    public partial class MainPage : ContentPage
    {
        //globale variabele
        private List<Pokemons> PokemonList;
        private List<Pokemons>PokemonListByType;
        private int index = 0;
        private String pokemontype = "default";
        public MainPage()
        {
            InitializeComponent();
            LoadPokemon();
        }

        private void LoadPokemon()
        {
            if (pokemontype == "default")
            {
                PokemonList = Pokemons.GetPokemons();
            }
            else
            {
                PokemonList = PokemonListByType;
            }
            ShowPokemons();
        }

        private void ShowPokemons()
        {
 
            if (index < 0)
            {
                index = PokemonList.Count() - 1;
            }
            if (index > PokemonList.Count() - 1)
            {
                index = 0;
            }

            Pokemons gekozenPokemon = PokemonList[index];
            lblHeight.Text = gekozenPokemon.Height.ToString();
            lblWeight.Text = gekozenPokemon.Weight.ToString();
            lblName.Text = gekozenPokemon.Name.ToString();
            lblType.Text = gekozenPokemon.Type.ToString();
            ImageLocation(gekozenPokemon.Id, gekozenPokemon.Name, gekozenPokemon.Type);

        }

        private void ImageLocation(int id, String Name, String pokemontype)
        {
            Debug.WriteLine($"https://static.pokemonpets.com/images/monsters-images-800-800/{id}-{Name}.png");
            imgPokemon.Source = $"https://static.pokemonpets.com/images/monsters-images-800-800/{id}-{Name}.png";
            imgBackground.Source = ImageSource.FromResource($"pokemonapp.Assets.{pokemontype.ToLower()}.png");
        }


        private void BtnPrevious_Clicked(object sender, EventArgs e)
        {
            index -= 1;
            LoadPokemon();
        }

        private void BtnNext_Clicked(object sender, EventArgs e)
        {
            index += 1;
            LoadPokemon();
        }

        private void pickType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PokemonList = Pokemons.GetPokemons();
            PokemonListByType = Pokemons.GetPokemonsByType();
            pokemontype = pickType.SelectedItem.ToString();
            for (int i = 0; i < PokemonList.Count(); i++)
            {
                String ControleType = PokemonList[i].Type;
                if (ControleType == pokemontype)
                {
                    PokemonListByType.Add(PokemonList[i]);
                }
            }
            Debug.WriteLine(PokemonListByType);
            LoadPokemon();
        }
    }
}
