#!/bin/bash

# Run Lightstreamer in Docker
docker run -d --name ls-server -p 80:8080 lightstreamer:latest
