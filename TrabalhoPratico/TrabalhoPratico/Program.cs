using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Matheus Felipe Rodrigues Leitão
//Rodrigo Octavio de Paiva


namespace TrabalhoPratico
{
    internal class Program
    {
            static string[,] produtos = new string[100, 4];
            static string[,] vendas = new string[100, 3];
        static int[,] relatorio = new int[100, 3];
        static int countLinhasProduto = 0;
            static int countLinhasVenda = 0;
        
            static void Main(string[] args)
            {
                int opcao;

                do
                {
                    Console.Clear();
                    opcao = Menu();
                    Console.Clear();
                    switch (opcao)
                    {
                        case 1:
                            CadastrarProduto();
                            break;
                        case 2:
                            CadastrarVenda();
                            break;
                        case 3:
                            RelatorioVenda();
                            break;
                        case 4:
                            RelatorioVendaFuncionario();
                            break;
                    }

                } while (opcao != 0);

            }

            static int Menu()
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("========================================");
                Console.WriteLine("1 - Cadastrar produtos");
                Console.WriteLine("2 - Realizar uma venda");
                Console.WriteLine("3 - Relatório de vendas");
                Console.WriteLine("4 - Relatório de vendas por funcionários");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("========================================");
                Console.Write("Opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());
                return opcao;
            }

            static void CadastrarProduto()
            {
                Console.WriteLine("Cadastro de Produto:");
                Console.WriteLine("========================================");
                Console.WriteLine("Informe o codigo do Produto: ");

                string codigo = Console.ReadLine();
                if (ExistProduto(codigo) < 0)
                {
                    produtos[countLinhasProduto, 0] = codigo;

                    Console.WriteLine("Informe a descrição do Produto: ");
                    produtos[countLinhasProduto, 1] = Console.ReadLine();

                    Console.WriteLine("Informe o valor do Produto: ");
                    produtos[countLinhasProduto, 2] = Console.ReadLine();

                    Console.WriteLine("Informe a quantidade do Produto: ");
                    produtos[countLinhasProduto, 3] = Console.ReadLine();

                    countLinhasProduto++;
                }
                else
                {
                    Console.WriteLine("Codigo já cadastrado! Tente novamente");
                }
            }

            static void CadastrarVenda()
            {
                Console.WriteLine("Cadastro de Venda:");
                Console.WriteLine("========================================");
                Console.WriteLine("Informe o codigo do Produto: ");

                string codigo = Console.ReadLine();
                if (ExistProduto(codigo) >= 0)
                {
                    Console.WriteLine("Informe o codigo do Vendedor: ");
                    string codigoVendedor = Console.ReadLine();
                    
                    Console.WriteLine("Informe a quantidade vendida do Produto: ");
                    int quantidadeVendida = Convert.ToInt32(Console.ReadLine());

                    bool atualizado = AtualizaEstoque(quantidadeVendida, ExistProduto(codigo));

                    if (atualizado)
                    {
                        vendas[countLinhasVenda, 0] = codigo;
                        vendas[countLinhasVenda, 1] = codigoVendedor;
                        vendas[countLinhasVenda, 2] = quantidadeVendida.ToString();

                        countLinhasVenda++;
                    }
                    else
                    {
                        Console.WriteLine("Quantidade indisponivel no estoque. Venda não efetuada");
                    }
                }
                else
                {
                    Console.WriteLine("Codigo não encontrado! Tente novamente");
                }
                Console.ReadKey();
            }

            static int ExistProduto(string codigo)
            {
                for (int i = 0; i < 100; i++)
                {
                    if (produtos[i, 0] == codigo)
                    {
                        return i;
                    }
                }
                return -1;
            }

            static bool AtualizaEstoque(int quantidadeVendida, int linhaProduto)
            {
                if (quantidadeVendida <= Convert.ToInt32(produtos[linhaProduto, 3]))
                {
                    produtos[linhaProduto, 3] = (Convert.ToInt32(produtos[linhaProduto, 3]) - quantidadeVendida).ToString();
                    return true;
                }
                return false;
            }
       
            static void RelatorioVenda()
            {
                Console.WriteLine("Relatório de Vendas:");
                Console.WriteLine("========================================");
                Console.WriteLine("Código do Produto | Código do Funcionário | Quantidade Vendida | Valor da Venda");
                Console.WriteLine("--------------------------------------------------------------------------------");

                double totalVendas = 0;

                for (int i = 0; i < countLinhasVenda; i++)
                {
                    string codigoProduto = vendas[i, 0];
                    string codigoFuncionario = vendas[i, 1];
                    int quantidadeVendida = Convert.ToInt32(vendas[i, 2]);

                    // Buscar informações do produto para calcular o valor da venda
                    int indiceProduto = ExistProduto(codigoProduto);
                    if (indiceProduto >= 0)
                    {
                        double valorUnitario = Convert.ToDouble(produtos[indiceProduto, 2]);
                        double valorVenda = quantidadeVendida * valorUnitario;

                        // Exibir informações da venda
                        Console.WriteLine($"{codigoProduto.PadRight(18)} | {codigoFuncionario.PadRight(22)} | {quantidadeVendida.ToString().PadRight(17)} | R$ {valorVenda:F2}");

                        // Acumular total de vendas
                        totalVendas += valorVenda;
                    }
                }

                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine($"Valor Total de Todas as Vendas: R$ {totalVendas:F2}");
                Console.WriteLine("========================================");

                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            

             }
        static void RelatorioVendaFuncionario()
        {
            Console.WriteLine("Relatório de Vendas por Funcionário:");
            Console.WriteLine("========================================");

            for (int i = 0; i < countLinhasVenda; i++)
            {
                string codigoFuncionario = vendas[i, 1];
                double totalVendas = 0;

                Console.WriteLine($"\nCódigo do Funcionário:" +codigoFuncionario);
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Código do Produto | Quantidade Vendida | Valor da Venda");
                Console.WriteLine("--------------------------------------------------------");

                for (int j = 0; j < countLinhasVenda; j++)
                {
                    if (vendas[j, 1] == codigoFuncionario)
                    {
                        string codigoProduto = vendas[j, 0];
                        int quantidadeVendida = Convert.ToInt32(vendas[j, 2]);
                        int indiceProduto = ExistProduto(codigoProduto);

                        if (indiceProduto >= 0)
                        {
                            double valorUnitario = Convert.ToDouble(produtos[indiceProduto, 2]);
                            double valorVenda = quantidadeVendida * valorUnitario;

                            Console.WriteLine($"{codigoProduto.PadRight(18)} | {quantidadeVendida.ToString().PadRight(17)} | R$ {valorVenda:F2}");
                            totalVendas += valorVenda;
                        }
                    }
                }

                double comissao = totalVendas * 0.10;
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine($"Total de Vendas do Funcionário: R$" + totalVendas);
                Console.WriteLine($"Comissão (10%): R$" + comissao );
                Console.WriteLine("========================================");

            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }


    }
}

    

