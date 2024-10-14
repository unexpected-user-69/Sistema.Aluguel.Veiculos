using System;
using ProjetoVeiculo.Modelo;

namespace ProjetoVeiculo.Repositorio;

public class RepositorioContrato
{
   private List<Contrato> contratos = [];

    public void Cadastrar(Contrato contrato) {
        contratos.Add(contrato);
    }

    public List<Contrato> contra() {
         Console.WriteLine("Contratos Cadastrados:");
        if (contratos.Count == 0)
        {
            Console.WriteLine("Nenhum Registro....");
        }
        return contratos;
    }
}

