using ProjetoVeiculo.Modelo;

namespace ProjetoVeiculo.IU;


public class cadastro2
{
    public Cliente CadastroCliente()
    {
        Cliente cliente = new();

        System.Console.Write("Nome: ");
        cliente.Nome = System.Console.ReadLine();

        System.Console.Write("CPF: ");
        cliente.CPF = System.Console.ReadLine();

        System.Console.Write("Telefone: ");
        cliente.Telefone = System.Console.ReadLine();

        return cliente;
    }
}

