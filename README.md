# LGT_Ribbon


## Įkėlimas:
### Kompiliavimas
Atlikus pakeitimus kode reikia sukompiliuoti projektą. Tai daroma per `visual studio` ar `dotnet cli` (geriau Release tipu, bet nelabai svarbu).
Būtina įsidiegti MapBasic, nes kompiliavimas sukonfigūruotas taip kad ir MBX sukompiliuotu, ne tik `c#` dll.

Sugeneruotas `LGT_Ribbon.mbx` randamas `"D:\git\LGT_Ribbon\src\LGT_Ribbon\bin\Release\"` arba `"D:\git\LGT_Ribbon\src\LGT_Ribbon\bin\Debug\"` aplanke.


### Mygtukų atnaujinimas vartotojams
Informacija kokius mygtukus sudėti laikoma faile `\\granitas\visi_gis\visi_gis\MI_17\Ribbon\ribbon.db`. 

Norint jį atnaujinti visiems vartotojams reikia atlikti šiuos veiksmus: 
1) Sugeneruojam naują `ribbon.db`.
    1) Paleist iš userio su Admin privilegija (žr `\\granitas\visi_gis\visi_gis\MI_17\Ribbon\LevelLists.txt`)
    2) Paklausus "Įdėti numatytuosius mygtukus ?"  paspaudžiam __Yes__
    3) Naujas `ribbon.db` sugeneruotas `%AppData%\Roaming\Mapinfo\LGTRibbon\ribbon.db`
2) Įkeliam naują `ribbon.db` į `\\granitas\visi_gis\visi_gis\MI_17\Ribbon\ribbon.db`

### MBX atnaujinimas
  Pakeitus tik mygtukus šio failo keisti nebūtina (užtenka pakeisti `ribbon.db`), bet jei pasikeitė programavimo logika keitimas atlikamas taip:
  1) Ištrinam aplanką `\\granitas\visi_gis\visi_gis\MI_17\Ribbon\Live\`
  2) Iškopijuojam visą `LGT_Ribbon.mbx` aplanką iš `\LGT_Ribbon\Source\LGT_Ribbon\bin\Debug\` ar `\LGT_Ribbon\Source\LGT_Ribbon\bin\Release\` į `\\granitas\visi_gis\visi_gis\MI_17\Ribbon\Live\`.
### Kiti failai
__Vartotoju instrukcijos:__ 
`\\granitas\it_apsikeitimas\Mapbasic\LGT_Ribbon\Vartotoju instrukcijos.txt` -> `\\granitas\visi_gis\visi_gis\MI_17\Ribbon\Vartotoju instrukcijos.txt`  
__Vartotoju log:__ 
`\\granitas\it_apsikeitimas\Mapbasic\LGT_Ribbon\Vartotoju log.txt` -> `\\granitas\visi_gis\visi_gis\MI_17\Ribbon\Vartotoju log.txt` (prieinamas )
__Pagrindinis MBX failas:__ 
`\\granitas\visi_gis\visi_gis\MI_17\Ribbon\Live\LGT_Ribbon.mbx`


