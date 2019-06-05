# Tiendeo
_GUIA_\
-Es necesario disponer de un **SQL Server**, de **NPM** y de **Angular CLI** instalado para poder ejecutarlo.\
-La ConnectionString se modifica en **appsettings.json** del proyecto **Tiendeo.API**\
-La URL base de la api se modifica en el archivo **environment/environment.ts**\
-La API Key de Google Maps se modifica en el archivo **environment/environment.ts**\
-Es **necesario** para el funcionamiento de la aplicación que se descargen todos los paquetes de NuGet\
-Es **necesario** para el funcionamiento de la aplicación que se establezca el proyecto de **API** como StartUp Project\
-Es **necesario** para el funcionamiento de la app que se ejecuten todas las **migraciones** en la base de datos que genera EntityFramework\
-Es **necesario** para el funcionamiento de la app que se ejecute el archivo **Tiendeo.DAL/Scripts/BasicData.sql** que incluye los datos de la aplicación.\
-Para ejecutar la APP de angular hay que ir a Tiendeo/App y ejecutar en un CMD los comandos: \
	-**npm install** ( para la instalación de todos los paquetes necesarios ) \
	-**npm start** ( para arrancar la aplicación, por defecto se lanza en http://localhost:4200 ) \

_NOTA_
**Importante**: Para poder entregar la prueba a la mayor brevedad, he omitido algo básico en cualquier proyecto, que son los Logs y la seguridad.
Solo dejar constancia de que es algo que se hacer ( lo he implementado en todos los proyectos que he desarrollado ), pero debido a que es una prueba de código, no he visto necesario implementarlo.
En caso de que se quiera incluir en el proyecto, con comunicarmelo será suficiente para que lo implemente en el proyecto.

En el caso de los **Logs**, utilizaría nLog, con la configuración del mismo en el appsettings.json del proyecto de API. Se crearía un proyecto nuevo con la definición e implementación del Logger.
En todos los controladores, servicios y repositorios se inyetaría mediante DI este logger, y en cada entrada de método y excepción, se logearía la información necesaria.

En el caso de la **API Security**, se implementaría un **MiddleWare** que interceptaría cada llamada a la API, y comprobaría que esta clave es correcta.\

Los test, solo he desarrollado los de la **BLL** y de una manera simple, para que se controlen los pocos métodos que tiene la capa de servicios.\


_OTROS_
-La aplicación disponer de **Swagger** para consultar y probar las distintas llamadas a la **API**\
-El mapa de google va realizando llamadas a la API cada vez que recibe un cambio de posición o zoom, en esta llamada se envian las coordenadas que forman el area que muestra el mapa, y un parámetro que indica cuantas tiendas va a mostrar como máximo\
-Se pueden modificar tanto la ciudad como el número de resultados desde la vista, y se verán los cambios en tiempo real\

_REQUERIMIENTOS_DE_LA_PRUEBA_
_API_   
Tanto los métodos que se han pedido específicamente como los que se describen abajo se pueden consultar y probar en Swagger.
1. Lista completa de las tiendas ordenadas por importancia.
/api/stores/top
2. La tienda más cercana a las coordenadas de un usuario.
/api/stores/near/top?latitude=XXXX&longitude=YYYY
3. Crear un endpoint que devuelva las X primeras tiendas ordenadas respecto a la distancia del usuario.
/api/stores/near?latitude=XXXXX&longitude=YYYYY&maxResults=15
4. Crear un endpoint que devuelva todos los servicios de una ciudad
/api/services-by-city/2

_BBDD_
1. Escribir una query que devuelva todos los servicios de tipo cajero
```
SELECT 
	* 
FROM 
	Establishment 
WHERE 
	Discriminator = 'Service' AND 
	ServiceType = 0
```

2. Escribir una query que devuelva todas las tiendas del negocio “Carrefour”
```
SELECT 
	ES.* 
FROM 
	Establishment ES INNER JOIN
	(SELECT Id FROM Enterprise WHERE Name = 'Carrefour') EN ON EN.Id = Es.EnterpriseId
WHERE 
	Discriminator = 'Store'
```

3. Escribir una query que devuelva las 2 tiendas más importantes del negocio “Lidl” en “Barcelona”.
```
SELECT TOP 2
	ES.* 
FROM 
	Establishment ES INNER JOIN
	(SELECT Id FROM Enterprise WHERE Name = 'Lidl') EN ON EN.Id = Es.EnterpriseId INNER JOIN
	(SELECT Id FROM City WHERE Name = 'Barcelona') CT ON CT.Id = Es.CityId
WHERE 
	Discriminator = 'Store'
ORDER BY
	ES.[Top] ASC
```
