#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained (no public spec available)
# --reject-unknown-enum-values is only safe on a build that narrows it to enums which cannot appear in
# a response; an older one accepts the flag and hardens every enum, so ordinary replies start throwing.
# `autosdk capabilities --require` asks the build itself, which replaces both a version floor (had to be
# looked up after each publish, and moved once already) and a grep over help-text prose. A CLI without
# the subcommand fails the call, so this is fail-closed.
require_autosdk_capability() {
  if ! autosdk capabilities --require "$1" >/dev/null 2>&1; then
    echo "error: this autosdk.cli does not support '$1'." >&2
    echo "       Run: dotnet tool update --global autosdk.cli --prerelease" >&2
    exit 1
  fi
}
install_autosdk_cli
require_autosdk_capability behavior:request-scoped-enum-rejection

rm -rf Generated

# Serper has no public OpenAPI spec — openapi.yaml is manually maintained from docs.
# Auth: --security-scheme sends the API key directly as X-API-KEY header
#       (no jq/yq conversion or PrepareRequest hook needed).
autosdk generate openapi.yaml \
  --namespace Serper \
  --clientClassName SerperClient \
  --targetFramework net10.0 \
  --output Generated \
  --reject-unknown-enum-values \
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
