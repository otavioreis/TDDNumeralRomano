FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /app

# Copiar csproj e restaurar dependencias
COPY NumeralRomano/*.csproj ./
RUN dotnet restore

# Build da aplicacao
COPY NumeralRomano/. ./
RUN dotnet publish -c Release -o out

# Build da imagem
FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "NumeralRomano.dll"]