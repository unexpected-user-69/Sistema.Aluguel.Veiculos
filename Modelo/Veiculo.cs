namespace ProjetoVeiculo.Modelo;

public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Ano { get; set; }
    public string Placa { get; set; }
    public string  Quilometragem { get; set; }

    public override string ToString()
    {
        return $"[{Marca}, {Modelo}, {Ano}, {Placa}, {Quilometragem}]";
    }
}

public class Moto
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Ano { get; set; }
    public string Placa { get; set; }
    public string  Quilometragem { get; set; }

    public override string ToString()
    {
        return $"[{Marca}, {Modelo}, {Ano}, {Placa}, {Quilometragem}]";
    }
}
