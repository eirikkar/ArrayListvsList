# Refleksjoner over kodevalg

ArrayList kan inneholde flere forskellige typer variabler, men det kommer på bekosting av at den ikke er like rask som en generisk Liste.
I Microsoft sin dokumentering står det at det ikke er anbefalt å bruke en ArrayList men at det er bedre å bruke en List<Object> hvis man ønsker å bruke
forskellige variabler i listen. Hvis listen skal inneholde en type variabler kan listen deklareres med variabelen i <>.

En varabel kan ikke brukes før den deklareres. Dette er fordi kompileren kjører fra topp til bunn og den vet ikke enda at den har blitt deklarert.
Hvis den må deklareres før kan den legges inn i en metode eller som et overordnet variabel.
