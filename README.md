# 7 Days Of Code BackEnd C#
## Day 1 : 
* Criar o c�digo C# que executar� uma requisi��o HTTP do tipo GET.
* Executar a requisi��o e pegar a resposta (o JSON)
* Imprimir o resultado no console
## Solu��o:
 Criei a fun��o ass�ncrona BuscaPokemon, essa fun��o faz uma solicita��o HTTP para a API da PokeAPI para obter informa��es sobre um Pok�mon com base em um nome fornecido. Ela utiliza o nome para construir a URL da solicita��o, faz a solicita��o e, em seguida, desserializa a resposta JSON em um objeto da classe Pokemon. Se a solicita��o for bem-sucedida, o objeto Pokemon � retornado; caso contr�rio, se ocorrer uma exce��o, a fun��o retorna null.Criei o m�todo ExibirInformacoesPokemon para imprimir as inform��es do Pok�mon conforme pedido pelo desafio.
