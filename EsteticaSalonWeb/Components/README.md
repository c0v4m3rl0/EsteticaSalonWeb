# 🏢 Glamour Salón & Estética — Sistema de Gestión Web
> **Desarrollado por:** Adrián Covarrubias
> **Estatus del Proyecto:** Entregable Final v1.0
> **Infraestructura:** Blazor Server / .NET 8 / EF Core / Azure SQL Database

---

## 📋 Descripción del Sistema
Glamour Salón es un software web responsivo empresarial diseñado bajo un enfoque híbrido descentralizado. Permite administrar de forma integrada el catálogo de servicios sanitarios e institucionales de belleza mediante el consumo de una API REST externa, interceptando dichos datos de forma relacional con una base de datos distribuida en la nube para el control operativo de altas de clientes y agendamiento transaccional de citas.

---

## 🛠️ Especificaciones Técnicas y Cumplimiento de Rúbrica

El sistema cumple rigurosamente con los 5 bloques estructurales requeridos por el esquema de evaluación:

### 1. Interfaz de Usuario y Estética unificada (Dashboard)
* **Diseño Conductor:** Paleta de tres colores corporativa basada en Negro Mate (`#1a1a1a`), Oro de Acento (`#d4af37`), y Blanco Comercial (`#ffffff`) para el óptimo contraste.
* **Métricas Operativas de Control:** Pantalla principal (`Home.razor`) automatizada que ejecuta funciones agregadas (`CountAsync()`) directamente en Azure SQL para reportar en tiempo real el total de clientes y transacciones vigentes.

### 2. Consumo de API Externa Descentralizada (`Catalogo.razor`)
* **Patrones de Control Asíncrono:** Implementación estricta del bloque condicional `@if (datos == null)` para desplegar Spinners visuales durante el tiempo de respuesta del servidor externo.
* **Filtros de Búsqueda:** Selector parametrizado funcional que discrimina los servicios por su identificador de Especialidad.

### 3. Operaciones Relacionales CRUD Locales/Remotas (`Clientes.razor`)
* **Persistencia de Datos:** Conexión persistente mediante Entity Framework Core hacia **Azure SQL Database** para operaciones seguras de Insertar, Modificar, Consultar y Eliminar.
* **Validación de Modelos:** Formularios protegidos con `<DataAnnotationsValidator />` y componentes nativos de Blazor para evitar cargas vacías o datos corruptos.
* **Mecanismo de Confirmación Segura:** Integración de un Modal Flotante de Verificación para operaciones de borrado físico (`Delete`), impidiendo la pérdida accidental de información del cliente.

### 4. Integración y Transaccionalidad (`CitasPage.razor`)
* **Inserción Compuesta:** Módulo maestro que asocia las llaves primarias de los clientes locales con las llaves lógicas de los servicios devueltos por la API externa, calculando el impacto financiero directo en la base de datos distribuida.

### 5. Escalabilidad y Valor Agregado (`Especiales.razor` — Módulo Extra)
* **Pantalla Extra Opcional:** Módulo de administración para paquetes premium estacionales (Novias, Graduaciones), expandiendo las capacidades comerciales de la arquitectura de software propuesta.

---

## 🚀 Instrucciones de Despliegue Local

1.  **Clonar/Abrir Proyecto:** Abrir el archivo de solución `EsteticaSalonWeb.sln` en Visual Studio 2022.
2.  **Configurar Connection String:** Verificar las credenciales del servidor Azure en el archivo `appsettings.json`.
3.  **Restaurar Dependencias:** Ejecutar la restauración de paquetes NuGet (`Microsoft.EntityFrameworkCore.SqlServer`, etc.).
4.  **Compilar y Correr:** Presionar `F5` para lanzar el servidor local de Kestrel y desplegar el sistema en el navegador.