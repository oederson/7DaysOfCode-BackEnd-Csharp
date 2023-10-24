using ConsoleApp.Models;
using System.Text.Json;

Pokemon pokemon1 = await BuscaPokemon("kakuna");
pokemon1.ExibirInformacoesPokemon();

Pokemon pokemon2 = await BuscaPokemon("wartortle");
pokemon2.ExibirInformacoesPokemon();

Pokemon pokemon3 = await BuscaPokemon("charmander");
pokemon3.ExibirInformacoesPokemon();

Console.ReadKey();


static async Task<Pokemon> BuscaPokemon(string nome)
{
    using (HttpClient httpClient = new HttpClient())
    {
        try
        {
            string resposta = await httpClient.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{nome}");
            var pokemon = JsonSerializer.Deserialize<Pokemon>(resposta);
            return pokemon;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
                return null;
        }
    }
}
            
