# WorkshopWinplex
Workshop Scrum + UX:  Exemplo de aplicação de gestão acesso


#MAPEAMENTO DE ACORDO COM O ESCOPO DO PROJETO http://www.winplex.com.br/workshop/projetoPHP.pdf
Empresa
 - Id
 - CNPJ
 - Nome
 - Servicos
 - Email

Usuario
 - Id
 - Nome
 - Email
 - Cidade
 - Estado
 - AcessoId

EmpresaUsuario
 - EmpresaId
 - UsuarioId

Acesso
 - Id
 - Login
 - Senha

Modulo
  - Id
  - Titulo
  - Descricao

Exemplo:
  - Módulo de gestão de empresas
  - Módulo de gestão de usuários de empresas
  - Módulo de gestão de anúncios

ModuloRestrito
  - Id
  - PermissaoEnum
  - AcessoId

PermissaoEnum:  
 Cadastrar, Listar, Visualizar, Excluir e Atualizar

Exemplo de aplicação de permissões:
  - Módulo de gestão de empresas
     AcessoId 5  
        - Pode Visualizar
        - Pode Atualizar
        - Não pode cadastrar
        - Não pode excluir

