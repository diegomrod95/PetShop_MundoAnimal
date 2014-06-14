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

-- ----------------------------------------------------------------------------
-- CATEGOIAS -- NÃO ALTERAR, COMPROMETE FUNCIONAMENTO DO SISTEMA
-- ----------------------------------------------------------------------------
INSERT INTO [Categoria]
    ([Nome], [Descricao])
VALUES
    ('Alimento Granel', 'Alimentos vendidos a granel.'),
    ('Alimento Unitário', 'Alimentos que são vendidos unitários.'),
    ('Higiene e Beleza', 'Produtos de higiene e Beleza'),
    ('Duráveis', 'Bens duráveis.'),
    ('Vestuário', 'Produtos de vestuário.'),
    ('Farmacia', 'Produto e Medicamentos.'),
    ('Conforto', 'Produto de conforto.'),
    ('Outro', 'Outros tipos de produtos.');
GO

-- ----------------------------------------------------------------------------
-- TIPO DE PEDIDOS -- NÃO ALTERAR, COMPROMETE FUNCIONAMENTO DO SISTEMA
-- ----------------------------------------------------------------------------
INSERT INTO [Tipo_Pedido]
    ([Descricao])
VALUES
    ('Venda'), ('Banho e Tosa'), ('Veterinario'), ('Outro');
GO