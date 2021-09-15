USE [TESTTCP]
GO
/****** Object:  StoredProcedure [dbo].[FacturasPorClienteProductoMasVendidoDetalle]    Script Date: 15/9/2021 02:04:48 ******/
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
  Where  Detalle.FechaAlta between '2021-09-01' and '2021-09-05' AND Clients.ID=1008 
    group by Cabecera.ID,  Cabecera.FechaAlta, Cabecera.Cli_ID, Cabecera.Estado,Detalle.Fact_ID,Detalle.Fact_DTL_ID,Detalle.FechaAlta, Detalle.Art_ID, Detalle.Cant, Detalle.Precio,  Detalle.Monto
	Order BY Monto desc


END
GO
