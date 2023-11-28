namespace Avaliacao1;

public static class App
{
    private static List<Treinador> treinadores = new List<Treinador>();
    private static List<Cliente> clientes = new List<Cliente>();

    public static void Menu()
    {
        int opcao = -1;
        do
        {
            Console.WriteLine(">>>> MENU DA APLICACAO <<<");
            Console.WriteLine("[1] CADASTRAR TREINADOR");
            Console.WriteLine("[2] CADASTRAR CLIENTE");
            Console.WriteLine("[3] LISTAR DADOS CADASTRADOS");
            Console.WriteLine("[4] GERAR RELATORIOS");
            Console.WriteLine("[0] SAIR");

            try
            {
                // Tenta converter a entrada para um número inteiro
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastroTreinador();
                        break;

                    case 2:
                         CadastroCliente();
                        break;

                    case 3:
                        ListarDados();
                        break;

                    case 4:
                        GerarRelatorios();
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Opcao invalida");
                        break;

                }
            }
            catch (FormatException)
            {
                // Captura a exceção FormatException se a entrada não puder ser convertida para decimal
                Console.WriteLine("Entrada inválida. Certifique-se de digitar um número decimal.");
            }
            catch (OverflowException)
            {
                // Captura a exceção OverflowException se a entrada for muito grande para ser armazenada em um decimal
                Console.WriteLine("Entrada inválida. O número é muito grande.");
            }
            catch (Exception ex)
            {
                // Captura outras exceções não tratadas
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }

        } while (opcao != 0);
    }

    public static void CadastroTreinador()
    {
        string cpf1 = "00000000000";
        string cref1 = "01";
        DateTime d1 = new DateTime(1999, 12, 20);
        if (VerificaCpf(cpf1))
        {
            if(VerificaCref(cref1)){
                Treinador t1 = new Treinador("Zequinha", d1, cpf1, cref1);
                treinadores.Add(t1);
            }
            
        }

        string cpf2 = "00000000001";
        string cref2 = "02";
        DateTime d2 = new DateTime(2000, 12, 20);
        if (VerificaCpf(cpf2))
        {
            if(VerificaCref(cref2)){
                Treinador t2 = new Treinador("Ze da Manga", d2, cpf2, cref2);
                treinadores.Add(t2);
            }
        }


    }

    public static void CadastroCliente(){
        string cpf1 = "00000000000";
        
        if(VerificaCpfCliente(cpf1)){
            Cliente c1 = new Cliente("João", new DateTime(1999, 02, 15),cpf1 , 1.75, 70.5);
            clientes.Add(c1);
        }

        string cpf2 = "00000000001";
        if(VerificaCpfCliente(cpf2)){
            Cliente c2 = new Cliente("Maria", new DateTime(1985, 12, 22), cpf2, 1.68, 60.2);
            clientes.Add(c2);
        }
        
    }

    public static void ListarDados()
    {
        Console.WriteLine(">>> Lista de Treinadores");
        foreach (var treinador in treinadores)
        {
            Console.WriteLine($"Nome: {treinador.Nome}");
            Console.WriteLine($"Data de Nascimento: {treinador.DataNascimento}");
            Console.WriteLine($"CPF: {treinador.CPF}");
            Console.WriteLine($"CREF: {treinador.CREF}");
            Console.WriteLine("---------------------------");
        }

        Console.WriteLine(">>> Lista de Clientes");
        foreach(var cliente in clientes){
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}");
            Console.WriteLine($"Idade: {cliente.Idade()}");
            Console.WriteLine($"CPF: {cliente.CPF}");
            Console.WriteLine($"Peso: {cliente.Peso}");
            Console.WriteLine($"Altura: {cliente.Altura}");
            Console.WriteLine("---------------------------");
        }
    }

