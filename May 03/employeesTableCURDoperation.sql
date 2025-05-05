create table employees(
	employeeid int primary key,
	firstname varchar(50),
	lastname varchar(50),
	department varchar(50),
	salary decimal(10,2),
	hiredate date
);

INSERT INTO employees VALUES
(1,'AMIT','SHARMA','COMPUTER SCIENCE',8500,'2025-05-01'),
(2,'NEHA','KUMAR','ELECTRONICS',8500,'2025-01-21'),
(3,'RAHUL','VERMA','MECHANICAL',8500,'2025-02-15'),
(4,'SNEHA','SINGH','COMPUTER SCIENCE',8500,'2024-12-16');

select * from employees;

update employees
set salary=65000
where employeeid=2 OR employeeid=3;

select firstname from employees
where salary=65000;

delete from employees
where hiredate>'2025-02-01';

