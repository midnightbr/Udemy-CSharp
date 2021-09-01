FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["EntradaDeDados_Parte1/EntradaDeDados_Parte1.csproj", "EntradaDeDados_Parte1/"]
RUN dotnet restore "EntradaDeDados_Parte1/EntradaDeDados_Parte1.csproj"
COPY . .
WORKDIR "/src/EntradaDeDados_Parte1"
RUN dotnet build "EntradaDeDados_Parte1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EntradaDeDados_Parte1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EntradaDeDados_Parte1.dll"]
