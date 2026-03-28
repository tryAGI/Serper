#!/usr/bin/env bash
set -euo pipefail

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease

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
