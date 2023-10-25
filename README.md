# 7 Days Of Code BackEnd C#
## Day 1 :
* Criar o código C# que executará uma requisição HTTP do tipo GET.
* Executar a requisição e pegar a resposta (o JSON)
* Imprimir o resultado no console
### Solução:
Criei a classe ListaPokemon para armazenar a lista de Pokémons disponiveis, depois listando e dando a opção para o usuario escolher um Pokémon na lista.
## Day2 :
* No primeiro dia, você fez uma chamada para a API do Pokémon para receber o JSON com detalhes das espécies de mascotes virtuais como resposta.A sua tarefa de hoje será parsear essa resposta. Em outras palavras, você vai extrair as informações desse JSON. Repare que o JSON possui uma série de informações que podem ser relevantes no momento da adoção de um mascote, tais como uma lista de habilidades (ability), altura (height) e peso (weight).
### Solução:
Criei a função assíncrona BuscaPokemon, essa função faz uma solicitação HTTP para a API da PokeAPI para obter informações sobre um Pokémon com base em um nome fornecido. Ela utiliza o nome para construir a URL da solicitação, faz a solicitação e, em seguida, desserializa a resposta JSON em um objeto da classe Pokemon. Se a solicitação for bem-sucedida, o objeto Pokemon é retornado; caso contrário, se ocorrer uma exceção, a função retorna null.Criei o método ExibirInformacoesPokemon para imprimir as informções do Pokémon conforme pedido pelo desafio.