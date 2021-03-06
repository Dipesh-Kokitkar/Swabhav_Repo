--TRANSACTION WITH TRY CATCH BLOCK

CREATE TABLE CUSTOMER(
CID INT PRIMARY KEY,
CNAME VARCHAR(20),
BAL INT
)

INSERT INTO CUSTOMER VALUES(101,'ABC',5000);

CREATE TABLE MARCHANT(
MID INT PRIMARY KEY,
MNAME VARCHAR(20),
MBAL INT
)

INSERT INTO MARCHANT VALUES(1,'D-MART',10000);

--TRANSACTION WITH NO ERROR

SELECT * FROM CUSTOMER;
SELECT * FROM MARCHANT;

BEGIN TRANSACTION
 BEGIN TRY
   UPDATE CUSTOMER SET BAL=BAL-4000;
   UPDATE MARCHANT SET MBAL=MBAL+4000;
   COMMIT;
   INSERT INTO A_LOG VALUES('TRANSACTION SUCESS');
 END TRY
 BEGIN CATCH
   ROLLBACK;
 END CATCH
 
SELECT * FROM CUSTOMER;
SELECT * FROM MARCHANT;

--TRANSATION WITH ERROR
BEGIN TRANSACTION
 BEGIN TRY
   UPDATE CUSTOMER SET BAL=BAL-400;
   SELECT * FROM CUSTOMER;
   UPDATE MARCHANT SET MBAL='ABC' WHERE MID=14400;
   COMMIT;
 END TRY
 BEGIN CATCH
   INSERT INTO A_LOG VALUES('TRANSACTION FAIL');
   ROLLBACK;
   SELECT * FROM CUSTOMER;
 END CATCH
SELECT * FROM CUSTOMER; 

