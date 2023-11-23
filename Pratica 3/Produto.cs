namespace pratica3;
class Produto{
    private int id_produto;
    private string nome_produto;
    private int qtd_estoque;
    private double preco_unitario;


    // Construtor
    public Produto(int id_produto, string nome_produto, int qtd_estoque, double preco_unitario)
    {
        this.id_produto = id_produto;
        this.nome_produto = nome_produto;
        this.qtd_estoque = qtd_estoque;
        this.preco_unitario = preco_unitario;
    }

    // Propriedades (equivalentes a getters e setters)
    public int Id_produto
    {
        get { return id_produto; }
        set { id_produto = value; }
    }

    public string Nome_produto
    {
        get { return nome_produto; }
        set { nome_produto = value; }
    }

    public int Qtd_estoque
    {
        get { return qtd_estoque; }
        set { qtd_estoque = value; }
    }

    public double Preco_unitario
    {
        get { return preco_unitario; }
        set { preco_unitario = value; }
    }

}