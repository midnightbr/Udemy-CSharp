FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Exercicio003/Exercicio003.csproj", "Exercicio003/"]
RUN dotnet restore "Exercicio003/Exercicio003.csproj"
COPY . .
WORKDIR "/src/Exercicio003"
RUN dotnet build "Exercicio003.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Exercicio003.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Exercicio003.dll"]
