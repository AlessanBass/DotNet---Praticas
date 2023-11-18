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
            opcao = int.Parse(Console.ReadLine()); // resolver depois

            switch(opcao){
                case 1:
                    string titulo, descricao, data;
                    string[] dataEmPartes;
                    int dia, mes, ano;
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
                    Tarefa tarefa = new Tarefa(tarefas.Count+1, titulo, descricao, dataVencimento);
                    tarefas.Add(tarefa);
                    
                break;

                case 2:
                    listaTarefas(tarefas);
                break;

                case 3:
                break;

                case 4:
                break;

                case 5:
                    Console.WriteLine("Fim do Progarama!");
                break;

                default:
                    Console.WriteLine("Ops... Opcao invalida");
                break;
            }

        }while(opcao != 5);
    }

    static void exibeMenu(){
        Console.WriteLine(">>> GESTAO DE TAREFAS <<<");
        Console.WriteLine("[1] CRIAR TAREFA");
        Console.WriteLine("[2] LISTAR TAREFAS");
        Console.WriteLine("[3] MARCAR UMA TAREFA COMO CONCLUIDA");
        Console.WriteLine("[4] EXCLUIR TAREFA");
        Console.WriteLine("[5] SAIR");
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
                Console.WriteLine("Status: Nao concluida");
            }else{
                Console.WriteLine("Status: Concluida");
            }
            Console.WriteLine("================================");
        }
    }
}