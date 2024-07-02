# Content Distribution Service

## Build the Docker image:
```shell
docker build -t dacm .
```

## Run the Docker container
```shell
docker run -d -p 8080:80 --name dacm dacm
```

## Access the application
Open your web browser and navigate to http://localhost:8080/swagger to see the Swagger UI for your API.