select sum(NbreButs), sum(NbrePasses), sum(TO_NUMBER(TempsPunition))
from StatistiquesJoueurs
where numjoueur = 17;


select * from equipes;

delete from matchs where nummatch = 11;

delete from equipes where numequipe = 30;