USE [TESTTCP]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FacturasPorClienteProductoMasVendidoDetalle] 
@IDcOConsulta int, 
@FechaInicio Date,
@FechaFin Date

AS
BEGIN

SELECT  TOP 1 Cabecera.ID,  Cabecera.FechaAlta, Cabecera.Cli_ID, Cabecera.Estado,Detalle.Fact_ID,Detalle.Fact_DTL_ID,Detalle.FechaAlta, Detalle.Art_ID, Detalle.Cant, Detalle.Precio,  Detalle.Monto
  FROM Clients inner join Cabecera on Cli_ID=Clients.ID inner join Detalle on Fact_ID=Cabecera.ID
  Where  Detalle.FechaAlta between @FechaFin and @FechaFin AND Clients.ID=@IDcOConsulta
    group by Cabecera.ID,  Cabecera.FechaAlta, Cabecera.Cli_ID, Cabecera.Estado,Detalle.Fact_ID,Detalle.Fact_DTL_ID,Detalle.FechaAlta, Detalle.Art_ID, Detalle.Cant, Detalle.Precio,  Detalle.Monto
	Order BY Monto desc


END
GO
