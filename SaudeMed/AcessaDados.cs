﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaudeMed.BDSAUDEMEDDataSetTableAdapters;
using System.Data;

namespace SaudeMed
{
    class AcessaDados
    {
        public string RetornaLogradouroporCEP(int cep)
        {
            ENDERECOTableAdapter endereco = new ENDERECOTableAdapter();
            string logradouro = endereco.PesquisaLogradouroPorCEP(cep);
            return logradouro; 
        }

        public string RetornaCidadeporCEP(int cep)
        {
            ENDERECOTableAdapter endereco = new ENDERECOTableAdapter();
            string cidade = endereco.RetornaCidadePorCEP(cep);
            return cidade;
        }
        public string RetornaBairroporCEP(int cep)
        {
            ENDERECOTableAdapter endereco = new ENDERECOTableAdapter();
            string bairro = (endereco.RetornaBairroporCEP(cep)).ToString();
            return bairro;
        }

        public string RetornaNomeJaCadastrado(string nome)
        {
            nome = nome.ToUpper();
            nome = "%" + nome +"%";
            FUNCIONARIOTableAdapter funcionario = new FUNCIONARIOTableAdapter();
            string NomedaTabela = "";
            var pesquisa = funcionario.RetornarNomeFuncionario(nome);
            if ( pesquisa != null)
            {
                NomedaTabela = pesquisa.ToString();
            }
            return NomedaTabela;
            
        }
        public DataTable RetornaTabelaFuncionarios()
        {
            ViewTabelaFuncionariosTableAdapter tabelafuncionarios = new ViewTabelaFuncionariosTableAdapter();
            DataTable tabela = new DataTable();
            tabela = tabelafuncionarios.GetData();
            return tabela;
        }

        public void Gravar(string nome, int cep, int numero, string comp, string telfixo, string telcel, string cpf, string id, string dtnascimento, string admissao, string funcao, string regprofissional)
        {
            FUNCIONARIOTableAdapter funcionario = new FUNCIONARIOTableAdapter();
            funcionario.Inserir(nome, cep, numero, comp, telfixo, telcel, cpf, id, dtnascimento, admissao, funcao, regprofissional);
        }

        public void Editar(string nome, int cep, int numero, string comp, string telfixo, string telcel, string cpf, string identidade, DateTime dtnascimento, DateTime admissao, 
            string funcao, string regprofissional, int idfuncionario, int originalID, string Originalnome, int Originalcep, int Originalnumero, string Originalcomp, 
            string Originaltelfixo, string Originaltelcel, string Originalcpf, string Originalidentidade, DateTime Originaldtnascimento, 
            DateTime Originaladmissao, string Originalfuncao, string Originalregprofissional)
        {
            FUNCIONARIOTableAdapter funcionario = new FUNCIONARIOTableAdapter();
            //funcionario.Update(nome,cep,numero,comp,telfixo,telcel,cpf,id,dtnascimento,admissao,funcao,regprofissional,
            funcionario.Update(nome, cep, numero, comp, telfixo, telcel, cpf, identidade, dtnascimento, admissao, funcao, regprofissional, originalID, Originalnome,
                Originalcep, Originalnumero, Originalcomp, Originaltelfixo, Originaltelcel,Originalcpf, Originalidentidade, Originaldtnascimento, Originaladmissao,
                Originalfuncao, Originalregprofissional);
        }

        public void Excluir(int idfuncionario)
        {
            FUNCIONARIOTableAdapter funcionario = new FUNCIONARIOTableAdapter();
            funcionario.DeletarFuncionario(idfuncionario);
        }

    }
}
