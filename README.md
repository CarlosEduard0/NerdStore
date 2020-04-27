<h1 align="center">
    NerdStore
</h1>
 
<p align="center">
	 <img src="https://img.shields.io/static/v1?label=PRs&message=welcome&color=green&labelColor=000000" alt="PRs welcome!" />
<img alt="License" src="https://img.shields.io/static/v1?label=license&message=MIT&color=green&labelColor=000000">
</p>

<p align="center">
  <a href="#beginner-sobre">Sobre</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#fire-como-contribuir">Como contribuir</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#lock-licença">Licença</a>
</p>

Projeto desenvolvido com finalidade de estudos sobre DDD (Domain-Drovem Design) e Event Sourcing.

> “Nós podemos buscar o estado de uma aplicação para encontrar o estado atual do mundo, e isso responde muitas perguntas. Entretanto há momentos que nós não só queremos ver onde nós estamos, mas também queremos saber como chegamos lá.”

##  :beginner: Sobre
**NerdStore** é a implementação de uma loja virtual utilizando os conceitos de DDD e Event Sourcing utilizando .NET Core 3.1. A estrutura do projeto está dividida em contextos, são eles: catalogo, vendas, pagamentos e core.

 - **Catalogo**: Esse contexto é o responsável por gerenciar todo os estoque dos produtos com regras de validação e garantir que não aconteça nenhum inconsistência no banco de dados.
 - **Vendas**: Esse contexto é o responsável por gerenciar os pedidos dos clientes.
 - **Pagamentos**: Esse contexto é o responsável por realizar a integração com uma api de pagamentos e finalizar ou recusar o pedido do cliente.
 - **Core**: Esse contexto é o responsável por realizar a comunicação entre todos os contextos da aplicação através de eventos de integração.

Projeto desenvolvido durante o curso de domínio ricos ministrado por [Eduardo Pires](https://desenvolvedor.io).

## :camera: Imagens

Vitrine dos produtos disponíveis na loja
<img alt="Vitrine" src=".github/images/vitrine.png" width="100%">

Carrinho do cliente
<img alt="Carrinho" src=".github/images/carrinho.png" width="100%">

Pagamento do pedido através de cartão de crédito
<img alt="Pagamento" src=".github/images/pagamento.png" width="100%">

Gerenciamento de produtos
<img alt="Admnistração" src=".github/images/admin.png" width="100%">

Histórico do pedido coletado através de Event Sourcing.
<img alt="Event Sourcing" src=".github/images/eventsourcing.png" width="100%">

 ##  :fire: Como contribuir
 
Contribuições são sempre bem-vindas e podem ser feitas de várias formas.
 1. **Reportar um bug** <br>
Se você encontrar algum bug, ele poderá ser reportar através de issues [aqui]().

 2. **Solicitar uma nova funcionalidade** <br>
 Você pode solicitar uma nova funcionalidade através de issues [aqui]() e  caso queria, poderá implementa-lá seguindo os passos:
-   Faça um fork desse repositório;
-   Cria uma branch com a sua feature:  `git checkout -b minha-feature`;
-   Faça commit das suas alterações:  `git commit -m 'feat: Minha nova feature'`;
-   Faça push para a sua branch:  `git push origin minha-feature`.

##  :lock: Licença

Esse projeto está sob a licença MIT.
