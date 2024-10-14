namespace ProjetoVeiculo.Modelo;

public class Cliente
{
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        public override string ToString()
    {
        return $"[{Nome}, {CPF}, {Telefone}]";
    }
}