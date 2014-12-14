select sum(NbreButs), sum(NbrePasses), sum(TO_NUMBER(TempsPunition))
from StatistiquesJoueurs
where numjoueur = 17;

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

--CLASSEMENT
--/////////////////////////////////////////////////////////////////////////////////////
--Classement Joueur
select cj.Prenom, cj.Nom, j.numeromaillot, j.typejoueur, j.Photo, e.Logo, cj.point 
from ClassementJoueur cj
inner join joueurs j on j.NUMJOUEUR = cj.NUMJOUEUR
inner join EQUIPES e on e.NUMEQUIPE = cj.NUMEQUIPE
where point >=0;

--Remplir combobox Division
select NOM from divisions;

--Classement Équipe selon Division
select e.LOGO, ce.NOM, e.VILLE, e.DATEINTRODUCTION, d.NOM, ce.POINTS
from ClassementEquipe ce
inner join equipes e on e.NUMEQUIPE = ce.NUMEQUIPE
inner join divisions d on d.NUMDIVISION = ce.NUMDIVISION
where d.NOM = 'Est';

--Gestion
--/////////////////////////////////////////////////////////////////////////////////////
--Remplir CB Gestion Equipe
select numequipe, nom 
from equipes;

--Remplir CB Gestion Division
select numdivision, nom 
from divisions;

--Gestion Ajout Match
insert into matchs
(NUMMATCH, NUMEQUIPEVIS, NUMEQUIPEMAI, DATEHEURE, HEURE, LIEU, POINTAGEMAISON, POINTAGEVISITEUR) values
(:NumMatch,:NumEquipeVis,:NumEquipeMai,:DateHeure,:Heure, :Lieu,:PointageMaison, :PointageVisiteur);
            
--Modifier Match
update matchs set nummatch = :NumMatch,
numequipevis = :NumEquipeVis,
numequipemai = :NumEquipeMai,
dateheure = :DateHeure,
heure = :Heure,
lieu = :Lieu,
pointagemaison = :PointageMaison,
pointagevisiteur = :PointageVisiteur;

--Load Info Match
select ev.nom, em.nom, dateheure, heure, lieu, pointagemaison, pointagevisiteur, numequipevis, numequipemai
from matchs m
inner join EQUIPES ev on ev.NUMEQUIPE = m.NUMEQUIPEVIS
inner join EQUIPES em on em.NUMEQUIPE = m.NUMEQUIPEMAI;

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

--Ajout Joueur
insert into joueurs
(NUMJOUEUR,  NOM,    PRENOM,     NAISSANCE,  NUMEROMAILLOT,  TYPEJOUEUR,     PHOTO,  NUMEQUIPE) values (:NumJoueur, :Nom,   :Prenom,    :Naissance, :NumMaillot,    :TypeJoueur,    :Photo, :NumEquipe)";

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
inner join equipes e on e.NUMEQUIPE = j.numequipe 
