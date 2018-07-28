CREATE PROCEDURE [dbo].[InsertCliente]
	@NomeCliente varchar(max),
	@EmailCliente varchar(max)
AS
begin
	insert into Clientes(NomeCliente, EmailCliente)
	values (@NomeCliente, @EmailCliente);
end
