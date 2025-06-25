public class Quarto {
    public int Numero { get; set; }
    public double valorDiaria;
    public Quarto(int numero) {
        Numero = numero;
    }

    public double ValorDiaria{
        get { return valorDiaria; }
        set { if (value > 0) valorDiaria = value; 
            else Console.WriteLine("ERRO: O valor da diária deve ser maior que 0."); }
    }
}