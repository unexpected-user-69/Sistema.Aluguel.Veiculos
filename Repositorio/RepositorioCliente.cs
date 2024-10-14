using System;
using ProjetoVeiculo.Modelo;

namespace ProjetoVeiculo.Repositorio;

public class RepositorioCliente
{
    private List<Cliente> clientes = [];

    public void Cadastrar(Cliente cliente) {
        clientes.Add(cliente);
    }

    public List<Cliente> Clientes() {
         Console.WriteLine("Clientes Cadastrados:");
        if (clientes.Count == 0)
        {
            Console.WriteLine("Nenhum Registro....");
        }
        return clientes;
    }
}
