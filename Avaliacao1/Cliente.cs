namespace Avaliacao1;

public class Cliente
{
    private string nome = "";
    private DateTime dataNascimento;
    private string cpf = "";
    private double altura;
    private double peso;

    public int Idade()
    {
        int idade = DateTime.Today.Year - DataNascimento.Year;

        if (DataNascimento > DateTime.Today.AddYears(-idade))
        {
            idade--;
        }

        return idade;
    }

     public double IMC()
    {
        return Peso / (Altura * Altura);
    }


    public Cliente(string nome, DateTime dataNascimento, string cpf, double altura, double peso)
    {
        this.nome = nome;
        this.dataNascimento = dataNascimento;
        this.cpf = cpf;
        this.altura = altura;
        this.peso = peso;
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

    public double Altura
    {
        get { return altura; }
        set { altura = value; }
    }

    public double Peso
    {
        get { return peso; }
        set { peso = value; }
    }


}
