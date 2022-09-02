# teste_sinqia

Artigos de referencia para a realização.
##  Canal balta.io
### https://www.youtube.com/watch?v=QzCSN9wN4JA&t=2147s
## Link Documentação EntityFramework
### https://docs.microsoft.com/pt-br/ef/core/
  
 ## os endpoints que consegui fazer são 
 
  lista todos os pontos turisticos
  
 `Get - `
 https://localhost:7226/v1/pontos
 
lista o ponto turistico com o nome do parametro
 
 `Get - `
 https://localhost:7226/v1/pontos/<:local>
 
 adiciona um ponto turistico
 
 `Post - `
 https://localhost:7226/v1/pontos
 ```JSON
 {
    "nome":"node do ponto turistico",
    "descricao":"descrição do ponto turistico",
    "localizacao":"localização do ponto turistico",
    "cidade":"cidade do ponto turistico",
    "estado":"estado do ponto turistico"
 }
 ```
 atualiza um ponto turistico
 
`PUT - `
https://localhost:7226/v1/pontos/<:local>

deleta um ponto turistico

`DELETE -`
https://localhost:7226/v1/pontos/<:local>

Infelizmente não consegui implementar o frontend pois como não usava o windows por mais de um ano, não lembrava muita coisa de como funcionava, inclusive passei mais de uma hora só para baixar o git, o bash, adicionar a ssh no github, nem liguei meu note com o windows por mais de um ano, então até atualizar, instalar o que precisava demorou um pouco mais do esperado. Tentei realizar no linux porem não encontrei muita matéria sobre. Mas agradeço pela oportunidade mesmo assim, gostei bastante de ter conhecido mais a fundo o c#, vou me aprofundar um pouco mais nos windows Form agora