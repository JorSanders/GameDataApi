# GameDataApi
GameDataApi is a wrapper around the API of games that I play. In order to save the data to a DB or ELK stack
This project is still very much WIP

## Setup
Add the api secret to your user secrets
```shell
dotnet user-secrets set "TrackerNetwork:ApiKey" "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"
```

Run migrations
```shell
dotnet ef database update
```

## Development
add migration
```shell
dotnet ef migrations add MyFirstMigration
```

## Run
```shell
dotnet run
```
