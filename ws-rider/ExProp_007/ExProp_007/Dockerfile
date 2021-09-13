FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["ExProp_007/ExProp_007.csproj", "ExProp_007/"]
RUN dotnet restore "ExProp_007/ExProp_007.csproj"
COPY . .
WORKDIR "/src/ExProp_007"
RUN dotnet build "ExProp_007.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExProp_007.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExProp_007.dll"]
