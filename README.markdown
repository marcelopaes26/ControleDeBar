# Controle de Bar

## Visão Geral
O **Controle de Bar** é uma aplicação desenvolvida em **C#** para gerenciamento de bares, permitindo a administração de mesas, garçons, produtos e contas. Este documento descreve os requisitos funcionais, regras de negócio e instruções para configurar e executar o projeto.

## Módulos do Sistema

### 1. Módulo de Mesas
#### Requisitos Funcionais
- Inserção de novas mesas.
- Edição de mesas já cadastradas.
- Exclusão de mesas já cadastradas.
- Visualização de mesas cadastradas.
- Visualização dos detalhes de cada mesa.
- Visualização do status atual da mesa (Livre/Ocupada).

#### Regras de Negócio
- **Campos obrigatórios:**
  - **Número**: Único, número positivo.
  - **Quantidade de Lugares**: Número positivo.
- **Status possíveis**: Livre / Ocupada.
- O status padrão ao cadastrar uma mesa é "Livre".
- Não é permitido cadastrar mesas com números duplicados.
- Não é permitido excluir uma mesa com pedidos vinculados.

### 2. Módulo de Garçons
#### Requisitos Funcionais
- Inserção de novos garçons.
- Edição de garçons já cadastrados.
- Exclusão de garçons já cadastrados.
- Visualização de garçons cadastrados.

#### Regras de Negócio
- **Campos obrigatórios:**
  - **Nome**: Mínimo de 3 caracteres, máximo de 100.
  - **CPF**: Formato validado (XXX.XXX.XXX-XX).
- Não é permitido cadastrar garçons com o mesmo CPF.
- Não é permitido cadastrar um garçom com nome e CPF duplicados.
- Não é permitido excluir um garçom com pedidos vinculados.

### 3. Módulo de Produtos
#### Requisitos Funcionais
- Inserção de novos produtos.
- Edição de produtos já cadastrados.
- Exclusão de produtos já cadastrados.
- Visualização de produtos cadastrados.

#### Regras de Negócio
- **Campos obrigatórios:**
  - **Nome**: Mínimo de 2 caracteres, máximo de 100.
  - **Preço**: Número positivo com 2 casas decimais.
- Não é permitido cadastrar produtos com nomes duplicados.
- Não é permitido excluir um produto com pedidos vinculados.

### 4. Módulo de Conta
#### Requisitos Funcionais
- Abertura de contas para clientes realizarem pedidos.
- Adição de itens a um pedido existente.
- Remoção de itens de um pedido existente.
- Visualização do faturamento diário.
- Visualização de contas em aberto.
- Visualização de contas fechadas.
- Fechamento de pedidos.

#### Regras de Negócio
- **Campos obrigatórios na abertura de contas:**
  - **Nome do cliente**.
  - **Mesa**: Seleção obrigatória entre mesas cadastradas.
  - **Garçom**: Seleção obrigatória entre garçons cadastrados.
- **Campos obrigatórios no registro de pedidos:**
  - **Itens**: Lista de produtos com quantidade.
- **Status possíveis da conta**: Aberta / Fechada.
- O status padrão ao registrar uma conta é "Aberta".
- O sistema calcula automaticamente o valor total de cada pedido.
- O sistema calcula automaticamente o valor total faturado no dia.
- Cada mesa só pode ter um pedido ativo por vez.

## Pré-requisitos
Para executar o projeto, você precisará de:
- [.NET SDK](https://dotnet.microsoft.com/download) (versão 6.0 ou superior recomendada)
- [Visual Studio](https://visualstudio.microsoft.com/) (opcional, para desenvolvimento com IDE)
- Git para clonar o repositório

## Tecnologias Utilizadas
[![My Skills](https://skillicons.dev/icons?i=cs,dotnet,git,github,vscode)](https://skillicons.dev)