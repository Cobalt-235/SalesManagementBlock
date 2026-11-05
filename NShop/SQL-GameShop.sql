CREATE DATABASE GameshopDB
GO

USE GameshopDB
GO

-- Products: The catalog
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,          -- Manually typed ID
    ProductName NVARCHAR(100) NOT NULL,        
    Price DECIMAL(10, 2) NOT NULL,
    ShortDesc NVARCHAR(255),
    Category NVARCHAR(50)
);

-- Stock: Tracks quantity per product
CREATE TABLE Stock (
    ProductID INT PRIMARY KEY,
    Quantity INT NOT NULL DEFAULT 0,
    LastUpdated DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- Billings: One row per sale transaction
CREATE TABLE Billings (
    BillID INT IDENTITY(1,1) PRIMARY KEY,
    SaleDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(10, 2) NOT NULL, -- Calculated at time of sale
    CustomerName NVARCHAR(100)           -- Optional
);

-- BillingDetails: Links bills to products (Many-to-Many)
CREATE TABLE BillingDetails (
    DetailID INT IDENTITY(1,1) PRIMARY KEY,
    BillID INT,
    ProductID INT,
    QuantitySold INT,
    UnitPrice DECIMAL(10, 2),            -- Snapshot price at time of sale
    FOREIGN KEY (BillID) REFERENCES Billings(BillID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

INSERT INTO Products (ProductID, ProductName, Price, ShortDesc, Category) VALUES
(101, 'Elden Ring', 59.99, 'Open-world action RPG from FromSoftware.', 'RPG'),
(102, 'Cyberpunk 2077', 49.99, 'Sci-fi open-world RPG with deep storytelling.', 'RPG'),
(103, 'FIFA 24', 69.99, 'The world''s game – latest football simulation.', 'Sports'),
(104, 'Call of Duty: MW3', 69.99, 'Intense multiplayer first-person shooter.', 'Shooter'),
(105, 'Hollow Knight', 14.99, 'Beautiful 2D metroidvania adventure.', 'Indie'),
(106, 'Stardew Valley', 14.99, 'Relaxing farming and life simulation.', 'Simulation'),
(107, 'God of War Ragnarok', 69.99, 'Epic Norse mythology action-adventure.', 'Action'),
(108, 'Minecraft', 26.99, 'The ultimate sandbox building game.', 'Sandbox'),
(109, 'Resident Evil 4 Remake', 59.99, 'Survival horror classic reimagined.', 'Horror'),
(110, 'Rocket League', 19.99, 'High-powered vehicular soccer.', 'Sports');


INSERT INTO Stock (ProductID, Quantity, LastUpdated) VALUES
(101, 15, GETDATE()),   -- Elden Ring
(102, 8, GETDATE()),    -- Cyberpunk
(103, 25, GETDATE()),   -- FIFA 24
(104, 12, GETDATE()),   -- CoD MW3
(105, 40, GETDATE()),   -- Hollow Knight (Popular indie)
(106, 35, GETDATE()),   -- Stardew Valley
(107, 5, GETDATE()),    -- God of War (Low stock example)
(108, 50, GETDATE()),   -- Minecraft
(109, 10, GETDATE()),   -- RE4
(110, 20, GETDATE());   -- Rocket League


-- Create the Bill header
INSERT INTO Billings (SaleDate, TotalAmount, CustomerName) 
VALUES (GETDATE(), 109.98, 'John Doe');

-- Get the last inserted BillID
DECLARE @Bill1ID INT = SCOPE_IDENTITY();

-- Add the items to the details
INSERT INTO BillingDetails (BillID, ProductID, QuantitySold, UnitPrice) VALUES
(@Bill1ID, 101, 1, 59.99),
(@Bill1ID, 102, 1, 49.99);

INSERT INTO Billings (SaleDate, TotalAmount, CustomerName) 
VALUES (GETDATE(), 69.99, 'Jane Smith');

DECLARE @Bill2ID INT = SCOPE_IDENTITY();

INSERT INTO BillingDetails (BillID, ProductID, QuantitySold, UnitPrice) VALUES
(@Bill2ID, 104, 1, 69.99);

INSERT INTO Billings (SaleDate, TotalAmount, CustomerName) 
VALUES (GETDATE(), 29.98, 'Alex');

DECLARE @Bill3ID INT = SCOPE_IDENTITY();

INSERT INTO BillingDetails (BillID, ProductID, QuantitySold, UnitPrice) VALUES
(@Bill3ID, 105, 1, 14.99),
(@Bill3ID, 106, 1, 14.99);

SELECT 
    p.ProductID,
    p.ProductName,
    p.Category,
    s.Quantity,
    COUNT(bd.DetailID) as TimesSold
FROM Products p
JOIN Stock s ON p.ProductID = s.ProductID
LEFT JOIN BillingDetails bd ON p.ProductID = bd.ProductID
GROUP BY 
p.ProductID, p.ProductName, p.Category, s.Quantity
ORDER BY p.ProductID;