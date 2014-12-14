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

--Classement Joueur
select cj.Prenom, cj.Nom, j.numeromaillot, j.typejoueur, j.Photo, e.Logo, cj.point 
from ClassementJoueur cj
inner join joueurs j on j.NUMJOUEUR = cj.NUMJOUEUR
inner join EQUIPES e on e.NUMEQUIPE = cj.NUMEQUIPE
where point >=0;

--Remplir combobox Division
select NOM from divisions

--Classement Équipe selon Division
select e.LOGO, ce.NOM, e.VILLE, e.DATEINTRODUCTION, d.NOM, ce.POINTS
from ClassementEquipe ce
inner join equipes e on e.NUMEQUIPE = ce.NUMEQUIPE
inner join divisions d on d.NUMDIVISION = ce.NUMDIVISION
where d.NOM = 'Est'








