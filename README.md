# EMARESA1

## Conceptos de programacion #1 SRP
Responsabilidad de principio simple, o separar un problema en problemas mas sencillos

**¿Como separarlo?**

* En este caso se separa en dos clases
   * Una clase maneja datos (clase modelo)
   * La otra clase maneja acciones (clase de servicio)


## ¿como se crea la clase de modelo?

* Cree una clase
* Y agregue los campos que necesita usar

```csharp
    internal class Producto
    {
        // campos
        public string nombre;
        public int precio;
        public string envase;
    }
```

## ¿Como se crea la clase de servicio?

* Cree una clase
* Y agregue metodos o funciones.

```csharp
    internal class ProductoServicio
    {
        public void mostrar(Producto prod)
        {
            // codigo
        }
    }
```

## ¿Como se crea la clase de dominio?
Una clase de modedominiolo es como una clase de modelo + servicio.

> No es recomendable de usar, es mejor usar modelo y servicio separado.

```csharp
internal class RectanguloDominio
    {
        public int alto;
        public int ancho;
        public int obtenerPerimetro()
        {
            return alto * 2 + ancho * 2;
        }
        public int obtenerArea()
        {
            return alto * ancho;
        }
        public double obtenerDiagonal()
        {
            return Math.Sqrt(alto * alto + ancho * ancho);
        }
    }
```