CREATE DATABASE imobiliaria_lp2;

CREATE TABLE cliente (
	id INT NOT NULL AUTO_INCREMENT,
	nome VARCHAR(64) NOT NULL,
	cpf VARCHAR(16) NOT NULL,
	rg VARCHAR(16),
	telefone VARCHAR(16) NOT NULL,
	email VARCHAR(64),
	dataNasc VARCHAR(16),
	ativo INT NOT NULL,

	PRIMARY KEY(id)
);

CREATE TABLE funcionario (
	id INT NOT NULL AUTO_INCREMENT,
	nome VARCHAR(64) NOT NULL,
	telefone VARCHAR(16) NOT NULL,
	email VARCHAR(64) NOT NULL,
	funcao VARCHAR(32) NOT NULL,
	creci VARCHAR(32),
	login VARCHAR(64),
	senha VARCHAR(64),
	ativo INT NOT NULL,
	acesso INT NOT NULL, -- 1 para gerente e 0 para corretor

	PRIMARY KEY(id)
);

CREATE TABLE proprietario (
	id INT NOT NULL AUTO_INCREMENT,
	nome VARCHAR(64) NOT NULL,
	cpf VARCHAR(16) NOT NULL,
	rg VARCHAR(16),
	dataNasc VARCHAR(16),
	telefone VARCHAR(16) NOT NULL,
	email VARCHAR(64),
	rua VARCHAR(128),
	numero INT,
	bairro VARCHAR(64),
	cidade VARCHAR(32),
	ativo INT NOT NULL,

	PRIMARY KEY(id)
);

CREATE TABLE imovel (
	id INT NOT NULL AUTO_INCREMENT,
	tipo VARCHAR(32) NOT NULL, -- casa/apto./terreno/chácara/sítio...
	categoria VARCHAR(16) NOT NULL, -- venda ou aluguel ou aluguel/venda
	metragem FLOAT,
	frente FLOAT,
	fundo FLOAT,
	valor FLOAT,
	bairro VARCHAR(64),
	rua VARCHAR(128),
	cidade VARCHAR(64),
	numero INT,
	id_proprietario INT,
	vendido INT, -- 0 ou 1
	alugado INT, -- 0 ou 1

	PRIMARY KEY(id),
	FOREIGN KEY(id_proprietario)
		REFERENCES proprietario(id)
);

CREATE TABLE vendas (
	id INT NOT NULL AUTO_INCREMENT,
	id_proprietario INT,
	nome_proprietario VARCHAR(64),
	cpf_proprietario VARCHAR(16),
	rg_proprietario VARCHAR(16),
	telefone_proprietario VARCHAR(16),
	email_proprietario VARCHAR(64),
	id_cliente INT,
	nome_cliente VARCHAR(64),
	cpf_cliente VARCHAR(16),
	rg_cliente VARCHAR(16),
	telefone_cliente VARCHAR(16),
	email_cliente VARCHAR(64),
	id_imovel INT,
	tipo_imovel VARCHAR(32), -- casa/apto./terreno/chácara/sítio...
	categoria_imovel VARCHAR(16),
	valor_imovel FLOAT,
	bairro_imovel VARCHAR(64),
	rua_imovel VARCHAR(128),
	cidade_imovel VARCHAR(64),
	numero_imovel INT,
	id_funcionario INT,
	nome_funcionario VARCHAR(64),
	telefone_funcionario VARCHAR(16),
	email_funcionario VARCHAR(64),
	creci_funcionario VARCHAR(32),
	dataVenda VARCHAR(16),
	tipo VARCHAR(32),

	PRIMARY KEY(id),
	FOREIGN KEY(id_cliente)
		REFERENCES cliente(id),
	FOREIGN KEY(id_imovel)
		REFERENCES imovel(id),
	FOREIGN KEY(id_proprietario)
		REFERENCES proprietario(id),
	FOREIGN KEY(id_funcionario)
		REFERENCES funcionario(id)
);

-- INSERTS

-- FUNCIONARIOS
INSERT INTO funcionario(nome, telefone, email, funcao, creci, login, senha, ativo, acesso)
	VALUES('admin', '(16)9999-9999', 'admin@admin', 'administrador', '123123', 'admin', '123', 1, 1);
INSERT INTO funcionario(nome, telefone, email, funcao, creci, login, senha, ativo, acesso)
	VALUES('Ana', '(16)8888-8888', 'ana@ifsp', 'corretor', '111111', 'ana', '123', 1, 0);

-- CLIENTES
INSERT INTO cliente(nome, cpf, rg, telefone, email, dataNasc, ativo)
	VALUES('Cebolinha', '111,111,111-11', '111111', '(11)1111-1111', 'cebolinha@br', '11111911', 1);
INSERT INTO cliente(nome, cpf, rg, telefone, email, dataNasc, ativo)
	VALUES('Monica', '222,222,222-22', '222222', '(22)2222-2222', 'monica@br', '22121922', 1);
INSERT INTO cliente(nome, cpf, rg, telefone, email, dataNasc, ativo)
	VALUES('Cascão', '333,333,333-33', '333333', '(33)3333-3333', 'cascao@br', '13031933', 1);
INSERT INTO cliente(nome, cpf, rg, telefone, email, dataNasc, ativo)
	VALUES('Magali', '444,444,444-44', '444444', '(44)4444-4444', 'magali@br', '14041944', 1);
INSERT INTO cliente(nome, cpf, rg, telefone, email, dataNasc, ativo)
	VALUES('Chaves', '555,555,555-55', '555555', '(11)5555-5555', 'chaves@br', '15051955', 1);
