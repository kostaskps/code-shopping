#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Stage 1: Define base image for Production
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

#Stage 2: Build and publish the code
FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Shopping.App/Shopping.App.csproj", "Shopping.App/"]
RUN dotnet restore "Shopping.App/Shopping.App.csproj"
COPY . .
WORKDIR "/src/Shopping.App"
RUN dotnet build "Shopping.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Shopping.App.csproj" -c Release -o /app/publish

#Stage 3: Copy published output and build the final image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Shopping.App.dll"]