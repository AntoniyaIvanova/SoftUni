ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC071EF6F709

ALTER TABLE Users
ADD CONSTRAINT PK_CompositeIdUsername
PRIMARY KEY(Id, Username)