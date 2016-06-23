drop table vaarwater cascade constraints;
drop table typevaarwater cascade constraints;
drop table type cascade constraints;
drop table boot cascade constraints;
drop table boothuur cascade constraints;
drop table huur cascade constraints;
drop table klant cascade constraints;
drop table huurmateriaal cascade constraints;
drop table materiaal cascade constraints;

drop sequence ai_klant;
drop sequence ai_huur;
drop sequence ai_materiaal;
drop sequence ai_vaarwater;

create sequence ai_klant
START WITH 100;
create sequence ai_huur
START WITH 100;
create sequence ai_materiaal
START WITH 100;
create sequence ai_vaarwater
START WITH 100;

CREATE TABLE KLANT(
KlantID NUMBER PRIMARY KEY,
Naam VARCHAR2(255) NOT NULL,
Email VARCHAR2(255) NOT NULL
);

CREATE TABLE Type(
Type VARCHAR2(255) PRIMARY KEY,
Omschrijving VARCHAR2(255) NOT NULL
);

CREATE TABLE BOOT(
Naam VARCHAR2(255) PRIMARY KEY,
Type REFERENCES Type(Type) NOT NULL,
Literinhoud NUMBER,
Klasse VARCHAR2(100) NOT NULL
);

CREATE TABLE HUUR(
HuurID NUMBER PRIMARY KEY,
KlantID REFERENCES Klant(KlantID),
DatumBegin DATE NOT NULL,
DatumEind DATE NOT NULL,
Verhuurder VARCHAR2(255) NOT NULL
);

CREATE TABLE BOOTHUUR(
Naam REFERENCES Boot(Naam),
HuurID REFERENCES Huur(HuurID),
PRIMARY KEY(Naam,HuurID)
);

CREATE TABLE MATERIAAL(
MateriaalID NUMBER PRIMARY KEY,
Naam VARCHAR2(255) NOT NULL,
Omschrijving VARCHAR2(255),
Pakket REFERENCES Materiaal(MateriaalID)
);

CREATE TABLE HUURMATERIAAL(
HuurID REFERENCES Huur(HuurID),
MateriaalID REFERENCES Materiaal(MateriaalID),
PRIMARY KEY(HuurID,MateriaalID)
);

CREATE TABLE VAARWATER(
VaarwaterID NUMBER PRIMARY KEY,
Naam VARCHAR2(100) NOT NULL
);

CREATE TABLE TYPEVAARWATER(
VaarwaterID REFERENCES Vaarwater(VaarwaterID),
Type REFERENCES Type(Type),
PRIMARY KEY(VaarwaterID,Type)
);

CREATE OR REPLACE TRIGGER klant_ai
BEFORE INSERT ON KLANT
FOR EACH ROW
BEGIN
:new.KlantID := ai_klant.NEXTVAL;
END;
/

CREATE OR REPLACE TRIGGER Huurcontract_ai
BEFORE INSERT ON HUUR
FOR EACH ROW
BEGIN
:new.HuurID := ai_huur.NEXTVAL;
END;
/

CREATE OR REPLACE TRIGGER materiaal_ai
BEFORE INSERT ON MATERIAAL
FOR EACH ROW
BEGIN
:new.MateriaalID := ai_materiaal.NEXTVAL;
END;
/

CREATE OR REPLACE TRIGGER vaarwater_ai
BEFORE INSERT ON VAARWATER
FOR EACH ROW
BEGIN
:new.VaarwaterID := ai_vaarwater.NEXTVAL;
END;
/

-- INSERTS --

--Vaarwater Inserts--
INSERT INTO VAARWATER(Naam) VALUES('IJsselmeer');
INSERT INTO VAARWATER(Naam) VALUES('Noordzee');

--Type Inserts--
INSERT INTO TYPE(Type,Omschrijving) VALUES ('Motorboot','Dit is een boot die aangedreven wordt door een motor');
INSERT INTO TYPE(Type,Omschrijving) VALUES ('Spierkrachtboot', 'Dit is een boot die aangedreven wordt door spierkracht of wind');

-- TypeVaarwater Inserts--
INSERT INTO TypeVaarwater(VaarwaterID,Type) VALUES(100,'Motorboot');
INSERT INTO TypeVaarwater(VaarwaterID,Type) VALUES(101,'Motorboot');

--Boot Inserts--
INSERT INTO Boot(Naam,Type,Literinhoud,Klasse) VALUES('Snelboot','Motorboot',15,'Kruiser');
INSERT INTO Boot(Naam,Type,Literinhoud,Klasse) VALUES('Niet zo snel boot','Motorboot',20,'Kruiser');
INSERT INTO Boot(Naam,Type,Literinhoud,Klasse) VALUES('Ook een snelle boot','Motorboot',15,'Kruiser');
INSERT INTO Boot(Naam,Type,Literinhoud,Klasse) VALUES('Langvaarboot','Motorboot',50,'Kruiser');
INSERT INTO BOOT(Naam,Type,Klasse) VALUES('Langzameboot','Spierkrachtboot','Valk');
INSERT INTO BOOT(Naam,Type,Klasse) VALUES('De Horizon','Spierkrachtboot','Valk');
INSERT INTO BOOT(Naam,Type,Klasse) VALUES('De Zonsondergang','Spierkrachtboot','Valk');
INSERT INTO BOOT(Naam,Type,Klasse) VALUES('De Dageraad','Spierkrachtboot','Valk');
INSERT INTO BOOT(Naam,Type,Klasse) VALUES('Blauw licht','Spierkrachtboot','Laser');
INSERT INTO BOOT(Naam,Type,Klasse) VALUES('Rood licht','Spierkrachtboot','Laser');
INSERT INTO BOOT(Naam,Type,Klasse) VALUES('Groen licht','Spierkrachtboot','Laser');
INSERT INTO BOOT(Naam,Type,Klasse) VALUES('Roei tot je een ons weegt','Spierkrachtboot','Kano');
INSERT INTO BOOT(Naam,Type,Klasse) VALUES('Twee peddels extra','Spierkrachtboot','Kano');
INSERT INTO BOOT(Naam,Type,Klasse) VALUES('Twee peddels minder','Spierkrachtboot','Kano');

--Materiaal Insert--
INSERT INTO MATERIAAL(Naam, Omschrijving) VALUES('SlaapPakket','Dit pakket bestaat uit een luchtbed en een slaapzak');
INSERT INTO MATERIAAL(Naam, Omschrijving) VALUES('KookPakket','Met dit pakket kun je aan wal koken');
INSERT INTO MATERIAAL(Naam, Omschrijving) VALUES('Zaklamp','Schijnt tot 100m ver!');
INSERT INTO MATERIAAL(Naam, Omschrijving) VALUES('Zwemvest','Zodat je niet verdrinkt!');
INSERT INTO MATERIAAL(Naam, Omschrijving, Pakket) VALUES('Luchtbed','Om op te slapen',100);
INSERT INTO MATERIAAL(Naam, Omschrijving, Pakket) VALUES('Slaapzak','Om in te slapen',100);
INSERT INTO MATERIAAL(Naam, Omschrijving, Pakket) VALUES('Gaspit','Om op te koken',101);
INSERT INTO MATERIAAL(Naam, Omschrijving, Pakket) VALUES('Gasfles','Inclusief gas! Om mee te koken',101);
INSERT INTO MATERIAAL(Naam, Omschrijving, Pakket) VALUES('Koelbox','Dan blijft je eten lekker vers!',101);
INSERT INTO MATERIAAL(Naam, Omschrijving, Pakket) VALUES('Servies','Nu kun je ook ergens op eten',101);