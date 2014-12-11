select sum(NbreButs), sum(NbrePasses), sum(TO_NUMBER(TempsPunition))
from StatistiquesJoueurs
where numjoueur = 17;