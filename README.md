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
## Day3:
* Dar boas vindas ao usuário, ler o nome da pessoa e dados que você achar relevante
* Exibir um menu que possibilite: “Adoção de mascotes”, “Ver mascotes adotados” e “Sair do Jogo”
O que é esperado do menu de adoção?
* Que o jogador possa escolher uma espécie e ver ou não suas características antes de adotá-lo
* Que o jogador possa ver detalhes sobre as espécies que desejar antes de fazer a escolha da adoção
* Que caso o jogador goste das características do mascote, ele possa realizar a adoção do mesmo
### Solução:
Criei um laço while que utiliza todas as classes desenvolvidas nos dias anteriores, criei a classe MeusTamagochi para adicionar os tamagochis adotados. 

## Day 4:
* Refatorar o sistema para ficar de acordo com o padrão MVC, com Model, View e Controller.
### Solução
Criei a classe TamagochiController, para gerenciar os métodos da classe Menu que é a view do meu projeto.

## Day 5:
* Desenvolver interações do jogador com seus mascotes. Lidar com atributos e poder realmente brincar com seus pokémons.

### Solução
Adicionei a classe Pokemon as propriedades humor e alimentação. Adicionei menu para poder interagir com o pokemon, e a função alimentar e brincar.