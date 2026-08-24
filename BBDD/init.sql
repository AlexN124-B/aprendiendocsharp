CREATE DATABASE IF NOT EXISTS products_db
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE products_db;

CREATE TABLE IF NOT EXISTS products (
    id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT,
    price DECIMAL(10, 2) NOT NULL,
    title VARCHAR(255) NOT NULL,
    description TEXT NULL,
    category VARCHAR(100) NOT NULL,
    stock INT UNSIGNED NOT NULL DEFAULT 0,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
        ON UPDATE CURRENT_TIMESTAMP,

    PRIMARY KEY (id),
    INDEX idx_products_category (category),
    INDEX idx_products_title (title)
) ENGINE=InnoDB
  DEFAULT CHARSET=utf8mb4
  COLLATE=utf8mb4_unicode_ci;

INSERT INTO products (price, title, description, category, stock)
VALUES (19.99, 'Producto de prueba', 'Descripción de ejemplo para pruebas', 'General', 10);