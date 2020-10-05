public class Contato
    {
        private string tel;
        private string nome;
        private string email;

        public Contato(string tel, string nome, string email)
        {
            this.tel = tel;
            this.nome = nome;
            this.email = email;
        }

        public override string ToString() {
            return $"Nome: {nome} - Telefone: {tel} - Email: {email}\n";
        }

        public string Tel {
            get { return tel; }
            set { tel = value; }
        }

        public string Nome {
            get { return nome ;}
            set { nome = value; }
        }

        public string Email {
            get { return email; }
            set { email = value; }
        }
}
