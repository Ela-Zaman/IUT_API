﻿    CREATE TABLE room
(
    roomid text,
    roomno integer,
	level integer;
    roomname text,
    building text,
    roomtype text,
    CONSTRAINT room_pkey PRIMARY KEY (roomid)
);