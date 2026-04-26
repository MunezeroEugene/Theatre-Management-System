# --- Stage 1: Build Frontend ---
FROM node:20-alpine AS build-frontend
WORKDIR /app/tms-fn
COPY tms-fn/package*.json ./
RUN npm install
COPY tms-fn/ ./
RUN npm run build

# --- Stage 2: Build Backend ---
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-backend
# Note: Using SDK 8.0 as base, but your project mentions net10.0. 
# If net10.0 is required, this image should be updated when 10.0 SDK is available.
WORKDIR /src
COPY ["TheatreMs.Api/TheatreMs.Api.csproj", "TheatreMs.Api/"]
RUN dotnet restore "TheatreMs.Api/TheatreMs.Api.csproj"
COPY TheatreMs.Api/ ./TheatreMs.Api/
WORKDIR "/src/TheatreMs.Api"
RUN dotnet build "TheatreMs.Api.csproj" -c Release -o /app/build

# --- Stage 3: Publish ---
FROM build-backend AS publish
RUN dotnet publish "TheatreMs.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

# --- Stage 4: Final Image ---
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Copy Frontend Build to wwwroot
COPY --from=build-frontend /app/tms-fn/dist ./wwwroot

# Expose port (Railway uses PORT env var)
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "TheatreMs.Api.dll"]
