FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Matrizes/Matrizes.csproj", "Matrizes/"]
RUN dotnet restore "Matrizes/Matrizes.csproj"
COPY . .
WORKDIR "/src/Matrizes"
RUN dotnet build "Matrizes.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Matrizes.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Matrizes.dll"]
