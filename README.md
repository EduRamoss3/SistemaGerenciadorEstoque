<!DOCTYPE html>
<html>
<head>
   SISTEMA DE GERENCIAMENTO DE ESTOQUE EM C# E WINDOWS FORMS
</head>
<body>

<h1>VISÃO GERAL</h1>
<p>Este é um projeto de um Sistema de Gerenciamento de Estoque desenvolvido em C# com interface gráfica em Windows Forms. O sistema permite que o usuário realize operações de CRUD para clientes, manipule o estoque, registre compras, pagamentos, alterações em notas fiscais, além de oferecer a funcionalidade de parcelamento de produtos.</p>

<h1>FUNCIONALIDADES PRINCIPAIS</h1>
<ul>
    <li>CRUD de Clientes: Cadastre, visualize, atualize e remova informações de clientes.</li>
    <li>Manipulação do Estoque: Adicione, remova e atualize itens do estoque com suas respectivas quantidades.</li>
    <li>Registro de Compras: Registre as compras efetuadas, com detalhes como valor, quantidade, data e status de pagamento.</li>
    <li>Gerenciamento de Pagamentos: Acompanhe os pagamentos efetuados, parcelas e valores pendentes.</li>
    <li>Alteração em Notas Fiscais: Realize atualizações e edições em notas fiscais já registradas.</li>
    <li>Parcelamento de Produtos: Permita o parcelamento de compras para facilitar a gestão financeira.</li>
</ul>

<h1>REQUISITOS</h1>
<p>Para executar o projeto, é necessário ter os seguintes requisitos instalados:</p>
<ul>
    <li>Microsoft Visual Studio (versão recomendada: 2019 ou superior)</li>
    <li>.NET Framework (versão recomendada: 4.7.2 ou superior)</li>
    <li>SQL Server Compact Edition (SqlCe) para o banco de dados</li>
</ul>

<h1>COMO UTILIZAR</h1>
<p>Siga as etapas abaixo para utilizar o sistema:</p>
<ol>
    <li>Faça o clone do repositório para o seu ambiente local.</li>
    <li>Abra o projeto utilizando o Microsoft Visual Studio.</li>
    <li>Verifique a conexão com o banco de dados SqlCe e, se necessário, ajuste o caminho do arquivo do banco de dados.</li>
    <li>Compile e execute o projeto a partir do Visual Studio.</li>
    <li>Explore as funcionalidades do sistema utilizando a interface gráfica intuitiva.</li>
</ol>

<h1>ESTRUTURA DO PROJETO</h1>
<p>O projeto está estruturado da seguinte forma:</p>
<ul>
    <li><strong>Models</strong>: Contém as classes que representam as entidades do sistema, como Cliente e Compra.</li>
    <li><strong>DataAccess</strong>: Responsável pela interação com o banco de dados, incluindo operações CRUD.</li>
    <li><strong>Forms</strong>: Contém as janelas e formulários do Windows Forms utilizados para a interface gráfica.</li>
    <li><strong>Utils</strong>: Algumas classes utilitárias para auxiliar no projeto.</li>
</ul>

<h1>CONTRIBUTING</h1>
<p>Se você deseja contribuir com o projeto, sinta-se à vontade para criar um fork do repositório e enviar suas sugestões através de pull requests. Vamos adorar receber feedback e melhorias!</p>

<h1>LICENÇA</h1>
<p>Este projeto está licenciado sob a <a href="LICENSE">MIT License</a>.</p>

</body>
</html>
