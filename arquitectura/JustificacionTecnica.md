#Responsabilidades:
  -API Gateway: Punto de entrada único para todas las solicitudes, manejará el enrutamiento y maneja la autenticación inicial con middlewares.

  -Middleware de Autorización: Gestionará los permisos y roles de los usuarios obteniendo la informacion de la sesion del usuario (Token de sesion).

  -Microservicio de Autenticación: Se encargará del login, registro, y generación de tokens JWT.
  -Microservicio de Gestión de Usuarios: Para la administración de los datos de los usuarios (Crear, Leer, Actualizar, Eliminar).
  -Microservicio de Gestión de Roles: Para la administración de los datos de los roles de usuario (Crear, Leer, Actualizar, Eliminar).
  -Microservicio de Auditoría: Registrará todos los eventos de acceso y cambios en el sistema (Registrar eventos).
  
  -Base de datos SQL: Guarda informacion relacionada a los usuarios y los roles.
  -Base de datos No SQL: Guarda el registro de los eventos ejecutados y sesiones de usuario

#Decisiones Tecnicas:
  
  -Api Gateway: Unifica los endpoints en una unica ruta para los clientes y se encarga del enrutamiento de las distintas peticiones,
  contiene tambien un middleware que se encarga de la validacion de la autorizacion del usuario para el consumo de ciertos servicios.
  Ademas maneja la comunicacion via HTTPS lo que agrega confidencialidad e integridad de los datos protegiendo las rutas.

  -Microservicios: Los microservicios nos brindan una escalabilidad y mantenimiento independiente de cada servicio, 
  cada una debe contar con responsabilidades bien definidas y pueden escalar independientemente, 
  esto permite actualizaciones y despliegues sin afectar todo el sistema.

  -Base de datos SQL: Almacena los datos estructurados de usuarios, roles y permisos garantizando 
  consistencia en cada transaccion y relaciones complejas.

  -Base de datos No SQL: Se utiliza para la auditoria (registro de log y eventos) y sesiones de usuario (tokens), esto nos permite un alto volumen
  de escritura y escalabilidad.

#Flujo de Datos

  -Autenticación: El cliente envia las credenciales al API Gateway, este lo redirige al Auth Service, se validan las credenciales y se genera
  un Token de acceso que se guarda en una base de datos No SQL, la respuesta incluye el JWT para futuras peticiones.

  -Autorización: el cliente incluye el token de la autencicacion en la cabecera de la solicitud, el API Gateway verifica la firma del Token y la expiración,
  una vez validada la veracidad del token el API Gatweay y consulta el servicio del Rol para validar los permisos que tiene el usuario 
  para consumir ciertos servicios.

  -Gestion de Usuarios/Roles: Una vez validada la autorización del usuario, los administradores o usuarios con los privilegios necesarios pueden hacer 
  modificacions a la base de datos como creacion de nuevos usuarios/roles, lectura de los usuarios/roles, actualización y eliminacion de los mismos.

  -Auditoria: Cada que se consume un servicio, se genera un error o cualquier evento critico se genera un historico con estos eventos para su futuro analisis.
