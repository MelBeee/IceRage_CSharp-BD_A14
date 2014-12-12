CREATE TABLE Divisions
  (
    NumDivision  NUMBER (2) NOT NULL ,
    Nom          VARCHAR2 (30 CHAR) NOT NULL ,
    DateCreation DATE NOT NULL
  ) ;
ALTER TABLE Divisions ADD CONSTRAINT Divisions_PK PRIMARY KEY ( NumDivision ) ;

CREATE TABLE Joueurs
  (
    NumJoueur     NUMBER (2) NOT NULL ,
    Nom           VARCHAR2 (20 CHAR) NOT NULL ,
    Prenom        VARCHAR2 (20 CHAR) NOT NULL ,
    Naissance     DATE NOT NULL ,
    NumeroMaillot NUMBER (2) NOT NULL ,
    TypeJoueur    VARCHAR2 (15 CHAR) NOT NULL ,
    Photo varchar2(100),
    NumEquipe NUMBER (2) NOT NULL
  ) ;
ALTER TABLE Joueurs ADD CONSTRAINT CKTypeJ CHECK ( TypeJoueur IN ('Attaquant', 'Defenseur', 'Gardien')) ;
ALTER TABLE Joueurs ADD CONSTRAINT Joueurs_PK PRIMARY KEY ( NumJoueur ) ;

CREATE TABLE StatistiquesJoueurs
  (
    NumMatch       NUMBER (3) NOT NULL ,
    NumJoueur      NUMBER (2) NOT NULL ,
    NbreButs       NUMBER (2) ,
    NbrePasses     NUMBER (2) ,
    TempsPunition VARCHAR2(5)
  );
ALTER TABLE StatistiquesJoueurs ADD CONSTRAINT StatistiquesJoueurs_PK PRIMARY KEY ( NumMatch, NumJoueur ) ;

CREATE TABLE Matchs
  (
    NumMatch     NUMBER (3) NOT NULL ,
    NumEquipeVis NUMBER (2) NOT NULL ,
    NumEquipeMai NUMBER (2) NOT NULL ,
    DateHeure      DATE NOT NULL ,
    Lieu         VARCHAR2 (30 CHAR) NOT NULL 
  ) ;
ALTER TABLE Matchs ADD CONSTRAINT Matchs_PK PRIMARY KEY ( NumMatch ) ;
ALTER TABLE MATCHS ADD PointageMaison NUMBER(2);
ALTER TABLE MATCHS ADD PointageVisiteur NUMBER(2);
ALTER TABLE MATCHS ADD Heure VARCHAR2(5);

CREATE TABLE Equipes
  (
    NumEquipe NUMBER (2) NOT NULL ,
    Nom       VARCHAR2 (50 CHAR) NOT NULL ,
    Logo BLOB,
    Ville            VARCHAR2 (30 CHAR) NOT NULL ,
    NumDivision      NUMBER (2) NOT NULL ,
    DateIntroduction DATE NOT NULL
  ) ;
ALTER TABLE Equipes ADD CONSTRAINT Equipes_PK PRIMARY KEY ( NumEquipe ) ;

ALTER TABLE StatistiquesJoueurs ADD CONSTRAINT StatistiquesJoueurs_Joueurs_FK FOREIGN KEY ( NumJoueur ) REFERENCES Joueurs ( NumJoueur ) ;

ALTER TABLE StatistiquesJoueurs ADD CONSTRAINT StatistiquesJoueurs_Matchs_FK FOREIGN KEY ( NumMatch ) REFERENCES Matchs ( NumMatch ) ;

ALTER TABLE Joueurs ADD CONSTRAINT Joueurs_Equipes_FK FOREIGN KEY ( NumEquipe ) REFERENCES Equipes ( NumEquipe ) ON
DELETE CASCADE ;

ALTER TABLE Matchs ADD CONSTRAINT Matchs_Equipes_FK FOREIGN KEY ( NumEquipeVis ) REFERENCES Equipes ( NumEquipe ) ON
DELETE CASCADE ;

ALTER TABLE Matchs ADD CONSTRAINT Matchs_Equipes_FKv2 FOREIGN KEY ( NumEquipeMai ) REFERENCES Equipes ( NumEquipe ) ON
DELETE CASCADE ;

ALTER TABLE Equipes ADD CONSTRAINT Equipes_Divisions_FK FOREIGN KEY ( NumDivision ) REFERENCES Divisions ( NumDivision ) ON
DELETE CASCADE ;

CREATE SEQUENCE CKDivision START WITH 1 NOCACHE ORDER ;
CREATE OR REPLACE TRIGGER Divisions_NumDivision_TRG BEFORE
  INSERT ON Divisions FOR EACH ROW BEGIN :NEW.NumDivision := CKDivision.NEXTVAL;
END;
/

CREATE SEQUENCE CKNumJoueur START WITH 1 NOCACHE ORDER ;
CREATE OR REPLACE TRIGGER Joueurs_NumJoueur_TRG BEFORE
  INSERT ON Joueurs FOR EACH ROW BEGIN :NEW.NumJoueur := CKNumJoueur.NEXTVAL;
END;
/
CREATE SEQUENCE CKNumMatch START WITH 1 NOCACHE ORDER ;
CREATE OR REPLACE TRIGGER Matchs_NumMatch_TRG BEFORE
  INSERT ON Matchs FOR EACH ROW BEGIN :NEW.NumMatch := CKNumMatch.NEXTVAL;
END;
/
CREATE SEQUENCE CKNumEquipe START WITH 1 NOCACHE ORDER ;
CREATE OR REPLACE TRIGGER Equipes_NumEquipe_TRG BEFORE
  INSERT ON Equipes FOR EACH ROW BEGIN :NEW.NumEquipe := CKNumEquipe.NEXTVAL;
END;
/
COMMIT; 