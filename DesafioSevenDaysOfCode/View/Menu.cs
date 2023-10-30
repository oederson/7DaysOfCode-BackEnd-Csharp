using ConsoleApp.Models;
using DesafioSevenDaysOfCode.Models;
using DesafioSevenDaysOfCode.Services;


namespace DesafioSevenDaysOfCode.View
{
    public class Menu
    {
        private MeusTamagochi tamagochiList = new MeusTamagochi();
        private string nome;
        public void Mensagens() 
        {
            Console.Write("Qual seu nome ? ");
            string nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("__________________________________________________________");
            Console.WriteLine($"{nome} Voce deseja:");
            Console.WriteLine("1 - Adotar um macote virtual");
            Console.WriteLine("2 - Ver seus mascotes");
            Console.WriteLine("3 - Sair");

        }
        public void VerSeusMascotes()
        {
            Pokemon pokemon = new Pokemon();
            var listando = tamagochiList.ObterTodosPokemons();
            if (listando.Count == 0)
            {
                Console.WriteLine("Nenhum mascote adotado.");
            }
            foreach (var item in listando)
            {
              item.ExibirInformacoesPokemon();
            }
            
            bool exibir = true;
            while (exibir)
            {
                Console.WriteLine($"{nome} voce deseja::");
                Console.WriteLine($"1 - Selecionar um pokemon para brincar");
                Console.WriteLine("3 - Voltar");


                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        for (int i = 0; i < listando.Count; i++) 
                        {
                            Console.WriteLine($"{i} - Para {listando[i].Name}");
                        }
                        Console.WriteLine("___________________________");
                        int escolha = int.Parse(Console.ReadLine());
                         pokemon = listando[escolha];
                        InteragirComPokemon(pokemon);
                        break;


                    case "2":
 
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
        public async Task MenuAdocao() 
        {
            TamagochiServices servicos = new TamagochiServices();
            var listaPokemon = await servicos.BuscarListaPokemon();
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

                switch (Console.ReadLine())
                {
                    case "1":

                        var tamagochi = await servicos.BuscaPokemon(listaPokemon.Results[escolha - 1].Url.ToString());
                        tamagochi.ExibirInformacoesPokemonAntesDeAdotar();
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
        }
        public static void InteragirComPokemon(Pokemon poke)
        {
            bool exibir = true;

            while (exibir)
            {
                Console.WriteLine($" voce deseja::");
                Console.WriteLine($"1 - Saber como {poke.Name} está");
                Console.WriteLine($"2 - Alimentar {poke.Name}");
                Console.WriteLine($"3 - Brincar com {poke.Name}");
                Console.WriteLine("4 - Sair");


                switch (Console.ReadLine())
                {
                    case "1":
                        poke.ExibirInformacoesPokemon();
                        break;

                    case "2":
                        poke.Alimentacao++;
                        poke.Humor++;
                        Console.ReadKey();
                        break;

                    case "3":
                        poke.Alimentacao--;
                        poke.Humor++;
                        break;
                    case "4":
                        exibir = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

        }

    }
}
