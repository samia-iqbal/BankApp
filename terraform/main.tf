terraform {
    required_providers {
        azurerm = {
            source  = "hashicorp/azurerm"
            version = "~> 2.46.0"
        }    
    }    
}

 

provider "azurerm" {
    features {}
}
variable "services" {
  description = "List of web apps"
  type        = map
  default     = {
    FrontEnd = {
      name="samia-frontEndController"
    },
    AccountNumber = {
      name="samia-AccountNumber"
    },
    Names = {
      name="samia-namesController"
    },
    Merge = {
      name="samia-mergeController"
    },
  }
}

 

resource "azurerm_resource_group" "rg" {
    name     = "samiaiqbal"
    location = "uksouth"
}
resource "azurerm_app_service_plan" "app-service-plan" {
  name = "samia-appservice"
  resource_group_name = azurerm_resource_group.rg.name
  location = azurerm_resource_group.rg.location
  kind = "Windows"
  reserved = false
  sku {
    tier = "Basic"
    size = "B1"
  }
}
resource "azurerm_app_service" "webapp" {
  
   for_each = var.services
    name = each.value.name
    resource_group_name = azurerm_resource_group.rg.name
    location = azurerm_resource_group.rg.location
    app_service_plan_id = azurerm_app_service_plan.app-service-plan.id

 

    site_config{
    dotnet_framework_version = "v5.0"

 


}

 

app_settings ={
"AppSettings__accountNumberServiceURL" : "https://samia-accountnumber.azurewebsites.net"
"AppSettings__nameServiceURL" : "https://samia-namescontroller.azurewebsites.net"
"AppSettings__mergedServiceURL" : "http://samia-mergecontroller.azurewebsites.net"

 

}
}