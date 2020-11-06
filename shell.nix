{ pkgs ? import <nixpkgs> {} }:
pkgs.mkShell {
  buildInputs = [
    pkgs.dotnet-sdk_3
    pkgs.jetbrains.rider
  ];
  DOTNET_CLI_TELEMETRY_OPTOUT = "true";
}
