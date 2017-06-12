# WorkshopWinplex
Workshop Scrum + UX:  Exemplo de aplicação de gestão acesso
 
Acesso padrão admin: 
login: winplex
senha: pnl@016

#MAPEAMENTO DE ACORDO COM O ESCOPO DO PROJETO http://www.winplex.com.br/workshop/projetoPHP.pdf

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
 
