#!/bin/bash

# Run Ghost in Docker
docker run -d --name ghost-container -p 3001:2368 -e NODE_ENV=development ghost:latest
