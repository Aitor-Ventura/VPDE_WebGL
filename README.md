https://aitor-ventura.github.io/VPDE_WebGL/

https://aitorventura.itch.io/vpde-webgl

Se ha desarrollado una pequeña demo de un videojuego que consiste en clicar globos, y por cada globo se obtiene un punto.
### Despliegue en GitHub Pages
Una vez se tenga el comportamiento deseado en el juego, basta con buildear el proyecto con la configuración específica para WebGL. Para esto, se debe seguir la siguiente serie de pasos:

1. ```File -> Build Settings```
2. Seleccionar ```WebGL``` y seguidamente clic en ```Switch Platform```
3. Construir el proyecto en una carpeta elegida. Una vez se haya elegido la carpeta deseada, subirla como único repositorio GitHub, o sus contenidos en la carpeta raíz del propio repositorio del proyecto.
4. En GitHub, seleccionar ```Settings``` del repositorio, ir al apartado ```Pages``` y seleccionar el ```branch``` correspondiente a donde se encuentre la carpeta de la build hecha previamente.
5. Esperar hasta que se complete el despliegue.

Para más información en cómo empezar en GitHub Pages, consultar la [documentación oficial](https://pages.github.com/).

### Despliegue en itch.io
Una vez se tenga el comportamiento deseado en el juego, basta con buildear el proyecto con la configuración específica para WebGL. Para esto, se debe seguir la siguiente serie de pasos:

1. ```File -> Build Settings```
2. Seleccionar ```WebGL``` y seguidamente clic en ```Switch Platform```
3. Construir el proyecto en una carpeta elegida.
4. Comprimir la carpeta en un archivo ```.zip```.
5. Ir a itch.io y crear un nuevo proyecto. Establecer un nombre, una URL, su precio... Una vez esté todo hecho, subir el archivo ```.zip``` creado previamente.
