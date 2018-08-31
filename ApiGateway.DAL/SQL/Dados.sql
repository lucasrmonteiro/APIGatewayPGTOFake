USE [Pagamentos]
GO

insert into Loja values ('Loja A');
insert into Loja values ('Loja B');
insert into Loja values ('Loja C');


insert into Bandeira values ('Visa');
insert into Bandeira values ('Mastercard');

insert into GatewayPagamento values ('Stone');
insert into GatewayPagamento values ('Cielo');


insert into ConfiguracaoGatewayLoja values (1, 1 ,1 ,0)
insert into ConfiguracaoGatewayLoja values (1, 2 ,1 ,0)

insert into ConfiguracaoGatewayLoja values (2, 1 ,1 ,1)
insert into ConfiguracaoGatewayLoja values (2, 1 ,1 ,1)

insert into ConfiguracaoGatewayLoja values (3, 1 ,1 ,1)
insert into ConfiguracaoGatewayLoja values (3, 1 ,1 ,1)
