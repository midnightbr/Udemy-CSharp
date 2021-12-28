FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ExProp_24/ExProp_24.csproj", "ExProp_24/"]
RUN dotnet restore "ExProp_24/ExProp_24.csproj"
COPY . .
WORKDIR "/src/ExProp_24"
RUN dotnet build "ExProp_24.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExProp_24.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExProp_24.dll"]
