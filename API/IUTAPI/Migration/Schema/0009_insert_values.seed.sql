--------------------------  Student  --------------------------------

insert into student values(1,170042001, 'Adnan', 'CSE', '`', 2017, 'Dhaka' , 'adnan01@gmail.com','Male');
insert into student values(2,160042001, 'Bashir', 'CSE', 'CSE', 2016, 'Gazipur', 'bashir02@gmail.com', 'Male');
insert into student values(3,150042001, 'Catherine', 'CSE', 'SWE', 2015, 'Tangail', 'catherine03@gmail.com','Female');
insert into student values(4,140042001, 'David', 'CSE', 'CSE',2014,'Mymensingh','david04@gmail.com','Male');
insert into student values(5,170042002, 'Ethan', 'CSE', 'CSE',2017,'Khulna', 'ethan02@gmail.com','Male');
insert into student values(6,160042002, 'Fahim', 'CSE', 'Software Engineering',2016,'Barisal','fahim02@gmail.com','Male');
insert into student values(7,150042002, 'George' ,'CSE','Software Engineering',2015,'Rajshahi','George@gmail.com','Male');
insert into student values(8,140042002, 'Hannah','CSE','CSE',2014,'Sylhet','hannah02@gmail.com','Female');
insert into student values(9,170042003, 'Ishrak', 'CSE', 'SWE',2017, 'Chittagong','Ishrak03@gmail.com','Male');
insert into student values(10,170042004, 'John', 'CSE','SWE',2017,'Rongpur','john04@gmail.com','Male');
insert into student values(11,170041001, 'Katlyn','EEE',NULL,2017,'Rongpur','katlyn01@gmail.com','Female');


----------------------------- Teacher  ----------------------------------

insert into facultymember values(1,10001,'Mr. Ahmed ','CSE','0123456789','Assistant Professor','ahmed01@gmail.com','AB2-501','Male');
insert into facultymember values(2,10002,'Mr. Bond ','EEE','01234567356','Professor','bond02@gmail.com','AB1-201','Male');
insert into facultymember values(3,10003,'Ms. Chloe','CSE','0123456709','Lecturer','chloe@gmail.com','AB2-404','Female');
insert into facultymember values(4,10004,'Ms. Diana','CSE','0123456735','Lecturer','diana04@gmail.com','AB2-501','Female');
insert into facultymember values(5,10005,'Mr. Edward','EEE','012345679','Lecturer','edward05@gmail.com','AB2-504','Male');
insert into facultymember values(6,10006,'Mr. Felix','CSE','0123456773','Part-time Faculty','felix06@gmail.com','AB2-505','Male');
insert into facultymember values(7,10007,'Ms. Graham','MCE','0123456782','Professor','graham07@gmail.com','AB2-401','Male');
insert into facultymember values(8,10008,'Ms. Hamida','CEE','0123456761','Assistant Professor','hamida08@gmail.com','AB1-404','Female');
insert into facultymember values(9,10009,'Mr. Allen','TVE','0123456753','Assistant Professor','allen09@gmail.com','AB1-408','Male');
insert into facultymember values(10,100010,'Mr. James','BTM','0123456753','Assistant Professor','james10@gmail.com','AB1-201','Male');



------------------------------  Staff  ----------------------------------------

insert into staff values(1,'101','Mr. Kader','Senior Worker','094834894','Cafeteria','Male');
insert into staff values(2,'102','Mr. Firoj','Senior Worker','094834845','Cafeteria','Male');
insert into staff values(3,'103','Mr. Ramjan','Senior Chef','094834875','Cafeteria','Male');
insert into staff values(4,'104','Mr. Monir','Senior Worker','094834868','Cafeteria','Male');
insert into staff values(5,'105','Mr. Ismail','Gate-Keeper','094834812','IUT Gate','Male');
insert into staff values(6,'106','Mr. Hafiz','Janitor','094834860','Male Hall','Male');
insert into staff values(7,'107','Mr. Imtiaz','Librarian','094834863','Library','Male');
insert into staff values(8,'108','Mr. Amzad','Assistant Secretary','094834802','Admin Building','Male');
insert into staff values(9,'109','Mr. Anwar','Secretary','094834873','Admin Building','Male');
insert into staff values(10,'110','Mr. Rayhan','Computer Operator','094834853','Computer office','Male');



