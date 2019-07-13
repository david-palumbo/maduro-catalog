FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Maduro.Catalog.Api/Maduro.Catalog.Api.csproj", "Maduro.Catalog.Api/"]
COPY ["Maduro.Catalog.Application/Maduro.Catalog.Application.csproj", "Maduro.Catalog.Application/"]
COPY ["Maduro.Catalog.Domain/Maduro.Catalog.Domain.csproj", "Maduro.Catalog.Domain/"]
RUN dotnet restore "Maduro.Catalog.Api/Maduro.Catalog.Api.csproj"
COPY . .
WORKDIR "/src/Maduro.Catalog.Api"
RUN dotnet build "Maduro.Catalog.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Maduro.Catalog.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Maduro.Catalog.Api.dll"]