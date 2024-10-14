using ProjetoVeiculo.Modelo;

namespace ProjetoVeiculo.IU;


public class cadastroCarro
{
    public Carro CadastroCarro()
    {
        Carro Carro = new();

        System.Console.Write("Marca: ");
        Carro.Marca = System.Console.ReadLine();

        System.Console.Write("Modelo: ");
        Carro.Modelo = System.Console.ReadLine();

        System.Console.Write("Ano: ");
        Carro.Ano = System.Console.ReadLine();

        System.Console.Write("Placa: ");
        Carro.Placa = System.Console.ReadLine();

        System.Console.Write("Quilometragem : ");
        Carro.Quilometragem = System.Console.ReadLine();

        return Carro;
    }
}

public class cadastroMoto
{
    public Moto CadastroMoto()
    {
        Moto Moto = new();

        System.Console.Write("Marca: ");
        Moto.Marca = System.Console.ReadLine();

        System.Console.Write("Modelo: ");
        Moto.Modelo = System.Console.ReadLine();

        System.Console.Write("Ano: ");
        Moto.Ano = System.Console.ReadLine();

        System.Console.Write("Placa: ");
        Moto.Placa = System.Console.ReadLine();

        System.Console.Write("Quilometragem : ");
        Moto.Quilometragem = System.Console.ReadLine();

        return Moto;
    }
}