/* Mudar Para herança */
    public static bool VerificaCpf(string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf))
        {
            throw new ArgumentException("O CPF ou CREF não pode ser nulo ou vazio.");
        }

        // Verifica se é um CPF válido
        if (cpf.Length == 11)
        {
            //verifica se não existe outro cpf já cadastrado
            foreach (var treinador in treinadores)
            {
                if (treinador.CPF.Equals(cpf))
                {
                    Console.WriteLine($"CPF {cpf} já Cadastrado!");
                    return false;
                }
            }
        }else{
            Console.WriteLine($"CPF {cpf} com nenos de 11 digitos!");
            return false;
        }

        return true;
    }

     public static bool VerificaCpfCliente(string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf))
        {
            throw new ArgumentException("O CPF ou CREF não pode ser nulo ou vazio.");
        }

        // Verifica se é um CPF válido
        if (cpf.Length == 11)
        {
            //verifica se não existe outro cpf já cadastrado
            foreach (var cliente in clientes)
            {
                if (cliente.CPF.Equals(cpf))
                {
                    Console.WriteLine($"CPF {cpf} já Cadastrado!");
                    return false;
                }
            }
        }else{
            Console.WriteLine($"CPF {cpf} com nenos de 11 digitos!");
            return false;
        }

        return true;
    }


    public static bool VerificaCref(string cref)
    {
        if (string.IsNullOrWhiteSpace(cref))
        {
            throw new ArgumentException("O CREF não pode ser nulo ou vazio.");
        }

        //verifica se não existe outro cpf já cadastrado
        foreach (var treinador in treinadores)
        {
            if (treinador.CREF.Equals(cref))
            {
                Console.WriteLine($"CREF {cref} já Cadastrado!");
                return false;
            }
        }

        return true;
    }

    public static void GerarRelatorios(){
        DateTime hoje = DateTime.Today;
        int mesAtual = 12;

        // 1. Treinadores com idade entre dois valores
        var treinadoresIdade = GetTreinadoresComIdadeEntre(10, 30);
        Console.WriteLine($">>> Treinadores com idades entre {10} e {30}");
        ImprimirRelatorioTreinador(treinadoresIdade);

        // 2. Clientes com idade entre dois valores
        var clientesIdade = GetClientesComIdadeEntre(10, 30);
        Console.WriteLine($">>> Clientes com idades entre {10} e {30}");
        ImprimirRelatorioCliente(clientesIdade);

        // 3. Clientes com IMC maior que um valor, em ordem crescente
        var clientesIMC = GetClientesComIMCMaiorQue(25)
            .OrderBy(c => c.IMC());
        Console.WriteLine($">>> Clientes com Imc maior que {25}");
        ImprimirRelatorioCliente(clientesIMC);

        // 4. Clientes em ordem alfabética
        var clientesOrdenados = GetClientesOrdenadosPorNome();
        Console.WriteLine($">>> Clientes Ordenados");
        ImprimirRelatorioCliente(clientesOrdenados);

         // 5. Clientes do mais velho para mais novo
        Console.WriteLine($">>> Clientes do mais velho ao mais novo");
        var clientesMaisVelhos = GetClientesOrdenadosPorIdade(false);
        ImprimirRelatorioCliente(clientesMaisVelhos);

        // 6. Treinadores e clientes aniversariantes do mês informado
        var aniversariantesDoMesTreinadores = GetAniversariantesTreinadoresDoMes(mesAtual);
        Console.WriteLine($">>> Aniversariantes do mes Treinadores: ");
        ImprimirRelatorioTreinador(aniversariantesDoMesTreinadores);

        var aniversariantesDoMesClientes = GetAniversariantesClientesDoMes(mesAtual);
        Console.WriteLine($">>> Aniversariantes do mes Clientes: ");
        ImprimirRelatorioCliente(aniversariantesDoMesClientes);
        
    }

    public static IEnumerable<Treinador> GetTreinadoresComIdadeEntre(int idadeMinima, int idadeMaxima)
    {
        return treinadores.Where(t => t.Idade() >= idadeMinima && t.Idade() <= idadeMaxima);
    }

    public  static IEnumerable<Cliente> GetClientesComIdadeEntre(int idadeMinima, int idadeMaxima)
    {
        return clientes.Where(c => c.Idade() >= idadeMinima && c.Idade() <= idadeMaxima);
    }

    public static IEnumerable<Cliente> GetClientesComIMCMaiorQue(double imcMinimo)
    {
        return clientes.Where(c => c.IMC() > imcMinimo);
    }

    public  static IEnumerable<Cliente> GetClientesOrdenadosPorNome()
    {
        return clientes.OrderBy(c => c.Nome);
    }

    public  static IEnumerable<Cliente> GetClientesOrdenadosPorIdade(bool crescente = true)
    {
        return crescente
            ? clientes.OrderBy(c => c.Idade())
            : clientes.OrderByDescending(c => c.Idade());
    }

    

    private static void ImprimirRelatorioTreinador(IEnumerable<Treinador> treinadores)
    {
        
        foreach (var treinador in treinadores)
        {
            Console.WriteLine($"Nome: {treinador.Nome}");
            Console.WriteLine($"Data de Nascimento: {treinador.DataNascimento}");
            Console.WriteLine($"Idade: {treinador.Idade()}");
            Console.WriteLine($"CPF: {treinador.CPF}");
            Console.WriteLine($"CREF: {treinador.CREF}");
            Console.WriteLine("---------------------------");
        }
    }

    private static void ImprimirRelatorioCliente(IEnumerable<Cliente> clientes)
    {
        
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}");
            Console.WriteLine($"Idade: {cliente.Idade()}");
            Console.WriteLine($"CPF: {cliente.CPF}");
            Console.WriteLine($"Peso: {cliente.Peso}");
            Console.WriteLine($"Altura: {cliente.Altura}");
            Console.WriteLine("---------------------------");
        }
    }

    public static IEnumerable<Treinador> GetAniversariantesTreinadoresDoMes(int mes)
    {
        return treinadores
            .Where(t => t.DataNascimento.Month == mes)
            .OrderBy(t => t.DataNascimento);
    }

    public static IEnumerable<Cliente> GetAniversariantesClientesDoMes(int mes)
    {
        return clientes
            .Where(t => t.DataNascimento.Month == mes)
            .OrderBy(t => t.DataNascimento);
    }
}
