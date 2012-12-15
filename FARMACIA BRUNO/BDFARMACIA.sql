/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     15/12/2012 16:32:01                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BAIRRO') and o.name = 'FK_BAIRRO_REFERENCE_CIDADE')
alter table BAIRRO
   drop constraint FK_BAIRRO_REFERENCE_CIDADE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENTE') and o.name = 'FK_CLIENTE_REFERENCE_ENDERECO')
alter table CLIENTE
   drop constraint FK_CLIENTE_REFERENCE_ENDERECO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ENDERECO') and o.name = 'FK_ENDERECO_REFERENCE_CIDADE')
alter table ENDERECO
   drop constraint FK_ENDERECO_REFERENCE_CIDADE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ENDERECO') and o.name = 'FK_ENDERECO_REFERENCE_BAIRRO')
alter table ENDERECO
   drop constraint FK_ENDERECO_REFERENCE_BAIRRO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FUNCIONARIO') and o.name = 'FK_FUNCIONA_REFERENCE_ENDERECO')
alter table FUNCIONARIO
   drop constraint FK_FUNCIONA_REFERENCE_ENDERECO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITEMPRODUTO') and o.name = 'FK_ITEMPROD_REFERENCE_PRODUTO')
alter table ITEMPRODUTO
   drop constraint FK_ITEMPROD_REFERENCE_PRODUTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITENSDEVENDA') and o.name = 'FK_ITENSDEV_REFERENCE_ITEMPROD')
alter table ITENSDEVENDA
   drop constraint FK_ITENSDEV_REFERENCE_ITEMPROD
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITENSDEVENDA') and o.name = 'FK_ITENSDEV_REFERENCE_PRODUTO')
alter table ITENSDEVENDA
   drop constraint FK_ITENSDEV_REFERENCE_PRODUTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITENSDEVENDA') and o.name = 'FK_ITENSDEV_REFERENCE_VENDA')
alter table ITENSDEVENDA
   drop constraint FK_ITENSDEV_REFERENCE_VENDA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUTOSDESCARTADOS') and o.name = 'FK_PRODUTOS_REFERENCE_PRODUTO')
alter table PRODUTOSDESCARTADOS
   drop constraint FK_PRODUTOS_REFERENCE_PRODUTO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUTOSDESCARTADOS') and o.name = 'FK_PRODUTOS_REFERENCE_FUNCIONA')
alter table PRODUTOSDESCARTADOS
   drop constraint FK_PRODUTOS_REFERENCE_FUNCIONA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VENDA') and o.name = 'FK_VENDA_REFERENCE_FUNCIONA')
alter table VENDA
   drop constraint FK_VENDA_REFERENCE_FUNCIONA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VENDA') and o.name = 'FK_VENDA_REFERENCE_CLIENTE')
alter table VENDA
   drop constraint FK_VENDA_REFERENCE_CLIENTE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BAIRRO')
            and   name  = 'INDEX_1'
            and   indid > 0
            and   indid < 255)
   drop index BAIRRO.INDEX_1
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BAIRRO')
            and   type = 'U')
   drop table BAIRRO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CIDADE')
            and   type = 'U')
   drop table CIDADE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENTE')
            and   type = 'U')
   drop table CLIENTE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ENDERECO')
            and   type = 'U')
   drop table ENDERECO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FUNCIONARIO')
            and   type = 'U')
   drop table FUNCIONARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ITEMPRODUTO')
            and   type = 'U')
   drop table ITEMPRODUTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ITENSDEVENDA')
            and   type = 'U')
   drop table ITENSDEVENDA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUTO')
            and   type = 'U')
   drop table PRODUTO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUTOSDESCARTADOS')
            and   type = 'U')
   drop table PRODUTOSDESCARTADOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIOS')
            and   type = 'U')
   drop table USUARIOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VENDA')
            and   type = 'U')
   drop table VENDA
go

if exists(select 1 from systypes where name='DOMAIN_1')
   drop type DOMAIN_1
go

/*==============================================================*/
/* Domain: DOMAIN_1                                             */
/*==============================================================*/
create type DOMAIN_1
   from char(10)
go

/*==============================================================*/
/* Table: BAIRRO                                                */
/*==============================================================*/
create table BAIRRO (
   IDBAIRRO             int                  not null,
   BAIRRO               varchar(50)          not null
      constraint CKC_BAIRRO_BAIRRO check (BAIRRO = upper(BAIRRO)),
   IDCIDADE             int                  not null,
   constraint PK_BAIRRO primary key (IDBAIRRO)
)
go

