# SimpleInventario
Sistema de inventario simple desarrollado con WinForms, NetFramework 4.7.2

Este sistema cuenta con: 
+ Catalogo de unidades de medida
+ Catalogo de productos o servicio
+ Entradas de producto o servicio
+ Salidas de producto o servicio
+ Reporte de Existencias
+ Reporte de Movimientos (kardex) por producto

Instalar LocalDb desde SQL Server Express 2016-2019

[Instalar LocalDb](https://learn.microsoft.com/es-es/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver16#installation-media)

Descargar e Instalar Extension Microsoft Rdlc Report Designer Para Visual Studio 2022 

[Microsoft Rdlc Report Designer 2022](https://marketplace.visualstudio.com/items?itemName=ProBITools.MicrosoftRdlcReportDesignerforVisualStudio2022)

Desarrollo de pruebas con LocalDb 2019, al ejecutar el projecto se crea la base de datos DBSimpleInventario


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