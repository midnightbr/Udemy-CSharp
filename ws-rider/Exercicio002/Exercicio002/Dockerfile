FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Exercicio002/Exercicio002.csproj", "Exercicio002/"]
RUN dotnet restore "Exercicio002/Exercicio002.csproj"
COPY . .
WORKDIR "/src/Exercicio002"
RUN dotnet build "Exercicio002.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Exercicio002.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Exercicio002.dll"]
