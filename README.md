# maduro-catalog
Cigar catalog

## Getting Started

### Linux

#### Install .NET Core 2.2

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

#### Build

Navigate to the **/src** directory and run:

> dotnet build