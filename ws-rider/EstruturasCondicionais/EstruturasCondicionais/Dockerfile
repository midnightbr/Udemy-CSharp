FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["EstruturasCondicionais/EstruturasCondicionais.csproj", "EstruturasCondicionais/"]
RUN dotnet restore "EstruturasCondicionais/EstruturasCondicionais.csproj"
COPY . .
WORKDIR "/src/EstruturasCondicionais"
RUN dotnet build "EstruturasCondicionais.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EstruturasCondicionais.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EstruturasCondicionais.dll"]
