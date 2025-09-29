Este repositorio contiene mi solución a la prueba técnica para el puesto de **Desarrollador Fullstack**.

##Estructura del repositorio

├── 📁 Arquitectura/
│ ├── Arquitectura.drawio
│ └── JustificacionTecnica.md
├── 📁 taskManagerApi/
├── 📁 Code-review/
│ └── CodeReview.md
├── 📁 Diagnostico/
│ └── Resolucion.md
└── 📄 README.md


## Entregables

### 1. Diseño de Arquitectura
- Diagrama de arquitectura del sistema de gestión de usuarios
- Justificación técnica de las decisiones tomadas
- Flujo de datos explicado

### 2. Task Manager API
API RESTful construida con .NET 8, Entity Framework Core y MySQL/SQLite, que permite gestionar tareas con operaciones CRUD y autenticación con JWT.

## Tecnologías utilizadas
    - .NET 8 Web API
    - Entity Framework Core
    - MySQL / SQLite
    - JWT (JSON Web Tokens)
    
## Instalación y configuración

## Configurar la cadena de conexión en appsettings.json:

    {
    "ConnectionStrings": {
        "DefaultConnection": "server=localhost;database=taskmanager;user=root;password=tu_password"
    },
    "Jwt": {
        "Key": "ClaveSecreta_DeberiaSerMasLarga123456789!"
    }
    }

## Ejecutar las migraciones de base de datos:

    dotnet ef database update

## Iniciar la aplicación:

    dotnet run

## La API estará disponible en:
    https://localhost:5135

## Autenticación

    La API utiliza JWT para acceder a los endpoints de /api/tasks, primero debes registrarte o iniciar sesión en /api/auth/login.
    Luego, incluye el token en el header de tus peticiones:
    Authorization: Bearer <token_jwt>

## Endpoints principales
    ** Autenticación **
    - POST /api/auth/register → Registrar un nuevo usuario.
    - POST /api/auth/login → Obtener un token JWT.
    ** Tareas (requieren token JWT) **
    - GET /api/tasks → Listar todas las tareas.
    - GET /api/tasks/{id} → Obtener una tarea por ID.
    - POST /api/tasks → Crear una nueva tarea.
    - PUT /api/tasks/{id} → Actualizar una tarea existente.
    - DELETE /api/tasks/{id} → Eliminar una tarea.

## Manejo de errores
    La API devuelve mensajes en JSON para:

    401 → No autorizado (token inválido o ausente).
    403 → Acceso denegado (sin permisos).
    404 → Endpoint no encontrado.
    500 → Error interno del servidor.

### 3. Revisión de Código
- Análisis de fragmentos de código proporcionados
- Detección de errores y malas prácticas
- Sugerencias de mejora justificadas

### 4. Diagnóstico de Fallos
- Hipótesis de fallo en producción
- Plan de diagnóstico detallado
- Estrategia de comunicación de avances