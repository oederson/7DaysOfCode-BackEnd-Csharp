using DesafioSevenDaysOfCode.Models;

namespace DesafioSevenDaysOfCode.Services
{
    public class Menu
    {     
        public async Task ExibirMenuPrincipal () 
        {
            TamagochiServices servicos = new TamagochiServices();         
            var listaPokemon = await servicos.BuscarListaPokemon();
            MeusTamagochi tamagochiList = new MeusTamagochi();                     
            Console.Write("Qual seu nome ? ");
            string nome = Console.ReadLine();
            bool exibirMenu = true;
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
                        Console.WriteLine("------------------------ Adotar um mascote ----------------------");
                        Console.WriteLine("Escolha uma especie :");
                        foreach (var pokemons in listaPokemon.Results)
                        {
                            string id = pokemons.Url.ToString().Replace("https://pokeapi.co/api/v2/pokemon/", "").Replace("/", "");
                            Console.WriteLine($"{id} - {pokemons.Name}");
                        }
                        await Console.Out.WriteAsync("Digite o numero do tamagochi desejado :");
                        int escolha = int.Parse(Console.ReadLine());
                        bool exibir = true;

                        while (exibir)
                        {
                            Console.WriteLine($"{nome} voce deseja::");
                            Console.WriteLine($"1 - Saber mais sobre o {listaPokemon.Results[escolha - 1].Name}");
                            Console.WriteLine($"2 - Adotar {listaPokemon.Results[escolha - 1].Name}");
                            Console.WriteLine("3 - Voltar");
                            Console.WriteLine(listaPokemon.Results[escolha - 1].Url);

                            switch (Console.ReadLine())
                            {
                                case "1":

                                    var tamagochi = await servicos.BuscaPokemon(listaPokemon.Results[escolha - 1].Url.ToString());
                                    tamagochi.ExibirInformacoesPokemon();
                                    break;

                                case "2":
                                    tamagochi = await servicos.BuscaPokemon(listaPokemon.Results[escolha - 1].Url.ToString());
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
                        break;
                    case "2":
                        var listando = tamagochiList.ObterTodosPokemons();
                        if(listando.Count == 0) 
                        {
                            await Console.Out.WriteLineAsync("Nenhum mascote adotado.");
                            break;
                        }
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
        }              
    }
}
