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

        public string Usuarios_RetornaNome(int idfuncionario)
        {
            FUNCIONARIOTableAdapter fun = new FUNCIONARIOTableAdapter();
            var teste = fun.RetornaNomeFuncionarioporId(idfuncionario);
            if (teste == null)
                return "";
            else
                return teste.ToString();
            
        }

        public DataTable Produtos_RetornaDescricao()
        {
            PRODUTOTableAdapter produtos = new PRODUTOTableAdapter();
            DataTable tabela = new DataTable();
            tabela = produtos.GetData();
            return tabela;
        }

        public DataTable ItensProduto_RetornaLotes(int idproduto)
        {
            ITEMPRODUTOTableAdapter item = new ITEMPRODUTOTableAdapter();
            DataTable tabela = item.RetornaDataTableLotePorIDProduto(idproduto);
            return tabela;
        }

        public bool ItensProduto_RetornaSeExisteLote(string lote, int idproduto)
        {
            ITEMPRODUTOTableAdapter item = new ITEMPRODUTOTableAdapter();
            var teste = item.RetornaLote(lote, idproduto);
            if (teste == null)
                return false;
            else
                return true;
        }

        public void ItensProduto_Incluir(int idproduto, string lote, DateTime validade, int quantidade)
        {
            ITEMPRODUTOTableAdapter item = new ITEMPRODUTOTableAdapter();
            item.Insert(idproduto, lote, validade, quantidade);
        }


        public DataTable ItensProduto_RetornaDataTablePorLoteIDProduto(string lote, int idproduto)
        {
            ITEMPRODUTOTableAdapter item = new ITEMPRODUTOTableAdapter();
            DataTable tabela = item.RetornaDatatablePorLoteEIdProduto(lote, idproduto);
            return tabela;
        }

        public void ItensProduto_AtualizarLote(DateTime data, int quantidade, int iditemproduto)
        {
            ITEMPRODUTOTableAdapter item = new ITEMPRODUTOTableAdapter();
            item.AtualizarLote(data.ToShortDateString(), quantidade, iditemproduto);
        }

        public void ItensDescartados_InsereExclusao(int idproduto, int iditem, int quantidade, DateTime data, int idfuncionario, string motivo)
        {
            PRODUTOSDESCARTADOSTableAdapter produto = new PRODUTOSDESCARTADOSTableAdapter();
            produto.Insert(idproduto, iditem, quantidade, data, idfuncionario, motivo);
        }

        public void ItensProduto_Excluir(int idItemProduto)
        {
            ITEMPRODUTOTableAdapter item = new ITEMPRODUTOTableAdapter();
            item.DeletarPorItemIdProduto(idItemProduto);
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

        public DataTable CEP_RetornCEPEnderecoCidadeBairroPorEndereco(string endereco)
        {
            string _endereco = "%" + endereco + "%";
            BUSCPAPORCEPTableAdapter busca = new BUSCPAPORCEPTableAdapter();
            DataTable enderecos = busca.RetornaCEPEnderecoBairroCidadePorEndereco(_endereco);
            return enderecos;
        }

        public DataTable Cliente_RetornDataTablePorTelefone(string telefone)
        {
            CLIENTETableAdapter cliente = new CLIENTETableAdapter();
            DataTable tabela = cliente.RetornaDataTableClientePorTelefone(telefone, telefone);
            return tabela;

        }

        public DataTable Cliente_RetornaTabelaCliente()
        {
            CLIENTETableAdapter cliente = new CLIENTETableAdapter();
            DataTable tabela = new DataTable();
            tabela = cliente.NomeRetornaDatatable();            
            return tabela;
        }
        
        public DataTable Cliente_RetornaTabelaClientePorNome(string nome)
        {
            CLIENTETableAdapter cliente = new CLIENTETableAdapter();
            DataTable tabela = new DataTable();
            tabela = cliente.RetornaDataTablePorNome("%" + nome + "%");
            return tabela;
        }

        public void Cliente_IserirNovoCliente(string _nome, string _cpf, string _telfixo, string _telcel, int _numero, string _comp, int _cep)
        {
            CLIENTETableAdapter cliente = new CLIENTETableAdapter();
            cliente.Insert(_nome, _cpf, _telfixo, _telcel, _cep, _numero, _comp);
        }

        public void Cliente_AtualizarCliente(string _nome, string _cpf, string _telfixo, string _telcel, 
            int _numero, string _comp, int _cep, int _idcliente)
        {
            CLIENTETableAdapter cliente = new CLIENTETableAdapter();
            cliente.AtualizaCliente(_nome, _cpf, _telfixo, _telcel, _cep, _numero, _comp, _idcliente);
        }

        public void Cliente_ExcluirCliente(int idcliente)
        {
            CLIENTETableAdapter cliente = new CLIENTETableAdapter();
            cliente.Delete(idcliente);

        }

        public DataTable ItensProdutos_ViewLotesPorDescricao(string _descricao)
        {
            ITEMPRODUTOTableAdapter item = new ITEMPRODUTOTableAdapter();
            DataTable tabela =  item.ViewLotesPorDescricao(_descricao);
            return tabela;
        }

        public DataTable ItensProtutos_ViewItensProdutos()
        {
            ViewTabelaItensProdutoTableAdapter view = new ViewTabelaItensProdutoTableAdapter();
            DataTable tabela = view.RetornaDadosOrdenados();
            return tabela;
 
        }

        public DataTable ItensProdutos_ViewitensProdutosPorDescricao(string descricao)
        {
            ViewTabelaItensProdutoTableAdapter view = new ViewTabelaItensProdutoTableAdapter();
            DataTable tabela = view.RetornaDataTabledosProdutosCadastradosPorDescricao(descricao);
            return tabela;
        }

        public string Venda_RetornaUltimaVenda()
        {
            VENDATableAdapter ven = new VENDATableAdapter();
            var venda = ven.RetornaUltimaVenda();
            return venda.ToString();
        }

        public void Venda_InsereVendaTemporaria(int idcliente, int idfuncionario)
        {
            VENDATableAdapter ven = new VENDATableAdapter();
            DateTime data = DateTime.Now;

            ven.InsereVendaTemporaria(idcliente, idfuncionario,data.ToShortDateString());
        }

        public void Venda_DeletaVendaPorID(int idvenda)
        {
            VENDATableAdapter ven = new VENDATableAdapter();
            ven.DeletaVendaPorId(idvenda);
        }

        public void ItensVenda_InserirVenda(int idvenda, int idproduto, int iditemproduto, float precounitario, int quantidade)
        {
            ITENSDEVENDATableAdapter itens = new ITENSDEVENDATableAdapter();
            float subtotal = quantidade*precounitario;
            itens.Insert(idvenda, iditemproduto, idproduto, precounitario, quantidade, subtotal);
        }

        public void ItensVenda_DeletarVendaPorID(int idvenda)
        {
            ITENSDEVENDATableAdapter itens = new ITENSDEVENDATableAdapter();
            itens.DeletaItensdeVendaPorIDVenda(idvenda);
        }

        public void ItensVenda_AtualizaEstoquePorIdItemProduto(int iditemproduto, int quantidade)
        {
            ITEMPRODUTOTableAdapter item = new ITEMPRODUTOTableAdapter();
            item.AlteraQuantidadePorIdItemProduto(quantidade, iditemproduto);
        }

        public int ItensVenda_RetornaQuantidadeEstoque(string lote, string Descricao)
        {
            ITEMPRODUTOTableAdapter itens = new ITEMPRODUTOTableAdapter();
            int quantidade = (int)itens.RetornaQuantidadeEmEstoquePorDescricaoLote(Descricao, lote);
            return quantidade;
        }

        public DataTable ItensVenda_RetornaDatatableListadeVenda(int idvenda)
        {
            ViewTabeladeVendasTableAdapter table = new ViewTabeladeVendasTableAdapter();
            DataTable tabela = table.RetornaViewTabelaDeVenda(idvenda);
            return tabela;
        }

        public int ItensVenda_RetornaIDItemProduto(string lote, int idproduto)
        {
            ITEMPRODUTOTableAdapter itens = new ITEMPRODUTOTableAdapter();
            int id = (int)itens.RetornaIDItemProdutoPorIDProdutoLote(idproduto, lote);
            return id;
        }

        public int ItensVenda_RetornaIDProduto(string descricao)
        {
            PRODUTOTableAdapter itens = new PRODUTOTableAdapter();
            int id = (int)itens.RetornaIdProdutoPorDescricao(descricao);
            return id;
        }

        public void ItensVenda_DeletaItensVendaIDProdutoQuantidade(int idproduto, int quantidade)
        {
            ITENSDEVENDATableAdapter itens = new ITENSDEVENDATableAdapter();
            itens.DeletaItensVendaPorIdProdutoeQuantidade(idproduto, quantidade);
        }

        public float ItensVenda_RetornaDescontoMaximoPorIDITemProduto(int iditemproduto)
        {
            ViewTabeladeVendasTableAdapter view = new ViewTabeladeVendasTableAdapter();
            float valor = float.Parse(view.RetornaDescontoMaximoPorIdItemProduto(iditemproduto).ToString());
            return valor;

        }

        public void Venda_AtualizaVendaFinalizaPorIDVenda(int idvenda, double subtotal, double desconto)
        {
            VENDATableAdapter venda = new VENDATableAdapter();
            double total = subtotal - desconto;
            venda.AtualizaVendaPorIDVenda(subtotal, desconto, total, idvenda);
        }

    }
}
        
        