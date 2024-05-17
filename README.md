# SimpleInventario
Sistema de inventario simple desarrollado con WinForms, NetFramework 4.7.2

Este sistema cuenta con: 
+ Catalogo de unidades de medida
+ Catalogo de productos o servicio
+ Entradas de producto o servicio
+ Salidas de producto o servicio
+ Reporte de Existencias
+ Reporte de Movimientos (kardex) por producto

Desarrollo de pruebas con LocalDb 2019, al ejecutar el projecto se crea la base de datos DBSimpleInventario

Se puede instalar LocalDb desde SQL Server Express 2016-2019

https://learn.microsoft.com/es-es/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver16#installation-media

Este programa se compilo y ejecuto con Visual Studio 2022 Community Edition.

Si no se instalan los paquetes automaticamente reinstalarlos desde menu
Herramientas>Administrador de paquetes NuGet>Consola del administrador de paquetes

Update-Package -Reinstall


Este proyecto utiliza:
+ Entity Framework
+ MaterialSkin.2
+ Microsoft.ReportingServices.ReportViewerControl.Winforms
+ Microsoft.SqlServer.Server
+ Microsoft.SqlServer.Types
+ DataAnnotations