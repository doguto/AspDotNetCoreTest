FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

RUN apt-get update -q && \
    apt-get install -y --no-install-recommends \
    build-essential \
    git \
    vim && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

RUN mkdir -p /src
WORKDIR /srv

EXPOSE 5243
