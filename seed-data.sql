-- =============================================
-- Datos de prueba para BibliotecaApp
-- Ejecutar en MySQL:
--   mysql -u root -p < scripts/seed-data.sql
-- O abrir en MySQL Workbench / DataGrip y ejecutar.
-- =============================================

USE BibliotecaDb;

-- Limpiar datos anteriores (por si ejecutás varias veces)
SET FOREIGN_KEY_CHECKS = 0;
TRUNCATE TABLE Prestamos;
TRUNCATE TABLE Books;
TRUNCATE TABLE Users;
SET FOREIGN_KEY_CHECKS = 1;

-- Usuarios
INSERT INTO Users (Name, Email) VALUES
('Alice Johnson', 'alice@library.com'),
('Bob Martinez',  'bob@library.com'),
('Carol White',   'carol@library.com');

-- Libros
INSERT INTO Books (Title, Author, ISBN, IsAvailable) VALUES
('Clean Code',               'Robert C. Martin', '978-0132350884', 1),
('The Pragmatic Programmer', 'Andrew Hunt',       '978-0201616224', 1),
('Design Patterns',          'Gang of Four',      '978-0201633610', 1),
('Refactoring',              'Martin Fowler',     '978-0134757599', 1),
('Domain-Driven Design',     'Eric Evans',        '978-0321125217', 1);

-- Préstamo de ejemplo (Alice se llevó Clean Code)
INSERT INTO Prestamos (BookId, UserId, LoanDate) VALUES
(1, 1, '2026-06-20 10:00:00');
