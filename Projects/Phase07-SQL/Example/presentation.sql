-- create database 
CREATE DATABASE SqlWorkshop;

-- parse dataset and create RealEstate table
DECLARE @JSON NVARCHAR(MAX);

SELECT @JSON=BulkColumn FROM 
OPENROWSET (BULK 'F:\Temporary\archive\21-2-12.json', SINGLE_NCLOB) 
AS importData;

SELECT * INTO RealEstate
FROM OPENJSON (@JSON)
WITH
(
    [district] NVARCHAR(MAX),
    [token] NVARCHAR(10) NOT NULL PRIMARY KEY COLLATE Latin1_General_BIN,
    [sub_category] NVARCHAR(MAX),
    [category] NVARCHAR(MAX),
    [business_type] NVARCHAR(MAX),
    [price] BIGINT,
    [credit] BIGINT,
    [rent] BIGINT,
    [title] NVARCHAR(MAX),
    [location] NVARCHAR(MAX),
    [area] INT,
    [year] INT,
    [room] INT
);

-- create Owner table
CREATE TABLE RealEstateOwner
(
    national_id VARCHAR(10) NOT NULL PRIMARY KEY,
    first_name NVARCHAR(20),
    last_name NVARCHAR(20)
);

-- create Ownership table
CREATE TABLE RealEstateOwnership
(
    owner_national_id VARCHAR(10),
    real_estate_token NVARCHAR(10) COLLATE Latin1_General_BIN,
    CONSTRAINT ownership_owner_fk FOREIGN KEY (owner_national_id) REFERENCES RealEstateOwner(national_id),
    CONSTRAINT ownership_re_fk FOREIGN KEY (real_estate_token) REFERENCES RealEstate(token)
);

-- insert some data
INSERT INTO RealEstateOwner VALUES
(
    '0021111111',
    'GHOLI',
    'GHOLIZADEH'
);

INSERT INTO RealEstateOwner VALUES
(
    '0021111112',
    'REZA',
    'REZAEI'
);

INSERT INTO RealEstateOwner VALUES
(
    '0021111113',
    'ARASH',
    'MAHDAVI'
);

INSERT INTO RealEstateOwnership VALUES
(
    '0021111111',
    '-bX_kqTkr'
);

INSERT INTO RealEstateOwnership VALUES
(
    '0021111111',
    '-gJoamHY0'
);

INSERT INTO RealEstateOwnership VALUES
(
    '0021111112',
    'AXdrAS3F'
);

INSERT INTO RealEstateOwnership VALUES
(
    '0021111112',
    'AXfXNHsW'
);

-- check data
SELECT TOP(10) * FROM RealEstate;
SELECT TOP(10) * FROM RealEstateOwner;
SELECT TOP(10) * FROM RealEstateOwnership;

-- JOINS
-- INNER
SELECT * FROM RealEstateOwner 
INNER JOIN RealEstateOwnership
ON RealEstateOwner.national_id = RealEstateOwnership.owner_national_id;

-- LEFT
SELECT * FROM RealEstateOwner 
LEFT OUTER JOIN RealEstateOwnership
ON RealEstateOwner.national_id = RealEstateOwnership.owner_national_id;

-- RIGHT
SELECT * FROM RealEstateOwner 
RIGHT JOIN RealEstateOwnership
ON RealEstateOwner.national_id = RealEstateOwnership.owner_national_id;

-- FULL
SELECT * FROM RealEstateOwner 
FULL JOIN RealEstateOwnership
ON RealEstateOwner.national_id = RealEstateOwnership.owner_national_id;

-- FUNCTIONS
SELECT TOP(10) AVG(price/area) FROM RealEstate
WHERE district = N'ستارخان' AND price IS NOT NULL;

-- GROUP BY
SELECT owner_national_id, COUNT(owner_national_id)
FROM RealEstateOwnership
GROUP BY owner_national_id;

-- ORDER BY
SELECT TOP(10) price FROM RealEstate
WHERE district = N'ستارخان' AND price IS NOT NULL
ORDER BY price ASC;

-- TSQL
DECLARE @TOKEN NVARCHAR(10);
SELECT @TOKEN = token FROM RealEstateOwnership WHERE owner_national_id = '0021111111';
