# 💡 Esercizio di Gruppo – Astrazione in C#

Questo progetto è stato sviluppato come esercizio di gruppo per mettere in pratica i concetti di **OOP** (Programmazione Orientata agli Oggetti) in C#, con particolare attenzione all’**astrazione**, **incapsulamento**, **ereditarietà** e **polimorfismo**.

## 🧠 Obiettivo

Progettare un’applicazione che gestisca un **ente formativo** in grado di offrire corsi sia **in presenza** che **online**. Il sistema permette di:

- Gestire i corsi
- Definire le modalità di erogazione
- Applicare i principi OOP in modo corretto

---

## ✅ Requisiti OOP implementati

### 1. Astrazione
- È stata creata una **classe astratta `Corso`**, con proprietà comuni (`Titolo`, `DurataOre`)
- Sono definiti metodi astratti:
  - `ErogaCorso()`
  - `StampaDettagli()`

### 2. Ereditarietà
- Due classi concrete derivate da `Corso`:
  - `CorsoInPresenza`: aggiunge proprietà `Aula`, `NumeroPosti`
  - `CorsoOnline`: aggiunge proprietà `Piattaforma`, `LinkAccesso`

### 3. Incapsulamento
- I dati sono privati e accessibili solo tramite **proprietà con validazioni**, ad esempio:
  - `DurataOre` non può essere negativa
  - `NumeroPosti` deve essere almeno 1

### 4. Polimorfismo
- Utilizzo di `List<Corso>` per contenere corsi di entrambi i tipi
- Chiamata ai metodi `ErogaCorso()` e `StampaDettagli()` su ogni oggetto della lista in modo **polimorfico**

---

## 🛠️ Struttura del progetto
- Corso.cs // Classe astratta
- CorsoInPresenza.cs // Classe derivata per corsi in aula
- CorsoOnline.cs // Classe derivata per corsi online
- Program.cs // Entry point con test e demo

---

## ▶️ Esecuzione

1. Clona la repository:

-git clone https://github.com/Lopimax27/EsercizioDiGruppoCorsi.git
-cd EsercizioDiGruppoCorsi
-Apri la soluzione con Visual Studio oppure esegui:
-dotnet run


## 📚 Concetti chiave:

-🧱 Astrazione

-🔗 Ereditarietà

-🔒 Incapsulamento

-🔁 Polimorfismo

## ✍️ I CAMPIONI:
Alessandro Lopardo, Andrea Fabbri, Carlo Condello, Simone Addesso
