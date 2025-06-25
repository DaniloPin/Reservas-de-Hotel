Hospede hospede = new Hospede("Débora Pinheiro");
Quarto quarto = new Quarto(3108);
quarto.valorDiaria = 250;

Reserva reserva = new Reserva (hospede, quarto, 8);
Console.WriteLine("Reserva para: " + reserva.Hospede.Nome);
Console.WriteLine("Quarto: " + reserva.Quarto.Numero);
Console.WriteLine("Valor total: R$ " + reserva.ValorTotal.ToString("F2"));