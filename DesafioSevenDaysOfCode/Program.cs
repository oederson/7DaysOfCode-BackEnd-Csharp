using ConsoleApp.Models;
using System.Text.Json;


ListaPokemon lista = await ListarPokemon();

int numeroPokemon = lista.Results.Length +1;

while(true)
{
    foreach (var pokemons in lista.Results)
    {
        string id = pokemons.Url.ToString().Replace("https://pokeapi.co/api/v2/pokemon/", "").Replace("/","");
        Console.WriteLine($"{id} - {pokemons.Name}");
    }
    Console.WriteLine("\n");
    Console.Write("Escolha um Pokemon, ou 0 para sair :");
    numeroPokemon = int.Parse(Console.ReadLine());
    if (numeroPokemon > lista.Results.Length)
    {
        Console.WriteLine("Não é possivel selecionar o Pokemon selecionado");
        Thread.Sleep(2000);
        Console.Clear();
    }
    else if (numeroPokemon == 0) 
    {
        Console.WriteLine("Saindo...");
        break;
    }
    else
    {
        Pokemon pokemon = await BuscaPokemon(lista.Results[numeroPokemon - 1].Url.ToString());
        pokemon.ExibirInformacoesPokemon();
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }
}



static async Task<ListaPokemon> ListarPokemon()
{
    using (HttpClient httpClient = new HttpClient())
    {
        try
        {
            string resposta = await httpClient.GetStringAsync("https://pokeapi.co/api/v2/pokemon/");
            var pokemon = JsonSerializer.Deserialize<ListaPokemon>(resposta);
            return pokemon;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
}

static async Task<Pokemon> BuscaPokemon(string nome)
{
    using (HttpClient httpClient = new HttpClient())
    {
        try
        {
            string resposta = await httpClient.GetStringAsync(nome);
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
            