/*==============================================================*/
/* Index: INDEX_1                                               */
/*==============================================================*/
create index INDEX_1 on BAIRRO (
IDCIDADE ASC
)
go

/*==============================================================*/
/* Table: CIDADE                                                */
/*==============================================================*/
create table CIDADE (
   IDCIDADE             int                  not null,
   CIDADE               varchar(200)         not null
      constraint CKC_CIDADE_CIDADE check (CIDADE = upper(CIDADE)),
   UF                   varchar(2)           not null
      constraint CKC_UF_CIDADE check (UF = upper(UF)),
   constraint PK_CIDADE primary key (IDCIDADE)
)
go

/*==============================================================*/
/* Table: CLIENTE                                               */
/*==============================================================*/
create table CLIENTE (
   IDCLIENTE            int                  identity(1,1) not for replication,
   NOME                 varchar(250)         not null
      constraint CKC_NOME_CLIENTE check (NOME = upper(NOME)),
   CPF                  int                  null,
   TELEFONEFIXO         int                  null,
   TELEFONECELULAR      int                  null,
   CEP                  int                  null,
   NUMERO               int                  null,
   COMPLEMENTO          varchar(20)          null,
   constraint PK_CLIENTE primary key (IDCLIENTE)
)
go

/*==============================================================*/
/* Table: ENDERECO                                              */
/*==============================================================*/
create table ENDERECO (
   CEP                  int                  not null,
   ENDRECO              varchar(200)         not null
      constraint CKC_ENDRECO_ENDERECO check (ENDRECO = upper(ENDRECO)),
   IDCIDADE             int                  not null,
   IDBAIRRO             int                  not null,
   constraint PK_ENDERECO primary key (CEP)
)
go

/*==============================================================*/
/* Table: FUNCIONARIO                                           */
/*==============================================================*/
create table FUNCIONARIO (
   IDFUNCIONARIO        int                  identity(1,1),
   NOME                 varchar(250)         null
      constraint CKC_NOME_FUNCIONA check (NOME is null or (NOME = upper(NOME))),
   CEP                  int                  null,
   NUMERO               int                  null,
   COMPLEMENTO          varchar(20)          null
      constraint CKC_COMPLEMENTO_FUNCIONA check (COMPLEMENTO is null or (COMPLEMENTO = upper(COMPLEMENTO))),
   TELEFONEFIXO         varchar(10)          null,
   TELEFONECELULAR      varchar(10)          null,
   CPF                  varchar(11)          null,
   IDENTIDADE           varchar(20)          null
      constraint CKC_IDENTIDADE_FUNCIONA check (IDENTIDADE is null or (IDENTIDADE = upper(IDENTIDADE))),
   DTNASCIMENTO         date                 null,
   ADMISSAO             date                 null,
   FUNCAO               varchar(100)         null
      constraint CKC_FUNCAO_FUNCIONA check (FUNCAO is null or (FUNCAO = upper(FUNCAO))),
   REGPROFISSIONAL      varchar(50)          null,
   constraint PK_FUNCIONARIO primary key (IDFUNCIONARIO)
)
go

/*==============================================================*/
/* Table: ITEMPRODUTO                                           */
/*==============================================================*/
create table ITEMPRODUTO (
   IDITEM               int                  identity(1,1),
   IDPRODUTO            int                  null,
   LOTE                 varchar(20)          not null,
   VALIDADE             date                 not null,
   QUANTIDADE           int                  null,
   constraint PK_ITEMPRODUTO primary key (IDITEM)
)
go

/*==============================================================*/
/* Table: ITENSDEVENDA                                          */
/*==============================================================*/
create table ITENSDEVENDA (
   IDITENSVENDA         int                  identity(1,1),
   IDVENDA              int                  not null,
   IDITEMPRODUTO        int                  null,
   IDPRODUTO            int                  null,
   PRECOUNITARIO        float                not null,
   QUANTIDADE           int                  not null,
   SUBTOTAL             float                not null,
   constraint PK_ITENSDEVENDA primary key (IDITENSVENDA)
)
go

