namespace HotelHostingSystem.Entitiers;

public class Reserva
{
    private List<Pessoa> _hospedes;
    private Suite _suite;
    private int _diasReservados;

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (hospedes == null || hospedes.Count == 0)
        {
            throw new ArgumentException("A lista de hóspedes não pode ser nula ou vazia!");
        }
        
        _hospedes = hospedes;
    }
    
    public void CadastrarSuite(Suite suite)
    {
        _suite = suite ?? throw new ArgumentException("A suíte não pode ser nula!");
    }
    
    public int ObterQuantidadeHospedes()
    
    {
        return _hospedes.Count;
    }
    
    public decimal CalcularValorDiaria()
    {
        if (_diasReservados <= 0)
        {
            throw new ArgumentException("Número de dias reservados deve ser maior que zero.");
        }
        
        return _diasReservados >= 10 
            ? _suite.ValorDiaria * _diasReservados * 0.9m
            : _suite.ValorDiaria * _diasReservados;
    }
    
    public int DiasReservados
    {
        get => _diasReservados;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Número de dias reservados deve ser maior que zero.");
            }
            _diasReservados = value;
        }
    }
}