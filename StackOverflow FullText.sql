
CREATE FULLTEXT CATALOG  SO_FullText_Cat AS DEFAULT
;

CREATE FULLTEXT INDEX ON dbo.Posts (Title LANGUAGE 1033, prod_desc LANGUAGE 1033)
KEY INDEX PK_Posts ON SO_FullText_Cat WITH STOPLIST = SYSTEM;
;

ALTER FULLTEXT INDEX ON dbo.Posts START FULL POPULATION;
;



