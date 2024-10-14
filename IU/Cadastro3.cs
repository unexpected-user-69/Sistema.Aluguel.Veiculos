 using ProjetoVeiculo.Modelo;

namespace ProjetoVeiculo.IU;
 

 public class cadastro3
 {
    public Contrato CadastroContrato()
        {
         Contrato contrato = new();

        System.Console.Write("ID do veículo: ");
        contrato.IdVeiculo = System.Console.ReadLine();

        System.Console.Write("ID do cliente: ");
        contrato.IdCliente = System.Console.ReadLine();

        System.Console.Write("Data de início: ");
        contrato.DataInicio = System.Console.ReadLine();

        System.Console.Write("Data de fim ");
        contrato.DataFim = System.Console.ReadLine();

        System.Console.Write("Valor total: ");
        contrato.ValorTotal = System.Console.ReadLine();

        return contrato;
    }
}
 
