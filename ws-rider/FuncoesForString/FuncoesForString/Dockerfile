FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FuncoesForString/FuncoesForString.csproj", "FuncoesForString/"]
RUN dotnet restore "FuncoesForString/FuncoesForString.csproj"
COPY . .
WORKDIR "/src/FuncoesForString"
RUN dotnet build "FuncoesForString.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FuncoesForString.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FuncoesForString.dll"]
