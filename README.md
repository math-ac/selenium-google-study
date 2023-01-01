# Case Técnico Concert

Utilização do [.NET](https://dotnet.microsoft.com/pt-br/) em junção com [Selenium](https://www.selenium.dev/) para automatização da página do [Google](https://google.com).

## Detalhes Técnicos
---

- .NET 7.0
- Selenium 4.7
- xUnit 2.4.2
- Chromium e Chromedriver 108
- Opensuse Tumbleweed

## Preparação do Ambiente
---

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
---

Para reprodução dos testes deste repositório, tendo preparado o ambiente, clone o projeto:

```
git clone https://github.com/math-ac/concert-case
```

Dentro da pasta do projeto execute o comando:

```
dotnet test
```

## Análise de Usabilidade
---

Com a automação de diferentes buscas, pode-se ter avaliar a usabilidade que a busca do Gooogle oferece. As buscas efetuadas foram:

- Imagens de cachorros
- Dados de uma ação
- Notícias em alta sobre o Brasil
- Letras de uma música
- Um fato sobre o Brasil
- Clima de uma cidade
- Pizzarias locais

