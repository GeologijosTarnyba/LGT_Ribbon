Árankis padarytas pagal HelloRibbon pavizdá.

HelloRibbon - pagrindinis mapbasic / .net projektas.
RibbonClasses - Core ribbon mechanikos.
RibbonDatabase - projektas skirtas sukurti / skaityti / atnaujinti db failà.

--
Teisiø failas:
tai tekstinis failas, ið kurio nuskaitomos varototjø teisës, pagal kurias galima kustomizuoti interfeisà kiekvienai grupei atskirai.
ieðkomas "HelloRibbon independant\Resource1.resx" faile apraðyto kontamojo "RoleFileLoc" ("\\granitas\visi_gis\visi_gis\MI_17\Ribbon\LevelLists.txt")
stulepiai: username teisës (atskirti tarpu)
tesës: RibbonClasses.UserLevel enumeratorios reikðmës (Admin, User, Tester). Unknown ir None neturëtø bût naudojami ðiame faile.
User: teisës gauna visi vartotojai esantys "LGT" domene.
Teisës viena kitos neperraðo t.y. userá galima apraðyt daugiau nei vienà kartà (su skirtingomis teisëmis).
pvz:
sarunasg Admin
sarunasg Tester
simonasd Tester

--
Duomenø bazës failas (toliau db failas):
ieðkomas "HelloRibbon independant\Resource1.resx" faile apraðyto kontamojo "LiteDbFileLoc" ("\\granitas\visi\visi\Sarunas\MyDatabase.db")
kolkas interfeis pakeitimai gali bûti daromi tik "HelloRibbon independant\Source\Default.cs" vietoje, jei 
db failas neegzistuoja - bus pasiûlyta atidaryti default reikðmes.
jei sutinkama uþkraut ðias reikðmes ir vartotojas yra Admin, bus pasiûlyta sukurti tà failà.
Tai norint atnaujinti interfeiso reikðmes bûtø atliekami ðie veiksmai:
  paredaguojams "HelloRibbon independant\Source\Default.cs" failas
  sukompiliujamas projektas
    atidaromas HelloRibbon.sln su visual studio
    buildinamas projektas
  paleidþiamas helloribbon.mbx su Admin teises turinèiu vartotoju (þr. "Teisiø failas").
  sekamas dialogas (Uþkraunamas default, sukuriamas db failas)
  db failas (visi_gis) pakeièiamas katik sukurtu nauju db failu.
 
--
Scrape tabas sukurtas pagalbiniam funkcionalumui laikyti.

--
Kompiliavimas (Build)
pabuildint per visual studio c# dalá (iðmes klaidà, galima nekreipt dëmesio realiai)
su map basic mbx sukompiliuot

-----------------------------------
todo:

problema: Reikia write privilegijø á duomenø bazës failo lokacijà
sprendimas1: Perkelti db failà á vietà kur visi vartotojai gali raðyti. - vistiek iðlieka problema, kad bet kas gali já iðtrint panorëjas, gal net problemø bûti, jei du varotojai vienu metu atidarinës.
sprendimas2: Pakeisti failo nuskaitymo bûdà - pirma failà nusikopijuoti lokaliai, po to já skaityti.
sprendimas3: Neenaudoti litedb failo. - web api bûtø variantas, daug geresnis variantas, bet jauèiu kad dabar uþteks sprendimas2 trumpam laikotarpyje geresnis.
sprendimas4: nenaudot db failo iðvis, hardcodint á mbx viskà. - Nebûtø ten taip ir blogai, tik kad negalëtume daryt pakeitimø, kol visi useriai neatsijungs nuo mbx.
daroma: sprendimas2:
 galima default imt lokacijà "C:\Users\sarunasg\AppData\Roaming\MapInfo\LGTRibbon", jei ten nëra failo, tada kopijuoja á ten db failà ið visi_gis ir tæsia. Jei visi_gis neranda - ima default.

 

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