# SuperMarket

Sistema de clasificación y gestión de productos para un supermercado, desarrollado como proyecto final de la asignatura **Programación III**.

---

## 📄 Descripción del proyecto
Esta aplicación web permite gestionar productos clasificados por tipo: frutas, vegetales y productos lácteos. 
Permite registrar, visualizar, editar y eliminar productos en memoria utilizando el patrón MVC con ASP.NET Core.

---

## 🛠️ Tecnologías utilizadas
- **Backend:** ASP.NET Core MVC
- **Lenguaje:** C#
- **Frontend:** Razor Pages + Bootstrap 5
- **Control de versiones:** GitHub
- **Gestor de tareas:** Jira (Scrum Board)
- **Testing:** xUnit (con pruebas de servicios)

---

## 📈 Funcionalidades implementadas
- [x] Crear productos con nombre, descripción, precio y tipo
- [x] Visualización de productos clasificados por categoría
- [x] Edición de productos existentes
- [x] Eliminación individual desde la vista principal
- [x] Validaciones básicas de formularios
- [x] Interfaz responsiva con Bootstrap

---

## 📁 Estructura del proyecto
```
SuperMarket2024G34/
├── Application/
│   ├── Enums/
│   ├── Repositories/
│   ├── Services/
│   └── Viewmodels/
├── SuperMarket2024G34/ (WebApp)
│   ├── Controllers/
│   └── Views/Market/
├── SuperMarket2024G34.Tests/ (xUnit tests)
```

---

## 📖 Instrucciones para ejecutar localmente
1. Clona el repositorio
```bash
git clone https://github.com/CarlenisVC/SuperMarketCarlenis.git
```
2. Abre la solución en Visual Studio 2022
3. Ejecuta el proyecto `SuperMarket2024G34`
4. Navega a: `https://localhost:xxxx/`

---

## 📅 Scrum Sprint 1
- Total de historias: 10 (US01 - US10)
- Epic: EP01 - Gestión de productos
- Herramienta de gestión: Jira

### Meta del sprint
> Completar la implementación y validación de las funcionalidades principales del sistema, incluyendo la creación, visualización, edición y eliminación de productos categorizados.

---

## 👥 Equipo de trabajo
| Nombre     | Rol           | Responsabilidades principales                         |
|------------|----------------|-------------------------------------------------------|
| Emilia     | Developer      | Programación backend/frontend, pruebas, servicios     |
| Carlenis   | Scrum Master   | Documentación, pruebas manuales, planificación       |
| Jonathan   | Product Owner  | Historias de usuario, validación funcional y feedback |

---

## 📄 Captura de Jira (opcional)
![jira-board](docs/jira_board.png)

---

## 🌟 Estado actual
- Proyecto funcional y finalizado
- Pruebas unitarias ejecutadas con éxito
- Documentación lista para entrega final

---

## 🔗 Repositorio
https://github.com/CarlenisVC/SuperMarketCarlenis

---

> Proyecto desarrollado para fines académicos en el Instituto Tecnológico de las Américas (ITLA), 2025.
