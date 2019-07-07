# maduro-catalog
Cigar catalog. Part of the [maduro](https://github.com/david-palumbo/maduro) project.

- [Source](https://github.com/david-palumbo/maduro-catalog)
- [Pipelines](https://dev.azure.com/david-palumbo/maduro/_build)
- [Boards](https://dev.azure.com/david-palumbo/maduro/_workitems/recentlyupdated)

[![Build Status](https://dev.azure.com/david-palumbo/maduro/_apis/build/status/david-palumbo.maduro-catalog?branchName=master)](https://dev.azure.com/david-palumbo/maduro/_build/latest?definitionId=1&branchName=master)

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=david-palumbo_maduro-catalog&metric=alert_status)](https://sonarcloud.io/dashboard?id=david-palumbo_maduro-catalog)

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

#### Run Tests

Navigate to the **/src** directory and run:

> dotnet test

## Code Coverage

Install Report Generator

> dotnet tool install --global dotnet-reportgenerator-globaltool --version 4.2.2

Generate the code coverage report by executing the **generate-test-report.bat** file
in the **/tasks** folder.