INSERT INTO Cliente values('Eduardo');
INSERT INTO Cliente values('José');

SELECT * FROM Cliente;


SELECT nome from Cliente;


SELECT * from Telefones;

INSERT INTO Telefones values('023456789','Fixo',1);

INSERT INTO Telefones values('9999999999','Fixo',2);


SELECT * FROM Cliente
WHERE nome='Eduardo';

DELETE FROM Telefones WHERE ClienteId=1;
DELETE FROM Cliente WHERE id=1

update Cliente set Nome='Eduardo Monteiro'
WHERE Nome='Eduardo'

