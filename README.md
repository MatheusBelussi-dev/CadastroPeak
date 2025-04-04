# Peak Invest - Teste Técnico

Este projeto consiste em uma aplicação web desenvolvida com Angular (frontend) e .NET (backend) para realizar cálculos de parcelas e consultas de nomes.

## Estrutura do Projeto

O projeto está organizado em duas partes principais:

1. **Backend (.NET)**
   - PeakInvest.API: API REST
   - PeakInvest.Application: Camada de aplicação
   - PeakInvest.Domain: Camada de domínio
   - PeakInvest.Infrastructure: Camada de infraestrutura

2. **Frontend (Angular)**
   - PeakInvest.Web: Aplicação Angular

## Requisitos

- .NET 8.0 SDK
- Node.js (versão LTS recomendada)
- npm (gerenciador de pacotes do Node.js)

## Como Executar

### Backend

1. Navegue até a pasta do projeto backend:
   ```
   cd PeakInvest.API
   ```

2. Restaure os pacotes NuGet:
   ```
   dotnet restore
   ```

3. Execute a API:
   ```
   dotnet run
   ```

4. A API estará disponível em:
   - https://localhost:7052 (HTTPS)
   - http://localhost:5052 (HTTP)
   - Swagger UI: https://localhost:7052/swagger

### Frontend

1. Navegue até a pasta do projeto frontend:
   ```
   cd PeakInvest.Web
   ```

2. Instale as dependências:
   ```
   npm install
   ```

3. Execute a aplicação Angular:
   ```
   ng serve
   ```

4. A aplicação estará disponível em:
   - http://localhost:4200

## Funcionalidades

### Cálculo de Parcelas
- Endpoint: POST /api/Calculo
- Corpo da requisição:
  ```json
  {
    "quantidadeParcelas": 12,
    "valorParcela": 100.00
  }
  ```
- Retorna o valor total com acréscimo de 5% por parcela

### Consulta de Nomes
- Endpoint: GET /api/Consulta/{id}
- IDs disponíveis: 1, 2, 3
- Retorna o nome correspondente ao ID

## Arquitetura

O projeto segue os princípios do Domain-Driven Design (DDD) e SOLID:

- **Domain Layer**: Contém as entidades e interfaces do domínio
- **Application Layer**: Contém os serviços de aplicação
- **Infrastructure Layer**: Contém as implementações concretas
- **API Layer**: Contém os controllers que expõem os endpoints

## Observações

- O backend está configurado para desabilitar o redirecionamento HTTPS em ambiente de desenvolvimento
- O frontend está configurado para se comunicar com o backend na porta 7052
- A aplicação usa Bootstrap para estilização