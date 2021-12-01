DROP DATABASE restaurantManagement;
CREATE DATABASE restaurantManagement;
USE restaurantManagement;

CREATE TABLE kind(
	id INT(6) AUTO_INCREMENT PRIMARY KEY, 
	kind_name VARCHAR(100) NOT NULL,
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
    amount int NOT NULL,
    id_food INT NOT NULL,
    id_bill INT NOT NULL,
    PRIMARY KEY(id),
	FOREIGN KEY (id_bill) REFERENCES bill(id),
	FOREIGN KEY (id_food) REFERENCES food(id)
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
IN create_date DATE,
In gender int
)
BEGIN
   INSERT INTO 
	user(first_name, last_name, birthday, create_date,gender)
	VALUES
	(first_name, last_name, birthday, create_date,gender);
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
DELIMITER $$
DROP PROCEDURE IF EXISTS insertBillDetail $$
CREATE PROCEDURE insertBillDetail(
    IN amount INT,
    IN id_food INT,
    IN id_bill INT
)
BEGIN
   INSERT INTO 
	bill_detail(amount, id_food, id_bill)
	VALUES	
	(amount, id_food, id_bill);
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
CALL insertNewFood('Pepsi', 10000, 3, '2021-10-21');
CALL insertNewFood('C2', 8000, 3, '2021-10-21');
CALL insertNewFood('Rau câu', 12000, 2, '2021-10-21');
CALL insertNewFood('Bánh mì Bò Kho', 45000, 1, '2021-10-21');
CALL insertNewFood('Hủ tiếu mực', 60000, 1, '2021-10-21');
-- user
CALL insertUser('Như', 'Trần Thị','2019-05-15','2019-11-20');
CALL insertUser('Huy', 'Trần','2019-08-01','2019-12-31'); 

-- bill
INSERT INTO 
	bill(total_money, total_amount, create_date)
	VALUES	
	(610000 , 21, '2021-10-20');

CALL insertBillDetail (1, 1, 1);
CALL insertBillDetail (10, 2, 1);
CALL insertBillDetail (10, 6, 1);

DELIMITER // -- them ham cap nhap user tren id
CREATE PROCEDURE updateUser(
IN id INT,
IN 	first_name NVARCHAR(100),
IN 	last_name NVARCHAR(100),
IN birthday DATE,
IN  gender INT
)
BEGIN
   update user
   set first_name=first_name,last_name=last_name,birthday=birthday,gender=gender
   where id=id;
	
END //
DELIMITER ;
CREATE PROCEDURE insertBill(
in total_money FLOAT ,
in total_amount int,
in create_date DATE 
)
BEGIN
   INSERT INTO 
	bill(total_money, total_amount, create_date)
	VALUES	
	(total_money , total_amount, create_date )
	
END //
DELIMITER ;
