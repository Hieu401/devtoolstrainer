namespace DevToolsTrainer

module QuestionAnswers =

    let dockerFile: string = "[
	{\"Which instruction is used to set a base image to build on top from?\": \"FROM\"},
	{\"Which instruction is used to run a command as a layer for the new image?\": \"RUN\"},
	{\"Which instruction is used to run a command with changeable arguments when the container is started?\": \"CMD\"},
	{\"Which instruction is used to add metadata to the containers of the image?\": \"LABEL\"},
	{\"Which instruction is used to have the containers of the image listen to certain ports by default?\": \"EXPOSE\"},
	{\"Which instruction is used to add environment variables to the containers of the image?\": \"ENV\"},
	{\"Which advanced instruction is used to add files to the filesystem of the containers?\": \"ADD\"},
	{\"Which basic instruction is used to add files to the filesystem of the containers?\": \"COPY\"},
	{\"Which instruction is used to run a command with unchangeable arguments when the container is started?\": \"ENTRYPOINT\"},
	{\"Which instruction is used to create a mount point for volumes on the Docker of the host?\": \"VOLUME\"},
	{\"Which instruction is used to set the standard username when running CMD, RUN and ENTRYPOINT instructions?\": \"USER\"},
	{\"Which instruction is used to set the woking directory for the RUN, CMD, ENTRYPOINT, ADD and COPY instructions?\": \"WORKDIR\"},
	{\"Which instruction is used to add instructions when this image is used as base image for another image?\": \"ONBUILD\"},
	{\"Which instruction is used to set the default stopsignal used to stop the containers of this image?\": \"STOPSIGNAL\"},
	{\"Which instruction is used to set the exact method used to check the health status of the docker containers?\": \"HEALTHCHECK\"},
	{\"Which instruction is used to set the default shell used in the containers of this image when running shell commands?\": \"SHELL\"}
    ]"

    let imageBuild: string = "[
	{\"Get all locally stored images\": \"docker image ls\"},
	{\"Build an imagine using a docker file in the current folder\": \"docker build .\"},
	{\"Build and tag an imagine using a docker file in the current folder as test:dev\": \"docker build -t test:dev .\"},
	{\"Build an imagine using a docker file in your repository https://github.com/user/reponame\": \"docker build https://github.com/user/reponame\"},
	{\"Create an image from container qwer1234 and name it testapi\": \"docker commit qwer1234 testapi\"},
	{\"Remove image testapi:v1\": \"docker rmi testapi:v1\"},
	{\"Tag an existing image testapi:v1 to create a new unique image testapi:v2\": \"docker image tag testapi:v1 testapi:v2\"}
    ]"

    let imageRepository: string = "[
	{\"Login your docker hub\": \"docker login\"},
	{\"Pull image testapi:v1 from registry\": \"docker image pull testapi:v1\"},
	{\"Push image testapi:v1 to registry of awesomeusername\": \"docker image push awesomeusername/testapi:v1\"}
    ]"

    let imageInfo: string = "[
	{\"Show history of image testapi:v1\": \"docker history testapi:v1\"}
    ]"

    let containers: string = "[
	{\"Get all live containers\": \"docker ps\"},
	{\"Get live and stopped containers\": \"docker ps -a\"},
	{\"Start container qwer1234\": \"docker start qwer1234\"},
	{\"Stop container qwer1234\": \"docker stop qwer1234\"},
	{\"Stop and restart container qwer1234\": \"docker restart qwer1234\"},
	{\"Pause the processes in the running container qwer1234\": \"docker pause qwer1234\"},
	{\"Unpause the processes in the running container qwer1234\": \"docker unpause qwer1234\"},
	{\"Stop the container qwer1234 using SIGKILL on the inside\": \"docker kill qwer1234\"},
	{\"Create a new container from image test:dev without starting it\": \"docker create test:dev\"},
	{\"Run docker from image testapi:v1\": \"docker run testapi:v1\"},
	{\"Run container from image testapi:v1 and remove it after it stops\": \"docker run --rm testapi:v1\"},
	{\"Run container from image testapi:v1 and run the ls command in it after start\": \"docker run -it testapi:v1 ls\"},
	{\"Run container from image testapi:v1 and open its shell after start\": \"docker run -it testapi:v1 sh\"},
	{\"Run container from image testapi:v1 in the background\": \"docker run -d testapi:v1\"},
	{\"Run container from image testapi:v1 and name it helloworld\": \"docker run --name hellworld testapi:v1\"},
	{\"Run container from image testapi:v1 and connect it to user-defined network \"mynetwork\"\": \"docker run --network=\"mynetwork\" testapi:v1\"},
	{\"Remove the container qwer1234\": \"docker rm qwer1234\"},
	{\"Update the configurations of container qwer1234\": \"docker update qwer1234\"},
	{\"Rename container qwer1234 to 1234qwer\": \"docker rename qwer1234 1234qwer\"},
	{\"Run the ls command in the qwer1234 docker container\": \"docker exec qwer1234 ls\"}
    ]"

    let containerInfo: string = "[
	{\"Get port mapping from container qwer1234\": \"docker port qwer1234\"},
	{\"List logs from container qwer1234\": \"docker logs qwer1234\"},
	{\"List real time events from your docker\": \"docker events\"},
	{\"List running processes in container qwer1234\": \"docker top qwer1234\"},
	{\"List resource usage of container qwer1234\": \"docker stats qwer1234\"},
        {\"Show changes to file system of container qwer1234\": \"docker diff qwer1234\"}
    ]"

    let networking: string = "[
	{\"List all networks\": \"docker network ls\"},
	{\"Remove network testnetwork\": \"docker network rm testnetwork\"},
	{\"Show info of network testnetwork\": \"docker network inspect testnetwork\"},
	{\"Connect container qwer1234 to network testnetwork\": \"docker network connect testnetwork qwer1234\"},
	{\"Disconnect container qwer1234 from network testnetwork\": \"docker network diconnect testnetwork qwer1234\"},
	{\"Create a new network named my_network\": \"docker network create my_network\"}
    ]"

    let storage: string = "[
	{\"Create a new volume called db_storage\": \"docker volume create db_storage\"},
	{\"View all volumes\": \"docker volume ls\"},
	{\"View the details of volume db_storage\": \"docker volume inspect db_storage\"},
	{\"Remove the volume db_storage\": \"docker volume rm db_storage\"},
	{\"Where is the volume db_storage stored on Linux by default?\": \"var/lib/docker/volumes/db_storage\"}
    ]"

    let dockerComposeYaml: string = "[
	{\"Define a service api1 whos image which should be named iapi1 is build using the dockerfile in current directory\": \"services: api1: build: . image: iapi1\"},
	{\"Define a service api1 which is build from image iapi1\": \"services: api1: image: iapi1\"},
	{\"Define a service api1 whos container name will be api1\": \"services: api1: container_name: api1\"},
	{\"Define a service api1 with a volume at host location /var/lib/docker/volumes/api1_volume to /var/lib/mysql\": \"services: api1: volumes: - /var/lib/docker/volumes/api1_volume:/var/lib/mysql\"},
	{\"Define a service api1 and overwrite the start command of that container with \'nginx\'\": \"services: api1: command: nginx\"},
	{\"Define a service api1 whos environment variable db_port should be 4321 and db_host should be localhost\": \"services: api1: environment: - db_port: 4321 - do_host: localhost\"},
	{\"Define a service api1 whos environment variables can be retrieved at ./.env\": \"services: api1: env_file: ./.env\"},
	{\"Define a service api1 that tries to restart up to 3 time upon failure\": \"services: api1: restart: on-failure:3\"},
	{\"Define a service api1 that is connected to networks network1 and network2\": \"services: api1: networks: - network1 - network2\"},
	{\"Define a service api1 whos port 80 is expose to host port 8080\": \"services: api1: ports: \'8080:80\'\"},
	{\"Define a service api1 that depends on containers db and nginx to be up in order to start\": \"services: api1: depends_on: - db - nginx\"},
	{\"Define a bridge network network1\": \"networks: network1: driver: bridge\"},
	{\"Define an existing network network1\": \"networks: network1: external: true\"},
	{\"Define a named volume called postgres-data to be used in services\": \"volumes: postgres-data:\"}
    ]"

    let dockerCompose: string = "[
	{\"Build the images and start the containers for the services\": \"docker-compose up\"},
	{\"Stop the service containers and remove them\": \"docker-compose down\"},
	{\"Stop the services\": \"docker-compose stop\"},
	{\"Start the services\": \"docker-compose start\"},
	{\"Build the images for the services\": \"docker-compose build\"},
	{\"Create the containers for the services\": \"docker-compose create\"},
	{\"Restart the containers of the services\": \"docker-compose restart\"},
	{\"Pause the service processes\": \"docker-compose pause\"},
	{\"Unpause the service processes\": \"docker-compose unpause\"},
	{\"Build the images and start the containers for the services using the configuration file at ../docker-compose.yml\": \"docker-compose -f ../docker-compose.yml up\"}
    ]"
    let swarm: string = "[]"

    let createrepo: string = "[
	{\"Initialize a new repo in current project\": \"git init\"},
	{\"Upload current repo to remote at https://github.com/Developer/projectname and name it origin\": \"git remote add origin https://github.com/Developer/projectname\"},
	{\"Download project from existing remote repository https://github.com/Developer/projectname to current folder\": \"git clone https://github.com/Developer/projectname\"}
    ]"
    let gitInfo: string= "[
	{\"Show changes to files not yet staged\": \"git diff\"},
	{\"Show changes to staged files\": \"git diff --cached\"},
	{\"Show changes to staged and unstaged files\": \"git diff HEAD\"},
	{\"Show changes to commit qwer1234 and asdf5678\": \"git diff qwer1234 asdf5678\"},
	{\"Show author and change date of controller.js file\": \"git blame controller.js\"},
	{\"Show file changes to commit asdf1234\": \"git show asdf1234\"},
	{\"Show file changes to commit asdf1234, specifically test.js\": \"git show asdf1234:test.js\"},
	{\"Show full change history\": \"git log\"},
	{\"Show change history for file/directory test.js\": \"git log test.js\"}
    ]"
    let branch: string = "[
	{\"List all local branches\":\"git branch\"},
	{\"Checkout to branch new_branch\":\"git checkout new_branch\"},
	{\"Create a new branch called new_branch\":\"git branch new_branch\"},
	{\"Delete branch new_branch\":\"git branch -d new_branch\"},
	{\"Merge new_branch in current branch\":\"git merge new_branch\"}
    ]"
    let commit: string = "[
	{\"Show changed files\": \"git status\"},
	{\"Stage file test.js\":\"git add test.js\"},
	{\"Stage all changed files\":\"git add .\"},
	{\"Commit staged files with the message \'First commit\'\":\"git commit -m \'First commit\'\"},
	{\"Unstage test.js, but keep changes\":\"git reset test.js\"}
    ]"
    let remote: string = "[
	{\"Update local repo with all the latest changes from remote repository\":\"git fetch\"},
	{\"Get all changes from remote and merge in local\":\"git pull\"},
	{\"Get all changes from remote and rebase in local\":\"git pull --rebase\"},
	{\"Update remote repos with local repos\":\"git push\"},
	{\"Connect and update current branch to remote repos origin, branch master\":\"git push --set-upstream origin master\"}
    ]" 

    let nginxBasicDirectives: string = "[
	{\"\": \"\"},
	{\"\": \"\"},
	{\"\": \"\"},
	{\"\": \"\"}
    ]"

    let nginxStaticFilesDirectives: string = "[
	{\"\": \"\"},
	{\"\": \"\"},
	{\"\": \"\"},
	{\"\": \"\"}
    ]"

    let nginxReverseProxyDirectives: string = "[
	{\"\": \"\"}
    ]"

    let nginxSSLDirectives: string = "[
	{\"\": \"\"}
    ]"

    let nginxLoggingDirectives: string = "[
	{\"\": \"\"}
    ]"

    let nginxCommands: string = "[
	{\"Start the nginx webserver\": \"nginx\"},
	{\"Stop the nginx webserver\": \"nginx -s stop\"},
	{\"Reload the nginx webserver\": \"nginx -s reload\"},
	{\"Reopen log files\": \"nginx -s reopen\"},
	{\"Stop nginx webserver gracefully\": \"nginx -s quit\"}
    ]"

    let nginxFastCGICacheDirextives: string = "[]"

    let nginxMIMETypes: string = "[]"