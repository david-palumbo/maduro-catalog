# Getting Started

## Platform Configuration

- [Linux](linux.md)
- [Windows](windows.md)

## Authentication Configuration

### Azure Active Directory

1. Create a new application registration in you Azure Active Directory subscription
2. Add a new file in the **/src/Maduro.Catalog.Api** folder named **appsettings.local.json**
3. Add the following contents to the file using your own client ID and tenant ID
   ```json
    {
        "Authentication": {
            "AzureActiveDirectory": {
                "ClientId": "00000000-0000-0000-0000-000000000000",
                "TenantId": "00000000-0000-0000-0000-000000000000"
            } 
        } 
    }
   ```