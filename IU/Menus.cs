using System;

namespace ProjetoVeiculo.IU;
public class Menu1
{
    public static string Exibir() {

           System.Console.WriteLine("********************************");
            System.Console.WriteLine("       ALOCACAO VEICULOS");
            System.Console.WriteLine();
            System.Console.WriteLine("  1. Cadastrar Veículo");
            System.Console.WriteLine("  2. Cadastrar Cliente");
            System.Console.WriteLine("  3. Cadastrar Contrato de Aluguel");
            System.Console.WriteLine("  4. Imprimir tudo");
            System.Console.WriteLine("  5. Salva tudo AlocacaoVeiculos.txt");
            System.Console.WriteLine("  0. Sair");
            System.Console.WriteLine("********************************");
            System.Console.Write("Qual sua opção: ");


        return System.Console.ReadLine();
    }
}

public class MenuVeiculo
{
    public static string Exibir() {

           System.Console.WriteLine("********************************");
            System.Console.WriteLine("       ALOCACAO VEICULOS");
            System.Console.WriteLine();
            System.Console.WriteLine("  1.  Cadastrar Carro ");
            System.Console.WriteLine("  2.  Cadastrar Moto");
            System.Console.WriteLine("  0. Sair");
            System.Console.WriteLine("********************************");
            System.Console.Write("Qual sua opção: ");


        return System.Console.ReadLine();
    }
}

public class MenuImpressao
{
    public static string Exibir() {

           System.Console.WriteLine("********************************");
            System.Console.WriteLine("       ALOCACAO VEICULOS");
            System.Console.WriteLine();
            System.Console.WriteLine("  1.  Impressao arq Alocacao.txt");
            System.Console.WriteLine("  2.  Impressao Cache");
            System.Console.WriteLine("  0. Sair");
            System.Console.WriteLine("********************************");
            System.Console.Write("Qual sua opção: ");


        return System.Console.ReadLine();
    }
}