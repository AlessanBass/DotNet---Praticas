namespace pratica3;

public static class App{
    private static List<Produto> produtos = new List<Produto>();

    public static void Menu(){
       int opcao = -1;

        do{
            Console.WriteLine(">>> GERENCIAMENTO <<<");
            Console.WriteLine("[1] Cadastrar Produto");
            Console.WriteLine("[2] Consultar Produtos");
            Console.WriteLine("[3] Atualizacao de Estoque");
            Console.WriteLine("[4] Listar Produtos");
            Console.WriteLine("[5] Gerar Relatórios");
            Console.WriteLine("[0] Sair");

            try
            {
                // Tenta converter a entrada para um número inteiro
               opcao = Convert.ToInt32(Console.ReadLine());

               switch(opcao){
                    case 1:
                        CadastroProduto();
                    break;

                    case 2:
                        ConsultarProduto();
                    break;

                    case 3:
                        Console.WriteLine("Em construcao...");
                    break;

                    case 4:
                        ListarProdutos();
                    break;

                    case 5:
                        Console.WriteLine("Em construcao...");
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

        }while(opcao != 0);
    }

    public static void CadastroProduto(){
        string nome_produto="";
        int id_produto, qtd_estoque =0;
        double preco_unitario = 0.0;

        Console.WriteLine(">>> CADASTRO PRODUTO <<<");
        try
        {
            Console.WriteLine("Informe o nome do produto:");
            nome_produto = Console.ReadLine() ?? "";
        }
        catch (System.IO.IOException ex)
        {
            Console.WriteLine("Ocorreu um erro na entrada/saída: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro: " + ex.Message);
        }
        Console.WriteLine("Informe a quantidade em estoque: ");
        try
            {
                // Tenta converter a entrada para um número inteiro
               qtd_estoque = Convert.ToInt32(Console.ReadLine());

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
        Console.WriteLine("Informe o preco: ");
        try
            {
                // Tenta converter a entrada para um número inteiro
               preco_unitario = Convert.ToDouble(Console.ReadLine());
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
        if(produtos.Count == 0){
            id_produto = 0;
        }else{
            id_produto = produtos.Last().Id_produto + 1;
        }

        Produto produto = new Produto(id_produto, nome_produto, qtd_estoque, preco_unitario);
        produtos.Add(produto);
        Console.WriteLine("Produto cadastrado com sucesso!");
        
    }

    public static void ListarProdutos(){
        Console.WriteLine(">>> LISTAGEM DE PRODUTOS <<<");

    if (produtos.Count == 0)
    {
        Console.WriteLine("Nenhum produto cadastrado.");
    }
    else
    {
        foreach (var produto in produtos)
        {
            Console.WriteLine($"ID: {produto.Id_produto}");
            Console.WriteLine($"Nome: {produto.Nome_produto}");
            Console.WriteLine($"Quantidade em Estoque: {produto.Qtd_estoque}");
            Console.WriteLine($"Preço Unitário: {produto.Preco_unitario.ToString("F2")}");
            Console.WriteLine("--------------------------------------------");
        }
    }
    }

    public static bool BuscaProduto(int id_desejado){
        foreach(var produto in produtos){
            if(id_desejado == produto.Id_produto){
                return true;
            }
        }
        throw new ProdutoNaoEncontrado();
    }

    public static void ConsultarProduto(){
        int id_desejado;
        if(produtos.Count == 0){
            Console.WriteLine("Nenhum produto cadastrado");
            return;
        }
        Console.WriteLine(">>> CONSULTA PRODUTO <<<");
        Console.WriteLine("Informe o id do produto: ");
        try
            {
                // Tenta converter a entrada para um número inteiro
               id_desejado = Convert.ToInt32(Console.ReadLine());
               if(BuscaProduto(id_desejado)){
                    Console.WriteLine(">>> Exibindo Produto <<<");
                    Console.WriteLine($"ID: {produtos[id_desejado].Id_produto}");
                    Console.WriteLine($"Nome: {produtos[id_desejado].Nome_produto}");
                    Console.WriteLine($"Quantidade em Estoque: {produtos[id_desejado].Qtd_estoque}");
                    Console.WriteLine($"Preço Unitário: {produtos[id_desejado].Preco_unitario.ToString("F2")}");
                    Console.WriteLine("--------------------------------------------");
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

    }
}