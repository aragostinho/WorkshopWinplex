# WORKSHOP WINPLEX
Workshop Scrum + UX:  Exemplo de aplicação de gestão acesso

## SETUP DE FERRAMENTAS
1. Visual Studio 2015 Community - https://www.visualstudio.com/pt-br/downloads/?rr=https%3A%2F%2Fwww.google.com.br%2F
2. MySql Work Bench 6.3 - https://dev.mysql.com/downloads/workbench/
3. [opcional] Update 3 Visua Studio 2015 - https://www.visualstudio.com/pt-br/news/releasenotes/vs2015-update3-vs

### Configurações acesso MySql
1. Após instalado o MySql, acessar o servidor localhost
2. Criar o banco de dados "gestaoacessos"
3. Rodar o script ScriptsSql\alterPassword.sql

### Acesso padrão admin: 
login: winplex
senha: pnl@016

## MAPEAMENTO DE ACORDO COM O [ESCOPO DO PROJETO](http://www.winplex.com.br/workshop/projetoPHP.pdf)

prestador
 - id
 - nome
 - listaServicos
 
colaborar
 - id
 - nome
 - senha
 - senha

gestaosenha
 - id
 - login
 - senha
 - linkacesso
 - utilizador (Empresa=0/Cliente=1)
 - prestadorid

modulo
  - id
  - nome 

modulopermisao
  - id
  - permissao (Cadastrar, Listar, Visualizar, Excluir e Atualizar)
  - colaboradorid
  - moduloid 
 
