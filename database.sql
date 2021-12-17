DROP DATABASE restaurantManagement;
CREATE DATABASE restaurantManagement;
USE restaurantManagement;

CREATE TABLE kind(
	id INT(6) AUTO_INCREMENT PRIMARY KEY, 
	kind_name NVARCHAR(100) NOT NULL,
	from_age INT,
    to_age INT,
    create_date DATE
);

CREATE TABLE food(
	id INT(6) AUTO_INCREMENT , 
	food_name NVARCHAR(100) NOT NULL,
	price FLOAT DEFAULT 0,
    id_kind INT(6),
	FOREIGN KEY (id_kind) REFERENCES kind(id),
    create_date DATETIME NOT NULL,
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
    id_bill INT NOT NULL,
    food_name VARCHAR(100) NOT NULL,
    price FLOAT NOT NULL,
    PRIMARY KEY(id),
	FOREIGN KEY (id_bill) REFERENCES bill(id)
);

CREATE TABLE user(
	id INT AUTO_INCREMENT , 
	first_name VARCHAR(100) NOT NULL,
	last_name VARCHAR(100) NOT NULL,
    phone CHAR(10) NOT NULL,
	email VARCHAR(100),
	birthday DATETIME,
    gender INT DEFAULT 0,
	user_name VARCHAR(100) NOT NULL UNIQUE,
	user_password  VARCHAR(100) NOT NULL,
	create_date DATETIME NOT NULL,
	userRole VARCHAR(100) DEFAULT "employee",
    PRIMARY KEY(id)
);
DELIMITER $$
CREATE PROCEDURE insertUser(
IN first_name NVARCHAR(100),
IN last_name NVARCHAR(100),
IN phone CHAR(10),
IN birthday DATETIME,
IN user_name VARCHAR(100),
IN user_password  VARCHAR(100),
IN create_date DATETIME,
IN userRole NVARCHAR(100)
)
BEGIN
   INSERT INTO 
	user(first_name, last_name, phone, birthday, user_name, user_password, userRole, create_date)
	VALUES
	(first_name,
    last_name,
    phone, 
    birthday, 
    user_name, 
    user_password, 
    userRole, 
    create_date);
END; $$

DELIMITER $$
DROP PROCEDURE IF EXISTS insertNewFood $$
CREATE PROCEDURE insertNewFood(
IN 	food_name NVARCHAR(100),
IN 	price FLOAT,
IN  id_kind INT(6),
IN create_date DATETIME
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
	IN id_bill INT,
    IN amount INT,
	IN food_name VARCHAR(100),
    IN price FLOAT
)
BEGIN
   INSERT INTO 
	bill_detail(id_bill, amount, food_name, price )
	VALUES	
	(id_bill, amount , food_name, price );
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
CALL insertNewFood('Canh chua cá kho tộ', 100000, 1, '2021-10-21');
CALL insertNewFood('Cơm tấm', 35000, 1, '2021-10-21');
CALL insertNewFood('Cơm gà xói mỡ', 30000, 1, '2021-10-21');
CALL insertNewFood('Pepsi', 10000, 3, '2021-10-21');
CALL insertNewFood('C2', 8000, 3, '2021-10-21');
CALL insertNewFood('Rau câu', 12000, 2, '2021-10-21');
CALL insertNewFood('Bánh mì Bò Kho', 45000, 1, '2021-10-21');
CALL insertNewFood('Hủ tiếu mực', 60000, 1, '2021-10-21');
-- user
CALL insertUser('Như', 'Trần Thị', '0915330370','2019-05-15',"admin", "123456",'2019-11-20','admin');
CALL insertUser('Huy', 'Trần','0123456789','2019-08-01',"employee", "123456",'2019-12-31','employee'); 
-- bill
INSERT INTO 
	bill(total_money, total_amount, create_date)
	VALUES	
	(2500000 , 10, '2021-10-20'),
    (650000 , 15, '2021-10-21'),
	(20000 , 20, '2021-9-15'),
	(500000 , 5, '2021-10-26');
    

CALL insertBillDetail (1, 10, 'Lẩu cá', 25000);
CALL insertBillDetail (2, 10, 'Cơm tấm', 35000);
CALL insertBillDetail (2, 5, 'Cơm gà xói mỡ', 30000);
CALL insertBillDetail (3, 20, 'Pepsi', 10000);
CALL insertBillDetail (4, 5, 'Canh chua cá kho tộ', 100000);
use restaurantManagement

DELIMITER $$
CREATE PROCEDURE updateFood(
IN 	id_in int(6),
IN 	food_name_in NVARCHAR(100),
IN 	price_in float,
IN id_kind_in int(6)
)
BEGIN
   update food
   set food_name = food_name_in, price = price_in, id_kind = id_kind_in
   where id = id_in;
