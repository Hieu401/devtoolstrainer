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
	{\"Which instruction is used to set the default shell used in the containers of this image when running shell commands?\": \"SHELL\"},
    ]"

    let imageBuild: string = "[
	{\"Get all locally stored images\": \"docker images ls\"},
	{\"Build an imagine using a docker file in the current folder\": \"docker build .\"},
	{\"Build and tag an imagine using a docker file in the current folder as test:dev\": \"docker build -t test:dev . \"},
	{\"Build an imagine using a docker file in your repository https://github.com/user/reponame\": \"docker build https://github.com/user/reponame\"},
	{\"Create an image from container qwer1234 and name it testapi\": \"docker commit qwer1234 testapi\"},
	{\"Remove image testapi:v1\": \"docker rmi testapi:v1\"},
	{\"Tag an existing image testapi:v1 to create a new unique image\": \"docker image tag testapi:v1 testapi:v2\"}
    ]"

    let imageRepository: string = "[
	{\"Login your docker hub\": \"docker login\"},
	{\"Pull image testapi:v1 from registry\": \"docker image pull testapi:v1\"},
	{\"Push image testapi:v1 to registry\": \"docker image push testapi:v1\"}
    ]"

    let imageInfo: string = "[
	{\"Show history of image testapi:v1\": \"docker history testapi:v1\"},
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
	{\"Run container from image testapi:v1 and open its shell after start\": \"docker run -it testapi:v1 bash\"},
	{\"Remove the container qwer1234\": \"docker rm qwer1234\"},
	{\"Update the configurations of container qwer1234\": \"docker update qwer1234\"},
	{\"Rename container qwer1234 to 1234qwer\": \"docker rename qwer1234 1234qwer\"},
	{\"Run the ls command in the qwer1234 docker container\": \"docker exec qwer1234 ls\"}
    ]"

    let containerInfo: string = "[
	{\"Get port mapping from container qwer1234\": \"docker port qwer1234\"},
	{\"List logs from container qwer1234\": \"docker logs qwer1234\"},
	{\"List real time events from container qwer1234\": \"docker events qwer1234\"},
	{\"List running processes in container qwer1234\": \"docker top qwer1234\"},
	{\"List resource usage of container qwer1234\": \"docker stats qwer1234\"},
        {\"Show changes to file system of container qwer1234\": \"docker diff qwer1234\"}
    ]"

    let networking: string = "[
	{\"List all networks\": \"docker network ls\"},
	{\"Remove network testnetwork\": \"docker network rm testnetwork\"},
	{\"Show info of network testnetwork\": \"docker network inspect testnetwork\"},
	{\"Connect container qwer1234 to network testnetwork\": \"docker network connect testnetwork qwer1234\"},
	{\"Disconnect container qwer1234 from network testnetwork\": \"docker network diconnect testnetwork qwer1234\"}
    ]"

    let storage: string = "[]"

    let dockerComposeYaml: string = "[]"

    let dockerCompose: string = "[]"
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