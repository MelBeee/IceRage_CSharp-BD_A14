--COMMANDES UTILISÉS DANS LA RECHERCHE / CONSULTATION 
--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////--
-- Recherche de matchs 
select * from matchs 
where DateHeure >= TO_DATE('01-01-2014', 'yyyy-mm-dd'); --selon date choisi

select * from matchs 
where (numequipevis = 1 OR numequipemai = 1) --selon equipe choisi
AND DateHeure >= '01-01-2014'; --selon date choisi

-- Recherche d'equipe
select * from equipes;

-- Recherche de joueurs
select * from joueurs;

select * from joueurs where numequipe =1; -- selon l'equipe choisi

--COMMANDES UTILISÉS DANS LE CLASSEMENT
--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////--
--Classement Joueur et Top3
select cj.Prenom, cj.Nom, j.numeromaillot, j.typejoueur, j.Photo, e.Logo, cj.point 
from ClassementJoueur cj
inner join joueurs j on j.NUMJOUEUR = cj.NUMJOUEUR
inner join EQUIPES e on e.NUMEQUIPE = cj.NUMEQUIPE
where point >=0;

-- Vue pour points joueurs
create view ClassementJoueur 
as
select sum(sj.Nbrebuts*2 + sj.nbrepasses) as Point, J.NOM, J.PRENOM, E.NOM as NomEquipe, j.numequipe, j.numjoueur
from StatistiquesJoueurs sj
inner join Joueurs J on sj.NUMJOUEUR = J.NUMJOUEUR
inner join EQUIPES E on J.NUMEQUIPE = E.NUMEQUIPE 
group by J.NOM, J.PRENOM, E.NOM, j.numequipe, j.numjoueur
order by point desc;

--Remplir combobox Division
select NOM from divisions;

--Classement Équipe selon Division
select e.LOGO, ce.NOM, e.VILLE, e.DATEINTRODUCTION, d.NOM, ce.POINTS
from ClassementEquipe ce
inner join equipes e on e.NUMEQUIPE = ce.NUMEQUIPE
inner join divisions d on d.NUMDIVISION = ce.NUMDIVISION
where d.NOM = 'Est';

-- Vue pour le nbre de Victoire vs le nbre de Defaite pour les equipes
create view CompterVictoireDefaite
as
--victoire Visiteur
select  1 as Victoire, 0 as Defaite, e.numequipe, e.nom
from matchs m inner join equipes e on e.numequipe = m.numequipevis
where m.pointagemaison < m.pointagevisiteur
union all
--Égalité Visiteur
select  0 as Victoire, 0 as Defaite, e.numequipe, e.nom
from matchs m inner join equipes e on e.numequipe = m.numequipevis
where m.pointagemaison = m.pointagevisiteur
union all
--Défaite Visiteur
select  0 as Victoire, 1 as Defaite, e.numequipe, e.nom
from matchs m inner join equipes e on e.numequipe = m.numequipevis
where m.pointagemaison > m.pointagevisiteur
union all 
--Victoire Receveur
select  1 as Victoire, 0 as Defaite, e.numequipe, e.nom
from matchs m inner join equipes e on e.numequipe = m.numequipemai
where m.pointagemaison > m.pointagevisiteur
union all
-- Égalité Receveur
select  0 as Victoire, 0 as Defaite, e.numequipe, e.nom
from matchs m inner join equipes e on e.numequipe = m.numequipemai
where m.pointagemaison = m.pointagevisiteur
union all
-- Défaite Receveur
select  0 as Victoire, 1 as Defaite, e.numequipe, e.nom
from matchs m inner join equipes e on e.numequipe = m.numequipemai
where m.pointagemaison < m.pointagevisiteur
;

create view VictoireDefaiteEquipe
as
select sum(Victoire) as Victoire, sum(Defaite) as Defaite, numequipe , nom
from CompterVictoireDefaite
group by numequipe , nom;

-- Vue pour le nombre de point Victoire pour classement equipe
create view ComptagePointEquipe
as
--victoire Visiteur
select  2 as Point, e.nom, e.numdivision, e.numequipe
from matchs m inner join equipes e on e.numequipe = m.numequipevis
where m.pointagemaison < m.pointagevisiteur
union all
--Égalité Visiteur
select  1 as Point,e.nom, e.numdivision, e.numequipe
from matchs m inner join equipes e on e.numequipe = m.numequipevis
where m.pointagemaison = m.pointagevisiteur
union all
--Défaite Visiteur
select  0 as Point,e.nom, e.numdivision, e.numequipe
from matchs m inner join equipes e on e.numequipe = m.numequipevis
where m.pointagemaison > m.pointagevisiteur
union all 
--Victoire Receveur
select  2 as Point, e.nom, e.numdivision, e.numequipe
from matchs m inner join equipes e on e.numequipe = m.numequipemai
where m.pointagemaison > m.pointagevisiteur
union all
-- Égalité Receveur
select  1 as Point,e.nom, e.numdivision, e.numequipe
from matchs m inner join equipes e on e.numequipe = m.numequipemai
where m.pointagemaison = m.pointagevisiteur
union all
-- Défaite Receveur
select  0 as Point, e.nom, e.numdivision, e.numequipe
from matchs m inner join equipes e on e.numequipe = m.numequipemai
where m.pointagemaison < m.pointagevisiteur
;
create view ClassementEquipe
as
select sum(Point) as Points,NOM,NUMDIVISION, numequipe
from ComptagePointEquipe
group by NOM,NUMDIVISION, numequipe
order by Points ;

