using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaudeMed.BDSAUDEMEDDataSetTableAdapters;
using System.Data;

namespace SaudeMed
{
    class AcessaDados
    {
        public string Endereco_RetornaLogradouroporCEP(int cep)
        {
            ENDERECOTableAdapter endereco = new ENDERECOTableAdapter();
            string logradouro = endereco.PesquisaLogradouroPorCEP(cep);
            return logradouro;
        }

        public string Endereco_RetornaCidadeporCEP(int cep)
        {
            ENDERECOTableAdapter endereco = new ENDERECOTableAdapter();
            string cidade = endereco.RetornaCidadePorCEP(cep);
            return cidade;
        }

        public string Endereco_RetornaBairroporCEP(int cep)
        {
            ENDERECOTableAdapter endereco = new ENDERECOTableAdapter();
            string bairro = (endereco.RetornaBairroporCEP(cep)).ToString();
            return bairro;
        }

        public string Funcionario_RetornaNomeJaCadastrado(string nome)
        {
            nome = nome.ToUpper();
            nome = "%" + nome + "%";
            FUNCIONARIOTableAdapter funcionario = new FUNCIONARIOTableAdapter();
            string NomedaTabela = "";
            var pesquisa = funcionario.RetornarNomeFuncionario(nome);
            if (pesquisa != null)
            {
                NomedaTabela = pesquisa.ToString();
            }
            return NomedaTabela;

        }

        public DataTable ViewTabelaFuncionario_RetornaTabelaFuncionarios()
        {
            ViewTabelaFuncionariosTableAdapter tabelafuncionarios = new ViewTabelaFuncionariosTableAdapter();
            DataTable tabela = new DataTable();
            tabela = tabelafuncionarios.GetData();
            return tabela;
        }

        public void Funcionario_Gravar(string nome, int cep, int numero, string comp, string telfixo, string telcel, string cpf, string id, string dtnascimento, string admissao, string funcao, string regprofissional)
        {
            FUNCIONARIOTableAdapter funcionario = new FUNCIONARIOTableAdapter();
            funcionario.Inserir(nome, cep, numero, comp, telfixo, telcel, cpf, id, dtnascimento, admissao, funcao, regprofissional);
        }

        public void Funcionario_Editar(string nome, int cep, int numero, string comp, string telfixo, string telcel, string cpf, string identidade, string dtnascimento, string admissao,
            string funcao, string regprofissional, int idfuncionario, int originalID)
        {
            FUNCIONARIOTableAdapter funcionario = new FUNCIONARIOTableAdapter();
            funcionario.AtualizarFuncionario(nome, cep, numero, comp, telfixo, telcel, cpf, identidade, dtnascimento, admissao, funcao,
                regprofissional, originalID);

        }

        public void Funcionario_Excluir(int idfuncionario)
        {
            FUNCIONARIOTableAdapter funcionario = new FUNCIONARIOTableAdapter();
            funcionario.DeletarFuncionario(idfuncionario);
        }

        public string[] Usuarios_DadosUsuarios(int idfuncionario)
        {
            USUARIOSTableAdapter usuarios = new USUARIOSTableAdapter();
            string[] dados = new string[6];
            /*dados[0] = usuarios.RetornaIdUsuario(idfuncionario).ToString();
            dados[1] = idfuncionario.ToString();
            dados[2] = usuarios.RetornaLogin(idfuncionario).ToString();
            dados[3] = usuarios.RetornaLogin(idfuncionario).ToString();
            dados[4] = usuarios.RetornaSenha(idfuncionario).ToString();
            dados[5] = usuarios.RetornaPermissaototal(idfuncionario).ToString();*/
            return dados;
        }

        public bool Usuarios_RetornaLoginUsuario(string login)
        {
            USUARIOSTableAdapter usuarios = new USUARIOSTableAdapter();
            var teste = usuarios.RetornaLoginCadastrados(login);
            if (teste == null)
            {
                return false;
            }
            else
                return true;
        }