-----------------------------  Course  ----------------------------------------

insert into Course values(1,'CSE 4401', 'Algorithm', 3.00, 'CSE', 4, 'Theory' , 'CSE 4301');
insert into Course values(2,'CSE 4301', 'Data Structure', 3.00, 'CSE', 3, 'Theory' , 'NULL');
insert into Course values(3,'CSE 4402', 'Algorithm', 3.00, 'CSE', 4, 'Lab' , 'CSE 4302');
insert into Course values(4,'CSE 4302', 'Linear Algebra', 3.00, 'CSE',3, 'Theory' , 'CSE 4302');
insert into Course values(5,'MCE 4403', 'Fluid Machanics', 3.00, 'MCE', 4, 'Theory' , 'Null');
insert into Course values(6,'MCE 4409', 'Fluid Machanics', 0.00, 'MCE', 4, 'Lab' , 'Null');
insert into Course values(7,'Math 4303', 'Math Calculus', 3.00, 'CSE', 3, 'Theory' , 'Math 01');
insert into Course values(8,'EEE 4404', 'EEE Curcuit', 3.00, 'EEE', 4, 'Theory' , 'CSE 4310');
insert into Course values(9,'EEE 4405', 'EEE lab', 0.75, 'EEE', 4, 'Lab' , 'NULL');
insert into Course values(10,'CSE 4406', 'HUM 4406', 3.00, 'CSE', 4, 'Theory' , 'NULL');
insert into Course values(11,'CSE 4304', 'C Programming ', 3.00, 'CSE', 3, 'Theory' , 'NULL');
insert into Course values(12,'CSE 4305', 'C Programming lab', 0.75, 'CSE', 3, 'Lab' , 'CSE 4304');
insert into Course values(13,'BTM 4407', 'Accounting', 3.00, 'BTM', 4, 'Theory' , 'NULL');
insert into Course values(14,'CEE 4401', 'Materials', 3.00, 'CEE', 4, 'Theory' , 'NULL');
insert into Course values(15,'CEE 4402', 'Materials', 0.75, 'CEE', 4, 'Lab' , 'NULL');



------------------------------  Department  ---------------------------------------

insert into Department values(1,'CSE');
insert into Department values(2,'EEE');
insert into Department values(3,'CEE');
insert into Department values(4,'MCE');
insert into Department values(5,'TVE');
insert into Department values(6,'BTM');



-------------------------------  CourseAssigned  -----------------------------------

insert into CourseAssigned values(1,'CSE 4302',10001,'3rd Semester',2016);
insert into CourseAssigned values(2,'EEE 4404',10005,'4th Semester',2017);
insert into CourseAssigned values(3,'MCE 4403',10007,'4th Semester',2018);
insert into CourseAssigned values(4,'BTM 4407',10010,'4th Semester',2015);
insert into CourseAssigned values(5,'CEE 4401',10011,'4th Semester',2017);
insert into CourseAssigned values(6,'CEE 4402',10011,'4th Semester',2017);
insert into CourseAssigned values(7,'CSE 4303',10001,'3rd Semester',2017);
insert into CourseAssigned values(8,'CSE 4404',10001,'4th Semester',2016);
insert into CourseAssigned values(9,'CSE 4405',10006,'4th Semester',2017);
insert into CourseAssigned values(10,'TVE 4401',10009,'4th Semester',2018);



-------------------------  DepartmentalCourse  ---------------------------------------



insert into DepartmentalCourse values(1,'CSE','CSE 4302');
insert into DepartmentalCourse values(2,'CSE','CSE 4401');
insert into DepartmentalCourse values(3,'CSE','CSE 4402');
insert into DepartmentalCourse values(4,'CSE','CSE 4403');
insert into DepartmentalCourse values(5,'CSE','CSE 4404');
insert into DepartmentalCourse values(6,'EEE','EEE 4401');
insert into DepartmentalCourse values(7,'CEE','CEE 4401');
insert into DepartmentalCourse values(8,'MCE','MCE 4403');
insert into DepartmentalCourse values(9,'BTM','BTM 4407');
insert into DepartmentalCourse values(10,'TVE','TVE 4401');