--COMMANDES UTILISÉS DANS LA GESTION
--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////--

--/////////// GESTION DES EQUIPES ///////////--
--Remplir CB Gestion Equipe
select numequipe, nom 
from equipes;

--Remplir CB Gestion Division
select numdivision, nom 
from divisions;

-- Ajouter équipe
insert into EQUIPES
(NUMEQUIPE, NOM, LOGO, VILLE, NUMDIVISION, DATEINTRODUCTION) values
(:Numequipe,:nom,:Logo,:Ville,:NumDivision,:DateValue);

-- Modifier équipe
update EQUIPES set
NOM=:nom, VILLE=:Ville,
NUMDIVISION=:NumDivision,
DATEINTRODUCTION=:DateValue;

-- Modifier LogoEquipe
update EQUIPES set 
Logo=:Logo;

--Load Info équipe
select e.*, d.nom from equipes e 
inner join divisions d on d.numdivision = e.numdivision;

-- Supprimer une équipe
delete from equipes where numequipe = 0; --chiffre en conséquence

--/////////// GESTION DES MATCHS ///////////--
--Gestion Ajout Matchs
insert into matchs
(NUMMATCH, NUMEQUIPEVIS, NUMEQUIPEMAI, DATEHEURE, HEURE, LIEU, POINTAGEMAISON, POINTAGEVISITEUR) values
(:NumMatch,:NumEquipeVis,:NumEquipeMai,:DateHeure,:Heure, :Lieu,:PointageMaison, :PointageVisiteur);
            
--Modifier Matchs
update matchs set nummatch = :NumMatch,
numequipevis = :NumEquipeVis,
numequipemai = :NumEquipeMai,
dateheure = :DateHeure,
heure = :Heure,
lieu = :Lieu,
pointagemaison = :PointageMaison,
pointagevisiteur = :PointageVisiteur;

--Load Info Matchs
select ev.nom, em.nom, dateheure, heure, lieu, pointagemaison, pointagevisiteur, numequipevis, numequipemai
from matchs m
inner join EQUIPES ev on ev.NUMEQUIPE = m.NUMEQUIPEVIS
inner join EQUIPES em on em.NUMEQUIPE = m.NUMEQUIPEMAI;

-- Supprimer un match et stats
delete from statistiquesjoueurs where nummatch = 0; --chiffre en conséquence
delete from matchs where nummatch = 0; --chiffre en conséquence

--/////////// GESTION DES DIVISIONS ///////////--
--Ajout Division
insert into divisions
(NUMDIVISION,    NOM,    DATECREATION) values
(:NumDivision,   :Nom,   :DateValue);

--Modifier Division
update divisions set
numdivision = :NumDivision,
NOM = :Nom,
DATECREATION = :DateValue;

--Load InfoDivision
select * from divisions;

--Supprimer une division
delete from divisions where numdivision = 0; --chiffre en conséquence

--/////////// GESTION DES JOUEURS ///////////--
--Ajout Joueur
insert into joueurs
(NUMJOUEUR, NOM, PRENOM, NAISSANCE, NUMEROMAILLOT, TYPEJOUEUR, PHOTO, NUMEQUIPE) values 
(:NumJoueur, :Nom, :Prenom, :Naissance, :NumMaillot, :TypeJoueur, :Photo, :NumEquipe);

--Modifier Joueur
update joueurs set
NUMJOUEUR =      :NumJoueur,
NOM =            :Nom,
PRENOM =         :Prenom,
NAISSANCE =      :Naissance,
NUMEROMAILLOT =  :NumMaillot,
TYPEJOUEUR =     :TypeJoueur,
PHOTO =          :Photo,
NUMEQUIPE =      :NumEquipe;

--Load Info Joueur
select j.*, e.nom from joueurs j
inner join equipes e on e.NUMEQUIPE = j.numequipe;

--Supprimer un joueur
delete from joueurs where numjoueur = 0; --chiffre en conséquence

--/////////// GESTION DES STATISTIQUES ///////////--
insert into StatistiquesJoueurs 
(NUMMATCH, NUMJOUEUR, NBREBUTS, NBREPASSES, TEMPSPUNITION) values 
(:NumMatch,:NumJoueur,:NbreButs,:NbrePasses,:TempsPunition);

--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////--
-- #4 A et B
CREATE SYNONYM SynJoueurXav FOR JOUEURS;
GRANT SELECT ON SynJoueurXav TO PUBLIC;
GRANT ALL ON SynJoueurXav TO BOUCHERM;
-- #4 D
GRANT SELECT ON ClassementJoueur TO PUBLIC;
-- #4 E
CREATE INDEX NomEquipe
ON JOUEURS(Nom);
-- #4 F
CREATE INDEX DateMatch
ON Matchs (DateHeure);
