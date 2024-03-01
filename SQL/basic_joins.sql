-- https://leetcode.com/studyplan/top-sql-50/

-- 1378. Replace Employee ID With The Unique Identifier
SELECT unique_id, name
FROM Employees E
         LEFT JOIN EmployeeUNI EU
                   ON E.id = EU.id

-- 1068. Product Sales Analysis I
SELECT product_name, year, price
FROM Product P
    INNER JOIN Sales S
ON P.product_id = S.product_id;

-- 1581. Customer Who Visited but Did Not Make Any Transactions
SELECT customer_id, count(*) as count_no_trans
FROM Visits V
WHERE V.visit_id NOT IN (SELECT visit_id FROM Transactions)
GROUP BY V.customer_id

-- 197. Rising Temperature


-- 1661. Average Time of Process per Machine
SELECT A1.machine_id, round(avg(A2.timestamp - A1.timestamp)::numeric, 3) AS processing_time
FROM Activity A1
         INNER JOIN Activity A2
                    ON A1.machine_id = A2.machine_id
                        AND A1.process_id = A2.process_id
                        AND A1.activity_type = 'start'
                        AND A2.activity_type = 'end'
GROUP BY A1.machine_id

-- 577. Employee Bonus
SELECT name, B.bonus
FROM Employee E
         LEFT JOIN Bonus B
                   ON E.empId = B.empId
WHERE B.bonus < 1000 IS NOT false

-- 1280. Students and Examinations
SELECT St.student_id, St.student_name, Sb.subject_name, count(E.subject_name) AS attended_exams
FROM Students St
         CROSS JOIN Subjects Sb
         LEFT JOIN Examinations E
                   ON St.student_id = E.student_id AND Sb.subject_name = E.subject_name
GROUP BY St.student_id, St.student_name, Sb.subject_name
ORDER BY St.student_id, Sb.subject_name

-- 570. Managers with at Least 5 Direct Reports
SELECT e1.name FROM Employee e1
WHERE id IN
      (SELECT e2.managerId FROM Employee e2
       GROUP BY e2.managerId
       HAVING count(e2.managerId) >= 5)

-- 1934. Confirmation Rate
SELECT
    S.user_id,
    round(((count(*) filter(WHERE action = 'confirmed'))::float / count(*))::numeric, 2) AS confirmation_rate
FROM Signups S
         LEFT JOIN Confirmations C
                   ON S.user_id = C.user_id
GROUP BY S.user_id