#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
RUN apt-get update && apt-get install -y xorg openbox libnss3 libasound2
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WhatsappScrapper/WhatsappScrapper.csproj", "WhatsappScrapper/"]
COPY ["Whatsapp.ApiConsumer/Whatsapp.ApiConsumer.csproj", "Whatsapp.ApiConsumer/"]
COPY ["WhatsAppScrapper.Models/WhatsAppScrapper.Models.csproj", "WhatsAppScrapper.Models/"]
COPY ["Whatsapp.Identity/Whatsapp.Identity.csproj", "Whatsapp.Identity/"]
COPY ["WhatsappScrapper.Bussiness/WhatsappScrapper.Bussiness.csproj", "WhatsappScrapper.Bussiness/"]
COPY ["WhatsappScrapper.DataAccess/WhatsappScrapper.DataAccess.csproj", "WhatsappScrapper.DataAccess/"]
RUN dotnet restore "WhatsappScrapper/WhatsappScrapper.csproj"
COPY . .
WORKDIR "/src/WhatsappScrapper"
RUN dotnet build "WhatsappScrapper.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WhatsappScrapper.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WhatsappScrapper.dll"]