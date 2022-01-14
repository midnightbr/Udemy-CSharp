FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["DateTime/DateTime.csproj", "DateTime/"]
RUN dotnet restore "DateTime/DateTime.csproj"
COPY . .
WORKDIR "/src/DateTime"
RUN dotnet build "DateTime.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DateTime.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DateTime.dll"]
