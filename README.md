# Examen de ingreso Ing Sw

## Descripción

alguna descripcion del sistema

## Diagrama de Clases

![alt text](https://github.com/gcondori1/biblioteca/blob/release-1.0/Repositories/Diagram/Diagrama%20de%20clases.png)

## Estructura del proyecto

    .
    ├── App             
       ├── Constants            # Constantes utilizadas en el proyecto
       ├── Utils                # Clase de utilidades
       ├── Forms                # Interfaces de usuario (UI)
    ├── Models                         
       ├── ViewModels           # Datos a mostrar en los formularios
    ├── Repositories                   
       ├── Entities             # Entidades de BD
       ├── Repositories         # Lógica para la obtención de datos
    ├── Services
       ├── services             # Lógica del negocio



## Instalación 

### Visual studio
 
```bash
git clone www.git

build -> build solution

Start application

```

## Preguntas

1. En C#, ¿para que sirve una propiedad?

*Sirve para representar el estado un objeto en cierto momento.*

2. ¿Cuando utilizaría acceso protegido en los miembros de una clase?

*Por definición, el acceso protegido solo permite que los miembros de una clase sean accedidos por las clases de un mismo paquete o subclases de la misma.*
*Normalmente se utiliza para encapsular miembros que solo se han accedidos por clases hijas.*

3. En UML, ¿qué tipo de relación es la siguiente?

*Es una relación de Realización. Se utiliza para determinar un contrato con otra clase, es decir, cuando dicha clase implementa una interface*

4. Explique con sus palabras, qué implica una relacion de dependencia entre dos clases.
*Una relación de dependencia entre dos clases, implica que las clases hijas heredarán todos sus atributos y métodos de la clase padre.*

5. V o F

a. Un constructor es un método que se invoca de forma automática cuando se instancia el objeto de una clase.
*Verdadero. Cada vez que se instancia una clase, se llama al constructor de dicho método, que puede estar sobrecargado.*

b. Un constructor debe tener el mismo nombre de la clase. 
*Verdadero. *

c. Un constructor debe retornar un valor.
*Falso. Los contructores solo deben asignar valores a las propiedades del mismo objeto. Normalmente se utiliza la palabra clave this.*

d. Un constructor puede ser privado.
*Si, normalmente es private cuando se desea que esa clase no sea instanciada.*

e. Una clase puede tener declarado un único constructor.
*Falso. Por definición, las clases pueden tener constructores sobrecargados, es decir, definir varios constructores que varían en los parámetros pasados como argumentos.*

