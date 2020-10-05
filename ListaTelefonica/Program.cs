using System;
using System.Collections.Generic;

class Program
    {
  

  static void Main(string[] args)
        {
            var list = new LinkedList<Contato>();
            var func = new Funcoes(list);

            int opc;
            string nome;
            string email;
            string tel;

            do
            {
                Opc();
                
                opc = (int)Convert.ToInt64(Console.ReadLine());
                switch(opc)
                {
                    case 0:
                        Console.WriteLine("Saindo do Programa");
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Coloque o numero de telefone: ");
                        tel = Console.ReadLine();

                        Console.WriteLine("Coloque nome do contato: ");
                        nome = Console.ReadLine();

                        Console.WriteLine("Coloque o email do contato: ");
                        email = Console.ReadLine();

                        func.AddContato(new Contato(tel, nome, email));
                        func.SalvarFile();
                        break;
                    case 2:
                        Console.WriteLine("Escreva o numero que deseja procurar: ");
                        int cont = (int)Convert.ToInt64(Console.ReadLine());
                        func.MostrarAgenda(cont);
                        break;
                    case 3 :
                        Console.WriteLine("Coloque o numero do contato que deseja excluir");
                        cont = (int)Convert.ToInt64(Console.ReadLine());
                        func.DeletContato(cont); 
                        func.SalvarFile();
                        break;
                    case 4:
                        Console.Write("Contatos ordenados por nome \n");
                        func.OrderNome();
                        func.SalvarFile();
                        break;
                    case 5:
                        Console.Write("Contatos ordenados por email \n");
                        func.OrderEmail();
                        func.SalvarFile();
                        break;
                    case 6:
                        func.Cont();
                        break;
                }
            } while(true);
        }



  private static void Opc()
    {
        Console.WriteLine("Aperte 0 para sair do programa");
        Console.WriteLine("Aperte 1 para introduzir novo contato");
        Console.WriteLine("Aperte 2 para procurar contato");
        Console.WriteLine("Aperte 3 para excluir contato");
        Console.WriteLine("Aperte 4 para ordenar contatos por Nome");
        Console.WriteLine("Aperte 5 para ordenar contatos por Email");
        Console.WriteLine("Aperte 6 para mostrar agenda");
    }
        

}    

