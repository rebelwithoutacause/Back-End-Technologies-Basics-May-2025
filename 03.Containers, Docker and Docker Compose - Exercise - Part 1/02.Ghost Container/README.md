# Ghost Docker Container

This project demonstrates how to run the [Ghost](https://en.wikipedia.org/wiki/Ghost_%28blogging_platform%29) blogging platform in a Docker container.

## 📦 Requirements
- Docker installed

## 🚀 How to Run

```bash
./run.sh
```

Or run manually:

```bash
docker run -d --name ghost-container -p 3001:2368 -e NODE_ENV=development ghost:latest
```

- Detached mode
- Container name: `ghost-container`
- Maps container port `2368` to local port `3001`
- Environment variable: `NODE_ENV=development`

## 🌐 Access
Open your browser and visit:

```
http://localhost:3001
```

You should see the Ghost blog interface.  
If a "We'll be right back" message appears, it means Ghost is still loading. Just refresh the browser.

## 📌 Notes
- Make sure port 3001 is available.
