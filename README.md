# ASP.NET-Core-Load-Balancing-with-Docker

使用 ASP.NET Core application with RESTful API
使用 Docker and NGINX as reverse proxy 實現 Load balancing

```
docker-compose build
docker-compose up -d --scale core-app=4 --no-recreate
```

注意: 由於 Nginx 免費版限制, Load balancing 最多可配置4個節點.