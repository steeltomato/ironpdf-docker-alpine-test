#FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build
FROM ironsoftwareofficial/alpine:latest-net60 as build

# RUN apk add --no-cache tzdata gcompat chromium 

WORKDIR /source

COPY . .

RUN dotnet restore

RUN dotnet run
