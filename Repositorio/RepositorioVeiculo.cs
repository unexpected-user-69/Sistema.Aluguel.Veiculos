using System;
using ProjetoVeiculo.Modelo;

namespace ProjetoVeiculo.Repositorio;

public class RepositorioCarro
{
    private List<Carro> Carros = new List<Carro>();

    public void Cadastrar(Carro Carro) {
        Carros.Add(Carro);
    }

    public List<Carro> Carro() {
        Console.WriteLine("Carros Cadastrados:");
        if (Carros.Count == 0)
        {
            Console.WriteLine("Nenhum Registro....");
        }
        return Carros;
    }
}


public class RepositorioMoto
{
    private List<Moto> Motos = new List<Moto>();

    public void Cadastrar(Moto Moto) {
        Motos.Add(Moto);
    }

    public List<Moto> Moto() {
        Console.WriteLine("Motos Cadastradas:");
        if (Motos.Count == 0)
        {
            Console.WriteLine("Nenhum Registro....");
        }
        return Motos;
    }
}
