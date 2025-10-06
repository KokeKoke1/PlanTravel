[readme (2).md](https://github.com/user-attachments/files/22728919/readme.2.md)
# PlanTravel

**PlanTravel** (znane również jako *ExtraTravel*) to nowoczesna aplikacja mobilna i desktopowa do **planowania podróży**, stworzona w technologii **.NET MAUI**. Umożliwia użytkownikom odkrywanie atrakcji turystycznych, tworzenie spersonalizowanych tras oraz organizowanie całej podróży w jednym miejscu.

> ✨ Twoja podróż zaczyna się tutaj – z PlanTravel każda wyprawa staje się prostsza i bardziej inspirująca.

---

## 🌍 Funkcje

- 🧭 **Planowanie trasy** — dodawaj punkty podróży, twórz harmonogramy i zapisuj plan w aplikacji.
- 🗺️ **Wyszukiwanie atrakcji** — znajdź miejsca warte odwiedzenia w wybranym promieniu.
- 📍 **Szczegóły lokalizacji** — zobacz opisy, zdjęcia, udogodnienia, godziny otwarcia i inne dane.
- ⭐ **Personalizacja** — dostosuj plan do własnych potrzeb, filtruj wyniki według kategorii.
- ☁️ **Synchronizacja danych** — opcjonalne przechowywanie planów w chmurze.

---

## 🧩 Technologie

- **.NET MAUI** – aplikacja wieloplatformowa (Android, iOS, Windows, macOS)
- **C# 11** – język implementacji logiki aplikacji
- **REST API / JSON** – komunikacja z zewnętrznymi serwisami turystycznymi
- **SQLite** – lokalna baza danych do przechowywania planów podróży

---

## ⚙️ Struktura projektu

- `PlanTravel/` – główny projekt .NET MAUI (UI + logika)
- `PlanTravel.Core/` – warstwa logiki biznesowej (modele, serwisy, interfejsy)
- `PlanTravel.API/` *(jeśli istnieje)* – serwerowe API do obsługi synchronizacji danych użytkownika

---

## 🚀 Uruchomienie projektu

### Wymagania

- .NET SDK 7.0+
- Visual Studio 2022 z rozszerzeniem **.NET MAUI workload**
- Emulator Android / iOS lub środowisko Windows/macOS

### Instalacja i uruchomienie

1. Sklonuj repozytorium:
   ```bash
   git clone https://github.com/KokeKoke1/PlanTravel.git
   cd PlanTravel
   ```
2. Przywróć zależności:
   ```bash
   dotnet restore
   ```
3. Otwórz rozwiązanie `PlanTravel.sln` w Visual Studio.
4. Wybierz platformę docelową (Android / Windows / iOS) i uruchom aplikację (F5 / Run).

---

## 🔧 Konfiguracja

- Ustaw klucze API w pliku `appsettings.json` lub w sekcji `Secrets` (jeśli aplikacja korzysta z zewnętrznych API do lokalizacji / map / atrakcji).
- Dla testów lokalnych można uruchomić aplikację bez kluczy, część funkcji (np. mapy) może być wtedy ograniczona.

---

## 🧪 Testowanie

Jeśli repo zawiera testy jednostkowe lub integracyjne:
```bash
dotnet test
```

---

## 🗺️ Przykładowe zastosowanie

1. Wybierz miasto lub obszar.
2. Określ promień wyszukiwania atrakcji.
3. Dodaj interesujące miejsca do planu.
4. Wygeneruj harmonogram podróży.

Aplikacja automatycznie zapisze plan i umożliwi jego edycję w dowolnym momencie.

---

## 🧠 Inspiracja i cel projektu

PlanTravel powstał z myślą o nowoczesnych podróżnikach, którzy chcą:
- szybko planować wyjazdy,
- mieć wszystkie informacje o atrakcjach w jednym miejscu,
- oszczędzić czas i uniknąć chaosu w organizacji podróży.

Projekt jest inspirowany artykułem z portalu [neteeo.com – ExtraTravel: Twoja podróż zaczyna się tutaj](https://neteeo.com/extratravel-twoja-podroz-zaczyna-sie-tutaj/).

---

## 🤝 Wkład w projekt

1. Forkuj repozytorium.
2. Utwórz nowy branch z opisową nazwą (`feature/nowa-funkcja`).
3. Wprowadź zmiany i przetestuj.
4. Otwórz Pull Request.

---

## 📄 Licencja

Brak informacji o licencji w repozytorium. Zalecane dodanie pliku `LICENSE` (np. **MIT License**).

---

## 📬 Kontakt

Autor: [KokeKoke1](https://github.com/KokeKoke1)

> PlanTravel – zaplanuj lepiej, podróżuj więcej.

