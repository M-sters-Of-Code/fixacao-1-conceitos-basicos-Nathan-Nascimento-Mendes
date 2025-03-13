
/*
 * As classes a serem dsenvolvidas devem atender aos seguintes requisitos:
 * - Devem estar na pasta Model
 * - Para a classe SomaDoisNumeros, deve-se criar um método estático chamado Somar que recebe dois inteiros e retorna a soma deles
 * - Para a classe MetrosMilimetros, deve-se criar um método estático chamado Converter que recebe um double e retorna o valor em milímetros
 * - A  classe CalculaAumento deve ter um método estático chamado Calcular que recebe um double salario e um double aumento e retorna o valor do salário com o aumento aplicado
 * A classe CalculaDesconto deve ter um método estático chamado Calcular que recebe um double valor e um double desconto e retorna o valor com o desconto aplicado
 * - A classe CalculaAluguelCarro deve ter um método estático chamado Calcular que recebe um int dias, um int quilometragemInicial, um int quilometragemFinal e retorna o valor total do aluguel
 */

//Primeira tarefa realizada
using FixacaoConceitosBasicos1.Model;

int menu = 0;
do
{
    try
    {
        Console.WriteLine("\n========================================================================");
        Console.WriteLine("\nOlá, escolha qual exercício deseja testar:\n" +
            "1 - Soma dois números\n" +
            "2 - Metros milimetros\n" +
            "3 - Calcula aumento\n" +
            "4 - Calcula desconto\n" +
            "5 - Calcula aluguel carro\n" +
            "6 - Sair\n");

        Console.Write("Opção: ");
        menu = int.Parse(Console.ReadLine());
        break;
    } catch (Exception e) {
        // Default do switch será executado
    }

    switch (menu)
    {
        case 1:
            int n1, n2;
            while (true)
            {
                try
                {
                    Console.Write("\n1° número: ");
                    n1 = int.Parse(Console.ReadLine());

                    break;
                } catch (Exception e)
                {
                    Console.WriteLine("Insira um valor válido para o 1° número.");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("2° número: ");
                    n2 = int.Parse(Console.ReadLine());

                    int resultado = SomaDoisNumeros.Somar(n1, n2);
                    Console.WriteLine($"\n{n1} + {n2} = {resultado}");
                    break;
                } catch (Exception e)
                {
                    Console.WriteLine("Insira um valor válido para o 2° número.");
                }
            }
            break;
        case 2:
            while (true)
            {
                try
                {
                    Console.Write("\nValor em metros: ");
                    double metros = double.Parse(Console.ReadLine());
                    double milimetros = MetrosMilimetros.Converter(metros);

                    Console.WriteLine($"\n{metros} metros equivalem a {milimetros} milímetros.");
                    break; // se for até o final do try ele sai do while
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nPor favor informe um valor válido.\n");
                }
            }
            break;
        case 3:
            Console.Write("\nSalario: ");
            double salarioAtual = double.Parse(Console.ReadLine());

            Console.Write("Percentual de aumento: ");
            double percentualAumento = double.Parse(Console.ReadLine());

            double salarioAtualizado = CalculaAumento.Calcular(salarioAtual, percentualAumento);

            double valorAumento = salarioAtualizado - salarioAtual;

            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine($"Salário antigo: {salarioAtual}\n" +
                $"Percentual de aumento: {percentualAumento}%\n" +
                $"Aumento do salário: {valorAumento.ToString("F2")}\n" +
                $"Salario Atual: {salarioAtualizado.ToString("F2")}");
            Console.WriteLine("---------------------------------------------");
            break;
        case 4:
            Console.Write("\nValor do produto: ");
            double valorMercadoria = double.Parse(Console.ReadLine());

            Console.Write("Percentual de desconto: ");
            double percentualDesconto = double.Parse(Console.ReadLine());

            double novoValorMercadoria = CalculaDesconto.Calcular(valorMercadoria, percentualDesconto);

            double valorDesconto = valorMercadoria - novoValorMercadoria;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Valor: {valorMercadoria}\n" +
                $"Percentual de Desconto: {percentualDesconto}%\n" +
                $"Valor de desconto: {valorDesconto.ToString("F2")}\n" +
                $"Valor com desconto: {novoValorMercadoria.ToString("F2")}");
            Console.WriteLine("-------------------------------------------");
            break;
        case 5:
            Console.WriteLine("\nQuantos dias você ficou com o veículo?");
            int dias = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos quilômetros marcava o odômetro antes de você pegar o carro?");
            int kmImicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos qulômetros o odômetro marca agora?");
            int kmFinal = int.Parse(Console.ReadLine());

            double valorAluguel = CalculaAluguelCarro.Calcular(dias, kmImicial, kmFinal);

            Console.WriteLine($"\nValor do aluguel: {valorAluguel.ToString("F2")}");
            break;
        case 6:
            break;
        default:
            Console.WriteLine("\n---------------\n" +
                                "Opção inválida!" +
                                "\n---------------\n");
            break;
    }
} while (menu != 6);


Console.WriteLine("========================================================================");