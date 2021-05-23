# Fyzikalni-kalkulator

### Verze 1.2
Jednoduchá kalkulačka na komplikované fyzikální zákony

Pejsar Vojtěch  
pejsar.vojtech.2018@ssps.cz  
23.5.2021

- #### Úvod
  - Účel
    - Program bude vypočítávat vysledek předem daného vzorečku. Bude používat jednoduché a intuitivní pole pro zadávaní čísel.
  - Odkazy 
    - odkaz
- ### Scénáře
  - Způsoby použití
    1. Výpočet
    2. Výběr jiných vzorečků (koncept)
  - Uživatelské role 
    - Program je zatím napánovaní jen pro jedu roli a to je uživatel. Ten kdo potřebuje výsledek.
  - Vymezení rozsahu
    - V programu nebude možné si vytvořit vlastní vzoreček. Možné bude pouze přepínat mezi předvytvořenými.
  - Nižší priorita
    - Důraz se nebude klást na efektivitu výpočtu. Vzorečky by měli být dostatečné jednoduché a program by i přesto měl běžet plynule.
- ### Hrubá architektura
    - #### Výpočet
      - Uživatel zadá hodnoty do popsaných textBox elementů. Po zmáčknutí buttonu se zobrazí výsledek výpočtu. 
      - Pole přijímající hodnoty budou vytvořeny tak, aby mohl uživatel zadat i velká čísla, nebo čísla ve zkráceném formátu (např: 1,124e10) nebo číslo zvyšovat a snižovat pomocí určených ovládacích prvků.
      - Bude mít možnost vybrat jendotky ve kterých čísla zadává.
    - #### Výběr vzorečku
      - Uživatel bude mít možnost vybrat jiný vzoreček pomocí přepínání záložek nebo oken.
