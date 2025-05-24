#!/bin/bash

# Run Apache HTTP Server in Docker with volume
docker run -d --name my-apache-app -p 8080:80 -v $(pwd):/usr/local/apache2/htdocs/ httpd:latest