/*==============================================================*/
/* Table: PRODUTO                                               */
/*==============================================================*/
create table PRODUTO (
   IDPRODUTO            int                  identity(1,1),
   DESCRICAO            varchar(500)         not null
      constraint CKC_DESCRICAO_PRODUTO check (DESCRICAO = upper(DESCRICAO)),
   CODBARRAS            varchar(50)          null,
   PRECOCOMPRA          float                not null,
   PRECOVENDA           float                not null,
   DESCONTOMAXIMO       float                not null,
   constraint PK_PRODUTO primary key (IDPRODUTO)
)
go

/*==============================================================*/
/* Table: PRODUTOSDESCARTADOS                                   */
/*==============================================================*/
create table PRODUTOSDESCARTADOS (
   IDEXCLUSAO           int                  identity(1,1),
   IDPRODUTO            int                  not null,
   IDITEM               int                  not null,
   QUANTIDADE           int                  not null,
   DATA                 date                 not null,
   IDFUNCIONARIO        int                  not null,
   MOTIVO               varchar(250)         not null,
   constraint PK_PRODUTOSDESCARTADOS primary key (IDEXCLUSAO)
)
go

/*==============================================================*/
/* Table: USUARIOS                                              */
/*==============================================================*/
create table USUARIOS (
   IDUSUARIO            int                  identity(1,1),
   IDFUNCIONARIO        int                  null,
   LOGIN                varchar(20)          null,
   SENHA                varchar(8)           null,
   PERMICAOTOTAL        bit                  null,
   constraint PK_USUARIOS primary key (IDUSUARIO)
)
go

/*==============================================================*/
/* Table: VENDA                                                 */
/*==============================================================*/
create table VENDA (
   IDVENDA              int                  identity(1,1),
   IDCLIENTE            int                  not null,
   IDFUNCIONARIO        int                  not null,
   DATAVENDA            date                 not null,
   SUBTOTAL             float                not null,
   DESCONTO             float                not null,
   TOTALVENDA           float                not null,
   constraint PK_VENDA primary key (IDVENDA)
)
go

alter table BAIRRO
   add constraint FK_BAIRRO_REFERENCE_CIDADE foreign key (IDCIDADE)
      references CIDADE (IDCIDADE)
go

alter table CLIENTE
   add constraint FK_CLIENTE_REFERENCE_ENDERECO foreign key (CEP)
      references ENDERECO (CEP)
go

alter table ENDERECO
   add constraint FK_ENDERECO_REFERENCE_CIDADE foreign key (IDCIDADE)
      references CIDADE (IDCIDADE)
go

alter table ENDERECO
   add constraint FK_ENDERECO_REFERENCE_BAIRRO foreign key (IDBAIRRO)
      references BAIRRO (IDBAIRRO)
go

alter table FUNCIONARIO
   add constraint FK_FUNCIONA_REFERENCE_ENDERECO foreign key (CEP)
      references ENDERECO (CEP)
go

alter table ITEMPRODUTO
   add constraint FK_ITEMPROD_REFERENCE_PRODUTO foreign key (IDPRODUTO)
      references PRODUTO (IDPRODUTO)
go

alter table ITENSDEVENDA
   add constraint FK_ITENSDEV_REFERENCE_ITEMPROD foreign key (IDITEMPRODUTO)
      references ITEMPRODUTO (IDITEM)
go

alter table ITENSDEVENDA
   add constraint FK_ITENSDEV_REFERENCE_PRODUTO foreign key (IDPRODUTO)
      references PRODUTO (IDPRODUTO)
go

alter table ITENSDEVENDA
   add constraint FK_ITENSDEV_REFERENCE_VENDA foreign key (IDVENDA)
      references VENDA (IDVENDA)
go

alter table PRODUTOSDESCARTADOS
   add constraint FK_PRODUTOS_REFERENCE_PRODUTO foreign key (IDPRODUTO)
      references PRODUTO (IDPRODUTO)
go

alter table PRODUTOSDESCARTADOS
   add constraint FK_PRODUTOS_REFERENCE_FUNCIONA foreign key (IDFUNCIONARIO)
      references FUNCIONARIO (IDFUNCIONARIO)
go

alter table VENDA
   add constraint FK_VENDA_REFERENCE_FUNCIONA foreign key (IDFUNCIONARIO)
      references FUNCIONARIO (IDFUNCIONARIO)
go

alter table VENDA
   add constraint FK_VENDA_REFERENCE_CLIENTE foreign key (IDCLIENTE)
      references CLIENTE (IDCLIENTE)
go

