﻿FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Listas/Listas.csproj", "Listas/"]
RUN dotnet restore "Listas/Listas.csproj"
COPY . .
WORKDIR "/src/Listas"
RUN dotnet build "Listas.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Listas.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Listas.dll"]
