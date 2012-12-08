/***********************************************************************
 * Module:  Funcionario.cs
 * Author:  LuisHenrique
 * Purpose: Definition of the Class Funcionario
 ***********************************************************************/
using System;
using SaudeMed.BDSAUDEMEDDataSetTableAdapters;

namespace SaudeMed
{
    public class Funcionario : Pessoa
    {
        public new void Inserir()
        {
            // TODO: implement
        }

        public new void Excluir()
        {
            // TODO: implement
        }

        public new void Atualizar()
        {
            // TODO: implement
        }

        public new void Listar()
        {
            // TODO: implement
        }

        public System.Collections.ArrayList venda;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetVenda()
        {
            if (venda == null)
                venda = new System.Collections.ArrayList();
            return venda;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetVenda(System.Collections.ArrayList newVenda)
        {
            RemoveAllVenda();
            foreach (Venda oVenda in newVenda)
                AddVenda(oVenda);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddVenda(Venda newVenda)
        {
            if (newVenda == null)
                return;
            if (this.venda == null)
                this.venda = new System.Collections.ArrayList();
            if (!this.venda.Contains(newVenda))
                this.venda.Add(newVenda);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveVenda(Venda oldVenda)
        {
            if (oldVenda == null)
                return;
            if (this.venda != null)
                if (this.venda.Contains(oldVenda))
                    this.venda.Remove(oldVenda);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllVenda()
        {
            if (venda != null)
                venda.Clear();
        }

        private int idfuncionario;
        private string identidade;
        private DateTime datanascimento;
        private DateTime admissao;
        private string funcao;
        private string registroprofissional;

        public string RegistroProfissional
        {
            get { return registroprofissional; }
            set { registroprofissional = value; }
        }
        

        public string Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }
        

        public DateTime Admissao
        {
            get { return admissao; }
            set { admissao = value; }
        }
        

        public DateTime DataNascimento
        {
            get { return datanascimento; }
            set { datanascimento = value; }
        }
        

        public string Identidade
        {
            get { return identidade; }
            set { identidade = value; }
        }
        

        public int IdFuncionario
        {
            get { return idfuncionario; }
        }
        
        

    }
}