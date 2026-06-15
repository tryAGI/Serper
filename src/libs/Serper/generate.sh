#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (no public spec available)

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

# Serper has no public OpenAPI spec — openapi.yaml is manually maintained from docs.
# Auth: --security-scheme sends the API key directly as X-API-KEY header
#       (no jq/yq conversion or PrepareRequest hook needed).
autosdk generate openapi.yaml \
  --namespace Serper \
  --clientClassName SerperClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-API-KEY

rm -rf ../../cli/Serper.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Serper.CLI \
  --sdk-project ../../libs/Serper/Serper.csproj \
  --targetFramework net10.0 \
  --namespace Serper \
  --clientClassName SerperClient \
  --package-id Serper.CLI \
  --tool-command-name serper \
  --user-secrets-id Serper.CLI \
  --api-key-env-var SERPER_API_KEY \
  --base-url-env-var SERPER_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-API-KEY
