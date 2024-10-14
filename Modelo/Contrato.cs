namespace ProjetoVeiculo.Modelo;

public class Contrato
{
        public string IdVeiculo { get; set; }
        public string IdCliente { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public string ValorTotal { get; set; }

         public override string ToString()
    {
        return $"[{IdVeiculo}, {IdCliente}, {DataInicio}, {DataFim},{ValorTotal}]";
    }
}
