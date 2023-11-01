using AutoMapper;
using ConsoleApp.DADOS;
using ConsoleApp.Models;
using DesafioSevenDaysOfCode.Models;
using DesafioSevenDaysOfCode.Services;
using DesafioSevenDaysOfCode.View;


namespace DesafioSevenDaysOfCode.Controller
{
    internal class TamagochiController
    {
        private readonly IMapper mapper;
        public TamagochiController()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PokemonDTO, Pokemon>());
            //var mapper = new Mapper(config);
            mapper = config.CreateMapper();

        }

        public  async Task Jogar()
        {
            TamagochiServices servicos = new TamagochiServices();
            var listaPokemon = await servicos.BuscarListaPokemon();
            MeusTamagochi tamagochiList = new MeusTamagochi();
            Menu menu = new Menu();
            Console.Write("Qual seu nome ? ");
            string nome = Console.ReadLine();
            string opcaoUsuario;
            int jogar = 1;
            while (jogar == 1)
            {
                menu.Mensagens(nome);
                switch (Console.ReadLine()) 
                {
                    case "1":
                        {
                            await menu.MenuAdocao(nome, listaPokemon);
                            string escolhaDoMenuAdocao = Console.ReadLine();
                            int escolha = int.Parse(escolhaDoMenuAdocao);
                            var tamagochi = await servicos.BuscaPokemon(listaPokemon.Results[escolha - 1].Url.ToString());
                            bool exibir = true;
                            while (exibir)
                            {
                                menu.OpcaoMenuAdocao(nome, listaPokemon, escolhaDoMenuAdocao);
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        tamagochi.ExibirInformacoesPokemonAntesDeAdotar();
                                        break;
                                    case "2":
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
                        }
                    case "2": 
                        {
                            
                            bool exibir = true;
                            while (exibir)
                            {
                                menu.VerSeusMascotesParaBrincar(nome, tamagochiList);
                                string escolhaParaBrincar = Console.ReadLine();
                                int escolhaBrincar = int.Parse(escolhaParaBrincar);
                                if(escolhaBrincar < tamagochiList.ObterTodosPokemons().Count()) 
                                {
                                    Pokemon poke = tamagochiList.ObterPokemon(escolhaBrincar);
                                    PokemonDTO pokeDTO = mapper.Map<PokemonDTO>(poke);
                                    menu.OpcoesParaBrincar(pokeDTO, nome);
                                    switch (Console.ReadLine())
                                    {
                                        case "1":
                                            pokeDTO.ExibirInformacoesPokemon();
                                            break;
                                        case "2":
                                            pokeDTO.Alimentacao++;
                                            
                                            break;
                                        case "3":
                                            pokeDTO.Humor++;
                                            pokeDTO.Alimentacao--;
                                            
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
                            break;
                        }
                    case "3": 
                        {
                            jogar = 0;
                            break;
                        }
                    default: 
                        {
                            Console.WriteLine("Opção Invalida!");
                            break;
                        }
                }
            }
        }
    }
}
