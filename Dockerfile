#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["2FA-Zero/2FA-Zero.csproj", "2FA-Zero/"]
RUN dotnet restore "2FA-Zero/2FA-Zero.csproj"
COPY . .
WORKDIR "/src/2FA-Zero"
RUN dotnet build "2FA-Zero.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "2FA-Zero.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "2FA-Zero.dll"]