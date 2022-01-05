FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Params/Params.csproj", "Params/"]
RUN dotnet restore "Params/Params.csproj"
COPY . .
WORKDIR "/src/Params"
RUN dotnet build "Params.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Params.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Params.dll"]
