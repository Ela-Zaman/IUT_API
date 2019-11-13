create table DepartmentalCourse(
DC_id int identity primary key,
D_id int,
C_id int,
foreign key (D_id) references Department(D_id),
foreign key (C_id) references Course(C_id)
);