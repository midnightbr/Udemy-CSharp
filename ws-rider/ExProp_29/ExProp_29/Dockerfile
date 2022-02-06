FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ExProp_29/ExProp_29.csproj", "ExProp_29/"]
RUN dotnet restore "ExProp_29/ExProp_29.csproj"
COPY . .
WORKDIR "/src/ExProp_29"
RUN dotnet build "ExProp_29.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExProp_29.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExProp_29.dll"]
