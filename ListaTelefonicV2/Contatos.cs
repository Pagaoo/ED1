using System;

namespace ListaTelefonicV2
{
    public class Contatos
    {
    public string nome { get; set; }

    public string tel { get; set; }

    public string email { get; set; }

    public string getNome()
    {
      return this.nome;
    }

    public string getTel()
    {
      return this.tel;
    }

    public string getEmail()
    {
      return this.email;
    }


    public void AddContato()
    {
      Console.WriteLine("Nome do contato: ");
      this.nome = Console.ReadLine();
      Console.WriteLine("Numero do contato: ");
      this.tel = Console.ReadLine();
      Console.WriteLine("Email do contato: ");
      this.email = Console.ReadLine();
    }
    }
}