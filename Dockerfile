# Простой Dockerfile для ASP.NET Web API
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Копирование файлов проекта
COPY . .

# Сборка и публикация
RUN dotnet publish -c Release -o out

# Финальный образ
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Открытие порта
EXPOSE 8080

# Запуск приложения
ENTRYPOINT ["dotnet", "WeddingServer.dll"]