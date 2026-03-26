#!/usr/bin/env bash
set -euo pipefail

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

# Serper has no public OpenAPI spec — openapi.yaml is manually maintained from docs
yq -i '
  del(.components.securitySchemes) |
  .components.securitySchemes.BearerAuth = {"type": "http", "scheme": "bearer"} |
  del(.security) |
  .security = [{"BearerAuth": []}]
' openapi.yaml

autosdk generate openapi.yaml \
  --namespace Serper \
  --clientClassName SerperClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
