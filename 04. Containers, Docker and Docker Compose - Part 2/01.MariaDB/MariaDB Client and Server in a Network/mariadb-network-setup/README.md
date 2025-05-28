# MariaDB Client and Server Docker Network

This project demonstrates how to run a MariaDB server and a MariaDB client in two separate containers connected via a Docker network.

## 🧱 Components

- `network-setup.sh` – Creates a custom Docker network.
- `mariadb-server.sh` – Starts the MariaDB server container.
- `mariadb-client.sh` – Launches a client container to connect to the server.

## 🔧 Usage

```bash
chmod +x *.sh
./network-setup.sh
./mariadb-server.sh
./mariadb-client.sh
```

## ✅ Result

- A running MariaDB server container.
- A client container that connects and allows SQL queries.
