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
dotnet add Infra.Bus/MicroRabbit.Infra.Bus/MicroRabbit.Infra.Bus.csproj reference Domain/MicroRabbit.Domain.Core/MicroRabbit.Domain.Core.csproj

dotnet build MicroRabbit.sln 
```