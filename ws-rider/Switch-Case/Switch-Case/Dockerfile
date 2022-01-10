FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Switch-Case/Switch-Case.csproj", "Switch-Case/"]
RUN dotnet restore "Switch-Case/Switch-Case.csproj"
COPY . .
WORKDIR "/src/Switch-Case"
RUN dotnet build "Switch-Case.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Switch-Case.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Switch-Case.dll"]
