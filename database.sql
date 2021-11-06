DROP DATABASE restaurantManagement;
CREATE DATABASE restaurantManagement;
USE restaurantManagement;

CREATE TABLE user(
	id INT AUTO_INCREMENT , 
	first_name VARCHAR(100) NOT NULL,
	last_name VARCHAR(100) NOT NULL,
	birthday DATE,
    create_date DATE NOT NULL,
    PRIMARY KEY(id)
);
INSERT INTO 
	user(first_name, last_name, birthday, create_date)
VALUES
	('Huy', 'Trần','2019-08-01','2019-12-31'),
	( 'Thanh', 'Nguyễn Thị','2019-05-15','2019-11-20');