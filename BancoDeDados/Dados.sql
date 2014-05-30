-- ----------------------------------------------------------------------------
-- SCRIPT COM DADOS PARA USO E TESTE DO BANCO
-- ----------------------------------------------------------------------------
USE [MundoAnimal_BD]
GO

-- ----------------------------------------------------------------------------
-- TIPOS DE CONTATO -- NÃO ALTERAR, COMPROMETE FUNCIONAMENTO DO SISTEMA
-- ----------------------------------------------------------------------------
INSERT INTO [Tipo_Contato] 
    ([Nome])
VALUES
    ('Telefone'), ('Celular'), ('Email'), ('Fax'), ('Twitter'), ('Facebook'),
    ('Orkut'), ('Outro');
GO

-- ----------------------------------------------------------------------------
-- CARGOS -- NÃO ALTERAR, COMPROMETE FUNCIONAMENTO DO SISTEMA
-- ----------------------------------------------------------------------------
INSERT INTO [Funcionario_Cargo]
    ([Nome])
VALUES
    ('Vendedor'), ('Diretor Geral'), ('Diretor Marketing'), ('Diretor Vendas'),
    ('Diretor TI'), ('Assitencia Tecnica'), ('DBA'), ('Contador'),
    ('Motorista'), ('Caixa'), ('Balconista'), ('Outro')
GO