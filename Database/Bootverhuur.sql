drop table vaarwater cascade constraints;
drop table typevaarwater cascade constraints;
drop table type cascade constraints;
drop table boot cascade constraints;
drop table boothuur cascade constraints;
drop table huurcontract cascade constraints;
drop table klant cascade constraints;
drop table huurmateriaal cascade constraints;
drop table materiaal cascade constraints;

drop sequence ai_klant;
drop sequence ai_huur;
drop sequence ai_materiaal;
drop sequence ai_vaarwater;

create sequence ai_klant;
create sequence ai_huur;
create sequence ai_materiaal;
create sequence ai_vaarwater;

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
Klasse VARCHAR2(100)
);

CREATE TABLE HUURCONTRACT(
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

CREATE OR REPLACE TRIGGER Huur_ai
BEFORE INSERT ON HUURCONTRACT
FOR EACH ROW
BEGIN
:new.HuurID := ai_huur.NEXTVAL;
END;
/

CREATE OR REPLACE TRIGGER materiaal_ai
BEFORE INSERT ON KLANT
FOR EACH ROW
BEGIN
:new.MateriaalID := ai_materiaal.NEXTVAL;
END;
/

CREATE OR REPLACE TRIGGER vaarwater_ai
BEFORE INSERT ON KLANT
FOR EACH ROW
BEGIN
:new.VaarwaterID := ai_vaarwater.NEXTVAL;
END;
/