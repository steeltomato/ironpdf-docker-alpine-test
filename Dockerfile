FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build

RUN apk add --no-cache tzdata gcompat chromium

WORKDIR /source

COPY . .

RUN dotnet restore

RUN dotnet run
