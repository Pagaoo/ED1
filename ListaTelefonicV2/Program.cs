using System;

namespace ListaTelefonicV2
{
    class Program
    {
    static void Main(string[] args)
    {
      Lista lista = new Lista();

      do
      {
        string opc = Console.ReadLine();
        Console.WriteLine("Selecione sua opção: ");
        OPC();
        switch (opc)
        {
          case "0":
            Console.WriteLine("Saindo do Programa");
            System.Environment.Exit(0);
            break;
          case "1":
            lista.Mostrar();
            break;
          case "2":
            Contatos contatos = new Contatos();
            contatos.AddContato();
            lista.AdicionarContato(contatos);
            lista.SalvarContatos();
            break;
          case "3":
            Console.WriteLine("Qual contato deseja remover?");
            Lista.ContatoRemoverMenuzinho(lista);
            break;
          case "4":
            break;
          case "5":
            break;
        }
      } while (true);
    }

    public static void OPC()
    {
      Console.WriteLine("__________________________");

      Console.WriteLine("Para mostrar todos os contatos, digite 1");
      Console.WriteLine("Para adicionar e salvar contato, digite 2");
      Console.WriteLine("Para deletar contato, digite 3");
      Console.WriteLine("Para ordenar contatos por nome, digite 4");
      Console.WriteLine("Para ordenar contatos por email, digite 5");
      Console.WriteLine("Para sair do programa, digite 0");
    }
    }
}
