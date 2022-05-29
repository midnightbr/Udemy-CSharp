namespace GetHashCode_and_Equals.Entities;

public class Client
{
    public string Name { get; set; }
    public string Email { get; set; }

    // Mais lento, mais 100% de certeza
    public override bool Equals(object? obj)
    {
        if (!(obj is Client))
        {
            return false;
        }
        Client other = obj as Client;
        return Email.Equals(other.Email);
    }

    // Mais rapido, porém a resposta positiva não é 100% confiavel.
    // No entanto, é raro haver error nessa comparação
    public override int GetHashCode()
    {
        return Email.GetHashCode();
    }
}