

CREATE TABLE PessoaTipo (
	Id INT PRIMARY KEY IDENTITY,
	Descricao VARCHAR(50) NOT NULL
)

CREATE TABLE Atividade (
	Id INT PRIMARY KEY IDENTITY,
	Descricao VARCHAR(50) NOT NULL	
)

CREATE TABLE Pessoa (
	Id INT PRIMARY KEY IDENTITY,	
	Nome VARCHAR(100) NOT NULL,	
	CPFCNPJ INT NOT NULL,
	DataNascimento DATETIME,
	DataInclusao DATETIME NOT NULL,
	Email VARCHAR(100) NOT NULL,
	IdAtividade INT	NOT NULL,
	IdPessoaTipo INT NOT NULL,
	IdTelefone INT,
	IdEndereco INT,
	IsAtivo BIT NOT NULL
)

CREATE TABLE Telefone (
	Id INT PRIMARY KEY IDENTITY,	
	NumeroFixo VARCHAR(50) NOT NULL,
	NumeroCelular VARCHAR(50) NOT NULL
)


CREATE TABLE Endereco (
	Id INT PRIMARY KEY IDENTITY,	
	Endereco VARCHAR(50),
	Complemento VARCHAR(50),
	Numero VARCHAR(50),
	Cidade VARCHAR(50),
	Bairro VARCHAR(50),
	Estado VARCHAR(50),
	CEP VARCHAR(50),
	Pais VARCHAR(50),
)

CREATE TABLE Curso (
	Id INT PRIMARY KEY IDENTITY,	 
	Nome  VARCHAR(50) NOT NULL,
	DataCriacao DATETIME NOT NULL
)


CREATE TABLE Oficina (
	Id INT PRIMARY KEY IDENTITY,	 
	Nome  VARCHAR(50) NOT NULL,
	DataCriacao DATETIME NOT NULL
)

CREATE TABLE Turma (
	Id INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) NOT NULL,
	Descricao VARCHAR(50), 
	DataCriacao DATETIME NOT NULL,
	IdOficina INT NOT NULL,
	IdEstado INT NOT NULL		
)

CREATE TABLE TurmaMatricula(
	IdMatricula INT NOT NULL,
	IdTurma INT NOT NULL,
	IdEstado INT NOT NULL,
)

CREATE TABLE Estado(
	Id INT PRIMARY KEY IDENTITY,
	Descricao VARCHAR(50)
)

CREATE TABLE Referencia(
	Id INT PRIMARY KEY IDENTITY,
	Descricao VARCHAR(50)
)

CREATE TABLE EstadoReferencia(
	IdEstado INT NOT NULL,
	IdReferencia INT NOT NULL
)


CREATE TABLE Matricula (
	Id INT PRIMARY KEY IDENTITY,	 
	IdAprendiz INT NOT NULL,
	IdCurso INT NOT NULL,
	DataMatricula DATETIME NOT NULL,
	IdEstado INT NOT NULL
)

create table GradeMatricula(
	Id INT PRIMARY KEY IDENTITY,
	IdOficina int NOT NULL,
	IdMatricula INT NOT NULL,
	isCompleto BIT NOT NULL
)


CREATE TABLE GradeProfessor (
	Id INT PRIMARY KEY IDENTITY,
	IdTurma INT NOT NULL,
	IdProfessor INT NOT NULL
)

CREATE TABLE Frequencia (
	Id INT PRIMARY KEY IDENTITY,
	IdTurma INT NOT NULL,
	Data DATETIME NOT NULL,
	IdMatricula INT NOT NULL,
	IsFalta BIT NOT NULL
)




ALTER TABLE Pessoa
ADD CONSTRAINT FK_Pessoa_IdPessoaTipo FOREIGN KEY (IdPessoaTipo) REFERENCES PessoaTipo(Id)

ALTER TABLE Pessoa
ADD CONSTRAINT FK_Pessoa_IdAtividade FOREIGN KEY (IdAtividade) REFERENCES Atividade(Id)

ALTER TABLE Pessoa
ADD CONSTRAINT FK_Pessoa_IdTelefone FOREIGN KEY (IdTelefone) REFERENCES Telefone(Id)

ALTER TABLE Pessoa
ADD CONSTRAINT FK_Pessoa_IdEndereco FOREIGN KEY (IdEndereco) REFERENCES Endereco(Id)
GO

ALTER TABLE Turma
ADD CONSTRAINT FK_Turma_IdOficina FOREIGN KEY (IdOficina) REFERENCES Oficina(Id)
GO

ALTER TABLE Turma
ADD CONSTRAINT FK_Turma_IdEstado FOREIGN KEY (IdEstado) REFERENCES Estado(Id)
GO

ALTER TABLE Matricula
ADD CONSTRAINT FK_Matricula_IdAprendiz FOREIGN KEY (IdAprendiz) REFERENCES Pessoa(Id)
GO

ALTER TABLE Matricula
ADD CONSTRAINT FK_Matricula_IdCurso FOREIGN KEY (IdCurso) REFERENCES Curso(Id)
GO

ALTER TABLE Matricula
ADD CONSTRAINT FK_Matricula_IdEstado FOREIGN KEY (IdEstado) REFERENCES Estado(Id)
GO

ALTER TABLE GradeProfessor
ADD CONSTRAINT FK_GradeProfessor_IdTurma FOREIGN KEY (IdTurma) REFERENCES Turma(Id)
GO

ALTER TABLE GradeProfessor
ADD CONSTRAINT FK_GradeProfessor_IdProfessor FOREIGN KEY (IdProfessor) REFERENCES Pessoa(Id)
GO

ALTER TABLE Frequencia
ADD CONSTRAINT FK_Frequencia_IdTurma FOREIGN KEY (IdTurma) REFERENCES Turma(Id)
GO

ALTER TABLE GradeMatricula
ADD CONSTRAINT FK_GradeMatricula_IdMatricula FOREIGN KEY (IdMatricula) REFERENCES Matricula(Id)
GO

ALTER TABLE GradeMatricula
ADD CONSTRAINT FK_GradeMatricula_IdOficina FOREIGN KEY (IdOficina) REFERENCES Oficina(Id)
GO

ALTER TABLE TurmaMatricula
ADD CONSTRAINT FK_TurmaMatricula_IdMatricula FOREIGN KEY (IdMatricula) REFERENCES Matricula(Id)
GO

ALTER TABLE TurmaMatricula
ADD CONSTRAINT FK_TurmaMatricula_IdEstado FOREIGN KEY (IdEstado) REFERENCES Estado(Id)
GO

ALTER TABLE TurmaMatricula
ADD CONSTRAINT FK_TurmaMatricula_IdTurma FOREIGN KEY (IdTurma) REFERENCES Turma(Id)
GO


ALTER TABLE EstadoReferencia
ADD CONSTRAINT FK_EstadoReferencia_IdEstado FOREIGN KEY (IdEstado) REFERENCES Estado(Id)
GO


ALTER TABLE EstadoReferencia
ADD CONSTRAINT FK_EstadoReferencia_IdReferencia FOREIGN KEY (IdReferencia) REFERENCES Referencia(Id)
GO

ALTER TABLE gradeprofessor
ADD CONSTRAINT FK_GradeProfessor_IdProfessor FOREIGN KEY (IdProfessor) REFERENCES Pessoa(Id)


ALTER TABLE Frequencia
ADD CONSTRAINT FK_Frequencia_IdMatricula FOREIGN KEY (IdMatricula) REFERENCES Matricula(Id)



