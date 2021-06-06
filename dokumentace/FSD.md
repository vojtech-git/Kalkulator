# Fyzikalni-kalkulator

### Verze 1.2

Pejsar Vojtěch  
pejsar.vojtech.2018@ssps.cz  
poslední úprava 6.6.2021

## Úvod
### Účel
- Program bude vypočítávat vysledek předem daného vzorečku. V první verzi bude program pracovat pouze s jedním vzorečkem. Po vypočítání bude program zobrazovat i veškeré mezivýpočty. Pro jednodušší využití bude program obsahovat okno "vysvětlivky" ve kterém budou popsány zkratky a vypsány všechny potřebné informace.
### Konvence dokumentu
- Důležité informace jsou napsány **tučně**
### Odkazy 
- odkaz
## Specifikace
### Základní funkce programu
- Program bude mít předem vytvořené pole určené pro potřebné hodnoty. Do polí se bude dát zadat desetinné čísla i dostatečně velké čísla.
- Program bude zobrazovat konečné výsledky a mezivýsledky do tabulky.
### Uživatelské role 
- Program je zatím napánovaní jen pro jedu roli a to je uživatel. Ten kdo potřebuje výsledek.
### Vymezení rozsahu
- V programu nebude možné si vytvořit vlastní vzoreček. Možné bude pouze přepínat mezi předvytvořenými.
### Nižší priorita
- Důraz se nebude klást na efektivitu výpočtu. Vzorečky by měli být dostatečné jednoduché a program by i přesto měl běžet plynule.
## Scénáře
1. Výpočet
2. Výběr jiných vzorečků (koncept)
### Scénář 1 - Výpočet
![Výpočet okno](/dokumentace/images_dokumentace/vypocetwindow.png)
- Nekolik polí pro zadání hodnot
- Button pro výpočet
- Tabulka s výsledky a mezivýsledky
- Button pro okno vysvětlivek
#### Akce
- Po zadání hodnot a kliknutí na tlačítko se oběví vysledek na pravé straně.
#### možné problémy 
- Je možné, že uživatel zadá číslo moc dlouhé pro výpočet. Čísla musí být omezeny nebo délka jinak ošetřena.
### Scénář 2 - Vysvětlivky
![Vysvětlivky okno](/dokumentace/images_dokumentace/vysvetlivkywindow.png)
- Text vysvětlující zkratky případné další potřebné informace
- Button "vrátit se k výpočtu"
#### Akce
- Po zmáčknuí tlačítka v okně výpočtu se okno výpočtu zavře a otevře se okno vysvětlivek.
### Scénář 3 - Výběr jiného vzorečku
![Vzorerčky okno](/dokumentace/images_dokumentace/vzorečkywindow.png)
- V základním okně comboBox na výběr jiného vzorečku.
#### Akce
- Uživatel si vybere v comboBoxu jiný vzoreček. To překreslí okno/otevře nové. Nové okno bude fungovat podobě jako staré ale s jinýmy hodnotami a jiným výpočtem.
