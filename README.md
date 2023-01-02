# Case Técnico Concert

Utilização do [.NET](https://dotnet.microsoft.com/pt-br/) em junção com [Selenium](https://www.selenium.dev/) para automatização da página do [Google](https://google.com).

## Detalhes Técnicos

- .NET 7.0
- Selenium 4.7
- xUnit 2.4.2
- Chromium e Chromedriver 108
- Opensuse Tumbleweed

## Preparação do Ambiente

Obtenha a versão mais recente do [.NET](https://dotnet.microsoft.com/pt-br/download) disponível para o sistema. A Microsoft possui uma [documentação](https://learn.microsoft.com/pt-br/dotnet/core/install/) bem elaborada, atendendo uma alta gama de sistemas (Linux, Windows e macOS). O sistema utilizado foi o [Opensuse Tumbleweed](https://www.opensuse.org/#Tumbleweed), mas os passos podem ser reproduzidos em outros sistemas.

Com o .NET já instalado no sistema, deve ser iniciado um novo projeto para teste. Existem alguns frameworks de teste para o .NET, o utilizado neste projeto foi o [xUnit](https://xunit.net/). Para iniciar o projeto, a partir da linha de comando, crie e acesse uma nova pasta:

```
mkdir concert-case # Criação de pasta
cd concert-case # Acesso a pasta
```

Dentro da pasta do projeto, inicie um novo projeto com o xUnit framework:

```
dotnet new xunit
```

Para verificar se o projeto foi criado corretamente, execute o teste com:

```
dotnet test
```

Uma mensagem de resposta deve aparecer

```
Iniciando execução de teste, espere...
1 arquivos de teste no total corresponderam ao padrão especificado.

Aprovado!  – Com falha:     0, Aprovado:     1, Ignorado:     0, Total:     1, Duração: < 1 ms - concert-case.dll (net7.0)

```

Com o projeto já inicializado, basta adicionar o Selenium, mais especificamente, o [Selenium WebDriver](https://www.selenium.dev/pt-br/documentation/webdriver/), para a automatização do navegador.

```
dotnet add package Selenium.WebDriver
```

Adicionalmente, é necessário obter o driver para o navegador que se deseja automatizar. Neste projeto foi utilizado o Chromium, que requer o [chromedriver](https://chromedriver.chromium.org/home), que foi obtido através do repositório oficial do Opensuse. Para utilização com outros navegadores e/ou sistemas, é recomendada a leitura da [documentação oficial](https://www.selenium.dev/pt-br/documentation/webdriver/getting_started/install_drivers/) do Selenium. Após isso, o desenvolvimento pode ser iniciado.

## Utilização

Para reprodução dos testes deste repositório, tendo preparado o ambiente, clone o projeto:

```
git clone https://github.com/math-ac/concert-case
```

Dentro da pasta do projeto execute o comando:

```
dotnet test
```

## Análise de Usabilidade

Com a automação de diferentes buscas, pôde-se avaliar a usabilidade que a busca do Gooogle oferece. As buscas efetuadas foram:

- Imagens de cachorros
- Dados de uma ação
- Notícias em alta sobre o Brasil
- Letra de uma música
- Um fato sobre o Brasil
- Clima de uma cidade
- Pizzarias locais

Como o serviço principal do Google é a busca por informação, os testes de automação foram elaborados para serem os mais simples e diretos possíveis, focando apenas nos resultados em que a própria página do Google gera.

### Resultados Obtidos

<details>
<summary><b>Imagens de cachorros</b></summary>

**Termo de busca:** Imagens de cachorros

**Experiência:** Tendo realizado a busca na página inicial do Google, os resultados obtidos apresentam algumas imagens e como esperado, link para outros sites. A página de resultados apresenta a aba de "Imagens" como segunda opção, o que facilita o encontro de imagens.

**Críticas:** Apesar do resultado da busca apresentar algumas imagens, o usuário deve selecionar a aba de "Imagens" para ter o resultado completo.

**Possíveis melhorias:** O resultado da busca poderia redirecionar o usuário diretamente para a aba de "Imagens" do Google, reduzindo o número de ações necessárias para se encontrar as imagens.

</details>

---

<details>
<summary><b>Dados de uma ação</b></summary>

**Termo de busca:** ITUB4

**Experiência:** Tendo realizado a busca na página inicial do Google, os resultados obtidos tem um foco nos dados da ação e só depois, link para outros sites. A página de resultados apresenta a aba de "Finanças" como segunda opção, redirecionando para a página da ação no [Google Finanças](https://www.google.com/finance/).

**Críticas:** Apesar do resultado satisfatório, há uma pequena inconsistência, onde além da aba de "Finanças" há um botão de mesmo nome próximo do resultado, que não redireciona ao site do Google Finanças, apenas aprenta outros dados da ação.

**Possíveis melhorias:** Renomear o botão de "Finanças" próximo ao resultado da busca, para evitar confusão com a aba de "Finanças" do Google.

</details>

---

<details>
<summary><b>Notícias em alta sobre o Brasil</b></summary>

**Termo de busca:** Notícias Brasil

**Experiência:** Tendo realizado a busca na página inicial do Google, os resultados obtidos apresentam um campo nomeado "Principais Notícias", com as notícias mais relevantes e como esperado, link para outros sites de notícias. A página de resultados apresenta a aba de "Notícias" como segunda opção, o que facilita o encontro de notícias.

**Críticas:** O resultado é um tanto satisfatório, mas uma vez que o usuário pode ter preferência por algum site de notícia específico, o campo de "Principais Notícias" pode ficar no caminho. 

**Possíveis melhorias:** Talvez aumentar a quantidade apresentada pelo campo "Principais Notícias" e mudar o seu layout.

</details>

---

<details>
<summary><b>Letra de uma música</b></summary>

**Termo de busca:** Letra de john mayer neon

**Experiência:** Tendo realizado a busca na página inicial do Google, os resultados obtidos apresentam a letra completa da música, além de links para escutá-la e informações sobre a música.

**Críticas:** A apresentação do resultado pode variar de acordo com os termos digitados, mesmo eles sendo bem similares ("neon letra" sendo um exemplo), deixando de apresentar os links e informações da música. 

**Possíveis melhorias:** Manter a consistência do resultado para termos de busca similares.

</details>

---