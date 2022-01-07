FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ExProp_27/ExProp_27.csproj", "ExProp_27/"]
RUN dotnet restore "ExProp_27/ExProp_27.csproj"
COPY . .
WORKDIR "/src/ExProp_27"
RUN dotnet build "ExProp_27.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExProp_27.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExProp_27.dll"]
