#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SwanSong.Api/SwanSong.Api.csproj", "SwanSong.Api/"]
COPY ["SwanSong.Business/SwanSong.Business.csproj", "SwanSong.Business/"]
COPY ["SwanSong.Data/SwanSong.Data.csproj", "SwanSong.Data/"]
COPY ["SwanSong.Domain/SwanSong.Domain.csproj", "SwanSong.Domain/"]
COPY ["SwanSong.Service/SwanSong.Service.csproj", "SwanSong.Service/"]
COPY ["SwanSong.Helper/SwanSong.Helper.csproj", "SwanSong.Helper/"]
RUN dotnet restore "SwanSong.Api/SwanSong.Api.csproj"
COPY . .
WORKDIR "/src/SwanSong.Api"
RUN dotnet build "SwanSong.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SwanSong.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SwanSong.Api.dll"]