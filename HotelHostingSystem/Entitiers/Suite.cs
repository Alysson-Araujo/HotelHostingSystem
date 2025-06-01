namespace HotelHostingSystem.Entitiers;

public class Suite
{
    private string _tipoSuite;
    private int _capacidade;
    private decimal _valorDiaria;
    
    
    public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
    {
        _tipoSuite = tipoSuite;
        _capacidade = capacidade;
        _valorDiaria = valorDiaria;
    }
    
    // getters e setters para possiveis utilizações futuras
    public string TipoSuite
    {
        get => _tipoSuite;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Tipo de suíte não pode ser nulo ou vazio.");
            }
            _tipoSuite = value;
        }
    }
    
    public int Capacidade
    {
        get => _capacidade;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Capacidade deve ser maior que zero.");
            }
            _capacidade = value;
        }
    }
    
    public decimal ValorDiaria
    {
        get => _valorDiaria;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Valor da diária deve ser maior que zero.");
            }
        }
    }
}