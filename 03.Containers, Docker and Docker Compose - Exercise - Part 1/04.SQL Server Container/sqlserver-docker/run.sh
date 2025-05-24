#!/bin/bash

# Run SQL Server in Docker
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong!Passw0rd" \
    -p 1433:1433 --name sql-container \
    -v sqldata:/var/opt/mssql \
    -d mcr.microsoft.com/mssql/server
