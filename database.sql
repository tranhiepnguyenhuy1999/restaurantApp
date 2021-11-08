DROP DATABASE restaurantManagement;
CREATE DATABASE restaurantManagement;
USE restaurantManagement;

CREATE TABLE kind(
	id INT(6) AUTO_INCREMENT , 
	name VARCHAR(100) NOT NULL,
	from_age INT,
    to_age INT,
    create_date DATE
);

CREATE TABLE food(
	id INT(6) AUTO_INCREMENT , 
	name VARCHAR(100) NOT NULL,
	price FLOAT DEFAULT 0,
    id_kind INT, 
    create_date DATE NOT NULL,
    PRIMARY KEY(id),
	FOREIGN KEY (id_kind)
	REFERENCES kind(id)
);

CREATE TABLE bill(
	id INT(6) AUTO_INCREMENT , 
	total_money FLOAT DEFAULT 0,
    total_amount int NOT NULL,
    create_date DATE NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE bill_detail(
	id INT(6) AUTO_INCREMENT , 
	price FLOAT DEFAULT 0,
    amount int NOT NULL,
    id_food INT NOT NULL,
    id_bill INT NOT NULL,
    create_date DATE NOT NULL,
    PRIMARY KEY(id),
	FOREIGN KEY (id_bill)
	REFERENCES bill(id)
);

CREATE TABLE user(
	id INT AUTO_INCREMENT , 
	first_name VARCHAR(100) NOT NULL,
	last_name VARCHAR(100) NOT NULL,
	birthday DATE,
    create_date DATE NOT NULL,
    PRIMARY KEY(id)
);

DELIMITER $$
CREATE PROCEDURE insertUser(
IN 	first_name_user NVARCHAR(100),
IN 	last_name_user NVARCHAR(100),
IN birthday_user DATE,
IN create_date_user DATE
)
BEGIN
   INSERT INTO 
	user(first_name, last_name, birthday, create_date)
	VALUES
	(first_name_user, last_name_user, birthday_user, birthday_user);
END; $$

 CALL insertUser('Thanh', 'Nguyễn Thị','2019-05-15','2019-11-20');

INSERT INTO 
	user(first_name, last_name, birthday, create_date)
VALUES
	('Huy', 'Trần','2019-08-01','2019-12-31'),
	( 'Thanh', 'Nguyễn Thị','2019-05-15','2019-11-20');