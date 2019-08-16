FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base
COPY ./bin/Debug/netcoreapp2.2/publish .