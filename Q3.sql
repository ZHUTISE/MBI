--В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.

create table product
(
    uid         varchar,
    description varchar not null
);

alter table product
    add constraint product_pk
        primary key (uid);



create table category
(
    uid         varchar,
    description varchar not null
);

alter table category
    add constraint category_pk
        primary key (uid);



create table category_product_map
(
    product_uid  varchar,
    category_uid varchar
);

alter table category_product_map
    add constraint category_product_map_pk
        primary key (product_uid, category_uid);

alter table category_product_map
    add constraint category_product_map_product_uid_fk
        foreign key (product_uid) references product;

alter table category_product_map
    add constraint category_product_map_category_uid_fk
        foreign key (category_uid) references category;



INSERT INTO product (uid, description) VALUES ('p-aaa'::varchar, 'apple'::varchar);
INSERT INTO product (uid, description) VALUES ('p-bbb'::varchar, 'banana'::varchar);
INSERT INTO product (uid, description) VALUES ('p-ccc'::varchar, 'cider'::varchar);
INSERT INTO product (uid, description) VALUES ('p-ddd'::varchar, 'donut'::varchar);
INSERT INTO product (uid, description) VALUES ('p-fff'::varchar, 'fridge'::varchar);
INSERT INTO product (uid, description) VALUES ('p-ggg'::varchar, 'grable'::varchar);
INSERT INTO product (uid, description) VALUES ('p-qwe'::varchar, 'pencil'::varchar);
INSERT INTO product (uid, description) VALUES ('p-plk'::varchar, 'pen'::varchar);
INSERT INTO product (uid, description) VALUES ('p-mbi'::varchar, 'notebook'::varchar);
INSERT INTO product (uid, description) VALUES ('p-zht'::varchar, 'ruler'::varchar);

INSERT INTO category (uid, description) VALUES ('c-qqq'::varchar, 'drinks'::varchar);
INSERT INTO category (uid, description) VALUES ('c-www'::varchar, 'food'::varchar);
INSERT INTO category (uid, description) VALUES ('c-eee'::varchar, 'stationare'::varchar);
INSERT INTO category (uid, description) VALUES ('c-ewq'::varchar, 'dress'::varchar);
INSERT INTO category (uid, description) VALUES ('c-ewa'::varchar, 'fruits'::varchar);

INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-aaa'::varchar, 'c-ewa'::varchar);
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-bbb'::varchar, 'c-ewa'::varchar);
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-aaa'::varchar, 'c-www'::varchar);
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-bbb'::varchar, 'c-www'::varchar);
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-ccc'::varchar, 'c-qqq'::varchar);
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-ddd'::varchar, 'c-www'::varchar);
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-qwe'::varchar, 'c-eee'::varchar);
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-plk'::varchar, 'c-eee'::varchar);
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-mbi'::varchar, 'c-eee'::varchar);
INSERT INTO category_product_map (product_uid, category_uid) VALUES ('p-zht'::varchar, 'c-eee'::varchar);

-- Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

select
    p.description as product_name,
    c.description as category_name
from
    product p
    left join category_product_map cpm
        on cpm.product_uid = p.uid
    left join category c
        on c.uid = cpm.category_uid
order by 2;