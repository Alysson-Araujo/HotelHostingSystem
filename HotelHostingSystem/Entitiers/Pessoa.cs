using System.Text.RegularExpressions;

namespace HotelHostingSystem.Entitiers;

public partial class Pessoa
{
    private string _nome;
    private string _sobrenome;
    
    public Pessoa(string nome, string sobrenome)
    {
        _nome = nome;
        _sobrenome = sobrenome;
    }
    
    // getters e setters para possiveis utilizações futuras
    public string Nome
    {
        get => _nome;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Nome não pode ser nulo ou vazio.");
            }
            _nome = value;
        }
        
    }
    
    public string Sobrenome
    {
        get => _sobrenome;
        set
        {
            
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Sobrenome não pode ser nulo ou vazio.");
            }
            
            _sobrenome = value;
        }
        
    }
    
}