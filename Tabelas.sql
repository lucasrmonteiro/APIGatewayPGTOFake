USE [Pagamentos]
GO

Create Table Loja
(
	IdLoja bigint identity(1,1),
	NomeLoja Varchar(100) not null,

	constraint PK_Loja primary key (idLoja)
);

Create Table Bandeira
(
	IdBandeira bigint identity(1,1),
	NomeBandeira Varchar(100) not null,

	constraint PK_Bandeira primary key (IdBandeira)
);


Create Table GatewayPagamento
(
	IdGateway bigint identity(1,1),
	NomeGateway Varchar(100) not null,

	constraint PK_GatewayPagamento primary key (IdGateway)
);

Create Table TransacaoLoja
(
	IdTransacao bigint identity(1,1),
	IdLoja bigint not null,
	Valor money,
	StatusTransacao bit not null,

	constraint PK_Transacao primary key (IdTransacao),
	constraint FK_Loja_TransacaoLoja foreign key (IdLoja) references Loja (IdLoja)
);

Create Table ConfiguracaoGatewayLoja
(
	IdConfiguracao bigint identity(1,1),
	IdLoja bigint not null,
	IdBandeira bigint not null,
	IdGateway bigint not null,
	FlUseAntiFraude bit default(0),

	constraint PK_ConfiguracaoGatewayLoja primary key (IdConfiguracao),
	constraint FK_Loja_ConfiguracaoGatewayLoja foreign key (IdLoja) references Loja (IdLoja),
	constraint FK_Bandeira_ConfiguracaoGatewayLoja foreign key (IdBandeira) references Bandeira (IdBandeira),
	constraint FK_GatewayPagamento_ConfiguracaoGatewayLoja foreign key (IdGateway) references GatewayPagamento (IdGateway)
);