---------------------------room---------------------------------------------


insert into Room values(1,'AC1_101',101,1,'MCE Teacher','Academic1','Official');
insert into Room values(2,'AC1_102',102,1,'MCE Teacher','Academic1','Official');
insert into Room values(3,'AC1_103',103,1,'MCE Teacher','Academic1','Official');
insert into Room values(4,'AC1_104',104,1,'MCE Teacher','Academic1','Official');
insert into Room values(5,'AC1_105',105,1,'MCE Teacher','Academic1','Official');
insert into Room values(6,'AC1_106',106,1,'MCE Teacher','Academic1','Official');
insert into Room values(7,'AC1_107',107,1,'MCE Teacher','Academic1','Official');
insert into Room values(8,'AC1_108',108,1,'MCE Teacher','Academic1','Official');
insert into Room values(9,'AC1_109',109,1,'None','Academic1','Official');
insert into Room values(10,'AC1_110',110,1,'None','Academic1','Official');
insert into Room values(11,'AC1_111',111,1,'None','Academic1','Official');
insert into Room values(12,'AC1_112',112,1,'MCE Teacher','Academic1','Official');
insert into Room values(13,'AC1_113',113,1,'None','Academic1','Official');
insert into Room values(14,'AC1_114',114,1,'MCE Teacher','Academic1','Official');
insert into Room values(15,'AC1_115',115,1,'MCE Teacher','Academic1','Official');
insert into Room values(16,'AC1_116',116,1,'None','Academic1','Official');
insert into Room values(17,'AC1_117',117,1,'MCE Teacher','Academic1','Official');
insert into Room values(18,'AC1_118',118,1,'None','Academic1','Official');
insert into Room values(19,'AC1_119',119,1,'MCE Teacher','Academic1','Official');
insert into Room values(20,'AC1_120',120,1,'None','Academic1','Official');
insert into Room values(21,'AC1_121',121,1,'MCE Teacher','Academic1','Official');
insert into Room values(22,'AC1_122',122,1,'None','Academic1','Official');
insert into Room values(23,'AC1_123',123,1,'MCE Teacher','Academic1','Official');
insert into Room values(24,'AC1_124',124,1,'None','Academic1','Official');
insert into Room values(25,'AC1_125',125,1,'MCE Teacher','Academic1','Official');


insert into Room values(26,'AC1_201',201,2,'None','Academic1','Official');
insert into Room values(27,'AC1_202',202,2,'EEE Teacher','Academic1','Official');
insert into Room values(28,'AC1_203',203,2,'EEE Teacher','Academic1','Official');
insert into Room values(29,'AC1_204',204,2,'EEE Teacher','Academic1','Official');
insert into Room values(30,'AC1_205',205,2,'EEE Teacher','Academic1','Official');
insert into Room values(31,'AC1_206',206,2,'EEE Teacher','Academic1','Official');
insert into Room values(32,'AC1_207',207,2,'EEE Teacher','Academic1','Official');
insert into Room values(33,'AC1_208',208,2,'EEE Teacher','Academic1','Official');
insert into Room values(34,'AC1_209',209,2,'None','Academic1','Official');
insert into Room values(35,'AC1_210',210,2,'Control and Microprocessor Lab','Academic1','Lab');
insert into Room values(36,'AC1_211',211,2,'EEE Teacher','Academic1','Official');
insert into Room values(37,'AC1_212',212,2,'EEE Teacher','Academic1','Official');
insert into Room values(38,'AC1_213',213,2,'None','Academic1','Official');
insert into Room values(39,'AC1_214',214,2,'None','Academic1','Official');
insert into Room values(40,'AC1_215',215,2,'None','Academic1','Official');
insert into Room values(41,'AC1_216',216,2,'None','Academic1','Official');
insert into Room values(42,'AC1_217',217,2,'EEE Teacher','Academic1','Official');
insert into Room values(43,'AC1_218',218,2,'None','Academic1','Official');
insert into Room values(44,'AC1_219',219,2,'None','Academic1','Official');
insert into Room values(45,'AC1_220',220,2,'None','Academic1','Official');
insert into Room values(46,'AC1_221',221,2,'EEE Teacher','Academic1','Official');




