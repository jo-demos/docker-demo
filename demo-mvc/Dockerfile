FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

LABEL version="1.0.0" description="ASP.NET CORE MVC with Docker"

COPY dist /app

WORKDIR /app

EXPOSE 80/tcp

ENTRYPOINT ["dotnet", "demo-mvc.dll"]
