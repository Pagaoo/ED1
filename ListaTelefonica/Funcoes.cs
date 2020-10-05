using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public class Funcoes
    {
        SortedList lista = new SortedList();
        private LinkedList<Contato> list = new LinkedList<Contato>();

        public Funcoes(LinkedList<Contato> list) {
            this.list = list;
        }

        public LinkedList<Contato> List {
            get { return list; }
            set { list = value; }
        }

        public void AddContato(Contato contato) {
            list.AddLast(contato);
        }

        public void DeletContato(int cont) {
            foreach(var contato in list.Where(item => item.Tel.Equals(cont)).ToArray())
            {
                list.Remove(contato);
            }
        }

        public void MostrarAgenda(int cont) {
            foreach (var contato in list)
            {
                if(contato.Tel.Equals(cont)) {
                    Console.WriteLine(contato.ToString());
                }
            }
        }

        public void OrderNome() {
            using (var file = new StreamWriter("Agenda.txt"))
            {
            var SortedList = list.OrderBy(item => item.Nome).ToList();
            }
        }        
                    
             

        public void OrderEmail() {
            using (var file = new StreamWriter("Agenda.txt"))
            {
                var SortedList = list.OrderBy(item => item.Email).ToList();
            }
        }

        public void SalvarFile() {
            using (var file = new StreamWriter("Agenda.txt"))
            {
                foreach (var contato in list)
                {
                    file.WriteLine(contato.ToString());
                }
            }
        }

        public void Cont () {
            using(var file = new StreamReader("Agenda.txt")) {
                foreach (var contato in list)
                {
                    Console.Write(contato.ToString());
                }
            }
        }
}