insert into Room values(47,'AC1_301',301,3,'Multipurpose Room','Academic1','Official');
insert into Room values(48,'AC1_302',302,3,'TVE Teacher','Academic1','Official');
insert into Room values(49,'AC1_303',303,3,'TVE Teacher','Academic1','Official');
insert into Room values(50,'AC1_304',304,3,'TVE Teacher','Academic1','Official');
insert into Room values(51,'AC1_305',305,3,'TVE Teacher','Academic1','Official');
insert into Room values(52,'AC1_306',306,3,'TVE Teacher','Academic1','Official');
insert into Room values(53,'AC1_307',307,3,'TVE Teacher','Academic1','Official');
insert into Room values(54,'AC1_308',308,3,'TVE Teacher','Academic1','Official');
insert into Room values(55,'AC1_309',309,3,'None','Academic1','Official');
insert into Room values(56,'AC1_310',310,3,'Language Lab','Academic1','Lab');
insert into Room values(57,'AC1_311',311,3,'Audio Visual lab and seminar room','Academic1','Official');
insert into Room values(58,'AC1_312',312,3,'REASP Department','Academic1','Official');
insert into Room values(59,'AC1_313',313,3,'Instructor','Academic1','Official');
insert into Room values(60,'AC1_314',314,3,'None','Academic1','Official');
insert into Room values(61,'AC1_315',315,3,'BTM Teacher','Academic1','Official');
insert into Room values(62,'AC1_316',316,3,'None','Academic1','Official');
insert into Room values(63,'AC1_317',317,3,'None','Academic1','Official');
insert into Room values(64,'AC1_318',318,3,'BTM Teacher','Academic1','Official');


insert into Room values(65,'AC1_401',401,4,'CEE Teacher','Academic1','Official');
insert into Room values(66,'AC1_402',402,4,'CEE Teacher','Academic1','Official');
insert into Room values(67,'AC1_403',403,4,'CEE Teacher','Academic1','Official');
insert into Room values(68,'AC1_404',404,4,'CEE Teacher','Academic1','Official');
insert into Room values(69,'AC1_405',405,4,'CEE Teacher','Academic1','Official');
insert into Room values(70,'AC1_406',406,4,'CEE Teacher','Academic1','Official');
insert into Room values(71,'AC1_407',407,4,'CEE Teacher','Academic1','Official');
insert into Room values(72,'AC1_408',408,4,'CEE Teacher','Academic1','Official');
insert into Room values(73,'AC1_409',409,4,'CEE Teacher','Academic1','Official');
insert into Room values(74,'AC1_410',410,4,'CEE Teacher','Academic1','Official');
insert into Room values(75,'AC1_411',411,4,'None','Academic1','Official');
insert into Room values(76,'AC1_412',412,4,'None','Academic1','Official');
insert into Room values(77,'AC1_413',413,4,'Drawing and Design','Academic1','Official');
insert into Room values(78,'AC1_414',414,4,'None','Academic1','Official');
insert into Room values(79,'AC1_415',415,4,'None','Academic1','Official');
insert into Room values(80,'AC1_416',416,4,'None','Academic1','Official');
insert into Room values(81,'AC1_417',417,4,'None','Academic1','Official');
insert into Room values(82,'AC1_418',418,4,'CEE Teacher','Academic1','Official');




insert into Room values(83,'AC1_501',501,5,'Electronics Lab','Academic1','Lab');
insert into Room values(84,'AC1_502',502,5,'Measurements and Instrumental lab','Academic1','Lab');
insert into Room values(85,'AC1_503',503,5,'None','Academic1','Official');
insert into Room values(86,'AC1_504',504,5,'Physics Lab','Academic1','Lab');
insert into Room values(87,'AC1_505',505,5,'None','Academic1','Official');
insert into Room values(88,'AC1_506',506,5,'None','Academic1','Official');
insert into Room values(89,'AC1_507',507,5,'Telecommunication Lab','Academic1','Lab');









