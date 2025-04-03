using System;

using System.IO;

namespace Documento

{

    class Program

    {

        static void Main()

        {

            string caminhoBase = "C:\\GerenciadorDeArquivos";

            if (!Directory.Exists(caminhoBase)) Directory.CreateDirectory(caminhoBase);

            while (true)

            {

                Console.Clear();

                Console.WriteLine("1 - Criar Pasta");

                Console.WriteLine("2 - Criar Arquivo");

                Console.WriteLine("3 - Deletar Pasta");

                Console.WriteLine("4 - Deletar Arquivo");

                Console.WriteLine("5 - Renomear Pasta");

                Console.WriteLine("6 - Renomear Arquivo");

                Console.WriteLine("7 - Adicionar Texto ao Arquivo");

                Console.WriteLine("8 - Sair");

                Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())

                {

                    case "1": CriarPasta(caminhoBase); break;

                    case "2": CriarArquivo(caminhoBase); break;

                    case "3": DeletarPasta(caminhoBase); break;

                    case "4": DeletarArquivo(caminhoBase); break;

                    case "5": RenomearPasta(caminhoBase); break;

                    case "6": RenomearArquivo(caminhoBase); break;

                    case "7": AdicionarTextoArquivo(caminhoBase); break;

                    case "8": return;

                    default:

                        Console.WriteLine("Opção inválida. Tente novamente.");

                        Console.ReadKey();

                        break;

                }

            }

        }

        static void CriarPasta(string caminhoBase)

        {

            Console.Write("Nome da pasta: ");

            string pasta = Path.Combine(caminhoBase, Console.ReadLine());

            if (!Directory.Exists(pasta))

                Directory.CreateDirectory(pasta);

            else

                Console.WriteLine("Pasta já existe.");

            Console.ReadKey();

        }

        static void CriarArquivo(string caminhoBase)

        {

            Console.Write("Nome do arquivo (.txt): ");

            string arquivo = Path.Combine(caminhoBase, Console.ReadLine());

            if (!File.Exists(arquivo))

            {

                Console.Write("Conteúdo: ");

                File.WriteAllText(arquivo, Console.ReadLine());

            }

            else

                Console.WriteLine("Arquivo já existe.");

            Console.ReadKey();

        }

        static void DeletarPasta(string caminhoBase)

        {

            Console.Write("Nome da pasta: ");

            string pasta = Path.Combine(caminhoBase, Console.ReadLine());

            if (Directory.Exists(pasta))

                Directory.Delete(pasta, true);

            else

                Console.WriteLine("Pasta não encontrada.");

            Console.ReadKey();

        }

        static void DeletarArquivo(string caminhoBase)

        {

            Console.Write("Nome do arquivo (.txt): ");

            string arquivo = Path.Combine(caminhoBase, Console.ReadLine());

            if (File.Exists(arquivo))

                File.Delete(arquivo);

            else

                Console.WriteLine("Arquivo não encontrado.");

            Console.ReadKey();

        }

        static void RenomearPasta(string caminhoBase)

        {

            Console.Clear();

            Console.Write("Digite o nome da pasta que deseja renomear: ");

            string pastaAntiga = Path.Combine(caminhoBase, Console.ReadLine());

            if (Directory.Exists(pastaAntiga))

            {

                Console.Write("Digite o novo nome da pasta: ");

                string nomeNovo = Console.ReadLine();

                string novaPasta = Path.Combine(caminhoBase, nomeNovo);

                Directory.Move(pastaAntiga, novaPasta);

                Console.WriteLine("Pasta renomeada com sucesso!");

            }

            else

            {

                Console.WriteLine("Pasta não encontrada.");

            }

            Console.WriteLine("Pressione qualquer tecla para voltar...");

            Console.ReadKey();

        }

        static void RenomearArquivo(string caminhoBase)

        {

            Console.Clear();

            Console.Write("Digite o nome do arquivo que deseja renomear (com extensão): ");

            string arquivoAntigo = Path.Combine(caminhoBase, Console.ReadLine());

            if (File.Exists(arquivoAntigo))

            {

                Console.Write("Digite o novo nome do arquivo (com extensão): ");

                string nomeNovo = Console.ReadLine();

                string arquivoNovo = Path.Combine(caminhoBase, nomeNovo);

                File.Move(arquivoAntigo, arquivoNovo);

                Console.WriteLine("Arquivo renomeado com sucesso!");

            }

            else

            {

                Console.WriteLine("Arquivo não encontrado.");

            }

            Console.WriteLine("Pressione qualquer tecla para voltar...");

            Console.ReadKey();

        }

        static void AdicionarTextoArquivo(string caminhoBase)

        {

            Console.Clear();

            Console.Write("Digite o nome do arquivo que deseja editar (com extensão): ");

            string nomeArquivo = Console.ReadLine();

            string caminhoArquivo = Path.Combine(caminhoBase, nomeArquivo);

            if (File.Exists(caminhoArquivo))

            {

                Console.Write("Digite o texto que será adicionado ao arquivo: ");

                string conteudo = Console.ReadLine();

                File.AppendAllText(caminhoArquivo, conteudo);

                Console.WriteLine("Texto adicionado com sucesso!");

            }

            else

            {

                Console.WriteLine("Arquivo não encontrado.");

            }

            Console.WriteLine("Pressione qualquer tecla para voltar...");

            Console.ReadKey();

        }

    }

}

