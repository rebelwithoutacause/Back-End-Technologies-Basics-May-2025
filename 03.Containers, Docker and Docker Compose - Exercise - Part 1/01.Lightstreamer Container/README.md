# Lightstreamer Docker Container

This project demonstrates how to run the [Lightstreamer](https://lightstreamer.com) server in a Docker container.

## 📦 Requirements
- Docker installed

## 🚀 How to Run

```bash
./run.sh
```

Or run manually:

```bash
docker run -d --name ls-server -p 80:8080 lightstreamer:latest
```

- Detached mode
- Container name: `ls-server`
- Maps container port `8080` to local port `80`

## 🌐 Access
Open your browser and visit:

```
http://localhost
```

The Lightstreamer server should be up and running.

## 📌 Notes
Make sure port 80 is not already in use.
