FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
WORKDIR /work

# Create development certificates to be used by default
RUN dotnet dev-certs https

# Restore service projects
COPY Greeter.Common/*.csproj ./Greeter.Common/
COPY Greeter.Grpc/*.csproj ./Greeter.Grpc/
COPY Greeter.Service/*.csproj ./Greeter.Service/
RUN dotnet restore -r linux-musl-x64 ./Greeter.Service

# Build and publish solution to /publish
COPY . .
RUN dotnet publish -c Release -r linux-musl-x64 --no-restore --self-contained -p:PublishTrimmed=True -o /publish Greeter.Service


# Build runtime image
FROM mcr.microsoft.com/dotnet/runtime-deps:7.0-alpine
ENV URLS "http://*:80;https://*:443"
ENV Logging__Console__FormatterName ""
WORKDIR /app

COPY --from=build-env /root/.dotnet/corefx/cryptography/x509stores /root/.dotnet/corefx/cryptography/x509stores
COPY --from=build-env /publish .

ENTRYPOINT ["/app/Greeter.Service"]
