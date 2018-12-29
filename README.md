# TrumpKnowsGrpc

A trivial gRPC implementation that uses a C# server (using .NET core) and a Node.js stub (or in other words, client).

## Prerequisites
* Ensure [Node.js](https://nodejs.org/en/download/) and [.NET core](https://www.microsoft.com/net/learn/get-started) is installed on your system.

## Usage

### Server
* From the root of the project, start the gRPC server by executing the following:
   1. `cd TrumpKnowsGrpcServer/`
   2. `dotnet build`
   3. `dotnet run`
### Client
* To interact with the server using the Node.js client, from a separate terminal window (also at the root of the project):
   1. `cd trump-knows-grpc-client/`
   2. `npm install`
   3. `node index.js`, as many times as you would like

## Contributing
Any changes to the protocol buffer definitions in the `protos/trump.proto` file will require re-generation of the C# server interfaces, as described on the [gRPC site](https://grpc.io/docs/tutorials/basic/csharp.html#generating-client-and-server-code).

## TODO (?)
Dynamically retrieve Tweets from Twitter API's rather than using static JSON.
