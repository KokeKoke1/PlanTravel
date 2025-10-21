# PlanTravel

PlanTravel (also known as ExtraTravel) is a cross-platform travel planning application based on .NET MAUI, available for both mobile and desktop devices.

The application features a built-in AI model that helps users discover attractions, plan routes, and organize trips in a single, intuitive interface. Currently, **I'm providing only the front-end of the application.**

> ✨ Start your journey here — PlanTravel makes every trip simpler and more inspiring.

---

## 🌍 Features

- 🧭 **Route Planning** — add travel points, create schedules, and save your plan.  
- 🗺️ **Attraction Search** — find places worth visiting within a selected radius.  
- 📍 **Location Details** — see descriptions, photos, amenities, opening hours, and more.  
- ⭐ **Personalization** — tailor plans to your needs and filter results by category.  
- ☁️ **Data Sync** — optional cloud storage for travel plans.

---

## 🧩 Technologies

- **.NET MAUI** — cross-platform app (Android, iOS, Windows, macOS)  
- **C# 11** — app logic implementation  
- **REST API / JSON** — communication with external travel services  
- **SQLite** — local database for storing travel plans

---

## ⚙️ Project Structure

- `PlanTravel/` — main .NET MAUI project (UI + logic)  
- `PlanTravel.Core/` — business logic layer (models, services, interfaces)  
- `PlanTravel.API/` *(optional)* — backend API for user data sync

---

## 🚀 Getting Started

### Requirements

- .NET SDK 7.0+  
- Visual Studio 2022 with **.NET MAUI workload**  
- Android/iOS emulator or Windows/macOS environment

### Installation

1. Clone the repo:
   ```bash
   git clone https://github.com/KokeKoke1/PlanTravel.git
   cd PlanTravel
