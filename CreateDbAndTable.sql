create database toDoAndDid;

CREATE TABLE tasks(
	id_task INT PRIMARY KEY IDENTITY,
	titulo_task VARCHAR(255) NOT NULL,
	data_abertura DATE NOT NULL,
	data_encerramento DATE
);

CREATE TABLE tela_login(
	id_user INT PRIMARY KEY IDENTITY,
	nome_user VARCHAR(255) NOT NULL
);

INSERT INTO tasks(titulo_task, data_abertura) VALUES('Entrega 3 do projeto de LPA', '2018-05-09');
INSERT INTO tela_login VALUES('Daniel');

select * from tasks;
select * from tela_login;