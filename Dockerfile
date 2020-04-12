FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine AS build
WORKDIR /home/dotnet/app
COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine
WORKDIR /home/dotnet/app
EXPOSE 80
COPY --from=build /home/dotnet/app/out .
ENTRYPOINT ["dotnet", "NerdStore.WebApp.MVC.dll"]