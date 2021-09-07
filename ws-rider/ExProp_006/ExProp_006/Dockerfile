FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["ExProp_006/ExProp_006.csproj", "ExProp_006/"]
RUN dotnet restore "ExProp_006/ExProp_006.csproj"
COPY . .
WORKDIR "/src/ExProp_006"
RUN dotnet build "ExProp_006.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExProp_006.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExProp_006.dll"]
