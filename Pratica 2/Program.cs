using System;
using System.Collections;
using System.Data.Common;
class Tarefa {
    private int id;
    private string titulo;
    private string descricao;
    private int concluida;
    private DateTime dataVencimento;

    public Tarefa (int id, string titulo, string descricao, DateTime dataVencimento ){
        this.id = id;
        this.titulo = titulo;
        this.descricao = descricao;
        this.dataVencimento = dataVencimento;
        this.concluida = 0;
    }

    public int Id
    {
        get {return id;}
        set {id = value;}
    }
    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }


    public string Descricao
    {
        get { return descricao; }
        set { descricao = value; }
    }

    public int Concluida
    {
        get { return concluida; }
        set { concluida = value; }
    }

    public DateTime DataVencimento
    {
        get { return dataVencimento; }
        set { dataVencimento = value; }
    }

    

}
class Pratica002{
    static void Main(){
        int opcao = 0;
        List<Tarefa> tarefas = new List<Tarefa>();
        

        do{
            exibeMenu();
            opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                    string titulo, descricao, data;
                    string[] dataEmPartes;
                    int dia, mes, ano, id;
                    Console.WriteLine(">>> CRIANDO UMA TAREFA <<<");

                    Console.WriteLine("Informe o titulo da tarefa");
                    titulo = Console.ReadLine();

                    Console.WriteLine("Informe a descricao da tarefa");
                    descricao = Console.ReadLine();

                    Console.WriteLine("Informe da data de vencimento nesse formato: DD/MM/ANO");
                    data = Console.ReadLine();

                    dataEmPartes = data.Split('/');
                    dia = converteParaInt(dataEmPartes[0]);
                    mes = converteParaInt(dataEmPartes[1]);
                    ano = converteParaInt(dataEmPartes[2]);

                    DateTime dataVencimento =  new DateTime(ano, mes, dia);
                    if(tarefas.Count > 0){
                        id = tarefas.Last().Id +1;
                    }else{
                        id = 1;
                    }
                    
                    Tarefa tarefa = new Tarefa(id, titulo, descricao, dataVencimento);
                    tarefas.Add(tarefa);

                    Console.WriteLine("Tarefa cadastrada com sucesso!"); 
                break;

                case 2:
                    listaTarefas(tarefas);
                break;

                case 3:
                    Console.WriteLine(">>> EXIBINDO ESTATISTICA <<<");
                    exibeEstatisticas(tarefas);
                break;

                case 4:
                    int idTarefa, retorno;
                    Console.WriteLine(">>> MARCAR COMO CONCLUIDA <<<");
                    listaTarefasPendentes(tarefas);
                    Console.WriteLine("Informe o id: ");
                    idTarefa = int.Parse(Console.ReadLine());
                    retorno = buscaTarefa(idTarefa, tarefas);
                    if( retorno == -1){
                        Console.WriteLine("Ops... tarefa não encontrada");
                    }else{
                        tarefas[retorno].Concluida = 1;
                        Console.WriteLine("Tarefa alterada com sucesso!");
                    }
                break;

                case 5:
                    Console.WriteLine(">>> EXCLUIR TAREFA<<<");
                    listaTarefas(tarefas);
                    Console.WriteLine("Informe o id: ");
                    idTarefa = int.Parse(Console.ReadLine());
                    retorno = buscaTarefa(idTarefa, tarefas);
                    if( retorno == -1){
                        Console.WriteLine("Ops... tarefa não encontrada");
                    }else{
                        tarefas.RemoveAt(retorno);
                        Console.WriteLine("Tarefa excluida com sucesso!");
                    }
                break;

                case 6:
                    Console.WriteLine("Fim do Progarama!");
                break;

                default:
                    Console.WriteLine("Ops... Opcao invalida");
                break;
            }

        }while(opcao != 6);
    }

    static void exibeMenu(){
        Console.WriteLine(">>> GESTAO DE TAREFAS <<<");
        Console.WriteLine("[1] CRIAR TAREFA");
        Console.WriteLine("[2] LISTAR TAREFAS");
        Console.WriteLine("[3] ESTATISTICAS BASICAS");
        Console.WriteLine("[4] MARCAR UMA TAREFA COMO CONCLUIDA");
        Console.WriteLine("[5] EXCLUIR TAREFA");
        Console.WriteLine("[6] SAIR");
    }

    static int converteParaInt(string valor){
        return Convert.ToInt32(valor);
    }

    static void listaTarefas(List<Tarefa> tarefas){
        Console.WriteLine(">>> LISTANDO TAREFAS");
        foreach(var tarefa in tarefas){
            Console.WriteLine($"ID: {tarefa.Id}");
            Console.WriteLine($"Titulo: {tarefa.Titulo}");
            Console.WriteLine($"Descricao: {tarefa.Descricao}");
            Console.WriteLine($"Data de Vencimento: { tarefa.DataVencimento}");
            if(tarefa.Concluida == 0){
                Console.WriteLine("Status: Pendente");
            }else{
                Console.WriteLine("Status: Concluida");
            }
            Console.WriteLine("================================");
        }
    }

    static void listaTarefasPendentes(List<Tarefa> tarefas){
        Console.WriteLine(">>> LISTANDO TAREFAS PENDENTES");
        foreach(var tarefa in tarefas){
            if(tarefa.Concluida == 0){
                Console.WriteLine($"ID: {tarefa.Id}");
                Console.WriteLine($"Titulo: {tarefa.Titulo}");
                Console.WriteLine($"Descricao: {tarefa.Descricao}");
                Console.WriteLine($"Data de Vencimento: { tarefa.DataVencimento}");
                Console.WriteLine("Status: Pendente");
                Console.WriteLine("================================");
            }
        }
        
    }

    static int buscaTarefa(int idTarefa, List<Tarefa> tarefas){

        for(int i = 0; i<tarefas.Count; i++){
            if(idTarefa == tarefas[i].Id){
                return i;
            }
        }
        return -1;
    }

    static void exibeDetalheTarefa(Tarefa tarefa){
        Console.WriteLine($"ID: {tarefa.Id}");
        Console.WriteLine($"Titulo: {tarefa.Titulo}");
        Console.WriteLine($"Descricao: {tarefa.Descricao}");
        Console.WriteLine($"Data de Vencimento: { tarefa.DataVencimento}");
        if(tarefa.Concluida == 0){
            Console.WriteLine("Status: Pendente");
        }else{
            Console.WriteLine("Status: Concluida");
        }
    }

    static void exibeEstatisticas(List<Tarefa> tarefas){
        int numeroTarefas = tarefas.Count;
        int tarefasConcluidas = 0;
        int tarefasPendentes = 0;

        foreach(var tarefa in tarefas){
            if(tarefa.Concluida == 1){
                tarefasConcluidas++;
            }else{
                tarefasPendentes++;
            }
        }

        Console.WriteLine("=================================");
        Console.WriteLine($"Qtd de tarefas cadastradas: {numeroTarefas}");
        Console.WriteLine($"Qtd de tarefas concluidas: {tarefasConcluidas}");
        Console.WriteLine($"Qtd de tarefas pendentes: {tarefasPendentes}");
        Console.WriteLine($"Tarefa mais antiga: ");
        exibeDetalheTarefa(tarefas.First());
        Console.WriteLine($"Tarefa mais recente: ");
        exibeDetalheTarefa(tarefas.Last());
        Console.WriteLine("=================================");
    }

}