# Segundo Parcial - Programacion Web 3

1) **Base de Datos y Configuración del Proyecto:**

      a. Crear en SQL Server las siguientes tablas:

     - **Empleado:** con los campos (IdEmpleado int NOT NULL, NombreCompleto nvarchar(100) NOT NULL, IdSucursal int NOT NULL)
     - **Sucursal:** con los campos (IdSucursal int, Direccion nvarchar(100) NOT NULL, Eliminada bit NOT NULL)
Recordar agregar la relación para que un Empleado esté relacionado a una Sucursal a través de IdSucursal. Establecer 
las claves primarias como identity.
  
      b. Crear un proyecto MVC llamado **SistemaDeGestionDeEmpleados.Web**. Pueden organizarlo en capas usando carpetas 
dentro del proyecto web o en diferentes proyectos (**SistemaDeGestionDeEmpleados.Data**, 
**SistemaDeGestionDeEmpleados.Servicios**).

      c. Utilizando EF (enfoque DatabaseFirst), crear el modelo conceptual, en una carpeta llamada “EF”

      d. Generar script para creación de base de datos, tablas e insert de 2 Sucursales no eliminadas y 1 Sucursal Eliminada
para que puedan crearse Empleados. (Eliminada = 1 quiere decir que esta eliminada la sucursal y Eliminada = 0 quiere 
decir que no esta eliminada la Sucursal).

2) **Funcionalidad de Creación de Empleados y Asignación de Sucursales**
   
      a. Crear una aplicación ASP.NET con una página que permita crear nuevos empleados. Esta página debe contener 
controles para Nombre Completo (input text), Sucursal (un combo o select option de HTML ordenados por Nombre 
de A a Z de todas las Sucursales NO Eliminadas) y un botón "Crear Empleado".
   
      b. Implementar el código necesario para almacenar un nuevo Empleado cuando se presiona el botón "Crear Empleado". 
Asocia cada empleado a una sucursal seleccionada en el combo.


3) **Visualización de Empleados y Sucursales Asociadas**

      a. Después de crear un Empleado, redirigir a una página que muestre todos los empleados registrados y la información 
de la sucursal asociada. Mostrar Nombre Completo del Empleado, Sucursal, Ciudad y Dirección de la Sucursal.

4) **Funcionalidad de Filtrado por Sucursal**

      a. Agregar una nueva funcionalidad de "Filtrar" en la misma página/vista. Incluir un combo de Sucursales (ordenadas 
      por Nombre de A a Z y NO Eliminadas) y un botón "Filtrar". Al elegir una Sucursal, mostrar solo los empleados 
      asociados a esa Sucursal. Si no se elige ninguna Sucursal, mostrar todos los empleados
