FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Exercicio005/Exercicio005.csproj", "Exercicio005/"]
RUN dotnet restore "Exercicio005/Exercicio005.csproj"
COPY . .
WORKDIR "/src/Exercicio005"
RUN dotnet build "Exercicio005.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Exercicio005.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Exercicio005.dll"]
