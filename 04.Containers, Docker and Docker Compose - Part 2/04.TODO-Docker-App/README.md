# 📝 Dockerized TODO App

This project is a simple TODO application consisting of:

- React frontend
- Node.js backend (Express)
- MongoDB database

## 🧩 Containers

- `frontend` - React app (port 3000)
- `backend` - Node.js app
- `mongo` - MongoDB latest image from Docker Hub

## 🔧 Setup Instructions

### 1. Build Docker Images

```bash
docker build -t todo-frontend ./frontend
docker build -t todo-backend ./backend
```

### 2. Create Docker Networks

```bash
docker network create react-express
docker network create express-mongo
```

### 3. Run MongoDB Container

```bash
docker run -d --name mongo   -v "$(pwd)/data:/data/db"   --network express-mongo   mongo:latest
```

### 4. Run Backend Container and Connect Networks

```bash
docker run -d --name backend   --network express-mongo   todo-backend

docker network connect react-express backend
```

### 5. Run Frontend Container

```bash
docker run -d --name frontend   -p 3000:3000   --network react-express   todo-frontend
```

## 🧽 Cleanup

To stop and remove containers:

```bash
docker rm -f frontend backend mongo
docker network rm react-express express-mongo
```
