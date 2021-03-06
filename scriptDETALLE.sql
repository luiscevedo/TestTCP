USE [TESTTCP]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle](
	[Fact_ID] [int] NOT NULL,
	[Fact_DTL_ID] [int] IDENTITY(1,1) NOT NULL,
	[FechaAlta] [date] NOT NULL,
	[Art_ID] [nvarchar](50) NOT NULL,
	[Cant] [decimal](18, 2) NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Monto] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Factura_Detalle_1] PRIMARY KEY CLUSTERED 
(
	[Fact_DTL_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Detalle_Factura_Cabecera] FOREIGN KEY([Fact_ID])
REFERENCES [dbo].[Cabecera] ([ID])
GO
ALTER TABLE [dbo].[Detalle] CHECK CONSTRAINT [FK_Factura_Detalle_Factura_Cabecera]
GO
