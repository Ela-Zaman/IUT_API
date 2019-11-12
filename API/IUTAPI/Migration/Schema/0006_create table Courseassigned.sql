Create Table CourseAssigned(
c_a_id integer primary key,
employeeId int,
Semester text,
batch int,
courseid text,
foreign key (courseid) references course(courseid),
foreign key (employeeid)references facultymember(employeeid)
);