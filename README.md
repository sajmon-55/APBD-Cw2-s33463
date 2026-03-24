1. Opis projektu:
   - program obsługuje wypożyczalnie sprzętu różnym użytkownikom.
   - projekt został podzielony na plik głowny Program.cs oraz podfoldery: Models, Services, Exceptions, Enums
   - Zawiera on klasy Wypożyczeń, Użytkowników jak i Sprzętu. Te dwie ostatnie są klasami abstrakcyjnymi aby ułatwić uniwersalność funkcji w nich zawartych dla dzieci tych klas
   - Za obsługę projektu odpowiadają klasy z nazwą Service, w interfejsach są podawane ich metody, a w samych klasach implementacje tych metod.
   - Decyzje te dają możliwość daleszgo rozwoju projektu w celu np. zróżnicowaniu formy wypożyczeń i zwrotów dla Studenta i Nauczyciela. Przykład: większy przelicznik kary
   - Ale przede wszystkim jest on czytelniejszy i bardziej przejrzysty
2. Kohezja:
   - Projekt zawiera podział Service na pod klasy EquipmentService, UserService itd.
Ma to na celu sensownie pokazać za co każda klasa odpowiada. Przykładem niskiej kohezji była by jedna klasa ServiceManager, która by miała wszystkie metody wcześniej wymienionych klas.
3. Sprzężenie:
   - Podczas tworzenia nowego wypożyczenia jako argument podaję się nie lapotp, czy mysz, tylko argumentem jest Equipment. Ponieważ dzięki temu gdybyśmy w przuszłosći dodali nowy sprzęt, nie musimy modyfikować całej
   logiki wypożyczenia, System opiera się na uniwersalonsci klasy abstrakcyjnej, a nie na detalach poszczególnego sprzetu. Również interfejsy sprawiają, że w wyjątkowych sytuacjach możemy nadpisać naszą metode w Program.cs