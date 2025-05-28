#!/bin/bash
# Connect to MariaDB Server via client container
docker run -it --rm \
  --name mariadb_client \
  --network mariadb_net \
  mariadb \
  mariadb -h mariadb_server -u myuser -p
