# Sistema de Parqueadero en C#

## Descripción

Este proyecto consiste en el desarrollo de un sistema sencillo para la gestión de un parqueadero, utilizando el lenguaje de programación **C#** y una arquitectura organizada por capas.

El objetivo principal del ejercicio es aplicar el concepto de **separación de responsabilidades**, dividiendo el proyecto en diferentes capas para que cada una se encargue de una función específica del sistema.

El proyecto cuenta con una interfaz gráfica sencilla desarrollada con **Windows Forms**, una capa encargada de la lógica de negocio y una capa encargada del acceso y conexión con la base de datos.

## Tecnologías utilizadas

* **C#**: lenguaje principal utilizado para desarrollar la aplicación.
* **.NET**: plataforma utilizada para ejecutar y estructurar el proyecto.
* **Windows Forms**: utilizado para construir la interfaz gráfica.
* **SQL Server**: sistema gestor de base de datos utilizado para almacenar la información.
* **SQL Server Management Studio (SSMS)**: herramienta utilizada para crear, administrar y consultar la base de datos.
* **Visual Studio**: entorno de desarrollo utilizado para crear, configurar, ejecutar y depurar el proyecto.

## Arquitectura del proyecto

El proyecto está organizado utilizando una arquitectura por capas:

```text
Parqueadero
│
├── CapaAccesoDatos
│   └── Conexión con SQL Server
│
├── CapaNegocio
│   └── Lógica y reglas del sistema
│
└── CapaPresentacion
    └── Windows Forms
```

### 1. Capa de Acceso a Datos

Esta capa se encarga de establecer la comunicación entre la aplicación y la base de datos de **SQL Server**.

Aquí se encuentra la configuración necesaria para realizar la conexión y posteriormente ejecutar las operaciones relacionadas con los datos.

Su responsabilidad principal es manejar el acceso a la información sin mezclarlo directamente con la interfaz gráfica o las reglas del negocio.

### 2. Capa de Lógica de Negocio

Esta capa contiene la lógica principal del sistema.

Su función es procesar las operaciones del parqueadero y aplicar las reglas necesarias antes de enviar o recibir información desde la capa de acceso a datos.

La separación de esta lógica permite que el proyecto sea más organizado y facilita su mantenimiento.

### 3. Capa de Presentación

La capa de presentación contiene la interfaz gráfica desarrollada utilizando **Windows Forms**.

Desde esta capa el usuario puede interactuar con el sistema mediante formularios, botones, campos de texto y otros controles visuales.

Esta capa se comunica con la capa de negocio para realizar las diferentes operaciones.

## Base de datos

La base de datos fue desarrollada utilizando **SQL Server** y administrada mediante **SQL Server Management Studio (SSMS)**.

SQL Server se utiliza para almacenar la información necesaria para el funcionamiento del sistema, mientras que SQL Server Management Studio permite crear la base de datos, tablas, consultas y realizar tareas de administración.

La aplicación desarrollada en C# se conecta a SQL Server mediante la capa de acceso a datos.

## Funcionamiento general

El flujo básico de la aplicación es:

```text
Usuario
   ↓
Windows Forms
   ↓
Capa de Negocio
   ↓
Capa de Acceso a Datos
   ↓
SQL Server
```

Cuando el usuario realiza una acción desde el formulario, la solicitud pasa a la capa de negocio. Esta procesa la operación y posteriormente utiliza la capa de acceso a datos para comunicarse con SQL Server.

La respuesta realiza el recorrido inverso hasta llegar nuevamente a la interfaz gráfica.

## Requisitos

Para ejecutar el proyecto se necesita tener instalado:

* Windows
* Visual Studio
* .NET SDK compatible con la versión utilizada por el proyecto
* SQL Server
* SQL Server Management Studio (SSMS)

## Instalación y ejecución

### 1. Clonar el repositorio

Desde una terminal se puede clonar el proyecto utilizando:

```bash
git clone URL_DEL_REPOSITORIO
```

Después ingresar a la carpeta:

```bash
cd NOMBRE_DEL_PROYECTO
```

### 2. Abrir el proyecto en Visual Studio

Abrir **Visual Studio** y seleccionar:

```text
Archivo → Abrir → Proyecto o solución
```

Seleccionar el archivo:

```text
.sln
```

del proyecto.

También se puede abrir directamente haciendo doble clic sobre el archivo `.sln`.

### 3. Restaurar las dependencias

Desde una terminal ubicada en la carpeta de la solución se puede ejecutar:

```bash
dotnet restore
```

Esto descarga y restaura los paquetes necesarios del proyecto.

### 4. Compilar el proyecto

Ejecutar:

```bash
dotnet build
```

Si la compilación termina correctamente, el proyecto está listo para ejecutarse.

### 5. Configurar SQL Server

Antes de ejecutar la aplicación se debe crear la base de datos utilizando el script SQL incluido en el proyecto.

Abrir **SQL Server Management Studio**, conectarse al servidor SQL Server y ejecutar el script de creación de la base de datos.

Posteriormente se debe verificar que la cadena de conexión utilizada por la aplicación corresponda al servidor SQL Server instalado en el equipo.

Ejemplo:

```text
Server=SERVIDOR;
Database=Parqueadero;
Trusted_Connection=True;
TrustServerCertificate=True;
```

La cadena exacta dependerá de la configuración de SQL Server utilizada.

### 6. Ejecutar desde Visual Studio

En Visual Studio:

1. Abrir el **Explorador de soluciones**.
2. Seleccionar el proyecto de presentación, correspondiente a Windows Forms.
3. Establecerlo como **proyecto de inicio**.
4. Presionar `F5` o seleccionar **Iniciar**.

También se puede ejecutar sin depuración utilizando:

```text
Ctrl + F5
```

## Comandos principales

Los comandos más importantes para trabajar con el proyecto desde una terminal son:

```bash
dotnet restore
```

Restaura las dependencias.

```bash
dotnet build
```

Compila la solución.

```bash
dotnet run
```

Ejecuta un proyecto .NET cuando el proyecto permite ejecución mediante CLI.

Para una solución con varios proyectos y Windows Forms, se recomienda principalmente ejecutar la aplicación desde **Visual Studio**, configurando correctamente el proyecto de presentación como proyecto de inicio.

## Objetivo académico

El ejercicio busca demostrar la implementación de una aplicación en C# utilizando una arquitectura por capas, permitiendo comprender cómo separar:

* La interfaz gráfica.
* La lógica de negocio.
* El acceso a datos.
* La comunicación con una base de datos SQL Server.

Esta estructura permite desarrollar aplicaciones más organizadas, mantenibles y fáciles de ampliar.
