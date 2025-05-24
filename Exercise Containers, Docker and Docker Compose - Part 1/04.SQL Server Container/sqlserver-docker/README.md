# SQL Server Docker Container

This project demonstrates how to run a Microsoft SQL Server instance in a Docker container.

## 📦 Requirements
- Docker installed

## 🚀 How to Run

```bash
./run.sh
```

Or run the container manually with:

```bash
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong!Passw0rd" \
    -p 1433:1433 --name sql-container \
    -v sqldata:/var/opt/mssql \
    -d mcr.microsoft.com/mssql/server
```

- Detached mode
- Port 1433 exposed
- Volume `sqldata` for persistent data

## 🌐 Connect
You can connect to the database on:

```
localhost:1433
```

Use SQL Server Management Studio (SSMS), Azure Data Studio, or any compatible client.

## 📌 Notes
- Make sure port 1433 is not already in use.
- The password must follow SQL Server security policy.