        public void Usuarios_Gravar(int idfuncionario, string login, string senha, bool acesso)
        {
            USUARIOSTableAdapter usuarios = new USUARIOSTableAdapter();
            usuarios.Insert(idfuncionario, login, senha, acesso);
        }

        public void Usuarios_Editar(int idfuncionario, string login, string senha, bool acesso)
        {
            USUARIOSTableAdapter usuarios = new USUARIOSTableAdapter();
            usuarios.Atualizar(idfuncionario, senha, acesso, login);
        }

        public string Usuarios_RetornaLoginPorIDFuncionario(int idfuncionario)
        {
            USUARIOSTableAdapter usuarios = new USUARIOSTableAdapter();
            var teste = usuarios.RetornaLoginporIDFuncionario(idfuncionario);
            if (teste == null)
                return "";
            else
                return teste.ToString();
        }

        public int Usuarios_RetornaIDLogin(int idfuncionario)
        {
            USUARIOSTableAdapter usuarios = new USUARIOSTableAdapter();
            int valor = (int)usuarios.RetornaIdUsuario(idfuncionario);
            return valor;
        }

        public bool Usuarios_RetornaUsuarioValido(string login, string senha)
        {
            USUARIOSTableAdapter usuarios = new USUARIOSTableAdapter();
            string _senha = usuarios.RetornaSenhaUsuario(login).ToString();
            if (_senha.Equals(senha))
            {
                return true;
            }
            else
                return false;
        }

        public bool Usuarios_RetornaAcessoUsuario(string login)
        {
            USUARIOSTableAdapter usuarios = new USUARIOSTableAdapter();
            var acesso = usuarios.RetornaAcessodoUsuario(login);
            if (acesso == true)
            {
                return true;
            }
            else
                return false;
        }

        public int Usuarios_RetornaIDFuncionario(string login)
        {
            USUARIOSTableAdapter usuarios = new USUARIOSTableAdapter();
            int valor = (int)usuarios.RetornaIdFuncionario(login);
            return valor;
        }

        public DataTable Produtos_RetornaDescricao()
        {
            PRODUTOTableAdapter produtos = new PRODUTOTableAdapter();
            DataTable tabela = new DataTable();
            tabela = produtos.GetData();
            return tabela;
        }

        public DataTable Produtos_RetornaDatatableDescricao(string descricao)
        {
            PRODUTOTableAdapter produto = new PRODUTOTableAdapter();
            DataTable tabela = produto.RetornaDataTableDescricao(descricao);
            return tabela;

        }
        
        public DataTable Produtos_RetornaDatatableBuscaCodBarras(string _codbarras)
        {
            PRODUTOTableAdapter produtos = new PRODUTOTableAdapter();
            DataTable tabela = new DataTable();
            tabela = produtos.RetornaDataTableConsultaCodBarras(_codbarras);
            return tabela;
        }

        public bool Produtos_RetornaSeExisteCodBarras(string _codbarras)
        {
            PRODUTOTableAdapter produto = new PRODUTOTableAdapter();
            var testa = produto.RetornaCodigodeBarras(_codbarras);
            if (testa == null)
                return false;
            else
                return true;                  
        }

        public bool Produtos_RetornaSeExisteDescricao(string descricao)
        {
            PRODUTOTableAdapter produto = new PRODUTOTableAdapter();
            var testa = produto.RetornaSeExisteDescricao(descricao);
            if (testa == null)
                return false;
            else
                return true;                   
        }

        public void Produtos_AtualizarProduto(int idproduto, string descricao, string codbarras, float precompra,            
            float precovenda, float descmaximo)
        {
            PRODUTOTableAdapter produtos = new PRODUTOTableAdapter();
            produtos.AtualizarProduto(descricao, codbarras, precompra, precovenda, descmaximo, idproduto);
        }

        public void Produtos_InserirNovo(string descricao, string codbarras, float precompra, float prevenda, float descmaximo)
        {
            PRODUTOTableAdapter produto = new PRODUTOTableAdapter();
            produto.Insert(descricao, codbarras,precompra,prevenda, descmaximo);
        }


    }
}
        
        