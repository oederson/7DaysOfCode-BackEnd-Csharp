using ConsoleApp.DADOS;
using ConsoleApp.Models;
using DesafioSevenDaysOfCode.Models;


namespace DesafioSevenDaysOfCode.View
{
    public class Menu
    {
        public void Mensagens(string nome)
        {
            Console.Clear();
            Console.WriteLine("__________________________________________________________");
            Console.WriteLine($"{nome} Voce deseja:");
            Console.WriteLine("1 - Adotar um macote virtual");
            Console.WriteLine("2 - Ver seus mascotes");
            Console.WriteLine("3 - Sair");
        }
        public void VerSeusMascotes(string nome, MeusTamagochi tamagochiList)
        {
            var listando = tamagochiList.ObterTodosPokemons();
            if (listando.Count == 0)
            {
                Console.WriteLine("Nenhum mascote adotado.");
            }
            foreach (var item in listando)
            {
                item.ExibirInformacoesPokemon();
            }
            Console.WriteLine($"{nome} voce deseja::");
            Console.WriteLine($"1 - Selecionar um pokemon para brincar");
            Console.WriteLine("3 - Voltar");
        }

        public void OpcoesVerSeusMascotes(string nome) {
            Console.WriteLine($"{nome} voce deseja::");
            Console.WriteLine($"1 - Selecionar um pokemon para brincar");
            Console.WriteLine("2 - Voltar");
        }   
               
        public async Task MenuAdocao(string nome, ListaPokemon listaPokemon)
        {
            Console.WriteLine("------------------------ Adotar um mascote ----------------------");
            Console.WriteLine("Escolha uma especie :");
            foreach (var pokemons in listaPokemon.Results)
            {
                string id = pokemons.Url.ToString().Replace("https://pokeapi.co/api/v2/pokemon/", "").Replace("/", "");
                Console.WriteLine($"{id} - {pokemons.Name}");
            }
            await Console.Out.WriteAsync("Digite o numero do tamagochi desejado :");
        }
        public void OpcaoMenuAdocao(string nome, ListaPokemon listaPokemon, string entrada)
        {
            int escolha = int.Parse(entrada);
                Console.WriteLine($"{nome} voce deseja::");
                Console.WriteLine($"1 - Saber mais sobre o {listaPokemon.Results[escolha - 1].Name}");
                Console.WriteLine($"2 - Adotar {listaPokemon.Results[escolha - 1].Name}");
                Console.WriteLine("3 - Voltar");

        }


        public  void InteragirComPokemon(Pokemon poke, string nome)
        {
            Console.WriteLine($"{nome} voce deseja::");
            Console.WriteLine($"1 - Saber como {poke.Name} está");
            Console.WriteLine($"2 - Alimentar {poke.Name}");
            Console.WriteLine($"3 - Brincar com {poke.Name}");
            Console.WriteLine("4 - Sair");
        }
        public void VerSeusMascotesParaBrincar(string nome, MeusTamagochi tamagochiList)
        {
            var listando = tamagochiList.ObterTodosPokemons();
            if (listando.Count == 0)
            {
                Console.WriteLine("Nenhum mascote adotado.");
            }
            Console.Clear();
            Console.WriteLine("------------------Seus mascotes________________");
            for (int i = 0; i < listando.Count; i++)
            {
            Console.WriteLine($"{i} - Para {listando[i].Name}");
            }
            Console.WriteLine("___________________________");
            Console.WriteLine("Escolha um para brincar ");
        }

        public void OpcoesParaBrincar (PokemonDTO poke, string nome) 
        {
            Console.WriteLine($"{nome} ...");
            Console.WriteLine($"1 - Veja os detalhes de {poke.Name}");
            Console.WriteLine($"2 - Alimentar {poke.Name}");
            Console.WriteLine($"3 - Brincar {poke.Name}");
            Console.WriteLine($"4 - Voltar");
        }
       





               
                }
            }

        

    

