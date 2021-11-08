DROP DATABASE restaurantManagement;
CREATE DATABASE restaurantManagement;
USE restaurantManagement;

CREATE TABLE kind(
	id INT(6) AUTO_INCREMENT PRIMARY KEY, 
	kìnd_name VARCHAR(100) NOT NULL,
	from_age INT,
    to_age INT,
    create_date DATE
);

CREATE TABLE food(
	id INT(6) AUTO_INCREMENT , 
	food_name VARCHAR(100) NOT NULL,
	price FLOAT DEFAULT 0,
    id_kind INT(6),
	FOREIGN KEY (id_kind) REFERENCES kind(id),
    create_date DATE NOT NULL,
    PRIMARY KEY(id)
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
    gender INT DEFAULT 0,
    create_date DATE NOT NULL,
    PRIMARY KEY(id)
);

DELIMITER $$
CREATE PROCEDURE insertUser(
IN 	first_name NVARCHAR(100),
IN 	last_name NVARCHAR(100),
IN birthday DATE,
IN create_date DATE
)
BEGIN
   INSERT INTO 
	user(first_name, last_name, birthday, create_date)
	VALUES
	(first_name, last_name, birthday, create_date);
END; $$
DELIMITER $$
DROP PROCEDURE IF EXISTS insertNewFood $$
CREATE PROCEDURE insertNewFood(
IN 	food_name NVARCHAR(100),
IN 	price FLOAT,
IN  id_kind INT(6),
IN create_date DATE
)
BEGIN
   INSERT INTO 
	food(food_name, price, id_kind, create_date)
	VALUES	
	(food_name, price, id_kind, create_date);
END; $$
DELIMITER ;

INSERT INTO 
	kind(kind_name, create_date)
	VALUES	
	('Món ăn', '2021-10-20'),
	('Tráng miệng', '2021-10-20'),
	('Thức uống', '2021-10-20');
    
-- food
CALL insertNewFood('Lẩu cá', 250000, 1, '2021-10-20');
CALL insertNewFood('Thịt kho', 30000, 1, '2021-10-21');
CALL insertNewFood('Canh chua cá kho tộ', 1000000, 1, '2021-10-21');
CALL insertNewFood('Cơm tấm', 35000, 1, '2021-10-21');
CALL insertNewFood('Cơm gà xói mỡ', 30000, 1, '2021-10-21');
CALL insertNewFood('Pepsi', 1000, 3, '2021-10-21');
CALL insertNewFood('C2', 8000, 3, '2021-10-21');
CALL insertNewFood('Rau câu', 12000, 2, '2021-10-21');
CALL insertNewFood('Bánh mì Bò Kho', 45000, 1, '2021-10-21');
CALL insertNewFood('Hủ tiếu mực', 60000, 1, '2021-10-21');
-- user
CALL insertUser('Như', 'Trần Thị','2019-05-15','2019-11-20');
CALL insertUser('Huy', 'Trần','2019-08-01','2019-12-31');
CALL insertUser( 'Thanh', 'Nguyễn Thị','2019-05-15','2019-11-20');


