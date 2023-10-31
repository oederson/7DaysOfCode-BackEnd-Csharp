using AutoMapper;
using ConsoleApp.Models;
using System.Text.Json;

namespace DesafioSevenDaysOfCode.Services;
public class TamagochiServices
    
{
    private IMapper<Pokemon> _mapper;
    public TamagochiServices(IMapper mapper)
    {
        _mapper = (IMapper<Pokemon>?)mapper;
    }
    public async Task<ListaPokemon> BuscarListaPokemon()
    {
        HttpClient httpClient = new HttpClient();
        try
        {
            var resposta = await httpClient.GetStringAsync("https://pokeapi.co/api/v2/pokemon/");
            var listaPokemon = JsonSerializer.Deserialize<ListaPokemon>(resposta);
            return listaPokemon;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
    public async Task<Pokemon> BuscaPokemon(string url)
    {
        HttpClient httpClient = new HttpClient();
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