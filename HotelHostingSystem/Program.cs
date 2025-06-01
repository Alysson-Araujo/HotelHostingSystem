using HotelHostingSystem.Entitiers;

namespace HotelHostingSystem;


public class Program
{
    public static void Main(string[] args)
    {
        Reserva reserva = new Reserva();
        
        Suite suite = new Suite("Prime", 10, 500.00m);
        
        Pessoa pessoa1 = new Pessoa("Ana", "Silva");
        Pessoa pessoa2 = new Pessoa("Carlos", "Oliveira");
        Pessoa pessoa3 = new Pessoa("Juliana", "Santos");
        Pessoa pessoa4 = new Pessoa("Marcos", "Ferreira");
        Pessoa pessoa5 = new Pessoa("Beatriz", "Souza");
        
        List<Pessoa> hospedes = new List<Pessoa>
        {
            pessoa1,
            pessoa2,
            pessoa3,
            pessoa4,
            pessoa5
        };
        
        reserva.DiasReservados = 10; 
        
        try
        {
            reserva.CadastrarHospedes(hospedes);
            reserva.CadastrarSuite(suite);
            
            int quantidadeHospedes = reserva.ObterQuantidadeHospedes();
            decimal valorDiaria = reserva.CalcularValorDiaria();
            
            Console.WriteLine($"Quantidade de hóspedes da Suite: {quantidadeHospedes}");
            Console.WriteLine($"Valor da diária da Suite: {valorDiaria:C}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        
    }
}

