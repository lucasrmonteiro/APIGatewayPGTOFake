FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 51177
EXPOSE 44330

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY APIGateway.Query/APIGateway.Query.csproj APIGateway.Query/
RUN dotnet restore APIGateway.Query/APIGateway.Query.csproj
COPY . .
WORKDIR /src/APIGateway.Query
RUN dotnet build APIGateway.Query.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish APIGateway.Query.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "APIGateway.Query.dll"]
