# APES

Proyecto APES:
Integrantes: LAURA Pablo, MENDOZA Lucas, ROMERO Lucas, SONCCO Shande

No basta con solo descargar el proyecto completo y ejecutarlo en Visual Studio, cuando eso sucede descubrimos un error desde el origen de datos. Esos datos deben originarse desde el mismo dispositivo que se usa.
Para poder usar el software correctamente necesita crear la base de datos y conectarla con Visual Studio desde su computadora. A continuacion proporcionamos la informacion necesaria para que lo pueda hacer.

Descargar Microsoft SQL Server 2019: https://www.youtube.com/watch?v=oYHmKFiNOYs

Como crear una base de datos en Microsoft SQL Server Management: https://youtu.be/fyvEhDgKl7E?si=o_tSMzJYTPWUHmZS&t=56 (Minuto 0:56 a 05:18). En el New Query copian todo el contenido de "Estructura_Principal.sql" y en otro New Query copian "Altas_Principal.sql" le dan a ejecutar(F5) y hacen un refresh sobre la base de datos

Como conectar la base de datos con Visual Studio: https://youtu.be/E_P0if5WJpk?si=KWyvUlozKBMOcPyo&t=949 (Minuto 15:49 a 21:58). El texto de DATA SOURCE va en el archivo "conexcion.vb"
