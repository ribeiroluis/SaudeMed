/***********************************************************************
 * Module:  Pessoa.cs
 * Author:  LuisHenrique
 * Purpose: Definition of the Class Pessoa
 ***********************************************************************/

using System;
namespace SaudeMed
{

    public abstract class Pessoa
    {
        public void Inserir()
        {
            // TODO: implement
        }

        public void Excluir()
        {
            // TODO: implement
        }

        public void Atualizar()
        {
            // TODO: implement
        }

        public void Listar()
        {
            // TODO: implement
        }

        private string cpf;
        private string nome;
        private string telefonefixo;
        private string telefonecelular;
        private int cep;
        private string logradouro;
        private int numero;
        private string complemento;
        private string bairro;
        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }
        

        public int CEP
        {
            get { return cep; }
            set { cep = value; }
        }
        

        public string TelefoneCelular
        {
            get { return telefonecelular; }
            set { telefonecelular = value; }
        }
        

        public string TelefoneFixo
        {
            get { return telefonefixo; }
            set { telefonefixo = value; }
        }
        

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        
    }

}