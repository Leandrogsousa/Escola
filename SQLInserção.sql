use GestaoEscolar



select * from Professor
Select * from Turma
Select * from ProfessorTurma
Select * from Atividade

INSERT INTO Professor (Nome,Usuario,Senha) values ('Maria Clara', 'Mclara','m12345')
INSERT INTO Professor (Nome,Usuario,Senha) values ('Pablo Carvalho', 'Pablo','pablo123')



INSERT INTO Turma (Descricao) values ('4� Ano')
INSERT INTO Turma (Descricao) values ('7� Ano')

INSERT INTO ProfessorTurma(IdProfessor,IdTurma) values (1,1)
INSERT INTO ProfessorTurma(IdProfessor,IdTurma) values (2,2)

INSERT INTO Atividade(Descricao,IdTurma) values ('Matem�tica: N�meros Reais',1)
INSERT INTO Atividade(Descricao,IdTurma) values ('Ingl�s: Verbo To Be',1)


