# Sistema de Gestión de Inventario - Práctica POO 🛒

Este proyecto es una aplicación de consola desarrollada en **C#** para demostrar los conceptos fundamentales de la Programación Orientada a Objetos. El sistema permite gestionar productos electrónicos y alimentos, aplicando reglas de negocio específicas para cada tipo.

##  Conceptos Aplicados

En este desarrollo se implementaron los siguientes pilares de POO:

* **Encapsulación:** Uso de atributos privados con propiedades públicas (get/set) para proteger los datos.
* **Herencia:** Una clase base "Producto" de la cual heredan las clases específicas.
* **Polimorfismo:** Sobrescritura (override) del método "CalcularImpuesto()" para manejar distintas tasas según el producto.

##  Estructura del Código

El sistema se divide en tres partes principales:

1.  **Clase Producto:** Contiene los datos básicos como Nombre, Código, Precio y Cantidad.
2.  **ProductoElectronico:** Añade el atributo de Garantía y aplica un 18% de ITBIS.
3.  **ProductoAlimento:** Añade la Fecha de Vencimiento y aplica un 8% de impuesto.


