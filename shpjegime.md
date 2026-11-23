#Lab 01 - Instalimi  i ambientit të zhvillimit

##Pershkrimi
Ky laborator ka për qëllim të tregojë mënyrën e instalimit të ambientit të zhvillimit dhe lidhjen me databazen 'StudentDB' ne SQL Server Express, per te numeruar rreshtat e tabeles studentet.

##Hapat e ekzekutimit
1. Instaloni SQL Server Express dhe SQL Server Management Studio (SSMS) në kompjuter
2. Krijoni një databazë të re me emrin 'StudentDB' në SQL Server Express

CREATE DATABASE StudentDB;
GO

USE StudentDB;
GO

3. Krijoni një tabelë të re me emrin 'studentet' në databazën 'StudentDB' me kolonat e mëposhtme:
   CREATE TABLE Studentet (
    Id INT IDENTITY PRIMARY KEY,
    Emri NVARCHAR(50) NOT NULL,
    Mbiemri NVARCHAR(50) NOT NULL
);
GO

4. Shtoni disa rreshta të dhënash në tabelën 'studentet' për testim:

INSERT INTO Studentet (Emri, Mbiemri) VALUES
(N'Orkida', N'Loku'),
(N'Orgest', N'Loku'),
(N'Serena', N'Loku');
GO

5. Ekzekutoni një query për të numeruar rreshtat e tabelës 'studentet':
SELECT COUNT(*) FROM Studentet;

6. Shikoni rezultatin e query-t për të parë numrin e rreshtave në tabelën 'studentet'.

7. Ekzekutohet kodi ne Program.cs per te testuar lidhjen me databazen dhe numerimin e rreshtave.

##Statusi dhe veshtiresite e hasura

Aplikacioni funksionon plotësisht pa gabime. Gjatë konfigurimit u shtua parametri TrustServerCertificate=True në connection string për të lejuar lidhjen e enkriptuar me serverin lokal të SQL Server Express.
