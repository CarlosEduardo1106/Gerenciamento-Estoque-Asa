# Gerenciamento-Estoque-Asa
--Sistema de estoque para a ASA: API em C# com cadastro de categorias e produtos e registro de entradas e saídas.--


//ASA - Sistema de Estoque\\

Sistema de controle de estoque da ASA. A ideia é organizar os produtos por categoria e registrar como entradas e saídas, mantendo sempre o saldo atualizado de cada item.

Status do projeto
Em desenvolvimento.


Hoje só existe parte do backend. O que já está pronto e o que falta:

Parte Situação
Modelos (Categorias, Produtos, Movimentos) Pronto
Conexão com o MySQL (Entity Framework Core) Pronto
DTOs de entrada e saída Pronto
Controladores (rotas da API) Em andamento
Registro de entrada e saúde com atualização do estoque A fazer
Frontend (React) integrado à API A fazer
Versão para celular A fazer
Funcionalidades previstas
Cadastro de categorias
Cadastro de produtos, ligados a uma categoria
Registro de entradas e saídas de estoque
Histórico de movimentos
Aplicativo para celular (iPhone e Android)
Tecnologias
C# com ASP.NET Core
Núcleo do Entity Framework
MySQL
Estrutura do projeto
GerenciamentoADRA/
-- Controladores/rotas da API
-- Dados/contexto do banco (AdraContext)
-- Dtos/objetos de entrada e saúde da API
-- Modelos/classes que representam como tabelas Modelos/classes que representam como tabelas
-- appsettings.json
-- Programa.cs

Banco de dados
O banco se chama sistema_adra e tem três tabelas:

--categorias
--produtos (cada produto pertence a uma categoria)
--movimentacoes (cada movimento pertence a um produto)
