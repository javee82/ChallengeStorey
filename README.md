# ChallengeStorey

IMPORTANTE: Para poder tener acceso a los datos, recuerde que debe configurar la conexión a la base de datos en el archivo appsetings.json.
Ejecutar en la consola el siguiente comando: update-database
Si todo salio bien deberia tener creada la nueva base de datos. Ejecutar una nueva consulta desde SQL Server utilizando los siguientes scripts, de lo contrario quedará vacia.

INSERT INTO Categorias(nombre) VALUES ('Iluminacion')
INSERT INTO Categorias(nombre) VALUES ('Refrigeracion')

INSERT INTO Items(Elemento, Valor, CategoriaId) VALUES ('Lámpara Led de 5w', 5, 1)
INSERT INTO Items(Elemento, Valor, CategoriaId) VALUES ('Lámpara Led de 10w', 10, 1)
INSERT INTO Items(Elemento, Valor, CategoriaId) VALUES ('Lámpara Incandescente 40w', 40, 1)
INSERT INTO Items(Elemento, Valor, CategoriaId) VALUES ('Lámpara Incandescente de 100w', 100, 1)
INSERT INTO Items(Elemento, Valor, CategoriaId) VALUES ('Lámpara Incandescente de 200w', 200, 1)

INSERT INTO Items(Elemento, Valor, CategoriaId) VALUES ('Heladera', 1000, 2)
INSERT INTO Items(Elemento, Valor, CategoriaId) VALUES ('Freezer', 1500, 2)
