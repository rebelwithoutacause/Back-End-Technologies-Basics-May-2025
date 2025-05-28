# Tracker App

This repository contains a simple Vue.js front-end app to keep track of daily duties.

## Docker

The app is built and served with NGINX inside a Docker container.

### Build the Docker Image

```bash
docker build -t your-dockerhub-username/tracker_app .
```

### Push to Docker Hub

```bash
docker login
docker push your-dockerhub-username/tracker_app
```

### Run the Container Locally

```bash
docker run -d -p 8080:80 your-dockerhub-username/tracker_app
```

Open your browser at http://localhost:8080 to see the app running.