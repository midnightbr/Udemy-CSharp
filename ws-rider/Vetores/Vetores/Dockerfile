FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Vetores/Vetores.csproj", "Vetores/"]
RUN dotnet restore "Vetores/Vetores.csproj"
COPY . .
WORKDIR "/src/Vetores"
RUN dotnet build "Vetores.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Vetores.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Vetores.dll"]
