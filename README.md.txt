# Rick & Morty Episodes — Full Stack Demo

Este proyecto es una aplicación full stack de demostración que consume la API pública de **Rick and Morty** y expone los episodios a través de un backend propio en **.NET**, que luego son consumidos por un frontend en **Angular**.

---
--FUENTE DEL REPOSITORIO--

PruebaTecnicaCarsales/

│

├── frontend/   → Proyecto Angular

│

└── backend/    → Proyecto ASP.NET Core Web API    

---
--ARQUITECTURA Y PUERTOS--

Angular (http://localhost:4200)

          ↓

Backend .NET (http://localhost:5039)

          ↓

Rick & Morty API (externa)

---
COMO EJECUTAR EL PROYECTO

1. Clonar el repositorio

git clone <URL_DE_TU_REPO>
cd PruebaTecnicaCarsales

2. Levantar el Backend (.NET)

cd backend

dotnet run

3. Levantar el Frontend (Angular)

cd frontend

npm install

ng serve

4. Luego abre en tu navegador:

http://localhost:4200/episodes





