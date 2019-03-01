select * from Usuarios

select * from Pacotes

select Pacotes.Cidade , Pacotes.NomePacote,Pacotes.DataIda,Pacotes.DataVolta
from Pacotes
where Pacotes.Cidade = 'Salvador' 
