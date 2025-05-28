#!/bin/bash
# Run MariaDB Server container
docker run -d \
  --name mariadb_server \
  --network mariadb_net \
  -e MARIADB_ROOT_PASSWORD=rootpass \
  -e MARIADB_USER=myuser \
  -e MARIADB_PASSWORD=mypassword \
  -e MARIADB_DATABASE=mydatabase \
  mariadb
