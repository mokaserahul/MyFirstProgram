select first_name, last_name, salary from employees where salary not between 10000 and 15000;


select first_name, department_name from employees inner join departments
on employees.department_id=departments.department_id;

select first_name, department_name from employees inner join departments
on employees.department_id=departments.department_id;