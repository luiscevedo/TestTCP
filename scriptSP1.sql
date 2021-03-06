USE [TESTTCP]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[FacturasPorClienteProductoMasVendido] 
@IDcOConsulta int, 
@FechaInicio Date,
@FechaFin Date

AS
BEGIN

SELECT  TOP 1 Cabecera.ID,  Cabecera.FechaAlta, Cabecera.Cli_ID, Cabecera.Estado,Detalle.Fact_DTL_ID, Detalle.Art_ID, Clients.RazonSocial
  FROM Clients inner join Cabecera on Cli_ID=Clients.ID inner join Detalle on Fact_ID=Cabecera.ID
  Where  Detalle.FechaAlta between @FechaInicio and @FechaFin AND Clients.ID=@IDcOConsulta 
    group by Monto,Cabecera.ID,Cabecera.FechaAlta, Cabecera.Cli_ID, Cabecera.Estado,Detalle.Fact_DTL_ID, Detalle.Art_ID, Clients.RazonSocial
	Order BY Monto desc

END
GO
