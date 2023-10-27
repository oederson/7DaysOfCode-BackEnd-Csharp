using ConsoleApp.Models;

namespace DesafioSevenDaysOfCode.Models
{
    public class MeusTamagochi
    {
        private List<Pokemon> listaTamagochi = new List<Pokemon>();

        public void AdicionarPokemon(Pokemon pokemon)
        {
            listaTamagochi.Add(pokemon);
        }
        public List<Pokemon> ObterTodosPokemons()
        {
            return listaTamagochi;
        }
    }
}
