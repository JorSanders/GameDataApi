FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

COPY . .
RUN ls -l appsettings*.json
RUN dotnet restore

RUN dotnet publish -c Release -o out
RUN ls -l out/appsettings*.json


FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./
RUN ls -l appsettings*.json

# Optional: Set this here if not setting it from docker-compose.yml
# ENV ASPNETCORE_ENVIRONMENT Development

ENTRYPOINT ["dotnet", "GameDataApi.dll"]
