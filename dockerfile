FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["dacm.csproj", "ContentDistributionApp/"]
RUN dotnet restore "ContentDistributionApp/dacm.csproj"
COPY . .
WORKDIR "/src/ContentDistributionApp"
RUN dotnet build "dacm.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dacm.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContentDistributionApp.dll"]