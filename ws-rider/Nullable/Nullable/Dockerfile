﻿FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Nullable/Nullable.csproj", "Nullable/"]
RUN dotnet restore "Nullable/Nullable.csproj"
COPY . .
WORKDIR "/src/Nullable"
RUN dotnet build "Nullable.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Nullable.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Nullable.dll"]
