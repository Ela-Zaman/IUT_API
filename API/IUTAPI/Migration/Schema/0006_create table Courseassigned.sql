Create Table CourseAssigned(
CA_id integer primary key,
F_id int,
Semester text,
batch int,
C_id text,
foreign key (C_id) references course(C_id),
foreign key (F_id)references facultymember(F_id)

);