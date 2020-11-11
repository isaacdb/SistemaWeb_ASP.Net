# Sistema Web com ASP.Net Core
<p align="center"> Sistema de gerenciamento de vendas </p>

<p align="center">
 <a href="#-sobre-o-projeto">Sobre o Projeto</a> •
 <a href="#funcionalidades">Funcionalidades</a> • 
 <a href="#tecnologias">Tecnologias</a> • 
 <a href="#como-executar">Como Executar</a> • 
 <a href="#autor">Autor</a>
</p>

## 🎨 Layout
<div align="center">
<img width="80%" alt="Index_controle_manutencao" title="#Index_controle_manutencao" src="https://github.com/isaacdb/SistemaWeb_ASP.Net/blob/main/PrintScreens/Home.PNG">
</div>

<h4 align="left"> 
	🚧 Finished!  🚧
</h4>

---
## 💻 Sobre o projeto
<p>Projeto desenvolvido durante um curso de C# Completo, com finalidade de por em prática os conhecimentos adquiridos.</p>
<p>Foi utilizado o padrão de desenvolvimento MVC(Model/Controller/View), metodo CodeFirst, banco de dados SQLServer, entity framework para a comunicação com o banco.</p>

---
## Funcionalidades

- [x] Cadastro/Edição/Remoção de vendedor
- [x] Cadastro/Edição/Remoção de departamentos
- [ ] Registro de vendas
- [x] Busca personalizada de vendas

---
### Tecnologias

As seguintes ferramentas foram utilizadas na construção do projeto:

- **C#**
- **ASP.Net Core2**
- **SQLServer**
- **Entity Framework**

---
# Como executar
<h4>Pré requisitos</h4>

- SQLServer
- VisualStudio

<h4>Execução</h4>
<p>Faça o git clone do projeto via <a href="https://github.com/isaacdb/SistemaWeb_ASP.Net">GitHub/isaacdb</a></p>

<p>Abra o arquivo SalesWebMvc.sln</p>
<p>É nescessario configurar a conexão do sistema com o seu proprio banco de dados, entao apos criar um servidor em seu banco, passe o caminho e o nome do seu servidor para o projeto no arquivo appsettings.json, como na imagem a seguir.</p>
<div><img width="100%" alt="Conexao_banco" title="#Conexao_banco" src="https://github.com/isaacdb/SistemaWeb_ASP.Net/blob/main/PrintScreens/Conexao_banco.PNG"></div>
<p>Agora abra o Package Manager Console do visual studio(Tools-> NuGet Package Manager-> Package Manager Console), e insira os seguintes comandos:</p>

* Add-Migration Initial
    * Inicia a conexão com o banco de dados, Initial será parte do nome de um arquivo criado para gerar essa conexão.
    
* Update-Database
    * Cria as tabelas no banco conforme as classes do sistema, e estas serão populadas com dados fictícios por uma função existente.

<p>Agora bastar iniciar o projeto, o sistema sera aberto automaticamente.</p>

---
### Autor
Isaac Debiasi
