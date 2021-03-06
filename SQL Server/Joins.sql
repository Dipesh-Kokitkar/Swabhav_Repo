SELECT * FROM EMP;

--INNER JOIN 
SELECT EMP.ENAME,DEPT.DNAME FROM EMP JOIN DEPT ON EMP.DEPTNO=DEPT.DEPTNO;

--ALL DEPT DEATILS ALONG WITH EMP IF ANY
SELECT * FROM DEPT LEFT JOIN EMP ON EMP.DEPTNO=DEPT.DEPTNO;

--SHOW DEPT WHERE NO EMP
 SELECT DEPT.DEPTNO,DEPT.DNAME
  FROM DEPT LEFT JOIN EMP 
   ON EMP.DEPTNO=DEPT.DEPTNO 
   WHERE EMPNO IS NULL;

 --SHOW EMPNO AND BOSS NAME
 
 SELECT A.ENAME AS BOSSNAME,B.ENAME 
  FROM EMP A LEFT JOIN EMP B 
  ON A.MGR=B.EMPNO;
  
  --SHOW ENAME DEPT AND MGR
  SELECT A.ENAME AS BOSSNAME,B.ENAME,DEPT.DNAME
  FROM (( EMP A JOIN EMP B ON A.MGR=B.EMPNO) 
  JOIN DEPT ON A.DEPTNO=DEPT.DEPTNO);
  
--DEPT WISE
SELECT DEPTNO,COUNT(EMPNO) AS TOTAL 
FROM EMP GROUP BY DEPTNO;
 
--JOB WISE 
SELECT JOB,COUNT(EMPNO) AS TOTAL 
FROM EMP GROUP BY JOB;
 
 --BOTH
 SELECT DEPTNO,JOB,COUNT(EMPNO) AS TOTAL
 FROM EMP GROUP BY DEPTNO,JOB;
 
 --NO OF MGRS IN DEPT 10
 SELECT COUNT(EMPNO) AS TOTAL 
 FROM EMP GROUP BY JOB,DEPTNO HAVING DEPTNO=10 AND JOB='MANAGER';
 
 --deptNAME	 wise EMP
 SELECT DEPT.DNAME,COUNT(EMP.EMPNO) AS TOTAL 
 FROM DEPT LEFT JOIN EMP
 ON EMP.DEPTNO=DEPT.DEPTNO GROUP BY DEPT.DNAME;
 
 --DEPT WITH LESS THAN 5 EMPS
 SELECT DEPT.DNAME,COUNT(EMP.EMPNO) AS TOTAL 
 FROM DEPT LEFT JOIN EMP
 ON EMP.DEPTNO=DEPT.DEPTNO GROUP BY DEPT.DNAME 
 HAVING COUNT(EMP.EMPNO)<5;
 
 