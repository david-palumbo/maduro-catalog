# Getting Started - Linux

## Install .NET Core 2.2

[Reference](https://dotnet.microsoft.com/download)

Ubuntu 18.04 x64

1. Register Microsoft Key and Feed
    ```bash
    wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb
    sudo dpkg -i packages-microsoft-prod.deb
    ```
1. Install the packages
    ```bash
    sudo add-apt-repository universe
    sudo apt-get install apt-transport-https
    sudo apt-get update
    sudo apt-get install dotnet-sdk-2.2
    ```

## Build

Navigate to the **/src** directory and run:

> dotnet build

## Run Tests

Navigate to the **/src** directory and run:

> dotnet test

## Install Docker (Optional)

These are the basic steps for installing Docker on Linux. For more comprehensive
instructions, check the reference link below.

[Reference](https://docs.docker.com/install/linux/docker-ce/ubuntu/)

Ubuntu 18.04 x64

1. Update the **apt** package index:
   ```bash
   sudo apt-get update
   ```
1. Install packages to allow **apt** to use a repository over HTTPS:
   ```bash
   sudo apt-get install \
    apt-transport-https \
    ca-certificates \
    curl \
    gnupg-agent \
    software-properties-common
   ```
1. Add Docker’s official GPG key:
   ```bash
   curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo apt-key add -
   ```
1. Install the latest version of Docker CE and containerd, or go to the next step 
   to install a specific version:
   ```bash
   sudo apt-get install docker-ce docker-ce-cli containerd.io
   ```

### Manage Docker as a non-root user

[Reference](https://docs.docker.com/install/linux/linux-postinstall/)

1. Create the **docker** group
   ```bash
   sudo groupadd docker
   ```
1. Add your user to the **docker** group
   ```bash
   sudo usermod -aG docker $USER
   ```