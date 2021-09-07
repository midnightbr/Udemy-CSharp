FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ExProp_001/ExProp_001.csproj", "ExProp_001/"]
RUN dotnet restore "ExProp_001/ExProp_001.csproj"
COPY . .
WORKDIR "/src/ExProp_001"
RUN dotnet build "ExProp_001.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExProp_001.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExProp_001.dll"]
