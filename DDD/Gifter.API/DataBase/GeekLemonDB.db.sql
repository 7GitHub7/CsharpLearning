BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Judges" (
	"ID"	INTEGER NOT NULL UNIQUE,
	"Login"	TEXT NOT NULL,
	"Password"	TEXT NOT NULL,
	"BirthDate"	TEXT NOT NULL,
	"Name_First"	TEXT NOT NULL,
	"Name_Last"	TEXT NOT NULL,
	"Email_ForeConference"	TEXT,
	"Email_ForSpeakers"	TEXT,
	"Phone_ForSpekers"	TEXT,
	"Phone_ForConference"	TEXT,
	"CategoryID"	INTEGER NOT NULL,
	CONSTRAINT "PK_Judges_KEY" PRIMARY KEY("ID" AUTOINCREMENT),
	CONSTRAINT "FK_CategoryId_Judges" FOREIGN KEY("CategoryID") REFERENCES "Categories"
);
CREATE TABLE IF NOT EXISTS "Categories" (
	"ID"	INTEGER NOT NULL UNIQUE,
	"DisplayName"	TEXT,
	"Name"	TEXT,
	"WhatWeAreLookingFor"	TEXT,
	PRIMARY KEY("ID" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "CallForSpeakes" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"Number"	TEXT NOT NULL,
	"Status"	INTEGER NOT NULL,
	"PreliminaryDecision_DecisionBy"	NUMERIC,
	"PreliminaryDecision_Date"	TEXT,
	"FinalDecision_DecisionBy"	INTEGER,
	"FinalDecision_Date"	TEXT,
	"Speaker_Name_First"	TEXT NOT NULL,
	"Speaker_Name_Last"	TEXT NOT NULL,
	"Speaker_Adress_Country"	TEXT NOT NULL,
	"Speaker_Adress_ZipCode"	TEXT NOT NULL,
	"Speaker_Adress_City"	TEXT NOT NULL,
	"Speaker_Adress_Street"	TEXT NOT NULL,
	"Speaker_Websites_Facebook"	TEXT,
	"Speaker_Websites_Twitter"	TEXT,
	"Speaker_Websites_Instagram"	TEXT,
	"Speaker_Websites_LinkedIn"	TEXT,
	"Speaker_Websites_TikTok"	TEXT,
	"Speaker_Websites_Youtube"	REAL,
	"Speaker_Websites_FanPageOnFacebook"	REAL,
	"Speaker_Websites_GitHub"	TEXT,
	"Speaker_Websites_Blog"	TEXT,
	"Speaker_BIO"	TEXT NOT NULL,
	"Speaker_Phone"	TEXT,
	"Speaker_Email"	TEXT NOT NULL,
	"Speaker_Birthdate"	TEXT,
	"Speech_Title"	TEXT NOT NULL,
	"Speech_Description"	TEXT NOT NULL,
	"Speech_Tags"	TEXT NOT NULL,
	"Speech_ForWhichAudience"	INTEGER NOT NULL,
	"Speech_TechnologyOrBussinessStory"	INTEGER NOT NULL,
	"Registration_RegistrationDate"	TEXT,
	"CategoryId"	INTEGER NOT NULL,
	"Score_Score"	INTEGER,
	"Score_RejectExplanation"	TEXT,
	"Score_WarringExplanation"	TEXT,
	CONSTRAINT "PK_CallForSpeakes_PK" PRIMARY KEY("Id" AUTOINCREMENT),
	CONSTRAINT "FK_JudgeID_CallForSpeech_PreminaryDecision_DecysionBy" FOREIGN KEY("PreliminaryDecision_DecisionBy") REFERENCES "Judges",
	CONSTRAINT "FK_JudgeID_CallForSpeech_FinalDecision_DecysionBy" FOREIGN KEY("FinalDecision_DecisionBy") REFERENCES "Judges",
	CONSTRAINT "FK_CategoryID_CallForSpeakes" FOREIGN KEY("CategoryId") REFERENCES "Categories"
);
INSERT INTO "Judges" VALUES (1,'Bartek','Bartek','30-12-1980','Bartosz','Gutkowski','Gutkowski@wp.pl','Gutkowski@geeklemonconference.pl','(+48)555 555 555','(+48)777 555 777',1);
INSERT INTO "Judges" VALUES (2,'Jakub','Jakub','22-11-1982','Jakub','Stapp','Stapp@wp.pl','Stapp@geeklemonconference.pl','(+48)555 555 555','(+48)777 555 777',1);
INSERT INTO "Judges" VALUES (3,'Anita','Anita','13-01-1987','Anita','Bartyzel','Bartyzel@geeklemonconference.pl','Bartyzel@wp.pl','(+48)555 555 555','(+48)777 555 777',2);
INSERT INTO "Judges" VALUES (4,'Piotr','Piotr','23-05-1981','Jakub','Wicherski','Wicherski@geeklemonconference.pl','Wicherski@wp.pl','(+48)555 555 555','(+48)777 555 777',2);
INSERT INTO "Judges" VALUES (5,'Damian','Damian','23-09-1985','Damian','Sob??tka','Sobotka@geeklemonconference.pl','Sobotka@wp.pl','(+48)555 555 555','(+48)777 555 777',3);
INSERT INTO "Judges" VALUES (6,'Tomasz','Tomasz','23-09-1989','Tomasz','Pilimon','Pilimon@geeklemonconference.pl','Pilimon@wp.pl','(+48)555 555 555','(+48)777 555 777',3);
INSERT INTO "Judges" VALUES (7,'Michal','Michal','23-09-1989','Micha??','Libudzic','Libudzic@geeklemonconference.pl','Libudzic@wp.pl','(+48)555 555 555','(+48)777 555 777',4);
INSERT INTO "Judges" VALUES (8,'Pawel','Pawel','23-09-1989','Pawe??','Mazurek','Mazurek@geeklemonconference.pl','Mazurek@wp.pl','(+48)555 555 555','(+48)777 555 777',4);
INSERT INTO "Judges" VALUES (9,'Grzegorz','Grzegorz','23-09-1989','Grzegorz','Przygudzki','Przygudzki@geeklemonconference.pl','Przygudzki@wp.pl','(+48)555 555 555','(+48)777 555 777',5);
INSERT INTO "Judges" VALUES (10,'Krzysztof','Krzysztof','23-09-1989','Krzysztof','Piwowarek','Piwowarek@geeklemonconference.pl','Piwowarek@wp.pl','(+48)555 555 555','(+48)777 555 777',5);
INSERT INTO "Judges" VALUES (11,'Maciek','Maciek','23-09-1990','Maciek','Zub','Zub@geeklemonconference.pl','Zub@wp.pl','(+48)555 555 555','(+48)777 555 777',6);
INSERT INTO "Judges" VALUES (12,'Hubert','Hubert','15-06-1980','Hubert','Korsan','Korsan@geeklemonconference.pl','Korsan@wp.pl','(+48)555 555 555','(+48)777 555 777',6);
INSERT INTO "Judges" VALUES (13,'GregoryA','GregoryB','20-02-2021','Gregory','Zakrowiski','Zakrowiski@wp.pl','Zakrowiski@geeklemonconference.pl','(51)222 555 555','(51)222 555 777',7);
INSERT INTO "Categories" VALUES (1,'.NET','DotNet','Szukamy war-stories, czyli czego?? co osoba m??wi??ca prze??y??a, bra??a czynny udzia?? i wysz??a na lub pod tarcz??. Czyli ??yciowych problem??w i rozwi??za??. To taki nasz konik. W drugiej kolejno??ci patrzymy na ciekawe przekrojowe tematy, kt??re poruszaj?? wzorce, style architektoniczne i inne ciekawe aspekty programowania w .net kt??re maj?? g????bszy sens a do tego nie przemijaj?? z wiatrem. Nast??pnie ciekaw narz??dzia, kt??re mog?? nam pom??c i wesprze?? w codziennej pracy ??? na przyk??ad testy konwencji za pomoc?? specjalnego narz??dzia do dotnet kt??re to umo??liwia robi??. Na ko??cu za?? biblioteki i frameworki.');
INSERT INTO "Categories" VALUES (2,'Architektury Aplikacji','Architecture','Szukamy temat??w, w kt??rych od razu wiadomo czego konkretnie uczestnik si?? dowie i co musi ju?? wiedzie??.
Je??eli masz temat og??lny i przekrojowy, to napisz jakie decyzje b??dziemy mogli lepiej podejmowa?? dzi??ki tej prezentacji.
Je??eli masz temat narz??dziowy, to napisz jaki problem albo jaki cel
konkretnie mo??emy zaadresowa?? po tej prezentacji.');
INSERT INTO "Categories" VALUES (3,'Soft Skills','SoftSkills','Kompetencje mi??kkie i budowanie relacji w biznesie inaczej. Ostatni rok pokaza??, ??e ??yjemy w bardzo niepewnych czasach. Potrzebujemy zatem nowych umiej??tno??ci, innowacyjnych rozwi??za?? i ??wie??ego podej??cia w tym jak wykonujemy swoj?? prac??. W tym roku stawiamy na kompetencje mi??kkie i budowanie relacji w biznesie po rebeliancku. Szukamy nowych, odwa??nych i eksperymentalnych metod wsp????pracy mi??dzy lud??mi oraz z klientami. Nawet je??li u??y??e?? jakiej?? metody tylko raz, ale prezentuje zupe??nie nowy spos??b my??lenia, to jeste??my ni?? zainteresowani.
Zaskocz nas i innych uczestnik??w konferencji 4Developers 2021 i do????cz do rebelii!');
INSERT INTO "Categories" VALUES (4,'Testerska','Tester','Zapraszamy ka??d?? osob??, kt??ra chce si?? podzieli?? swoim do??wiadczeniem/projektem/pora??kami/sukcesami/przemy??leniami w temacie testowania oprogramowania. Od pocz??tkuj??cego do zaawansowanego. W pe??ni wspomo??emy w przygotowaniach do poprowadzenia prelekcji.');
INSERT INTO "Categories" VALUES (5,'Cloud','Cloud','Tematy na kt??rych b??dziemy si?? skupia?? podczas tegorocznej edycji:
Chmura publiczna
Chmura hybrydowa
Multicloud
IaaS
IoT / Edge computing
Przetwarzanie danych
Security
Serverless');
INSERT INTO "Categories" VALUES (6,'PHP','PHP','Moja propozycja na motyw przysz??orocznej ??cie??ki PHP to ???lepsze jutro w Twoim projekcie???. Rozumiem przez to praktyczne sposoby na wyj??cie z obecnych problem??w w istniej??cych projektach od ludzi, kt??rym to si?? uda??o. Wiele os??b utkn????o w projektach, gdzie nic si?? nie zmienia, bo nikt nie ma wystarczaj??cej wiedzy ani do??wiadczenia (ani odwagi), ??eby ruszy?? co??, co dzia??a od lat. Takie osoby przychodz?? na konferencje, widz?? te wszystkie nowe l??ni??ce narz??dzia, ale nie maj?? jak zasypa?? tego w??wozu pomi??dzy w??asnymi projektami a ???nowym wspania??ym ??wiatem???. Dzi??ki takiemu podej??ciu mo??emy dowolny temat pokaza?? od strony drogi, jak?? przesz??y projekty prelegent??w. Zamiast opowiada?? po raz kolejny o danym narz??dziu, niech prelegent poka??e jak?? drog?? sam z nim przeszed??, im bardziej ???mi??si??cie???, tym lepiej. Oczywi??cie zachowamy balans, tj. na pewno pojawi?? si?? propozycje o PHP8, testowaniu, frameworkach, etc., ale by??oby interesuj??ce, gdyby prelegenci pokazali temat z ww. perspektywy.');
INSERT INTO "Categories" VALUES (7,'Java','Java','Szukamy temat??w, kt??re zwi??zane s?? z ca??ym ekosystemem JVM. Mog?? dotyczy?? przyk??adowo, nowo??ci w j??zyku, ciekawostek, wydajno??ci, framework??w czy dobrych praktyk. Z racji tego, ??e 4Developers ????czy ze sob?? wiele r????nych technologii, dobrze by by??o, ??eby tematy by??y potencjalnie interesuj??ce dla szerokiej grupy odbiorc??w, ale nie oznacza to, ??e tematy niszowe s?? z g??ry przekre??lone. Po prostu musimy zachowa?? odpowiedni balans podczas uk??adania agendy.');
INSERT INTO "Categories" VALUES (8,'JavaScript','JavaScript','Zapraszamy do zg??aszania wyst??pie?? zwi??zanych dowolnie z tematyk?? JavaScript ??? zar??wno tych bliskich przegl??darce, jak i zwi??zanych z backendem oraz node.js! W tym i nadchodz??cym roku nowymi gor??cymi tematami zdaj?? si?? by??: WebAssembly, Micro-frontends, JS w chmurze, (Dev)Ops z Node.js. R??wnie?? kr??luj??ce dotychczas tematy jak TypeScript oraz GraphQL wci???? mocno grzej?? i nie zanosi si?? by przesta??y ;). Zach??camy do zg??aszania prelekcji dotycz??cych zar??wno wymienionych, jak i dowolnych innych temat??w.
');
INSERT INTO "Categories" VALUES (9,'Frontend / UI','Frontend','Je??li chodzi o now?? ??cie??k?? Frontend/UI ch??tnie pos??ucham o design systemach, dost??pno??ci, metodach na usprawnienie pracy na linii design ??? developerzy, wtyczkach do Figmy/XD, kosmicznych zastosowaniach zmiennych w CSS ??? generalnie o wszystkim co wi????e si?? z frontendem w przegl??darce, a niekoniecznie jest kolejnym frameworkiem JS Je??li nie masz pewno??ci czy Twoja prezentacja powinna by?? skierowana bardziej na ??cie??k?? Frontend czy na JavaScript, ??mia??o zg??o?? na kt??r??kolwiek z nich ??? postaram si?? dobra?? odpowiednio do reszty i przekaza?? informacj?? zwrotn??.');
INSERT INTO "Categories" VALUES (10,'DevOps','DevOps','Podczas tegorocznego CFP na ??cie??k?? DevOps, wypatrujemy zg??osze?? z zakresu:
Cloud Native, Mikroserwisy, Kubernetes, Containers, Serverless
Zarz??dzanie konfiguracj??, infrastruktura jako kod, automatyzacja
Kultura DevOps
SRE
Obserwowalno????, pomiar, monitoring
Analiza DevOps, kwantyfikacja produktywno??ci, pomiar ryzyka
To mo??e by?? przydatne przy tworzeniu zg??oszenia CFP:
B??d?? zwi??z??y, ale te?? tre??ciwy, konkretny i szczeg????owy
Odpowiedz sobie na pytanie: co dok??adnie s??uchacz wyniesie z Twojej prezentacji?
Wysy??anie kilku zg??osze?? jest mile widziane!
Nie przyjmujemy ???vendor talks???!');
INSERT INTO "Categories" VALUES (11,'Mobile','Mobile','??cie??ka mobilna ma odzwierciedla?? multidyscyplinarno???? ca??ej konferencji 4developers, bo chcemy aby developerzy mogli uczy?? si?? od siebie nawzajem, r??wnie?? cross platformowo a cz??sto r??wnie?? korzysta?? z do??wiadcze?? niemobilnych. Dlatego sk??adamy agend?? jak najszerzej, ka??dy j??zyk, ka??da platforma, ka??de do??wiadczenie si?? liczy.');
INSERT INTO "Categories" VALUES (12,'Machine Learning','Machine Learning','Szukamy sesji opisuj??cych projekty z zakresu AI/ML/DL w kt??rych brali??cie udzia?? ??? zar??wno tych zako??czonych sukcesem, jak i tych mniej udanych. Interesuj?? nas te?? sesje po??wi??cone u??ywanym przez Was na co dzie?? narz??dziom, platformom i bibliotek?? uczenia maszynowego, szczeg??lnie je??li mo??ecie podzieli?? si?? radami dotycz??cymi ich efektywnego u??ycia. Nie ograniczamy zakresu tematycznego i poziomu trudno??ci zg??aszanych sesji.');
INSERT INTO "Categories" VALUES (13,'Python','Python',NULL);
INSERT INTO "Categories" VALUES (14,'test','test','test');
INSERT INTO "CallForSpeakes" VALUES (1,'4687654',0,NULL,NULL,NULL,NULL,'Cezary','Walenciuk','Poland','00-222','White Underwodds','Balskowa','https://www.facebook.com/cezary.walenciuk','https://twitter.com/walenciukc','https://www.instagram.com/cezarywalenciuk/','https://www.linkedin.com/in/cezary-walenciuk-35615644/','https://www.tiktok.com/@shanselman?','https://www.youtube.com/channel/UCaryk7_lKRI1EldZ6saVjBQ','https://www.facebook.com/JakProgramowac?fref=nf','https://github.com/PanNiebieski','https://cezarywalenciuk.pl/','Cz??owiek, kt??ry czuje, ??e jego misj?? jest nauczanie innych i otwieranie ich dr??g na lepsze jutro. Prowadzi bloga o przemawianiu i programowaniu. Ma tak??e sw??j kana?? YouTubie, na kt??rym s?? webinary na wszelki tematy. Prowadz??cy fanpage "JakProgramowa??" na Facebooku. Aktywny na Twitterze pod nazw?? "@waleniukC" oraz na Instagramie "cezary.walenciuk" gdzie wkleja pytania rekrutacyjne z r????nych obszar??w programowania.
Przemawia od 5 lat w Toastmasters oraz na konferencjach programistycznych.
Za??o??yciel klubu m??wc??w Ninja Speakers w Warszawie, kt??ry funkcjonowa?? przez 2 lata.  Od 8 lat pracuje jako programista .NET i siedzi w tak zwanej Web??wce. Zwyci??zca konkursu na mow?? inspiracyjn?? po angielsku w 2016 roku na terenie Polski Wschodniej. W 2018 roku wygra?? konkurs na opowiadanie historii w Bydgoszczy.',NULL,'ce@gmail.com',NULL,'JSON Web Token i Samuraje z ASP.NET CORE, Swagger UI i Blazor','Uwierzytelnianie i autoryzacja przy pomocy JSON Web Token??w (JWT) jest bardzo prosta. Chcieliby??my stworzy?? REST API dla naszej strony Samuraj??w, kt??r?? napiszemy w Blazor. Zobaczmy, jak te tokeny podr????uj?? z REST API do aplikacji SPA napisanej nie w Angularze, nie w React, a w C#. Oto moc WebAssemlby m??j samuraju. Dodatkowo nie chcemy si?? bawi?? w testowanie API przez Postman. Skorzystajmy z Swagger UI, kt??ry stworzy dla naszego REST API odpowiedni?? dokumentacj?? i tak?? stron?? testow??, kt??ra tak te?? obs??u??y  Uwierzytelnianie i autoryzacja przez Json Web Tokeny. Wstawaj Samuraju mamy aplikacj?? do zabezpieczenia.','.NET,C#,ASP.NET CORE, JSON WEB TOKENS, BLAZOR, Swagger UI',1,0,'02-02-2021',1,NULL,NULL,NULL);
CREATE UNIQUE INDEX IF NOT EXISTS "JudgesID_Index" ON "Judges" (
	"ID"	DESC
);
CREATE UNIQUE INDEX IF NOT EXISTS "CategoryID_Index" ON "Categories" (
	"ID"	DESC
);
COMMIT;
