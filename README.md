# Registration
    # Source: This is the source folder will all directories
        ## Common: This contains files that will be shared by services.
            * Commands
            * Events
            * Bus Client configuration and helper methods (RabbitMq)
            * ServiceHost: This is responsible for subscribing to messages (Commands and Events)

        ## Sales.Api:
            * Handlers: This will handle events 
            * Controllers: Contains controllers all the services
            * appseting.josn file: has rabbitMq section will configuration
            * Program: Will use serviceHost from Common project to suscribe to events, build and run
            * StartUp: Will use rabbitMq settings/configurations on Common project and also resolve dependencies

        ## Services:
            * Registration: Service responsible for registering users/clients
            * Handlers: This will handle user registration commands
            * appseting.josn file: has rabbitMq section will configuration
            * Program: Will use serviceHost from Common project to suscribe to commands, build and run
            * StartUp: Will use rabbitMq settings/configurations on Common project and also resolve dependencies