namespace pratica3;

public static class App{
    public static void Menu(){
       int opcao = -1;

        do{
            Console.WriteLine(">>> GERENCIAMENTO <<<");
            Console.WriteLine("[1] Cadastrar Produto");
            Console.WriteLine("[2] Consultar Produtos");
            Console.WriteLine("[3] Atualizacao de Estoque");
            Console.WriteLine("[4] Gerar Relatórios");
            Console.WriteLine("[0] Sair");

            try
            {
                // Tenta converter a entrada para um número inteiro
               opcao = Convert.ToInt32(Console.ReadLine());

               switch(opcao){
                    case 1:
                        Console.WriteLine("Em construcao...");
                    break;

                    case 2:
                        Console.WriteLine("Em construcao...");
                    break;

                    case 3:
                        Console.WriteLine("Em construcao...");
                    break;

                    case 4:
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
}