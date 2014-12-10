select m.NUMMATCH ,e.NOM, m.NUMEQUIPEMAI, m.NUMEQUIPEVIS 
from equipes e
inner join joueurs j on e.NUMEQUIPE = j.NUMEQUIPE
inner join StatistiquesJoueurs sj on j.NumJoueur = sj.NUMJOUEUR
inner join MATCHS m on sj.NUMMATCH = m.NUMMATCH
where m.NUMEQUIPEMAI > m.NUMEQUIPEVIS
;
 
union all;
select equipes.NOM from equipes;




select e.Logo,e.Nom,e.Ville,e.DateIntroduction,
d.NOM,d.NUMDIVISION
from equipes e
INNER JOIN DIVISIONS d on e.NUMDIVISION = d.NUMDIVISION
where eNumDivision = (select );

select j.NUMJOUEUR,j.prenom, j.nom, j.numeromaillot, j.typejoueur, j.photo, e.LOGO, s.NBREBUTS*2 + s.NBREPASSES as Score 
from joueurs j 
inner join equipes e on j.NUMEQUIPE = e.NUMEQUIPE 
inner join STATISTIQUESJOUEURS s on j.NUMJOUEUR = s.NUMJOUEUR
where s.NBREBUTS*2 + s.NBREPASSES  is not null
order by Score desc;

/*
CREATE TABLE Equipes
  (
    NumEquipe NUMBER (2) NOT NULL ,
    Nom       VARCHAR2 (50 CHAR) NOT NULL ,
    Logo BLOB,
    Ville            VARCHAR2 (30 CHAR) NOT NULL ,
    NumDivision      NUMBER (2) NOT NULL ,
    DateIntroduction DATE NOT NULL
  ) ;
  */