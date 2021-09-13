FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["ExProp_008/ExProp_008.csproj", "ExProp_008/"]
RUN dotnet restore "ExProp_008/ExProp_008.csproj"
COPY . .
WORKDIR "/src/ExProp_008"
RUN dotnet build "ExProp_008.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExProp_008.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExProp_008.dll"]
