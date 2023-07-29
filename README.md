# SistemaGerenciador
Sistema de Gerenciamento de Estoque em C# e Windows Forms

Visão Geral
Este é um projeto de um Sistema de Gerenciamento de Estoque desenvolvido em C# com interface gráfica em Windows Forms. O sistema permite que o usuário realize operações de CRUD para clientes, manipule o estoque, registre compras, pagamentos, alterações em notas fiscais, além de oferecer a funcionalidade de parcelamento de produtos.

Funcionalidades Principais
CRUD de Clientes: Cadastre, visualize, atualize e remova informações de clientes.
Manipulação do Estoque: Adicione, remova e atualize itens do estoque com suas respectivas quantidades.
Registro de Compras: Registre as compras efetuadas, com detalhes como valor, quantidade, data e status de pagamento.
Gerenciamento de Pagamentos: Acompanhe os pagamentos efetuados, parcelas e valores pendentes.
Alteração em Notas Fiscais: Realize atualizações e edições em notas fiscais já registradas.
Parcelamento de Produtos: Permita o parcelamento de compras para facilitar a gestão financeira.
Requisitos
Microsoft Visual Studio (versão recomendada: 2019 ou superior)
.NET Framework (versão recomendada: 4.7.2 ou superior)
SQL Server Compact Edition (SqlCe) para o banco de dados
Como Utilizar
Faça o clone do repositório para o seu ambiente local.
Abra o projeto utilizando o Microsoft Visual Studio.
Verifique a conexão com o banco de dados SqlCe e, se necessário, ajuste o caminho do arquivo do banco de dados.
Compile e execute o projeto a partir do Visual Studio.
Explore as funcionalidades do sistema utilizando a interface gráfica intuitiva.
Estrutura do Projeto
Models: Contém as classes que representam as entidades do sistema, como Cliente e Compra.
DataAccess: Responsável pela interação com o banco de dados, incluindo operações CRUD.
Forms: Contém as janelas e formulários do Windows Forms utilizados para a interface gráfica.
Utils: Algumas classes utilitárias para auxiliar no projeto.
Contribuindo
Se você deseja contribuir com o projeto, sinta-se à vontade para criar um fork do repositório e enviar suas sugestões através de pull requests. Vamos adorar receber feedback e melhorias!

Licença
Este projeto está licenciado sob a MIT License.

