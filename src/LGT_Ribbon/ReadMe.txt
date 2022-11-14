�rankis padarytas pagal HelloRibbon pavizd�.

HelloRibbon - pagrindinis mapbasic / .net projektas.
RibbonClasses - Core ribbon mechanikos.
RibbonDatabase - projektas skirtas sukurti / skaityti / atnaujinti db fail�.

--
Teisi� failas:
tai tekstinis failas, i� kurio nuskaitomos varototj� teis�s, pagal kurias galima kustomizuoti interfeis� kiekvienai grupei atskirai.
ie�komas "HelloRibbon independant\Resource1.resx" faile apra�yto kontamojo "RoleFileLoc" ("\\granitas\visi_gis\visi_gis\MI_17\Ribbon\LevelLists.txt")
stulepiai: username teis�s (atskirti tarpu)
tes�s: RibbonClasses.UserLevel enumeratorios reik�m�s (Admin, User, Tester). Unknown ir None netur�t� b�t naudojami �iame faile.
User: teis�s gauna visi vartotojai esantys "LGT" domene.
Teis�s viena kitos neperra�o t.y. user� galima apra�yt daugiau nei vien� kart� (su skirtingomis teis�mis).
pvz:
sarunasg Admin
sarunasg Tester
simonasd Tester

--
Duomen� baz�s failas (toliau db failas):
ie�komas "HelloRibbon independant\Resource1.resx" faile apra�yto kontamojo "LiteDbFileLoc" ("\\granitas\visi\visi\Sarunas\MyDatabase.db")
kolkas interfeis pakeitimai gali b�ti daromi tik "HelloRibbon independant\Source\Default.cs" vietoje, jei 
db failas neegzistuoja - bus pasi�lyta atidaryti default reik�mes.
jei sutinkama u�kraut �ias reik�mes ir vartotojas yra Admin, bus pasi�lyta sukurti t� fail�.
Tai norint atnaujinti interfeiso reik�mes b�t� atliekami �ie veiksmai:
  paredaguojams "HelloRibbon independant\Source\Default.cs" failas
  sukompiliujamas projektas
    atidaromas HelloRibbon.sln su visual studio
    buildinamas projektas
  paleid�iamas helloribbon.mbx su Admin teises turin�iu vartotoju (�r. "Teisi� failas").
  sekamas dialogas (U�kraunamas default, sukuriamas db failas)
  db failas (visi_gis) pakei�iamas katik sukurtu nauju db failu.
 
--
Scrape tabas sukurtas pagalbiniam funkcionalumui laikyti.

--
Kompiliavimas (Build)
pabuildint per visual studio c# dal� (i�mes klaid�, galima nekreipt d�mesio realiai)
su map basic mbx sukompiliuot

-----------------------------------
todo:

problema: Reikia write privilegij� � duomen� baz�s failo lokacij�
sprendimas1: Perkelti db fail� � viet� kur visi vartotojai gali ra�yti. - vistiek i�lieka problema, kad bet kas gali j� i�trint panor�jas, gal net problem� b�ti, jei du varotojai vienu metu atidarin�s.
sprendimas2: Pakeisti failo nuskaitymo b�d� - pirma fail� nusikopijuoti lokaliai, po to j� skaityti.
sprendimas3: Neenaudoti litedb failo. - web api b�t� variantas, daug geresnis variantas, bet jau�iu kad dabar u�teks sprendimas2 trumpam laikotarpyje geresnis.
sprendimas4: nenaudot db failo i�vis, hardcodint � mbx visk�. - Neb�t� ten taip ir blogai, tik kad negal�tume daryt pakeitim�, kol visi useriai neatsijungs nuo mbx.
daroma: sprendimas2:
 galima default imt lokacij� "C:\Users\sarunasg\AppData\Roaming\MapInfo\LGTRibbon", jei ten n�ra failo, tada kopijuoja � ten db fail� i� visi_gis ir t�sia. Jei visi_gis neranda - ima default.

 

------------------------

SAMPLES\RIBBONINTERFACE\DotNet\HelloRibbon Sample.

Description : 
Sample enables to add a new tab in the application

How To Run:
1.) Open HelloRibbon.csproj
2.) If MapInfo Pro x64 is installed in default location i.e. "C:\Program Files\MapInfo\Professional\" then you just have to build the project. In case MapInfo Pro x64 is not installed in default location then update the assembly reference path for MapInfo.Types.dll to your MapInfo Pro x64 bit installation directory and build the project.
3.) Run HelloRibbon.MBX from the project output path.

Note : 
Sample is only for MapInfo Pro 64 bit.



%