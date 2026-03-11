# Sistema de Gestión de Biblioteca

## Descripción

Aplicación de escritorio desarrollada en **C# con Windows Forms** que permite gestionar una biblioteca mediante un sistema CRUD completo.

El sistema permite administrar:

* Libros
* Usuarios
* Préstamos
* Devoluciones
* Estadísticas de préstamos

Este proyecto fue desarrollado como parte del **Desafío 1 – Aplicación de Escritorio**.

---

# Funcionalidades

## Gestión de Libros

Permite:

* Agregar libros
* Editar libros
* Eliminar libros
* Visualizar lista de libros

Campos:

* Título
* Autor
* Año de publicación

---

## Gestión de Usuarios

Permite:

* Agregar usuarios
* Editar usuarios
* Eliminar usuarios
* Visualizar lista de usuarios

Campos:

* Nombre
* Correo

---

## Gestión de Préstamos

Permite:

* Registrar préstamos de libros
* Registrar devoluciones
* Ver historial de préstamos

Reglas:

* Un libro prestado no puede volver a prestarse hasta que se devuelva.

---

## Estadísticas

Muestra estadísticas de uso de la biblioteca:

* Cantidad de préstamos por libro.

Esto permite identificar los **libros más prestados**.

---

# Tecnologías Utilizadas

* C#
* Windows Forms
* .NET
* Programación Orientada a Objetos (POO)

---

# Principios de POO aplicados

El proyecto aplica:

* Clases
* Encapsulamiento
* Modularización
* Separación de responsabilidades

Clases principales:

* Libro
* Usuario
* Prestamo
* BibliotecaService

---

# Estructura del Proyecto

```
BibliotecaAppUDB
│
├── Models
│   ├── Libro.cs
│   ├── Usuario.cs
│   └── Prestamo.cs
│
├── Servicios
│   └── BibliotecaService.cs
│
├── Forms
│   ├── MainForm.cs
│   ├── LibrosForm.cs
│   ├── UsuariosForm.cs
│   ├── PrestamosForm.cs
│   └── EstadisticasForm.cs
```

---

# Instalación

1. Clonar el repositorio:

```
git clone https://github.com/usuario/biblioteca-app.git
```

2. Abrir el proyecto en **Visual Studio**

3. Ejecutar el proyecto presionando:

```
F5
```

---

# Uso

1. Abrir la aplicación
2. Registrar libros
3. Registrar usuarios
4. Registrar préstamos
5. Registrar devoluciones
6. Consultar estadísticas

---

# Autor

Proyecto desarrollado por:

**[Tu Nombre]**

Universidad Don Bosco
# BibliotecaAppUDB
