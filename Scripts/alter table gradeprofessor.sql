alter table gradeprofessor
add IdAprendiz INT NOT NULL

ALTER TABLE gradeprofessor
ADD CONSTRAINT FK_GradeProfessor_IdAprendiz FOREIGN KEY (IdAprendiz) REFERENCES Pessoa(Id)