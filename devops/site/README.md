1. create image
```
docker build -t [IMAGE_NAME]:v1 .
```

2. run image in new container
```
docker run -d -p 8080:80 [IMAGE_NAME]:v1
```

3. check container running
```
docker container ps
```

4. kill container
```
docker container ps [ID]
```
