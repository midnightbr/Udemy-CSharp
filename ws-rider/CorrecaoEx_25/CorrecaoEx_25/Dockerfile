FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CorrecaoEx_25/CorrecaoEx_25.csproj", "CorrecaoEx_25/"]
RUN dotnet restore "CorrecaoEx_25/CorrecaoEx_25.csproj"
COPY . .
WORKDIR "/src/CorrecaoEx_25"
RUN dotnet build "CorrecaoEx_25.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CorrecaoEx_25.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CorrecaoEx_25.dll"]
