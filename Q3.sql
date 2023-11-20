--В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.

CREATE TABLE product (
	uid         VARCHAR(5),
    description VARCHAR(255) NOT NULL,
                CONSTRAINT product_pk 
                    PRIMARY KEY (uid)
	);



CREATE TABLE category (
	uid         VARCHAR(5),
    description VARCHAR(255) NOT NULL,
                CONSTRAINT category_pk 
                    PRIMARY KEY (uid)
	);



CREATE TABLE category_product_map (
	product_uid  VARCHAR(5),
	category_uid VARCHAR(5),
	             CONSTRAINT category_product_map_pk 
	                 PRIMARY KEY (product_uid ,category_uid)
	);

ALTER TABLE category_product_map
    ADD CONSTRAINT category_product_map_product_uid_fk
        FOREIGN KEY (product_uid) REFERENCES product;

ALTER TABLE category_product_map
    ADD CONSTRAINT category_product_map_category_uid_fk
        FOREIGN KEY (category_uid) REFERENCES category;



INSERT INTO product (uid, description) VALUES ('p-aaa', 'apple');
INSERT INTO product (uid, description) VALUES ('p-bbb', 'banana');
INSERT INTO product (uid, description) VALUES ('p-ccc', 'cider');
INSERT INTO product (uid, description) VALUES ('p-ddd', 'donut');
INSERT INTO product (uid, description) VALUES ('p-fff', 'fridge');
INSERT INTO product (uid, description) VALUES ('p-ggg', 'grable');
INSERT INTO product (uid, description) VALUES ('p-qwe', 'pencil');
INSERT INTO product (uid, description) VALUES ('p-plk', 'pen');
INSERT INTO product (uid, description) VALUES ('p-mbi', 'notebook');
INSERT INTO product (uid, description) VALUES ('p-zht', 'ruler');
INSERT INTO category (uid, description) VALUES ('c-qqq', 'drinks');
INSERT INTO category (uid, description) VALUES ('c-www', 'food');
INSERT INTO category (uid, description) VALUES ('c-eee', 'stationary');
INSERT INTO category (uid, description) VALUES ('c-ewq', 'dress');
INSERT INTO category (uid, description) VALUES ('c-ewa', 'fruits');
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-aaa', 'c-ewa');
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-bbb', 'c-ewa');
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-aaa', 'c-www');
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-bbb', 'c-www');
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-ccc', 'c-qqq');
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-ddd', 'c-www');
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-qwe', 'c-eee');
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-plk', 'c-eee');
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-mbi', 'c-eee');
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-zht', 'c-eee');

-- Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

SELECT
    p.description AS product_name,
    c.description AS category_name
FROM
    product p
    LEFT JOIN category_product_map cpm
        ON cpm.product_uid = p.uid
    LEFT JOIN category c
        ON c.uid = cpm.category_uid
ORDER BY 2;