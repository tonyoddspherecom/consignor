Consignor
=========

This is a .NET portable class library for the Shipment Server, Shipment Exporter and ShipAdvisor from Edi-Soft, see http://blog.edi-soft.no.

There is a NuGet package available here: https://www.nuget.org/packages/Consignor

Getting started
===============

After you have installed the NuGet package, you can get an instance of the 3 services using the static ConsignorService class:

```C#
using Consignor;

var ss = ConsignorService.CreateShipmentServer("<server url>", "<your actorid>", "<your key>");
var sa = ConsignorService.CreateShipAdvisor("<server url>", "<your username>", "<your password>");
var se = ConsignorService.CreateShipmentExporter("<server url>", "<your username>", "<your password>");
```




