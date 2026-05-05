FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY EagleVission/EagleVission.csproj EagleVission/
RUN dotnet restore EagleVission/EagleVission.csproj
COPY EagleVission/ EagleVission/
RUN dotnet publish EagleVission/EagleVission.csproj -c Release -o /app/publish --no-restore

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "EagleVission.dll"]
