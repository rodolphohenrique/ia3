ALTER TABLE Telefone
DROP CONSTRAINT FK_Telefone_IdPessoa

DROP TABLE Telefone

ALTER TABLE Pessoa
ADD TelefoneFixo VARCHAR(50)

ALTER TABLE Pessoa
ADD TelefoneCelular VARCHAR(50)

