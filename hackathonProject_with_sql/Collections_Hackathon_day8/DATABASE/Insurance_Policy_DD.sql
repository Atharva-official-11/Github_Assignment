CREATE DATABASE Insurance_Policy_DD;
use Insurance_Policy_DD

CREATE TABLE Policies (
    PolicyID INT PRIMARY KEY IDENTITY(1,1),
    PolicyHolderName NVARCHAR(100) NOT NULL,
    PolicyType VARCHAR(50) CHECK (PolicyType IN ('Life', 'Health', 'Vehicle', 'Property')) NOT NULL, 
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL
);

INSERT INTO Policies VALUES ('Atharva', 'Life', '2025-01-01', '2026-01-01'),
('Mikasa', 'Vehicle', '2025-11-02', '2027-01-01')



SELECT * FROM Policies;


