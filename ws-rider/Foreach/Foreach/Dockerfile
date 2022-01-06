FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Foreach/Foreach.csproj", "Foreach/"]
RUN dotnet restore "Foreach/Foreach.csproj"
COPY . .
WORKDIR "/src/Foreach"
RUN dotnet build "Foreach.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Foreach.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Foreach.dll"]
