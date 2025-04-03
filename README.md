# Gerenciador de Arquivos em C#

Este é um aplicativo simples de linha de comando em C# para gerenciar pastas e arquivos em um diretório específico. Ele permite criar, renomear, deletar e adicionar conteúdo a arquivos e pastas dentro de um diretório base.

## Funcionalidades

O programa oferece as seguintes funcionalidades:

1. **Criar Pasta**: Cria uma nova pasta dentro do diretório base.
2. **Criar Arquivo**: Cria um arquivo de texto (.txt) e adiciona um conteúdo inicial.
3. **Deletar Pasta**: Deleta uma pasta existente no diretório base.
4. **Deletar Arquivo**: Deleta um arquivo de texto existente no diretório base.
5. **Renomear Pasta**: Permite renomear uma pasta dentro do diretório base.
6. **Renomear Arquivo**: Permite renomear um arquivo de texto dentro do diretório base.
7. **Adicionar Texto ao Arquivo**: Permite adicionar conteúdo a um arquivo de texto existente.
8. **Sair**: Encerra o aplicativo.

## Pré-requisitos

Certifique-se de ter o seguinte instalado antes de rodar o projeto:

- [Microsoft .NET SDK](https://dotnet.microsoft.com/download) (versão 5.0 ou superior)
- Um editor de código como [Visual Studio](https://visualstudio.microsoft.com/), [Visual Studio Code](https://code.visualstudio.com/), ou qualquer editor de sua preferência.

## Como rodar o projeto

1. Clone ou baixe o repositório:
    ```bash
    git clone https://github.com/seu-usuario/gerenciador-de-arquivos.git
    ```

2. Abra o projeto em seu editor de código preferido.

3. Compile e execute o projeto:
    ```bash
    dotnet run
    ```

4. O aplicativo será executado no console. A partir daí, você poderá escolher as opções de gerenciamento de arquivos.

## Estrutura do Código

O código principal do aplicativo está na classe `Program`, que contém o método `Main` e várias funções responsáveis por executar as operações de gerenciamento de arquivos e pastas. O diretório base utilizado é `C:\GerenciadorDeArquivos`, onde todas as operações de arquivos e pastas serão realizadas.

## Exemplo de Execução

Após rodar o projeto, o menu será exibido com as opções disponíveis. Aqui está um exemplo de como o menu aparece no console:

1 - **Criar Pasta**
2 - **Criar Arquivo** 
3 - **Deletar Pasta**
4 - **Deletar Arquivo** 
5 - **Renomear Pasta** 
6 - **Renomear Arquivo**
7 - **Adicionar Texto ao Arquivo**
8 - **Sair Escolha uma opção:**

Escolha a opção desejada digitando o número correspondente.

## Observações

- O diretório base (`C:\GerenciadorDeArquivos`) será criado automaticamente, caso não exista.
- O programa não possui funcionalidades avançadas, como validação de entrada de dados (por exemplo, se o nome de um arquivo ou pasta é válido) ou controle de erros detalhado. 
- O programa não verifica se o conteúdo inserido no arquivo segue um formato específico.

## Contribuindo

Se você gostaria de contribuir para este projeto, por favor, faça um fork do repositório, crie uma branch para suas alterações e envie um pull request com suas melhorias.

## Licença

Este projeto é de código aberto e pode ser usado, modificado e distribuído de acordo com a licença MIT.
