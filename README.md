# .NET 7 NFT Exchange with Solana

This is a proof-of-concept project that demonstrates the usage of NFTs (Non-Fungible Tokens) in a .NET 7 application with Solana integration.

## Overview

This project showcases a basic NFT exchange application built using .NET 7 and Solana. It provides a set of API endpoints to interact with a Solana network and perform operations such as getting the account balance and sending currency.

The project consists of the following components:

- **API**: Contains the API endpoints implemented using ASP.NET Core.
- **Domain**: Contains the domain logic and services for interacting with Solana.
- **Infrastructure**: Contains the implementation of the Solana RPC client and other infrastructure-related code.
- **Tests**: Contains unit tests for the application.

## Prerequisites

Before running the application, make sure you have the following prerequisites installed:

- .NET 7 SDK
- Docker

## Getting Started

To get started with the project, follow these steps:

```bash
git clone https://github.com/your-username/nft-exchange-solana-dotnet7.git

//Build and run the application using Docker:

docker-compose up --build```

The API will be accessible at http://localhost:5000. You can test the API endpoints using a tool like cURL or a REST client.

## API Endpoints

The following API endpoints are available:

```bash 
GET /exchange/balance: Retrieves the account balance.
GET /exchange/balance/send/{value}: Sends the specified currency value.```

## Configuration
The application can be configured using environment variables. The following variables can be set:

SOLANA_RPC_URL: The URL of the Solana RPC endpoint.

Other Solana-related configuration variables, if applicable.

## Contributing

Contributions to this project are welcome. If you find any issues or would like to suggest improvements, please open an issue or submit a pull request.

## License
This project is licensed under the MIT License.
