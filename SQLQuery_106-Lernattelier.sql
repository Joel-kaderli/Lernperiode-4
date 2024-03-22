

BACKUP DATABASE StarWarsCopy
TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\StarWars_Backupdifferenttail.bak' 
WITH DIFFERENTIAL;

SELECT 
	starship_name,
	starship_class
FROM starship
INNER JOIN starshipclass
	ON starship.starship_id = starshipclass.starshipclass_id




CREATE DATABASE StarWarsSnapshot ON 
(
    NAME = 'StarWarsNew',
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\StarWarsNewSnapshot.ss'
) AS SNAPSHOT OF StarWarsNew;



-- Schritt 1: Neue Tabelle erstellen
CREATE TABLE timeperiods (
    timeperiod_id INT PRIMARY KEY,
    timeperiod_name VARCHAR(50),
    timeperiod_days INT
);

-- Schritt 2: Daten überführen
-- Annahme: timeperiod_id für 'year' ist 2
UPDATE starship
SET 
    starship_consumables_quantity = SUBSTRING(starship_consumables, 1, PATINDEX('% %', starship_consumables) - 1),
    starship_consumables_timeperiod_id = 2
WHERE 
    starship_consumables LIKE '%year%';


