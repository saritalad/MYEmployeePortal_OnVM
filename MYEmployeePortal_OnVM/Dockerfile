#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MYEmployeePortal_OnVM/MYEmployeePortal_OnVM.csproj", "MYEmployeePortal_OnVM/"]
RUN dotnet restore "MYEmployeePortal_OnVM/MYEmployeePortal_OnVM.csproj"
COPY . .
WORKDIR "/src/MYEmployeePortal_OnVM"
RUN dotnet build "MYEmployeePortal_OnVM.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MYEmployeePortal_OnVM.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MYEmployeePortal_OnVM.dll"]