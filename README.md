Specyfikacja techniczna:

Opis klas i metod:

Authentication:
 - CustomAuthenticationStateProvider - dostarcza stanu uwierzytelniania aplikacji
  - GetAuthenticationStateAsync - zwraca stan uwierzytelniania
  - UpdateAuthenticationState - aktualizuje stan uwierzytelniania przy logowaniu/wylogowaniu
  
 - UserAccount - reprezentuje konto użytkownika
 
 - UserAccountService - reprezentuje serwis, przechowujący i dostarczający informacji o kontach użytkownika (znajdują się tu dane do logowania)
 
 - UserSession - reprezentuje sesję użytkownika
 
 Data:
  - AppDbContext - reprezentuje kontekst bazy danych
   - OnModelCreating - zapełnia bazę danych pustymi tabelami, przy pierwszym uruchomieniu
  - Kategoria - model kategorii kontaktu
  - KategoriaServices - zapewnia obsługę danych związanych z Kategorią (w tym przypadku tylko get)
  - Kontakt - model kontaktu
  - KontaktServices - zapewnia obsługę danych związanych z encją kontaktu
   - GetKontaktAsync - zwraca wszystkie kontakty z bazy
   - AddKontaktAsync - dodaje nowy kontakt do bazy danych
   - UpdateKontaktAsync - aktualizuje istniejący kontakt
   - DeleteKontaktAsync - usuwa kontakt
  - Podkategoria - model Podkategorii
  - PodkategoriaServices - zapewnia obsługę danych związanych z encją podkategorii
  
 Pages:
  - FetchData - wyświetla listę kontaktów, umożliwia ich edycję, dodanie oraz usunięcie. Funkcje pojawiają się dopiero po zalogowaniu. Zostały zaimportowane serwisy, 
  w celu operacji na bazach danych.
  - Login - umożliwia logowanie do aplikacji
  
  Wykorzystane biblioteki:
  Microsoft.EntityFrameworkCore
  Microsoft.EntityFrameworkCore.Sqlite
  Microsoft.EntityFrameworkCore.Tools
