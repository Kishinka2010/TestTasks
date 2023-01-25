# 2 задание
CREATE TABLE Category(
id INT PRIMARY KEY, name VARCHAR(255) NOT NULL
);

CREATE TABLE Products(
id INT PRIMARY KEY, name VARCHAR(255) NOT NULL
);

CREATE TABLE ProductCategory(
products_id INT NOT NULL, category_id INT NOT NULL
);

INSERT INTO Products VALUES(1, 'Ноутбук'), (2, 'Телефон'), (3, 'Джинсы');
INSERT INTO Category VALUES(1, 'Техника'), (2, 'Одежда');
INSERT INTO ProductCategory VALUES(1, 1), (2, 1), (3, 2);

SELECT Prod.name, Cat.name
FROM Products Prod
LEFT JOIN ProductCategory ProdCat
	ON Prod.id = ProdCat.products_id
LEFT JOIN Category Cat
	ON ProdCat.category_id = C.id;
