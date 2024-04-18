# pruebanetcrud

Este proyecto es una API para la gestión de inmuebles, permitiendo realizar operaciones CRUD sobre los mismos.

# Inmuebles API Para Levantarlo con Visual Studio Code:
## Requisitos Previos

Para ejecutar este proyecto localmente, necesitarás tener instalado:

- .NET 8.0 SDK
- PostgreSQL
- Postman (para realizar pruebas de la API)

## Configuración Inicial

### Base de Datos

1. Asegúrate de tener PostgreSQL instalado y en ejecución.
2. Crea una base de datos para el proyecto.
3. Actualiza el archivo `appsettings.json` con la cadena de conexión a tu base de datos.

### Instalación de Dependencias

Ejecuta el siguiente comando en la raíz del proyecto para restaurar las dependencias necesarias:
dotnet restore
## Ejecutar el Proyecto

Para iniciar el servidor de desarrollo y ejecutar la API, utiliza:

dotnet run


Esto iniciará la API en `http://localhost:5000` por defecto.

## Endpoints de la API

A continuación, se detallan los endpoints disponibles y cómo probarlos usando Postman.

### Obtener Todos los Inmuebles

- **URL**: `/api/inmuebles`
- **Método**: `GET`
- **Body**: No aplica
- **Respuesta de Ejemplo**:

json
[
{
"id": 1,
"nombre": "Inmueble 1",
"direccion": "Calle Falsa 123",
"precio": 100000
}
]


### Crear un Nuevo Inmueble

- **URL**: `/api/inmuebles`
- **Método**: `POST`
- **Body**:

json
{
"nombre": "Inmueble Nuevo",
"direccion": "Calle Verdadera 456",
"precio": 150000
}


### Actualizar un Inmueble

- **URL**: `/api/inmuebles/{id}`
- **Método**: `PUT`
- **Body**:

json
{
"nombre": "Inmueble Actualizado",
"direccion": "Calle Actualizada 789",
"precio": 200000
}


### Eliminar un Inmueble

- **URL**: `/api/inmuebles/{id}`
- **Método**: `DELETE`
- **Body**: No aplica

## Pruebas con Postman

Para probar los endpoints, puedes importar la colección de Postman incluida en el proyecto o crear una nueva:

1. Abre Postman.
2. Crea una nueva solicitud seleccionando el método correspondiente y utilizando las URLs proporcionadas arriba.
3. Para los métodos que requieren un body, asegúrate de seleccionar `raw` y el tipo `JSON`, luego copia y pega el cuerpo de la solicitud correspondiente.
4. Envía la solicitud y revisa la respuesta.

## Contribuir

Si deseas contribuir a este proyecto, por favor haz un fork del repositorio y envía un pull request con tus cambios.

## Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo `LICENSE` para más detalles.


## Levantar el Proyecto con Visual Studio 2022

Para trabajar con este proyecto en Visual Studio 2022 y ejecutarlo localmente, sigue estos pasos:

### 1. Clonar el Repositorio

Primero, necesitas clonar el repositorio de GitHub a tu máquina local. Puedes hacer esto utilizando Git desde la línea de comandos:

git clone https://github.com/cibersabueso/pruebanetcrud.git
O puedes usar la opción de clonar repositorios directamente desde Visual Studio 2022:

- Abre Visual Studio 2022.
- En la pantalla de inicio, selecciona "Clonar un repositorio".
- En el campo "Ubicación del repositorio", ingresa `https://github.com/cibersabueso/pruebanetcrud.git`.
- Elige la ubicación local donde deseas clonar el repositorio y haz clic en "Clonar".

### 2. Abrir el Proyecto

Una vez clonado el repositorio, Visual Studio debería detectar automáticamente el archivo de solución `.sln` y mostrarte la opción de abrirlo. Si no es así, puedes abrirlo manualmente:

- Ve a "Archivo" > "Abrir" > "Proyecto/Solución" en la barra de menú.
- Navega hasta la ubicación donde clonaste el repositorio.
- Selecciona el archivo de solución `.sln` y haz clic en "Abrir".

### 3. Restaurar Dependencias

Antes de ejecutar el proyecto, es posible que necesites restaurar las dependencias de NuGet:

- Haz clic derecho en la solución en el Explorador de Soluciones.
- Selecciona "Restaurar paquetes NuGet".

### 4. Configurar la Cadena de Conexión

Asegúrate de actualizar el archivo `appsettings.json` con la cadena de conexión a tu base de datos PostgreSQL.

### 5. Ejecutar el Proyecto

Para ejecutar el proyecto:

- Establece el proyecto de API como proyecto de inicio (haz clic derecho en el proyecto en el Explorador de Soluciones y selecciona "Establecer como proyecto de inicio").
- Haz clic en el botón "IIS Express" o presiona `F5` para iniciar la depuración. Visual Studio compilará el proyecto y abrirá una ventana del navegador con la URL donde se está ejecutando la API, típicamente `http://localhost:5000`.

Ahora tu API debería estar corriendo localmente y puedes comenzar a hacer pruebas con Postman siguiendo las instrucciones proporcionadas anteriormente en este documento.

## Pruebas con Postman

(Repite las instrucciones de pruebas con Postman aquí si es necesario)

Recuerda que para probar los endpoints de la API, necesitarás utilizar Postman o cualquier otro cliente de API de tu preferencia, configurando las solicitudes según los endpoints y cuerpos de solicitud especificados anteriormente.