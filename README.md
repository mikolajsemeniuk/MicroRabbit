# MicroRabbit
get started
```sh
mkdir MicroRabbit &&
cd MicroRabbit &&
dotnet new sln -n MicroRabbit &&

mkdir Domain &&
mkdir Infra.Bus &&
mkdir Infra.IoC &&
mkdir Microservices &&
mkdir Presentation

dotnet new classlib -o Domain/MicroRabbit.Domain.Core &&
dotnet sln MicroRabbit.sln add Domain/MicroRabbit.Domain.Core/MicroRabbit.Domain.Core.csproj &&

dotnet new classlib Infra.Bus/MicroRabbit.Infra.Bus &&
dotnet sln MicroRabbit.sln add Infra.Bus/MicroRabbit.Infra.Bus/MicroRabbit.Infra.Bus.csproj &&
dotnet add Infra.Bus/MicroRabbit.Infra.Bus/MicroRabbit.Infra.Bus.csproj reference Domain/MicroRabbit.Domain.Core/MicroRabbit.Domain.Core.csproj &&

dotnet new classlib -o Infra.IoC/MicroRabbit.Infra.IoC &&
dotnet sln MicroRabbit.sln add Infra.IoC/MicroRabbit.Infra.IoC/MicroRabbit.Infra.IoC.csproj &&
dotnet add Infra.IoC/MicroRabbit.Infra.IoC/MicroRabbit.Infra.IoC.csproj reference Domain/MicroRabbit.Domain.Core/MicroRabbit.Domain.Core.csproj &&
dotnet add Infra.IoC/MicroRabbit.Infra.IoC/MicroRabbit.Infra.IoC.csproj reference Infra.Bus/MicroRabbit.Infra.Bus/MicroRabbit.Infra.Bus.csproj &&

dotnet new webapi -o Microservices/Banking/Api/MicroRabbit.Banking.Api &&
dotnet sln MicroRabbit.sln add Microservices/Banking/Api/MicroRabbit.Banking.Api/MicroRabbit.Banking.Api.csproj &&

dotnet new classlib -o Microservices/Banking/Application/MicroRabbit.Banking.Application &&
dotnet sln MicroRabbit.sln add Microservices/Banking/Application/MicroRabbit.Banking.Application/MicroRabbit.Banking.Application.csproj && 

dotnet new classlib -o Microservices/Banking/Domain/MicroRabbit.Banking.Domain &&
dotnet sln MicroRabbit.sln add Microservices/Banking/Domain/MicroRabbit.Banking.Domain/MicroRabbit.Banking.Domain.csproj &&

dotnet new classlib -o Microservices/Banking/Data/MicroRabbit.Banking.Data &&
dotnet sln MicroRabbit.sln add Microservices/Banking/Data/MicroRabbit.Banking.Data/MicroRabbit.Banking.Data.csproj &&

dotnet add Microservices/Banking/Data/MicroRabbit.Banking.Data/MicroRabbit.Banking.Data.csproj reference Microservices/Banking/Domain/MicroRabbit.Banking.Domain/MicroRabbit.Banking.Domain.csproj &&

dotnet add Microservices/Banking/Application/MicroRabbit.Banking.Application/MicroRabbit.Banking.Application.csproj reference Microservices/Banking/Domain/MicroRabbit.Banking.Domain/MicroRabbit.Banking.Domain.csproj &&

dotnet add Infra.IoC/MicroRabbit.Infra.IoC/MicroRabbit.Infra.IoC.csproj reference Microservices/Banking/Application/MicroRabbit.Banking.Application/MicroRabbit.Banking.Application.csproj &&

dotnet add Infra.IoC/MicroRabbit.Infra.IoC/MicroRabbit.Infra.IoC.csproj reference Microservices/Banking/Data/MicroRabbit.Banking.Data/MicroRabbit.Banking.Data.csproj &&

dotnet add Infra.IoC/MicroRabbit.Infra.IoC/MicroRabbit.Infra.IoC.csproj reference Microservices/Banking/Domain/MicroRabbit.Banking.Domain/MicroRabbit.Banking.Domain.csproj

dotnet ef migrations add InitialCreate \
    -c BankingDbContext \
    -p Microservices/Banking/Data/MicroRabbit.Banking.Data \
    -s Microservices/Banking/Api/MicroRabbit.Banking.Api

dotnet ef database update \
    -c BankingDbContext \
    -p Microservices/Banking/Data/Microrabbit.Banking.Data \
    -s Microservices/Banking/Api/MicroRabbit.Banking.Api

dotnet ef database drop \
    -c BankingDbContext \
    -p Microservices/Banking/Data/Microrabbit.Banking.Data \
    -s Microservices/Banking/Api/MicroRabbit.Banking.Api

dotnet add Microservices/Banking/Domain/MicroRabbit.Banking.Domain/MicroRabbit.Banking.Domain.csproj reference Domain/MicroRabbit.Domain.Core

dotnet build MicroRabbit.sln

dotnet run -p Microservices/Banking/Api/MicroRabbit.Banking.Api

```