INSERT INTO cliente(nome, cpf, rg, telefone, email, dataNasc, ativo)
	VALUES('Quico', '666,666,666-66', '666666', '(11)6666-6666', 'quico@br', '16061966', 1);
INSERT INTO cliente(nome, cpf, rg, telefone, email, dataNasc, ativo)
	VALUES('Seu Madruga', '777,777,777-77', '77777', '(11)7777-7777', 'seuMadruga@br', '17071977', 1);
INSERT INTO cliente(nome, cpf, rg, telefone, email, dataNasc, ativo)
	VALUES('Nhonho', '888,888,888-88', '888888', '(88)8888-8888', 'Nhonho@br', '18081988', 1);
INSERT INTO cliente(nome, cpf, rg, telefone, email, dataNasc, ativo)
	VALUES('Dona Florinda', '999,999,999-99', '999999', '(11)9999-9999', 'donaFlorinda@br', '19091989', 1);
INSERT INTO cliente(nome, cpf, rg, telefone, email, dataNasc, ativo)
	VALUES('Bulbasauro', '101,101,110-10', '101010', '(11)1010-1010', 'bulbasauro@br', '10101910', 1);

-- PROPRIETARIOS
INSERT INTO proprietario(nome, cpf, rg, dataNasc, telefone, email, rua, numero, bairro, cidade, ativo)
	VALUES('Faustão', '121,121,121-12', '121212', '12121912', '(16)1212-1212', 'faustao@br', 'Rua 1', 11, 'Bairro 1', 'São Carlos', 1);
INSERT INTO proprietario(nome, cpf, rg, dataNasc, telefone, email, rua, numero, bairro, cidade, ativo)
	VALUES('Silvio Santos', '122,122,122-22', '122122', '02121922', '(16)1212-2222', 'silvioSantos@br', 'Rua 2', 22, 'Bairro 2', 'São Carlos', 1);
INSERT INTO proprietario(nome, cpf, rg, dataNasc, telefone, email, rua, numero, bairro, cidade, ativo)
	VALUES('Fred Mercury Prateado', '133,133,133-33', '321333', '08121980', '(16)1233-3333', 'fredyMercuryPrateado@br', 'Rua 3', 33, 'Bairro 3', 'Araraquara', 1);
INSERT INTO proprietario(nome, cpf, rg, dataNasc, telefone, email, rua, numero, bairro, cidade, ativo)
	VALUES('Ursinho Gente Fina', '144,144,144-44', '121444', '12241924', '(16)1212-4444', 'ursinhoGenteFina@br', 'Rua 4', 14, 'Bairro 4', 'Campinas', 1);
INSERT INTO proprietario(nome, cpf, rg, dataNasc, telefone, email, rua, numero, bairro, cidade, ativo)
	VALUES('Boris', '155,155,155-55', '125555', '09101970', '(16)1212-5555', 'boris@br', 'Rua 5', 15, 'Bairro 5', 'Pindamonhangaba', 1);

-- IMÓVEIS
INSERT INTO imovel(tipo, categoria, metragem, frente, fundo, valor, bairro, rua, cidade, numero, id_proprietario, vendido, alugado)
	VALUES('Casa', 'Venda', 350, 10, 35, 400000, 'Bairro 10', 'Rua 10', 'São Carlos', 50, 1, 0, 0);
INSERT INTO imovel(tipo, categoria, metragem, frente, fundo, valor, bairro, rua, cidade, numero, id_proprietario, vendido, alugado)
	VALUES('Terreno', 'Venda', 550, 10, 55, 600000, 'Bairro 20', 'Rua 20', 'São Carlos', 65, 1, 0, 0);
INSERT INTO imovel(tipo, categoria, metragem, frente, fundo, valor, bairro, rua, cidade, numero, id_proprietario, vendido, alugado)
	VALUES('Apartamento', 'Aluguel', 120, 0, 0, 1400, 'Bairro 30', 'Rua 30', 'Araraquara', 70, 3, 0, 0);
INSERT INTO imovel(tipo, categoria, metragem, frente, fundo, valor, bairro, rua, cidade, numero, id_proprietario, vendido, alugado)
	VALUES('Casa', 'Venda', 1200, 20, 60, 1000000, 'Bairro 40', 'Rua 40', 'São Carlos', 41, 2, 0, 0);
INSERT INTO imovel(tipo, categoria, metragem, frente, fundo, valor, bairro, rua, cidade, numero, id_proprietario, vendido, alugado)
	VALUES('Apartamento', 'Aluguel', 100, 0, 0, 4000, 'Bairro 41', 'Rua 45', 'São Paulo', 45, 2, 0, 0);
INSERT INTO imovel(tipo, categoria, metragem, frente, fundo, valor, bairro, rua, cidade, numero, id_proprietario, vendido, alugado)
	VALUES('Casa', 'Venda', 350, 10, 35, 400000, 'Bairro 80', 'Rua 80', 'São Carlos', 80, 2, 0, 0);
INSERT INTO imovel(tipo, categoria, metragem, frente, fundo, valor, bairro, rua, cidade, numero, id_proprietario, vendido, alugado)
	VALUES('Casa', 'Venda', 300, 10, 30, 200000, 'Bairro 15', 'Rua 15', 'São Carlos', 30, 5, 0, 0);
INSERT INTO imovel(tipo, categoria, metragem, frente, fundo, valor, bairro, rua, cidade, numero, id_proprietario, vendido, alugado)
	VALUES('Kit', 'Aluguel', 50, 0, 0, 900, 'Bairro 40', 'Rua 40', 'São Carlos', 40, 4, 0, 0);

