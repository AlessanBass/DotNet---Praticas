namespace Avaliacao1;

public class Treinador{
    private string nome="";
    private DateTime dataNascimento;
    private string cpf="";
    private string cref="";
    
    public Treinador(string nome, DateTime dataNascimento, string cpf, string cref)
    {
        this.nome = nome;
        this.dataNascimento = dataNascimento;
        this.cpf = cpf;
        this.cref = cref;
    }

    public int Idade()
    {
        int idade = DateTime.Today.Year - DataNascimento.Year;

        if (DataNascimento > DateTime.Today.AddYears(-idade))
        {
            idade--;
        }

        return idade;
    }
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public DateTime DataNascimento
    {
        get { return dataNascimento; }
        set { dataNascimento = value; }
    }

    public string CPF
    {
        get { return cpf; }
        set { cpf = value; }
    }

    public string CREF
    {
        get { return cref; }
        set { cref = value; }
    }
}
