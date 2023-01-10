# Adapter + Facade - Example

Ejemplo del patron de diseño Adapter y Facade en C# .Net. 

Gestion de cuentas bancarias en aplicacion de escritorio y celular (simulado/fachada).

## ¿Que hace?
<ul>
<li> Divide las funciones disponibles segun el dispositivo: escritorio (version completa) y celular (demo) </li>
<li> Creacion y gestion de cuentas de banco segun su tipo (normal y super ahorro) </li>
<li> Creacion y Gestion de prestamos bancarios calculando tasa de interes </li>
<li> Creacion y Gestion de Tarjetas de credito </li>
<li> Creacion y Gestion de Certificados </li>
</ul>


## ¿Cual es el problema a resolver?

### En primer lugar, la aplicacion se divide en dos: 

App de escritorio - tiene acceso a todas las funciones disponibles

App de movil - tiene acceso a solo unas pocas funciones de gestion, ademas de que no permite la creacion y gestion de tarjetas de credito.

<strong>¿Que puedo hacer para solo usar ciertas funciones de ciertas clases sin repetir el codigo y ademas de no darle acceso directo a las clases principales en la version de celular?</strong>

### En segundo lugar, en la version de escritorio hay dos tipos de cuentas de ahorro:

Cuenta de Ahorro Comun - Esta cuenta se puede gestionar (crear, depositar, retirar y consultar) con normalidad.

Cuenta de Super Ahorro - Esta cuenta se puede gestionar con normalidad pero tiene una funcion adicional que no permite el retiro si este excede el 40% del balance

<strong>¿Como puedo implementar esta funcion extra si mi clase "CuentaSuperAhorro" no es compatible con la interfaz "IAhorro"? </strong>

## ¿Como se resuelve?

El primer problema se resuelve perfectamente implementando el patron de diseño Facade o Fachada...

El Segundo problema se resulve implementando el patron Adapter o Adaptador, con este, creo una clase llamada "Adaptador" el cual tiene las funciones necesarias para implementar la interfaz "IAhorro", mientras instancia la clase "CuentaDeSuperAhorro" e implementa su unica funcion dentro de la funcion "Retiros".


He aqui su diseño UML

[![UML.png](https://i.postimg.cc/rF5jqqnr/UML.png)](https://postimg.cc/TpYg9vXd)
