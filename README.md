# Adapter + Facade - Example

Ejemplo del patrón de diseño Adapter y Facade en C# .Net. 

Gestión de cuentas bancarias en aplicación de escritorio y celular (simulado/fachada).

## ¿Qué hace?
<ul>
<li> Divide las funciones disponibles según el dispositivo: escritorio (versión completa) y celular (demo) </li>
<li> Creación y Gestión de Cuentas de banco segun su tipo (normal y super ahorro) </li>
<li> Creación y Gestión de Préstamos bancarios calculando tasa de interés </li>
<li> Creación y Gestión de Tarjetas de crédito </li>
<li> Creación y Gestión de Certificados </li>
</ul>


## ¿Cuál es el problema a resolver?

### En primer lugar, la aplicación se divide en dos: 

App de Escritorio - tiene acceso a todas las funciones disponibles

App de Móvil - tiene acceso a solo unas pocas funciones de gestión, además de que no permite la creación y gestión de tarjetas de crédito.

<strong>¿Qué puedo hacer para solo usar ciertas funciones de ciertas clases sin repetir el código y además de no darle acceso directo a las clases principales en la versión de celular?</strong>

### En segundo lugar, en la versión de escritorio hay dos tipos de cuentas de ahorro:

Cuenta de Ahorro Común - Esta cuenta se puede gestionar (crear, depositar, retirar y consultar) con normalidad.

Cuenta de Super Ahorro - Esta cuenta se puede gestionar con normalidad, pero tiene una función adicional que no permite el retiro si este excede el 40% del balance.

<strong>¿Cómo puedo implementar esta función extra si mi clase "CuentaSuperAhorro" no es compatible con la interfaz "IAhorro"? </strong>

## ¿Cómo se resuelve?

El primer problema se resuelve perfectamente implementando el patrón de diseño Facade o Fachada, con este, creo una clase llamada "Fachada" el cual 'tomara prestado' funciones de las demás clases y solo las que son necesarias.

El Segundo problema se resuelve implementando el patrón Adapter o Adaptador, con este, creo una clase llamada "Adaptador" el cual tiene las funciones necesarias para implementar la interfaz "IAhorro", mientras instancia la clase "CuentaDeSuperAhorro" e implementa su única función dentro de la función "Retiros".


He aquí su diseño UML

[![UML.png](https://i.postimg.cc/rF5jqqnr/UML.png)](https://postimg.cc/TpYg9vXd)
