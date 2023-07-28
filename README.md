# sandbox-compose-devc

Example devcontainer repo using docker-compose for a .NET and a Redis container.

This is a simple two-container devcontainer using Docker Compose.

The main container is a .NET development container and uses the same base container as you would
get if you created a dev container in VSCode and chose .NET container as the base.

The second container is a Redis server.  This is used to demonstrate other services and also the simplicity
of networking with other containers in a compose.

The .NET `redis-client` project simply connects to the Redis server via the service name defined in the
Docker Compose `compose.yaml` file, `redis`.

# To Use

VSCode with Dev Containers and Remote Repositories extensions.

To create dev container, execute command (`Cmd-Shift-P`) `Dev Container: Clone Repository in Volume`

After changing anything under `./.devcontainer/`, run `Dev Containers: Rebuild Container`.  Your repo folder will be preserved, but you'll lose any other changes to the container.  So don't do custom things from the terminal in the container.  Make those changes in the container definition.

# Reference

* [Dev Containers in VSCode](https://code.visualstudio.com/docs/devcontainers/containers)
* [Dev Container Base Images](https://github.com/devcontainers/images/tree/main/src)
