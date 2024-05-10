CREATE TABLE menu (
    menu_id INT PRIMARY KEY IDENTITY,
    name VARCHAR(100),
    price DECIMAL(10,2),
    image VARCHAR(255)
);
CREATE TABLE lunch (
    lunch_id INT PRIMARY KEY IDENTITY,
    name VARCHAR(100),
    price DECIMAL(10,2),
    image VARCHAR(255)
);
INSERT INTO lunch (name, price, image) VALUES ('Sandwich', 5.99, 'sandwich.jpg');
INSERT INTO lunch (name, price, image) VALUES ('Salad', 7.49, 'salad.jpg');
INSERT INTO lunch (name, price, image) VALUES ('Burger', 6.99, 'burger.jpg');
