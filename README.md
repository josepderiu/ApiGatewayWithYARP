# Learning YARP

This project is a learning space dedicated to exploring and understanding the YARP (Yet Another Reverse Proxy) in .NET. The main goal is to implement an API Gateway using YARP to learn how it is configured and used in a microservices scenario.

## Project Structure

The project is divided into several parts:

- `Gateway`: This is the main entry point of the project. It is responsible for handling all incoming requests and routing them to the appropriate services. Here is where YARP is configured and used.

- `ServiceOne` and `ServiceTwo`: These are examples of microservices that perform the business logic of the application. The Gateway uses them to demonstrate how YARP can route requests to different services.

## API Routes

The `appsettings.json` file in the Gateway defines several routes under the `ReverseProxy` section. Here's a breakdown of these routes:

1. **route1**: This route matches GET requests to `api/foo/{**catch-all}`. The `{**catch-all}` is a catch-all parameter that matches any path after `api/foo/`. These requests are forwarded to `cluster1` and the path is transformed to `foo/{**catch-all}`. The original request headers and host are preserved.

2. **route2**: This route matches POST requests to `api/foo` that have a JSON body with a `name` property. The request is forwarded to `cluster1` and the path is transformed to `sayhello`.

3. **route3**: This route matches POST requests to `api/foo/{**catch-all}` that have a `name` query parameter. The request is forwarded to `cluster1` and the path is transformed to `sayhelloqueryparams/{**catch-all}`.

4. **route4**: This route matches any request to `api/bar/{**catch-all}`. The `{**catch-all}` is a catch-all parameter that matches any path after `api/bar/`. These requests are forwarded to `cluster2` and the path is transformed to `bar/{**catch-all}`. The original request headers and host are preserved.

## Getting Started

To get started with this project, you need to have .NET 8.0 installed on your machine. Once you have that, you can clone this repository and navigate to the project directory in your terminal.

## Building the Project

To build the project, navigate to the project directory in your terminal and run the `dotnet build` command.

## Running the Project

To run the project, navigate to the project directory in your terminal and run the `dotnet run` command.

## Contributing

As this is a learning project, contributions are welcome. Feel free to fork the project and submit a pull request.

## License

This project is licensed under the MIT License.
