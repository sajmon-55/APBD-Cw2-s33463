• Opis projektu:
  - program obsługuje wypożyczalnie sprzętu różnym użytkownikom.
  - projekt został podzielony na plik głowny Program.cs oraz podfoldery: Models, Services, Exceptions, Enums
  - Zawiera on klasy Wypożyczeń, Użytkowników jak i Sprzętu. Te dwie ostatnie są klasami abstrakcyjnymi aby ułatwić uniwersalność funkcji w nich zawartych dla dzieci tych klas
  - Za obsługę projektu odpowiadają klasy z nazwą Service, w interfejsach są podawane ich metody, a w samych klasach implementacje tych metod.
  - Dezycje te dają możliwość daleszgo rozwoju projektu w celu np. zróżnicowaniu formy wypożyczeń i zwrotów dla Studenta i Nauczyciela. Przykład: większy przelicznik kary
  - Ale przedewszystkim jest on czytelniejszy i bardziej przejrzysty