END; $$
DELIMITER $$

DELIMITER $$
CREATE PROCEDURE deleteFood(
IN 	id_in int(6)
)
BEGIN
   delete from food where id=id_in;
END; $$
DELIMITER $$

DELIMITER $$
CREATE PROCEDURE insertKindFood(
    IN id INT,
    IN kind_name NVARCHAR(100),
    IN from_age INT,
    IN to_age INT,
    IN create_date DATE
)
BEGIN
   INSERT INTO 
	kind(id, kind_name, from_age, to_age, create_date)
	VALUES	
	(id, kind_name,from_age,to_age, create_date);
END; $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE updateUser(
IN inId int,
IN inFirstName NVARCHAR(100),
IN inLastName NVARCHAR(100),
IN inPhone CHAR(10),
IN inBirthday DATE,
IN inUserName VARCHAR(100),
IN inUserPassword  VARCHAR(100)
)
BEGIN
  update user
   set first_name=inFirstName,last_name=inLastName,phone=inPhone,birthday=inBirthday,
   user_name=inUserName,user_password=inUserPassword
   where id=inId;
END; $$

DELIMITER $$
CREATE PROCEDURE insertBill(
    total_amount int ,
    total_money FLOAT ,
    create_date DATE 
)
BEGIN
   INSERT INTO 
	bill( total_amount,total_money, create_date)
	VALUES	
	(total_amount,total_money, create_date);
END; $$
DELIMITER ;

#
DELIMITER $$
CREATE PROCEDURE insertUser0(
IN first_name NVARCHAR(100),
IN last_name NVARCHAR(100),
IN phone CHAR(10),
IN birthday DATETIME,
IN user_name VARCHAR(100),
IN user_password  VARCHAR(100),
IN create_date DATETIME,
in gender  int
)
BEGIN
   INSERT INTO 
	user(first_name, last_name, phone, birthday, user_name, user_password, create_date,gender)
	VALUES
	(first_name, last_name, phone, birthday, user_name, user_password, create_date,gender);
END; $$

DELIMITER $$

DELIMITER $$
CREATE PROCEDURE updateUser0(
IN id0 int,
IN first_name NVARCHAR(100),
IN last_name NVARCHAR(100),
IN phone CHAR(10),
IN birthday DATE,
IN user_name VARCHAR(100),
IN user_password  VARCHAR(100),
in gender int
)
BEGIN
  update user
   set first_name=first_name,last_name=last_name,phone=phone,birthday=birthday,
   user_name=user_name,user_password=user_password,gender=gender
   where id=id0;
END; $$

DELIMITER $$
#
DELIMITER $$
CREATE PROCEDURE findDateBill01(
IN create_date0 DATE
)
BEGIN
  select * from bill where create_date= create_date0 order by create_date DESC,total_amount asc;
END; $$
DELIMITER $$
DELIMITER $$
CREATE PROCEDURE findDateBill02(
IN create_date0 DATE
)
BEGIN
  select * from bill where create_date= create_date0 order by create_date DESC,total_amount desc;
END; $$
DELIMITER $$
DELIMITER $$
CREATE PROCEDURE findDateBill03(
IN create_date0 DATE
)
BEGIN
  select * from bill where create_date= create_date0 order by create_date DESC,total_money asc;
END; $$
DELIMITER $$
DELIMITER $$
CREATE PROCEDURE findDateBill04(
IN create_date0 DATE
)
BEGIN
  select * from bill where create_date= create_date0 order by create_date DESC,total_money desc;
END; $$
DELIMITER $$
DELIMITER $$
CREATE PROCEDURE findDateBill11(
IN create_date0 DATE
)
BEGIN
  select * from bill where create_date= create_date0 order by create_date ASC,total_amount asc;
END; $$
DELIMITER $$
DELIMITER $$
CREATE PROCEDURE findDateBill12(
IN create_date0 DATE
)
BEGIN
  select * from bill where create_date= create_date0 order by create_date ASC,total_amount desc;
END; $$
DELIMITER $$
DELIMITER $$
CREATE PROCEDURE findDateBill13(
IN create_date0 DATE
)
BEGIN
  select * from bill where create_date= create_date0 order by create_date ASC, total_money asc;
END; $$
DELIMITER $$
DELIMITER $$
CREATE PROCEDURE findDateBill14(
IN create_date0 DATE
)
BEGIN
  select * from bill where create_date= create_date0 order by create_date ASC, total_money desc;
END; $$
DELIMITER $$

select * from food where food_name like "%com%"
