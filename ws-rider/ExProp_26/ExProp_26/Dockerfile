FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ExProp_26/ExProp_26.csproj", "ExProp_26/"]
RUN dotnet restore "ExProp_26/ExProp_26.csproj"
COPY . .
WORKDIR "/src/ExProp_26"
RUN dotnet build "ExProp_26.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExProp_26.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExProp_26.dll"]
