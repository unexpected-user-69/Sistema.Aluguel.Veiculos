using ProjetoVeiculo.IU;
using ProjetoVeiculo.Modelo;
using ProjetoVeiculo.Repositorio;

RepositorioMoto repositorioMoto = new();
RepositorioCarro repositorioCarro = new();
RepositorioCliente repositorioCliente = new();
RepositorioContrato repositorioContrato = new();

while (true)
{
    string opcaoDoUsuario = Menu1.Exibir();

    if (opcaoDoUsuario == "1")
    {
        while (true)
        {
            string opcaoSubmenu = MenuVeiculo.Exibir();
            if (opcaoSubmenu == "1")
            {
                cadastroCarro cadastroCarro = new();
                Carro Carro = cadastroCarro.CadastroCarro();
                repositorioCarro.Cadastrar(Carro);
                Console.WriteLine("Veículo cadastrado com sucesso!");
            }
            else if (opcaoSubmenu == "2")
            {
                cadastroMoto cadastroMoto = new();
                Moto Moto = cadastroMoto.CadastroMoto();
                repositorioMoto.Cadastrar(Moto);
                Console.WriteLine("Veículo atualizado com sucesso!");
            }
            else if (opcaoSubmenu == "0")
            {
                Console.WriteLine("Retornando ao menu principal...");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida, tente novamente.");
            }
        }
    }
    else if (opcaoDoUsuario == "2")
    {
        cadastro2 cadastro2 = new();
        Cliente cliente = cadastro2.CadastroCliente();
        repositorioCliente.Cadastrar(cliente);
        Console.WriteLine("Cliente cadastrado com sucesso!");
    }
    else if (opcaoDoUsuario == "3")
    {
        cadastro3 cadastro3 = new();
        Contrato contrato = cadastro3.CadastroContrato();
        repositorioContrato.Cadastrar(contrato);
        Console.WriteLine("Contrato cadastrado com sucesso!");
    }
    else if (opcaoDoUsuario == "4")
    {
        while (true)
        {
            string opcaoSubmenu = MenuImpressao.Exibir();

            if (opcaoSubmenu == "1")
            {
                Console.WriteLine("Conteúdo do arquivo AlocacaoVeiculos.txt:");
                using (StreamReader reader = new StreamReader("AlocacaoVeiculos.txt"))
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            else if (opcaoSubmenu == "2")
            {
                foreach (var Carro in repositorioCarro.Carro())
                {
                    Console.WriteLine(Carro);
                }

                foreach (var Moto in repositorioMoto.Moto())
                {
                    Console.WriteLine(Moto);
                }

                foreach (var cliente in repositorioCliente.Clientes())
                {
                    Console.WriteLine(cliente);
                }

                foreach (var contrato in repositorioContrato.contra())
                {
                    Console.WriteLine(contrato);
                }
            }
            else if (opcaoSubmenu == "0")
            {
                Console.WriteLine("Voltando...");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }

    else if (opcaoDoUsuario == "5")
    {
        Console.WriteLine("Salvando........");

        using (StreamWriter writer = new StreamWriter("AlocacaoVeiculos.txt", append: true))
        {
            writer.WriteLine("\n--- Alocacao_Veiculos ---");

            writer.WriteLine("Carros");
            foreach (var Carro in repositorioCarro.Carro())
            {
                writer.WriteLine(Carro);
            }

            writer.WriteLine("Motos");
            foreach (var Moto in repositorioMoto.Moto())
            {
                writer.WriteLine(Moto);
            }

            writer.WriteLine("Clientes");
            foreach (var cliente in repositorioCliente.Clientes())
            {
                writer.WriteLine(cliente);
            }

            writer.WriteLine("Contratos");
            foreach (var contrato in repositorioContrato.contra())
            {
                writer.WriteLine(contrato);
            }
        }

        Console.WriteLine("Informações salvas no arquivo AlocacaoVeiculos.txt.\n");

        // Leitura e impressão do conteúdo do arquivo
        Console.WriteLine("Conteúdo do arquivo AlocacaoVeiculos.txt:");
        using (StreamReader reader = new StreamReader("AlocacaoVeiculos.txt"))
        {
            string linha;
            while ((linha = reader.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        }
    }


    else if (opcaoDoUsuario == "0")
    {
        Console.WriteLine("Finalizando...");
        break;
    }
}
