FROM mcr.microsoft.com/devcontainers/dotnet:7.0-jammy

RUN <<EOF
apt update
apt install -y redis-tools
EOF

CMD exec /bin/bash -c "trap : TERM INT; sleep infinity & wait"
USER vscode
