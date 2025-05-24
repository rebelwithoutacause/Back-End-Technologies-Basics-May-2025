# Apache HTTP Server Docker Container

This project demonstrates how to run the Apache HTTP Server in a Docker container with a volume mount.

## 📦 Requirements
- Docker installed

## 📁 Local Directory Structure
Place the files you want to serve inside the current directory (where `run.sh` is located).

## 🚀 How to Run

```bash
./run.sh
```

Or run manually:

```bash
docker run -d --name my-apache-app -p 8080:80 -v $(pwd):/usr/local/apache2/htdocs/ httpd:latest
```

- Detached mode
- Container name: `my-apache-app`
- Maps container port `80` to local port `8080`
- Volume maps current directory to `/usr/local/apache2/htdocs/` in the container

## 🌐 Access
Open your browser and visit:

```
http://localhost:8080
```

You should see a list of files and folders from your current local directory. If you only see the "It works!" page, the volume wasn't mounted correctly.

## 📝 Notes
- Make sure to run this from a directory with at least one `.html` or other static file.
