-- ----------------------------------------------------------------------------
-- CRIA BANCO DE DADOS MundoAnimal_BD
-- ----------------------------------------------------------------------------
CREATE DATABASE [MundoAnimal_BD]
GO

USE [MundoAnimal_BD]
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Pessoa
-- ----------------------------------------------------------------------------
CREATE TABLE [Pessoa] (
    [Pessoa_Id]             INT IDENTITY PRIMARY KEY,
    [Nome]                  VARCHAR(60) NULL,
    [Sobrenome]             VARCHAR(80) NULL,
    [Nome_Fantasia]         VARCHAR(100) NULL,
    [Tipo_Pessoa]           CHAR(1) NOT NULL, -- F: Fisica, J: Juridica
    [Genero]                CHAR(1) NOT NULL DEFAULT 'O', -- M: Masculino, F: Feminino, O: Outro/Não tem
    [RG]                    CHAR(9) NULL, -- Formato: 55555555
    [CPF]                   CHAR(11) NULL, -- Formato: 55555555555
    [CNPJ]                  CHAR(14) NULL, -- Formato: 555555555555555
    [Nascimento]            DATETIME NULL,
    [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
    [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
    CONSTRAINT [ck_Pessoa_Genero]
        CHECK([Genero] IN ('M', 'F', 'O')),
    CONSTRAINT [ck_Pessoa_Tipo_Pessoa]
        CHECK([Tipo_Pessoa] IN ('F', 'J')),
    CONSTRAINT [ck_Pessoa_tipo_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Pessoa_Endereco
-- ----------------------------------------------------------------------------
CREATE TABLE [Pessoa_Endereco] (
    [Pessoa_Id]             INT NOT NULL,
    [Pais]                  VARCHAR(50) NOT NULL,
    [Estado]                CHAR(2) NULL,
    [Cidade]                VARCHAR(100) NULL,
    [Endereco]              VARCHAR(200) NULL,
    [NumeroEndereco]        INT NULL,
    [Bairro]                VARCHAR(120) NULL,
    [Complemento]           VARCHAR(300) NULL,
    [CEP]                   CHAR(8) NOT NULL DEFAULT 'EXTERIOR',
    [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
    [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
    PRIMARY KEY ([Pessoa_Id], [CEP]),
    CONSTRAINT [fk_Pessoa_Endereco_Pessoa]
        FOREIGN KEY([Pessoa_Id]) REFERENCES [Pessoa]([Pessoa_Id]),
    CONSTRAINT [ck_Pessoa_Endereco_tipo_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Tipo_Contato
-- ----------------------------------------------------------------------------
CREATE TABLE [Tipo_Contato] (
    [Tipo_Id]               INT PRIMARY KEY IDENTITY,
    [Nome]                  VARCHAR(150) NOT NULL,
    [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
    [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
    CONSTRAINT [ck_Tipo_Contato_tipo_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));          
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Pessoa_Contato
-- ----------------------------------------------------------------------------
CREATE TABLE [Pessoa_Contato] (
    [Pessoa_Id]             INT NOT NULL,
    [Tipo_Id]               INT NOT NULL,
    [Contato]               VARCHAR(150) NOT NULL,
    [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
    [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
    PRIMARY KEY ([Pessoa_Id], [Tipo_Id], [Contato]),
    CONSTRAINT [fk_Pessoa_Contato_Tipo]
        FOREIGN KEY([Tipo_Id]) REFERENCES [Tipo_Contato]([Tipo_Id]), 
    CONSTRAINT [fk_Pessoa_Contato_Pessoa]
        FOREIGN KEY([Pessoa_Id]) REFERENCES [Pessoa]([Pessoa_Id]),
    CONSTRAINT [ck_Pessoa_Contato_tipo_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Pessoa_Parente
-- ----------------------------------------------------------------------------
CREATE TABLE [Pessoa_Parente] (
    [Pessoa_Id]             INT NOT NULL,
    [Parente_Id]            INT NOT NULL,
    [Parentesco]            CHAR(1) NOT NULL, -- P: Pai, M: Mae, F: Filho(a), I: Irmao, C: Conjuge,
    [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
    [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
    PRIMARY KEY ([Pessoa_Id], [Parente_Id]),
    CONSTRAINT [fk_Pessoa_Parente_Pessoa]
        FOREIGN KEY([Pessoa_Id]) REFERENCES [Pessoa]([Pessoa_Id]),
    CONSTRAINT [fk_Pessoa_Parente_Parente_Pessoa]
        FOREIGN KEY([Parente_Id]) REFERENCES [Pessoa]([Pessoa_Id]),
    CONSTRAINT [ck_Pessoa_Parente_Parentesco]
        CHECK([Parentesco] IN ('P', 'M', 'F', 'I', 'C')),
    CONSTRAINT [ck_Pessoa_Parente_tipo_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Funcionario_Cargo
-- ----------------------------------------------------------------------------
CREATE TABLE [Funcionario_Cargo] (
    [Cargo_Id]              INT PRIMARY KEY IDENTITY,
    [Nome]                  VARCHAR(200) NOT NULL,
    [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
    [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
    CONSTRAINT [ck_Funcionario_Cargo_tipo_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Funcionario
-- ----------------------------------------------------------------------------
CREATE TABLE [Funcionario] (
    [Pessoa_Id]             INT NOT NULL,
    [Cargo_Id]              INT NOT NULL,
    [Salario]               DECIMAL(10, 2) NOT NULL,
    [Vale_Alimentacao]      DECIMAL(10, 2) NULL,
    [Vale_Transporte]       DECIMAL(10, 2) NULL,
    [Auxilio_Creche]        DECIMAL(10, 2) NULL,
    [Assitencia_Medica]     DECIMAL(10, 2) NULL,
    [Dia_Pagamento]         INT NULL,
    [Data_Demissao]         DATETIME NULL,
    [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
    [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
    PRIMARY KEY ([Pessoa_Id]),
    CONSTRAINT [fk_Funcionario_Pessoa]
        FOREIGN KEY([Pessoa_Id]) REFERENCES [Pessoa]([Pessoa_Id]),
    CONSTRAINT [fk_Funcionario_Cargo]
        FOREIGN KEY([Cargo_Id]) REFERENCES [Funcionario_Cargo]([Cargo_Id]),
    CONSTRAINT [ck_Funcionario_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));
GO

-- ----------------------------------------------------------------------------
-- CRIA VIEW View_Funcionarios
-- ----------------------------------------------------------------------------
CREATE VIEW [View_Funcionarios]
AS
SELECT 
    P.Pessoa_Id                 AS [Código da Pessoa],
    P.Nome, 
    P.Sobrenome,
    P.Tipo_Pessoa               AS [Tipo Pessoa],
    P.Genero                    AS [Genero],
    P.RG,
    P.CPF,
    P.Nascimento,
    YEAR(GETDATE() - P.Nascimento) - 1900 AS [Idade],
    F.Data_Cadastro             AS [Admissao],
    F.Salario                   AS [Salario], 
    F.Assitencia_Medica         AS [Assitencia Medica], 
    F.Auxilio_Creche            AS [Auxilio Creche], 
    F.Vale_Alimentacao          AS [Vale Alimentacao], 
    F.Vale_Transporte           AS [Vale Transporte],
    F.Dia_Pagamento             AS [Dia de Pagamento],
    F.Data_Demissao             AS [Data Demissao],
    F.Cargo_Id                  AS [Codigo do Cargo],
    C.Nome                      AS [Cargo] 
FROM [Pessoa] AS P JOIN [Funcionario] AS F ON P.Pessoa_Id = F.Pessoa_Id
                   JOIN [Funcionario_Cargo] AS C ON F.Cargo_Id = C.Cargo_Id
WHERE P.Ativo = 'S' AND F.Ativo = 'S'
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Fabricante
-- ----------------------------------------------------------------------------
CREATE TABLE [Fabricante] (
    [Fabricante_Id]         INT NOT NULL,
    [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
    [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
    PRIMARY KEY([Fabricante_Id]),
    CONSTRAINT [fk_Fabricante_Pessoa]
        FOREIGN KEY([Fabricante_Id]) REFERENCES [Pessoa]([Pessoa_Id]),
    CONSTRAINT [ck_Fabricante_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Categoria
-- ----------------------------------------------------------------------------
CREATE TABLE [Categoria] (
    [Categoria_Id]          INT IDENTITY PRIMARY KEY,
    [Nome]                  VARCHAR(100) NOT NULL,
    [Descricao]             VARCHAR(400),
    [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
    [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
    CONSTRAINT [ck_Categoria_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Produto
-- Tipo_unidade: UN - Unitario, KG - Killos, GR - Gramas, DU - Duzias, 
--               DZ - Dezenas, LT - Litros
-- ----------------------------------------------------------------------------
CREATE TABLE [Produto] (
    [Produto_Id]            INT PRIMARY KEY IDENTITY,
    [Nome]                  VARCHAR(150) NOT NULL,
    [Codigo]                CHAR(10) NOT NULL,
    [Tamanho]               DECIMAL(10,2) NULL,
    [Preco_Venda]           DECIMAL(10, 2) NULL,
    [Peso]                  DECIMAL(10,3) NULL,
    [Tipo_Medida]           CHAR(2) NOT NULL,
    [Descricao]             VARCHAR(1000) NULL,
    [Especificacoes]        VARCHAR(MAX) NULL,
    [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
    [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
    CONSTRAINT [ck_Produto_Tipo_Unidade]
        CHECK([Tipo_Medida] IN ('UN', 'KG', 'GR', 'DU', 'DZ', 'LT')),
    CONSTRAINT [ck_Produto_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Fabricante_Produto
-- ----------------------------------------------------------------------------
CREATE TABLE [Fabricante_Produto] (
   [Produto_Id]            INT NOT NULL,
   [Fabricante_Id]         INT NOT NULL,
   [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
   [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
   PRIMARY KEY ([Produto_Id], [Fabricante_Id]),
   CONSTRAINT [fk_Fabricante_Produto_Produto]
        FOREIGN KEY([Produto_Id]) REFERENCES [Produto]([Produto_Id]),
   CONSTRAINT [fk_Fabricante_Produto_Fabricante]
        FOREIGN KEY([Fabricante_Id]) REFERENCES [Fabricante]([Fabricante_Id]),
   CONSTRAINT [ck_Fabricante_Produto_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Categoria_Produto
-- ----------------------------------------------------------------------------
CREATE TABLE [Categoria_Produto] (
    [Categoria_Id]          INT NOT NULL,
    [Produto_Id]            INT NOT NULL,
    [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
    [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
    PRIMARY KEY([Categoria_Id], [Produto_Id]),
    CONSTRAINT [fk_Categoria_Produto_Produto]
        FOREIGN KEY([Produto_Id]) REFERENCES [Produto]([Produto_Id]),
    CONSTRAINT [fk_Categoria_Produto_Categoria]
        FOREIGN KEY([Categoria_Id]) REFERENCES [Categoria]([Categoria_Id]),
    CONSTRAINT [ck_Categoria_Produto_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Fornecedor
-- ----------------------------------------------------------------------------
CREATE TABLE [Fornecedor] (
   [Fornecedor_Id]         INT NOT NULL PRIMARY KEY,
   [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
   [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
   CONSTRAINT [ck_Fornecedor_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Fornecedor_Produto
-- ----------------------------------------------------------------------------
CREATE TABLE [Fornecedor_Produto] (
   [Fornecedor_Id]         INT NOT NULL,
   [Produto_Id]            INT NOT NULL,
   [Preco]                 DECIMAL(10, 2) NOT NULL,
   [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
   [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
   PRIMARY KEY([Fornecedor_Id], [Produto_Id]),
   CONSTRAINT [fk_Fornecedor_Produto_Fornecedor]
        FOREIGN KEY([Fornecedor_Id]) REFERENCES [Fornecedor]([Fornecedor_Id]),
   CONSTRAINT [fk_Fornecedor_Produto_Produto]
        FOREIGN KEY([Produto_Id]) REFERENCES [Produto]([Produto_Id]),
   CONSTRAINT [ck_Fornecedor_Produto_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));
GO

-- ----------------------------------------------------------------------------
-- CRIA TABELA Estoque_Produto
-- ----------------------------------------------------------------------------
CREATE TABLE [Estoque_Produto] (
    [Produto_Id]            INT NOT NULL,
    [Quantidade]            DECIMAL(10, 3) NULL,
    [Quantidade_Minima]     DECIMAL(10, 3) NULL,
    [Data_Cadastro]         DATETIME NOT NULL DEFAULT GETDATE(),
    [Ativo]                 CHAR(1) NOT NULL DEFAULT 'S',
    CONSTRAINT [fk_Estoque_Produto_Produto]
        FOREIGN KEY([Produto_Id]) REFERENCES [Produto]([Produto_Id]),
    CONSTRAINT [ck_Estoque_Produto_ativo_sn]
        CHECK([Ativo] IN ('S', 'N')));
GO

-- ----------------------------------------------------------------------------
-- CRIA VIEW View_Estoque
-- ----------------------------------------------------------------------------
CREATE VIEW [View_Estoque]
AS
SELECT 
    P.Produto_Id            AS [Id], 
    P.Codigo                AS [Codigo], 
    CT.Nome                 AS [Categoria], 
    P.Nome                  AS [Nome], 
    P.Preco_Venda           AS [Preco Venda], 
    P.Tipo_Medida           AS [Medida], 
    E.Quantidade            AS [Quantidade], 
    E.Quantidade_Minima     AS [Quantidade Minima], 
    CAST(E.Quantidade * P.Preco_Venda AS DECIMAL(10, 2)) AS Subtotal 
FROM Estoque_Produto AS E JOIN Produto AS P ON E.Produto_Id = P.Produto_Id 
                          JOIN Categoria_Produto AS C ON C.Produto_Id = P.Produto_Id 
                          JOIN Categoria AS CT ON C.Categoria_Id = CT.Categoria_Id
WHERE P.Ativo = 'S';
GO