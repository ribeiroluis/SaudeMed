/***********************************************************************
 * Module:  Funcionario.cs
 * Author:  LuisHenrique
 * Purpose: Definition of the Class Funcionario
 ***********************************************************************/

using System;

public class Funcionario
{
   public void Inserir()
   {
      // TODO: implement
   }
   
   public void Atualizar()
   {
      // TODO: implement
   }
   
   public void Excluir()
   {
      // TODO: implement
   }
   
   public void Listar()
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

   private int IdFuncionario;
   private string NomeFuncionario;
   private int Cep;
   private string Logradouro;
   private int Numero;
   private string Complemento;
   private string Bairro;
   private string Cidade;
   private string TelefoneFixo;
   private int TelefoneCelular;
   private int Cpf;
   private string Identidade;
   private DateTime DataNascimento;
   private DateTime Admissao;
   private string Funcao;
   private string RegistroProfissional;

}