FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MembroEstatico/MembroEstatico.csproj", "MembroEstatico/"]
RUN dotnet restore "MembroEstatico/MembroEstatico.csproj"
COPY . .
WORKDIR "/src/MembroEstatico"
RUN dotnet build "MembroEstatico.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MembroEstatico.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MembroEstatico.dll"]
