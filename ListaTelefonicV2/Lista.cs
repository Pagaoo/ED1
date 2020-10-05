using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ListaTelefonicV2
{
    public class Lista
    {
    SortedList lista = new SortedList();
    public Node begin, end;

    public Lista()
    {
      begin = null;
      end = null;
    }

    public void AdicionarContato(Contatos contatos)
    {
      var newNode = new Node(contatos);
      if (begin == null)
      {
        begin = newNode;
      }
      else
      {
        end.next = newNode;
      }
      end = newNode;
      newNode.next = begin;
    }

    public void RemoverContato(Contatos contatos)
    {
      if (begin == null)
      {
        Console.Write("Sem contatos");
      }
      else
      {
        var current = begin;
        var past = begin;

        do
        {
          if (current.data == contatos)
          {
            if (current == begin)
            {
              if (current.data == begin.next.data)
              {
                begin = null;
                current = null;
              }
              else
              {
                begin = current.next;
                end.next = current.next;
                current = null;
              }
              break;
            }
            else
            {
              past.next = current.next;
              if (current == end)
              {
                end = past;
              }
              current = null;
              break;
            }
          }
          else
          {
            past = current;
            current = current.next;
          }
        } while (current != begin);
      }
    }

    public void OrderNome(Contatos contatos)
    {
    
    }

    public void OrderEmail(Contatos contatos)
    {
      
    }

    public void Mostrar()
    {
      if (begin == null)
      {
        Console.Write("Sem contato");
      }
      else
      {
        //Console.Write("[HEAD]");
        var aux = begin;

        do
        {
          Console.Write($"-> Nome: [{aux.data.getNome()}] - Telefone: [{aux.data.getTel()}] - Email: [{aux.data.getEmail()}]\n");
          aux = aux.next;
        } while (aux != begin);
        //Console.Write("-> [NULL]");
      }
    }

    public string MostrarLista()
    {
      string lista = null;
      if (begin == null)
      {
        lista = "Sem contatos";
      }
      else
      {
        var aux = begin;
        do
        {
          lista = lista + $"Nome: [{aux.data.getNome()}] - Telefone: [{aux.data.getTel()}] - Email: [{aux.data.getEmail()}]\n";
          aux = aux.next;
        } while (aux != begin);
      }
      return lista;
    }

    public List<Contatos> MostrarContatos()
    {
      List<Contatos> contatos = new List<Contatos>();

      if (begin == null)
      {
        Console.Write("Sem contatos");
      }
      var aux = begin;
      do
      {
        contatos.Add(aux.data);
        aux = aux.next;
      } while (aux != end);
      return contatos;
    }

    public void SalvarContatos()
    {
      StreamWriter file;

      file = File.AppendText("Agenda.txt");
      string list = this.MostrarLista();
      file.WriteLine(list);
      file.Close();
    }

    public static Contatos Menu(List<Contatos> nums)
    {
      bool enter = false;
      int index = 0;

      do
      {
        Console.Clear();
        Console.WriteLine("Selecione contato para ser excluido: ");
        Console.WriteLine("Aperte 'B' para voltar");

        for (int i = 0; i < nums.Count; i++)
        {
          if (i == index)
          {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(nums[i].getNome());
          }
          else
          {
            Console.WriteLine(nums[i].getNome());
          }
          Console.ResetColor();
        }
        ConsoleKeyInfo keys = Console.ReadKey();

        if (keys.Key == ConsoleKey.DownArrow)
        {
          if (index == nums.Count - 1)
          {
            index = 0;
          }
          else
          {
            index++;
          }
        }
        else if (keys.Key == ConsoleKey.UpArrow)
        {
          if (index <= 0)
          {
            index = nums.Count - 1;
          }
          else
          {
            index--;
          }
        }
        else if (keys.Key == ConsoleKey.Enter)
        {
          enter = true;
        }
        else if (keys.Key == ConsoleKey.B)
        {
          return null;
        }
      } while (!enter);
      Console.Clear();
      return nums[index];
    }

    public static void ContatoRemoverMenuzinho(Lista lista)
    {
      List<Contatos> items = lista.MostrarContatos();
      bool removido = false;

      while (!removido)
      {
        Contatos itemSelec = Menu(items);
        if (itemSelec != null)
        {
          lista.RemoverContato(itemSelec);
          Console.WriteLine("Excluido!");
          removido = true;
        }
        else if (items == null)
        {
          removido = true;
          Console.WriteLine("Sem contatos");
        }
      }
    }
    }
}