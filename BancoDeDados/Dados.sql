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
-- PESSOAS PARA TESTAR TABELA E ENTIDADE PESSOA
-- ----------------------------------------------------------------------------
INSERT INTO [Pessoa]
    ([Nome], [Sobrenome], [Nome_Fantasia], [Tipo_Pessoa], [Genero], [RG], 
    [CPF], [CNPJ], [Nascimento])
VALUES
    ('Pedro', 'Aguiar', '', 'F', 'M', '939531219', '14455588249', '', '15/03/1985'),
    ('Maria', 'Aguiar', '', 'F', 'F', '125635489', '78452235479', '','11/06/1983'),
    ('Ronaldo', 'Aguiar Filho', '', 'F', 'M', '122354336', '18352232576', '', '21/03/1999'),
    ('', '', 'Ra��o Canina e Cia', 'J', 'O', '', '', '12345678912345', '');
GO

INSERT INTO [Pessoa_Endereco] 
    ([Pessoa_Id], [Pais], [Estado], [Cidade], [Endereco], [NumeroEndereco], 
    [Bairro], [Complemento], [CEP])
VALUES
    (1, 'Brasil', 'SP', 'S�o Paulo', 'Rua Borges Arruda', 50, 'S�o Arnaldo', 'Casa 71', '05156321'),
    (2, 'Brasil', 'SP', 'S�o Paulo', 'Rua Borges Arruda', 50, 'S�o Arnaldo', 'Casa 71', '05156321'),
    (4, 'Brasil', 'RJ', 'Niter�i', 'Rua da Esquina', 1150, 'Aviador Pedro', 'Galp�o 151. Lado C', '1234567'),
    (4, 'Brasil', 'BA', 'Salvador', 'Pelorinho', 171, 'Arretados da S�', 'Predio 32', '7654321');
GO

INSERT INTO [Pessoa_Contato]
    ([Pessoa_Id], [Tipo_Id], [Contato])
VALUES
    (1, 1, '1199999999'), (1, 1, '1143219865'), (1, 2, '11923456789'), (1, 3, 'pedro@aguiar.com.br'),
    (1, 5, 'pedro_agui32'), (1, 6, 'pedro.aguiar.585'),
    (2, 3, 'maria@aguiar.com.br'),
    (4, 1, '2191239321'), (4, 3, 'finaceiro@racao_canina_cia.com'), (4, 3, 'vendas@racao_canina_cia.com'), 
    (4, 3, 'sac@racao_canina_cia.com'), (4, 4, '2191239321');
GO 

INSERT INTO [Pessoa_Parente]
    ([Pessoa_Id], [Parente_Id], [Parentesco])
VALUES
    (1, 2, 'C'), (1, 3, 'F');
GO 

SELECT * FROM [Pessoa_Parente]