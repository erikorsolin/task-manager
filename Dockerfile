# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia apenas os arquivos do projeto
COPY ./src/*.csproj ./src/
WORKDIR /app/src
RUN dotnet restore

# Copia o restante do código
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Etapa de runtime
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "src.dll"]
