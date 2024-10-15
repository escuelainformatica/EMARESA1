// quiero hacer un sistema que maneje productos y que los productos se desplieguen en la pantalla.

// voy a hacer una variable para producto.

// una clase que es de datos
// una clase que hace operaciones

// quiero tener una variable que tenga los datos de un RECTANGULO.
// y quiero tener una clase de servicio para
//      perimetro, area y diagonal.
using ConsoleApp1;


Producto prod = new Producto();
ProductoServicio producA = new ProductoServicio();
prod.nombre = "cocacola";
prod.precio = 200;
prod.envase = "botella pet";

producA.mostrar(prod);

// rectangulo
Rectangulo rect = new Rectangulo();
rect.alto = 10;
rect.ancho = 10;
RectanguloServicio rects = new RectanguloServicio();

Console.WriteLine(rects.obtenerPerimetro(rect));
Console.WriteLine(rects.obtenerDiagonal(rect));
Console.WriteLine(rects.obtenerArea(rect));

// rectangulo dominio
RectanguloDominio rect2 = new RectanguloDominio();
rect2.alto = 10;
rect2.ancho = 10;
Console.WriteLine(rect2.obtenerPerimetro());
Console.WriteLine(rect2.obtenerDiagonal());
Console.WriteLine(rect2.obtenerArea());