insert into Room values(90,'AC2_101',101,1,'CEE Classroom','Academic2','Classroom');
insert into Room values(91,'AC2_102',102,1,'CEE Classroom','Academic2','Classroom');
insert into Room values(92,'AC2_103',103,1,'Environmental Engineering lab and Hydraulics lab','Academic2','Lab');
insert into Room values(93,'AC2_104',104,1,'Concrete lab','Academic2','Lab');
insert into Room values(94,'AC2_105',105,1,'Transportation Engineering lab','Academic2','lab');
insert into Room values(95,'AC2_106',106,1,'Geotech Lab','Academic2','Lab');
insert into Room values(96,'AC2_107',107,1,'Structure Lab','Academic2','Lab');
insert into Room values(97,'AC2_108',108,1,'CEE Classroom','Academic2','Classroom');



insert into Room values(98,'AC2_201',201,2,'EEE Classroom','Academic2','Classroom');
insert into Room values(99,'AC2_202',202,2,'EEE Classroom','Academic2','Classroom');
insert into Room values(100,'AC2_203',203,2,'EEE Classroom','Academic2','Classroom');
insert into Room values(101,'AC2_204',204,2,'CSE Classroom','Academic2','Classroom');
insert into Room values(102,'AC2_205',205,2,'CSE Classroom','Academic2','Classroom');
insert into Room values(103,'AC2_206',206,2,'CEE Classroom','Academic2','Classroom');




insert into Room values(104,'AC2_301',301,3,'CSE Classroom','Academic2','Classroom');
insert into Room values(105,'AC2_302',302,3,'CSE Classroom','Academic2','Classroom');
insert into Room values(106,'AC2_303',303,3,'Server Room','Academic2','Official');
insert into Room values(107,'AC2_304',304,3,'CSE Classroom','Academic2','Classroom');
insert into Room values(108,'AC2_305',305,3,'None','Academic2','Official');
insert into Room values(109,'AC2_306',306,3,'ICT Centre Lab 3','Academic2','Lab');
insert into Room values(110,'AC2_307',307,3,'ICT Centre Lab 1 and ICT Centre Lab 2','Academic2','Lab');


insert into Room values(111,'AC2_401',401,4,'CSE Teacher','Academic2','Official');
insert into Room values(112,'AC2_402',402,4,'CSE Teacher','Academic2','Official');
insert into Room values(113,'AC2_403',403,4,'CSE Teacher','Academic2','Official');
insert into Room values(114,'AC2_404',404,4,'CSE Teacher','Academic2','Official');
insert into Room values(115,'AC2_405',405,4,'CSE Teacher','Academic2','Official');
insert into Room values(116,'AC2_406',406,4,'CSE Teacher','Academic2','Official');
insert into Room values(117,'AC2_407',407,4,'CSE Teacher','Academic2','Official');
insert into Room values(118,'AC2_408',408,4,'CSE Teacher','Academic2','Official');
insert into Room values(119,'AC2_409',409,4,'CSE Teacher','Academic2','Official');
insert into Room values(120,'AC2_410',410,4,'Lab 5 and Lab 6' , 'Academic2','Lab');
insert into Room values(121,'AC2_411',411,4,'MCE Classroom','Academic2','Classroom');

insert into Room values(122,'AC2_501',501,5,'CSE Teacher','Academic2','Official');
insert into Room values(123,'AC2_502',502,5,'CSE Teacher','Academic2','Official');
insert into Room values(124,'AC2_503',503,5,'CSE Teacher','Academic2','Official');
insert into Room values(126,'AC2_504',504,5,'CSE Teacher','Academic2','Official');
insert into Room values(127,'AC2_505',505,5,'CSE Teacher','Academic2','Official');
insert into Room values(128,'AC2_506',506,5,'CSE Teacher','Academic2','Official');
insert into Room values(129,'AC2_507',507,5,'CEE Class','Academic2','Classroom');
insert into Room values(130,'AC2_508',508,5,'CSE Class','Academic2','Classroom');
insert into Room values(131,'AC2_509',509,5,'CSE Class','Academic2','Classroom');
insert into Room values(132,'AC2_510',510,5,'CSE Class','Academic2','Classroom');
insert into Room values(133,'AC2_511',511,5,'BTM Class','Academic2','Classroom');


