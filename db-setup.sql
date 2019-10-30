--  USE skilift;

-- CREATE TABLE users (
--     id VARCHAR(255) NOT NULL,
--     username VARCHAR(20) NOT NULL,
--     email VARCHAR(255) NOT NULL,
--     hash VARCHAR(255) NOT NULL,
--     PRIMARY KEY (id),
--     UNIQUE KEY email (email)
-- );

-- CREATE TABLE passengers (
--     id int NOT NULL AUTO_INCREMENT,
--     name VARCHAR(20) NOT NULL,
--     destination VARCHAR(255) NOT NULL,
--     userId VARCHAR(255),
--     INDEX userId (userId),
--     FOREIGN KEY (userId)
--         REFERENCES users(id)
--         ON DELETE CASCADE,  
--     PRIMARY KEY (id)
-- );
-- CREATE TABLE rides (
--     id int NOT NULL AUTO_INCREMENT,
--     name VARCHAR(20) NOT NULL,
--     destination VARCHAR(255) NOT NULL,
--     maxpassengers int NOT NULL,
--     userId VARCHAR(255),
--     INDEX userId (userId),
--     FOREIGN KEY (userId)
--         REFERENCES users(id)
--         ON DELETE CASCADE,  
--     PRIMARY KEY (id)
-- );

-- CREATE TABLE ride_passengers (
--     id int NOT NULL AUTO_INCREMENT,
--     rideId int NOT NULL,
--     passengerId int NOT NULL,
   
--     PRIMARY KEY (id),
--     INDEX (rideId, passengerId),

--     FOREIGN KEY (rideId)
--         REFERENCES rides(id)
--         ON DELETE CASCADE,

--     FOREIGN KEY (passengerId)
--         REFERENCES passengers(id)
--         ON DELETE CASCADE
-- )


-- -- CREATE TABLE vaultkeeps (
-- --     id int NOT NULL AUTO_INCREMENT,
-- --     vaultId int NOT NULL,
-- --     keepId int NOT NULL,
-- --     userId VARCHAR(255) NOT NULL,

-- --     PRIMARY KEY (id),
-- --     INDEX (vaultId, keepId),
-- --     INDEX (userId),

-- --     FOREIGN KEY (userId)
-- --         REFERENCES users(id)
-- --         ON DELETE CASCADE,

-- --     FOREIGN KEY (vaultId)
-- --         REFERENCES vaults(id)
-- --         ON DELETE CASCADE,

-- --     FOREIGN KEY (keepId)
-- --         REFERENCES keeps(id)
-- --         ON DELETE CASCADE
-- -- )


-- -- -- USE THIS LINE FOR GET KEEPS BY VAULTID
-- -- -- SELECT * FROM vaultkeeps vk
-- -- -- INNER JOIN keeps k ON k.id = vk.keepId 
-- -- -- WHERE (vaultId = @vaultId AND vk.userId = @userId) 
