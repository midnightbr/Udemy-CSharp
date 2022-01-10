FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Sintaxe_Alternativa/Sintaxe_Alternativa.csproj", "Sintaxe_Alternativa/"]
RUN dotnet restore "Sintaxe_Alternativa/Sintaxe_Alternativa.csproj"
COPY . .
WORKDIR "/src/Sintaxe_Alternativa"
RUN dotnet build "Sintaxe_Alternativa.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sintaxe_Alternativa.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sintaxe_Alternativa.dll"]
