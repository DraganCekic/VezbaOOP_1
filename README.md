ključne Funkcionalnosti Klase

Klasa `Automobil` implementira sledeće osobine i ponašanja:

 
* **Marka** i **Model** (string)
* **Godiste** (int)
* **Boja** (string)
* **MaxBrzina** (int)
* **TrenutnaBrzina** (int)

### Metode (Ponašanje)
1.  **`IspisiAtribute()`**: Štampa sve trenutne atribute automobila na konzolu.
2.  **`Farbaj(string novaBoja)`**: Menja boju automobila.
3.  **`Ubrzaj(out string poruka)`**: Povećava trenutnu brzinu za 5 km/h, ne dozvoljavajući prekoračenje `MaxBrzina`. 
4.  **`Uspori()`**: Smanjuje trenutnu brzinu za 5 km/h, ne dozvoljavajući brzinu ispod 0.
