# CQRS

¿Qué es CQRS?

CQRS es un patrón arquitectónico, donde el acrónimo significa Segregación de Responsabilidad de Consulta de Comando (o Command Query Responsibility Segregation, en inglés). Podemos hablar de CQRS cuando las operaciones de lectura de datos se separan de las operaciones de escritura de datos y ocurren en una interfaz diferente.

En la mayoría de los sistemas CQRS, las operaciones de lectura y escritura utilizan diferentes modelos de datos, a veces incluso diferentes almacenes de datos. Este tipo de segregación hace que sea más fácil escalar, leer y escribir operaciones y controlar la seguridad, pero agrega complejidad adicional a tu sistema.

Node.js at Scale, es una colección de artículos que se enfocan en las necesidades de las empresas con instalaciones más grandes de Node.js y desarrolladores avanzados de Node.


# Injenccion por dependencia por constructor
