--Base  de Donneés De projet fin d'etudes ( Application desktop Gestion D'une Ecole )--

Create database Gestion_Ecole 

Use Gestion_Ecole

Create table Login (
LoginA Varchar (10),
Mdp Varchar (20),
SerieA Varchar (20) primary key,
NomA Varchar (30),
)
 insert into Login Values ('Admin','11223344','HH1234','Hamza')

select * from Login
----------------------------------------TABLE ETUDIANT----------------------------------------------------------------------
Create Table Etudiant(
Code_E int primary key ,
Nom Varchar (15),
Prenom varchar (15),
CIN varchar(10),
Date_Naissance Date ,
Numero_telephone int unique,-- check (Numero_telephone like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
Adresse Varchar (100),
Code_F int  foreign key references  Filiére (Code_F) ON DELETE CASCADE
)

 


select * from Etudiant
select * from  Filiére
----------------------------------------TABLE Filiére ----------------------------------------------------------------------

Create  table Filiére(
Code_F int primary key ,
libelle varchar (50),
type_F Varchar (20),
)
 insert into  Filiére values ('1','TDI','1er Année')

select*From Filiére

----------------------------------------TABLE Professeur ---------------------------------------------------------------------

Create table Professeur(
Cin_P varchar(10) primary key  ,
Nom Varchar (15),
Prenom Varchar (20),

)
select*From Professeur

----------------------------------------TABLE Matiére ---------------------------------------------------------------------
Create table Matiére(
Code_M int Primary key   ,
libelle_M varchar (50),
coefficient int ,
Cin_P varchar(10)  foreign key references  Professeur (Cin_P) ON DELETE CASCADE

)
 insert into  Matiére values ('1','PFE','3','1')

select*From Matiére


----------------------------------------TABLE Evaluation ---------------------------------------------------------------------
Create table Evaluation (

Code_E int   foreign key references  Etudiant (Code_E) ON DELETE CASCADE,

Code_M int foreign key references Matiére (Code_M) ON DELETE CASCADE,

note Float,

CodeEvaluatio int primary key identity
)

select*From Evaluation

----------------------------------------TABLE des Absences -------------------------------------------------------------------
Create  table AbsenceE(
Code_E int   foreign key references  Etudiant (Code_E) ON DELETE CASCADE,

Code_M int foreign key references Matiére (Code_M) ON DELETE CASCADE,

date_absence date,
)
select*From AbsenceE



Create table AbsenceP(
Cin_P varchar(10)  foreign key references  Professeur (Cin_P) ON DELETE CASCADE,

Date_absence date ,
)
select*From AbsenceP

