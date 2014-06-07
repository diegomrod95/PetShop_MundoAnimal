<h1>Pet Shop Mundo Animal</h1>

<p>Sistema completo e E-commerce de uma empresa de grande porte do ramo de Pet Shop.</p>

<h3>Estrutura de Diretórios</h3>
<pre>
<code>
  projeto/
    README.md
    LICENCE
    BancoDeDados/
      MundoAnimal_BD.sql                  > Script de criação do banco
      Dados.sql                           > Dados para funcionamento do db
      Teste.sql                           > Dados para testar o funcionamento do db
    SistemaMundoAnimal/
      Forms/                              > Formularios usados pela aplicação
        ...
      Source/                             > Diretório com todos objetos da aplicação
        Dados/                            > Diretório com objetos referentes à tipos e banco de dados
          Tipos/                          > Diretório com tipos de dados
          BancoDeDados.cs                 > Classe responsável por fazer consultas e executar comandos no banco
        Entidades/                        > Diretório com entidades do sistema
        Pesquisa/                         > Diretório com classes referentes a pesquisa no banco
          Entidade/                       > Diretório com classes que realizam pesquisa de entidades no banco
      Testes/                             > Diretório com testes dos objetos da aplicação
        ...
      Program.cs                          > Classe reponsável por inicar o programa
</code>
</pre>

<h3>Complexidade:</h3>
<pre>
<code>
Project: SistemaMundoAnimal
Maintainability Index: 83
Cyclomatic Complexity: 502
Depth of Inheritance: 7
Class Coupling: 136
Lines of Code: 2.572
</code>
</pre>

<h3>Colaboradores</h3>
<ul>
  <li>Guilherme Bellotti - @guibellotti</li>
</ul>

<h4>Licença</h4>
<p> The MIT License (MIT) </p>

<p>Copyright (c) 2014 Diego Rodrigues</p>

<p>Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:</p>

<p>The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.</p>

<p>THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.</p>

<b>"O aviso de copyright acima e esta permissão deverá ser incluído em todas as 
cópias ou partes substanciais do Software."</b>