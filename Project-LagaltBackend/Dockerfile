#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Project-LagaltBackend/Project-LagaltBackend.csproj", "Project-LagaltBackend/"]
RUN dotnet restore "Project-LagaltBackend/Project-LagaltBackend.csproj"
COPY . .
WORKDIR "/src/Project-LagaltBackend"
RUN dotnet build "Project-LagaltBackend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Project-LagaltBackend.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Project-LagaltBackend.dll"]