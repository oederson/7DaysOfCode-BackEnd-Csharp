using ConsoleApp.Models;
using DesafioSevenDaysOfCode.Models;
using System.Text.Json;

ListaPokemon listaPokemon = await ListarPokemon();
MeusTamagochi tamagochiList = new MeusTamagochi();
Pokemon tamagochi = new Pokemon();
bool exibirMenu = true;
Console.Write("Qual seu nome ? ");
string nome = Console.ReadLine();
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("__________________________________________________________");
    Console.WriteLine($"{nome} Voce deseja:");
    Console.WriteLine("1 - Adotar um macote virtual");
    Console.WriteLine("2 - Ver seus mascotes");
    Console.WriteLine("3 - Sair");

    switch (Console.ReadLine())
    {
        case "1":
            {
                Console.WriteLine("------------------------ Adotar um mascote ----------------------");
                Console.WriteLine("Escolha uma especie");
                foreach (var pokemons in listaPokemon.Results)
                {
                    string id = pokemons.Url.ToString().Replace("https://pokeapi.co/api/v2/pokemon/", "").Replace("/", "");
                    Console.WriteLine($"{id} - {pokemons.Name}");
                }
                int escolha = int.Parse(Console.ReadLine());
                bool exibir = true;

                while (exibir)
                {
                    Console.WriteLine($"{nome}Voce deseja::");
                    Console.WriteLine($"1 - Saber mais sobre o {listaPokemon.Results[escolha - 1].Name}");
                    Console.WriteLine($"2 - Adotar {listaPokemon.Results[escolha - 1].Name}");
                    Console.WriteLine("3 - Voltar");
                    Console.WriteLine(listaPokemon.Results[escolha - 1].Url);

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("DFSDFSDFSDF");
                            tamagochi = await BuscaPokemon(listaPokemon.Results[escolha - 1].Url.ToString());
                            tamagochi.ExibirInformacoesPokemon();
                            break;

                        case "2":
                            tamagochi = await BuscaPokemon(listaPokemon.Results[escolha - 1].Url.ToString());
                            tamagochiList.AdicionarPokemon(tamagochi);
                            Console.WriteLine($"{listaPokemon.Results[escolha - 1].Name} Adiconado com sucesso");
                            Console.ReadKey();
                            break;

                        case "3":
                            exibir = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }
                }
            }
            break;

        case "2":
            var listando = tamagochiList.ObterTodosPokemons();
            foreach (var item in listando)
            {
                item.ExibirInformacoesPokemon();
            }
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();
            break;

        case "3":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
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
static async Task<Pokemon> BuscaPokemon(string url)
{
    using (HttpClient httpClient = new HttpClient())
    {
        try
        {
            string resposta = await httpClient.GetStringAsync(url);
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