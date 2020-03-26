FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app
EXPOSE 80
EXPOSE 443

COPY . .
COPY *.csproj ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "PlayersAPI.dll"]