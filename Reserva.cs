public class Reserva {
    private int diarias;
    public Hospede Hospede { get; set; }
    public Quarto Quarto { get; set; }

    public Reserva(Hospede hospede, Quarto quarto, int diarias) {
        if (diarias <= 0) {
            throw new ArgumentException("O valor da diária deve ser maior que zero.");
        }
        this.diarias = diarias;
        Hospede = hospede;
        Quarto = quarto;
    }

    public double ValorTotal { 
        get { return Quarto.valorDiaria * diarias; }
    }
}