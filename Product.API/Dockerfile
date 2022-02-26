#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
#ENV DB_CONNECTION_STRING="Server=localhost,14333; Database=my_db; User='sa'; Password='1Secure*Password1';"

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Merchandise.API/Merchandise.API.csproj", "Merchandise.API/"]
RUN dotnet restore "Merchandise.API/Merchandise.API.csproj"
COPY . .
WORKDIR "/src/Merchandise.API"
RUN dotnet build "Merchandise.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Merchandise.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Merchandise.API.dll"]