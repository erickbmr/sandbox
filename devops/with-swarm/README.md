1. create image
```
docker build -t [IMAGE_NAME]:v1 .
```

2. init swarm
```
docker swarm init
```

3. init service (run contaneirs)
```
docker service create --name [SERVICE_NAME] --replicas 3 --publish 8080:8080 [IMAGE_NAME]
```

4. scale containers
```
docker service scale [SERVICE_NAME]=5
```

5. check service
```
docker service ls
```

6. stop a container - other container will be up again
```
docker stop [CONTAINER_ID]
```

7. remove a service
```
docker service rm [SERVICE_ID]
```

