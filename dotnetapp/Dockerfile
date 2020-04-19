FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /app

# 複製 *.csproj 檔案至Docker中, 並Restore
COPY *.csproj ./
RUN dotnet restore

# 複製除了.dockerignore除外的所有檔案至Docker中, 並建置發佈專案
COPY . ./
WORKDIR /app
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "dotnetapp.dll"]