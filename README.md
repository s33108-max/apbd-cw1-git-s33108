1. Fast-forward się dzieje gdy nie była aktualizowana przed stworzeniem nowej gałęzi.
Historia jest prostą linią więc git przesuwa wskaźnik main na ostatni commit z dodatkowej gałęzi.
Merge commit dzieje się gdy po stworzeniu nowej gałęzi są zrobione nowe commity w głównej gałęzi przez co git musi stworzyć specjalny commit gdzie scala te dwie różne hisorie w jedną. 
2. Merge zachowuje prawdę historyczną. Są widoczne odnogi jak i punkt scalania obu gałęzi, natomiast rebase robi z historii comitow jedną dlugą linie bez odgałęzień.
3. Git zauwarzył, że ta sama linia kodu w gałęzi main jak i gałęzi pobocznej została zmieniona. w pliku były znaczniki, które pokazywały obie wersje (<<<<<<<, =======, >>>>>>>) trzeba było je usunąć a potem ja złączyłam oba napisy w jeden napis, nastepnie dodałam do staging area a potem zrobiłam commit i pusha.
