-- ----------------------------------------------------------------------------
-- SCRIPT COM DADOS PARA USO E TESTE DO BANCO
-- ----------------------------------------------------------------------------
USE [MundoAnimal_BD]
GO

-- ----------------------------------------------------------------------------
-- TIPOS DE CONTATO -- N�O ALTERAR, COMPROMETE FUNCIONAMENTO DO SISTEMA
-- ----------------------------------------------------------------------------
INSERT INTO [Tipo_Contato] 
    ([Nome])
VALUES
    ('Telefone'), ('Celular'), ('Email'), ('Fax'), ('Twitter'), ('Facebook'),
    ('Orkut'), ('Outro');
GO

-- ----------------------------------------------------------------------------
-- CARGOS -- N�O ALTERAR, COMPROMETE FUNCIONAMENTO DO SISTEMA
-- ----------------------------------------------------------------------------
INSERT INTO [Funcionario_Cargo]
    ([Nome])
VALUES
    ('Vendedor'), ('Diretor Geral'), ('Diretor Marketing'), ('Diretor Vendas'),
    ('Diretor TI'), ('Assitencia Tecnica'), ('DBA'), ('Contador'),
    ('Motorista'), ('Caixa'), ('Balconista'), ('Outro')
GO

-- ----------------------------------------------------------------------------
-- CATEGOIAS -- N�O ALTERAR, COMPROMETE FUNCIONAMENTO DO SISTEMA
-- ----------------------------------------------------------------------------
INSERT INTO [Categoria]
    ([Nome], [Descricao])
VALUES
    ('Alimento Granel', 'Alimentos vendidos a granel.'),
    ('Alimento Unit�rio', 'Alimentos que s�o vendidos unit�rios.'),
    ('Higiene e Beleza', 'Produtos de higiene e Beleza'),
    ('Dur�veis', 'Bens dur�veis.'),
    ('Vestu�rio', 'Produtos de vestu�rio.'),
    ('Farmacia', 'Produto e Medicamentos.'),
    ('Conforto', 'Produto de conforto.'),
    ('Outro', 'Outros tipos de produtos.');
GO

-- ----------------------------------------------------------------------------
-- TIPO DE PEDIDOS -- N�O ALTERAR, COMPROMETE FUNCIONAMENTO DO SISTEMA
-- ----------------------------------------------------------------------------
INSERT INTO [Tipo_Pedido]
    ([Descricao])
VALUES
    ('Venda'), ('Banho e Tosa'), ('Veterinario'), ('Outro');
GO