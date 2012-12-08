/***********************************************************************
 * Module:  ItensdeVenda.cs
 * Author:  LuisHenrique
 * Purpose: Definition of the Class ItensdeVenda
 ***********************************************************************/

using System;
namespace SaudeMed
{

    public class ItensdeVenda
    {
        public void Inserir()
        {
            // TODO: implement
        }

        public void Excluir()
        {
            // TODO: implement
        }


        private int iditemdevenda;
        private int idvenda;
        private int idproduto;
        private int quantidade;
        private float precounitario;
        private float valortotal;

        public float ValorTotal
        {
            get { return valortotal; }
            set { valortotal = value; }
        }
        

        public float PrecoUnitario
        {
            get { return precounitario; }
            set { precounitario = value; }
        }
        

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        

        public int IdProduto
        {
            get { return idproduto; }
        }
        

        public int IdVenda
        {
            get { return idvenda; }            
        }
        

        public int IdItemdeVenda
        {
            get { return iditemdevenda; }
        }
        



    }
}