insert into Room values(134,'AC2_601',601,6,'CSE Teacher','Academic2','Official');
insert into Room values(135,'AC2_602',602,6,'CSE Teacher','Academic2','Official');
insert into Room values(136,'AC2_603',603,6,' MCE Classroom','Academic2','Classroom');
insert into Room values(137,'AC2_604',604,6,'MCE Classroom','Academic2','Classroom');
insert into Room values(138,'AC2_605',605,6,'CSE Lab 1','Academic2','Lab');
insert into Room values(139,'AC2_606',606,6,'MCE Classroom','Academic2','Classroom');
insert into Room values(140,'AC2_607',607,6,'CSE Lab 2','Academic2','Lab');
insert into Room values(141,'AC2_608',608,6,'CSE Lab 4','Academic2','Lab');
insert into Room values(142,'AC2_609',609,6,'CSE Lab 3','Academic2','Lab');




insert into Room values(143,'Admin_201',201,2,'Pro Vice Chancellor','Admin','Official');
insert into Room values(144,'Admin_202',202,2,'Assistant Protocol office','Admin','Official');
insert into Room values(145,'Admin_203',203,2,'Assistant Secretary to Pro Vs','Admin','Official');
insert into Room values(146,'Admin_204',204,2,'Board Room','Admin','Official');
insert into Room values(147,'Admin_205',205,2,'Committee Room','Admin','Official');
insert into Room values(148,'Admin_206',206,2,'PS to VC','Admin','Official');
insert into Room values(149,'Admin_207',207,2,'Chief Of Establishment','Admin','Official');
insert into Room values(150,'Admin_208',208,2,'None','Admin','Official');
insert into Room values(151,'Admin_209',209,2,'Assistant Vice Chancellor','Admin','Official');
insert into Room values(152,'Admin_210',210,2,'None','Admin','Official');
insert into Room values(153,'Admin_211',211,2,'VIP Room','Admin','Official');
insert into Room values(154,'Admin_212',212,2,'None','Admin','Official');
insert into Room values(155,'Admin_213',213,2,'Section Officer','Admin','Official');
insert into Room values(156,'Admin_214',214,2,'None','Admin','Official');
insert into Room values(157,'Admin_215',215,2,'Establishment and Cabinet','Admin','Official');
insert into Room values(158,'Admin_216',216,2,'None','Admin','Official');
insert into Room values(159,'Admin_217',217,2,'Photocopier Room','Admin','Official');



insert into Room values(160,'Admin_301',301,3,'None','Admin','Official');
insert into Room values(161,'Admin_302',302,3,'Account and finance','Admin','Account and finance');
insert into Room values(162,'Admin_303',303,3,'Comptroller','Admin','Official');
insert into Room values(163,'Admin_304',304,3,'Assistant Comptroller and Accounts','Admin','Accounts and Finance');
insert into Room values(164,'Admin_305',305,3,'Planning and Development','Admin','Official');
insert into Room values(165,'Admin_306',306,3,'None','Admin','Official');
insert into Room values(166,'Admin_307',307,3,'Planning and Development','Admin','Official');
insert into Room values(167,'Admin_308',308,3,'Pocket allowance+Examination+Verification+Convocation','Admin','Section Officer');
insert into Room values(168,'Admin_309',309,3,'Planning and Development','Admin','Official');
insert into Room values(169,'Admin_310',310,3,'None','Admin','Official');
insert into Room values(170,'Admin_311',311,3,'Administration','Admin','Assistant Register');
insert into Room values(171,'Admin_312',312,3,'Administration','Admin','Registrar');
insert into Room values(172,'Admin_313',313,3,'Admission + Board Scholarship + Id Card','Admin','Senior Administrative Officer');
insert into Room values(173,'Admin_314',314,3,'None','Admin','Official');
insert into Room values(174,'Admin_315',315,3,'Record Keeper','Admin','Office of assistant');
insert into Room values(175,'Admin_316',316,3,'None','Admin','Official');
insert into Room values(176,'Admin_317',317,3,'None','Admin','Official');
insert into Room values(177,'Admin_318',318,3,'None','Admin','Official');
insert into Room values(178,'Admin_319',319,3,'Information+Reception+Delivery Corner','Admin','Information');
