﻿using ConsoleApp.Models;

namespace DesafioSevenDaysOfCode.Models
{
    public class MeusTamagochi
    {
        private List<Pokemon> listaTamagochi = new List<Pokemon>();

        public void AdicionarPokemon(Pokemon pokemon)
        {
            pokemon.Alimentacao =GerarNumeroAleatorio();
            pokemon.Humor = GerarNumeroAleatorio();
            listaTamagochi.Add(pokemon);
        }
        public List<Pokemon> ObterTodosPokemons()
        {
            return listaTamagochi;
        }

        // Gera um número aleatório de 0 a 10.
        public static int GerarNumeroAleatorio()
        {
            Random random = new Random();
            return random.Next(11); 
        }
        public Pokemon ObterPokemon(int indice)
        {
            if (indice >= 0 && indice < listaTamagochi.Count)
            {
                return listaTamagochi[indice];
            }
            else
            {
                 throw new ArgumentOutOfRangeException("Índice fora dos limites da lista");
            }
        }
    }
}
