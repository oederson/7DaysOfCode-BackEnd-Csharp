# 7 Days Of Code BackEnd C#
## Day 1 : 
* Criar o código C# que executará uma requisição HTTP do tipo GET.
* Executar a requisição e pegar a resposta (o JSON)
* Imprimir o resultado no console
## Solução:
 Criei a função assíncrona BuscaPokemon, essa função faz uma solicitação HTTP para a API da PokeAPI para obter informações sobre um Pokémon com base em um nome fornecido. Ela utiliza o nome para construir a URL da solicitação, faz a solicitação e, em seguida, desserializa a resposta JSON em um objeto da classe Pokemon. Se a solicitação for bem-sucedida, o objeto Pokemon é retornado; caso contrário, se ocorrer uma exceção, a função retorna null.Criei o método ExibirInformacoesPokemon para imprimir as informções do Pokémon conforme pedido pelo desafio.
