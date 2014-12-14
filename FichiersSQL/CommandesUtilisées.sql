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
--�galit� Visiteur
select  1 as Point,e.nom, e.numdivision, e.numequipe
from matchs m inner join equipes e on e.numequipe = m.numequipevis
where m.pointagemaison = m.pointagevisiteur
union all
--D�faite Visiteur
select  0 as Point,e.nom, e.numdivision, e.numequipe
from matchs m inner join equipes e on e.numequipe = m.numequipevis
where m.pointagemaison > m.pointagevisiteur
union all 
--Victoire Receveur
select  2 as Point, e.nom, e.numdivision, e.numequipe
from matchs m inner join equipes e on e.numequipe = m.numequipemai
where m.pointagemaison > m.pointagevisiteur
union all
-- �galit� Receveur
select  1 as Point,e.nom, e.numdivision, e.numequipe
from matchs m inner join equipes e on e.numequipe = m.numequipemai
where m.pointagemaison = m.pointagevisiteur
union all
-- D�faite Receveur
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