# APBD Ćwiczenia 7 - PC Components API

Aplikacja jest prostym REST API do zarządzania komputerami oraz ich komponentami.

Projekt został przygotowany w ASP.NET Core Web API z użyciem Entity Framework Core w podejściu Code First. Baza danych jest tworzona na podstawie klas encji oraz migracji EF Core.

## Opis projektu

Aplikacja pozwala zarządzać komputerami oraz sprawdzać komponenty przypisane do danego komputera.

W projekcie zostały przygotowane encje odpowiadające tabelom:

- PCs
- Components
- ComponentTypes
- ComponentManufacturers
- PCComponents

Relacja między komputerami i komponentami została zrealizowana przez tabelę pośrednią `PCComponents`, ponieważ jeden komputer może mieć wiele komponentów, a jeden komponent może występować w wielu komputerach.

Dodatkowo tabela `PCComponents` przechowuje pole `Amount`, czyli ilość danego komponentu w komputerze.

## Struktura projektu

Projekt został podzielony na kilka warstw:

```text
Controllers/   - kontrolery API
Data/          - AppDbContext i konfiguracja bazy danych
DTOs/          - klasy DTO dla requestów i response'ów
Models/        - encje EF Core
Services/      - logika biznesowa
Migrations/    - migracje Entity Framework Core
