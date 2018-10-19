# Examen Acceso a Datos.

## 1. Describe las diferencias entre IQueryable<T> e IEnumerable<T>.

La diferencia principal entre ambas interfaces es que los métodos de extensión definidos en la IQueryable<T> tienen como parámetros objetos Expression en puesto de Func, lo que significa que el delegado que recibe es un árbol de expresiones. Esto ayuda a la hora de realizar consultas SQL, ya que si lo hacemos con IEnumerable entonces las filas son arrastradas a memoria como objetos antes de ejecutar la sentencia mientras que IQueryable puede convertirse a SQL y ejecutarse directamente.

Por tanto, utilizaremos IEnumerable para trabajar con colecciones en la memoria e IQueryable para conexiones con fuentes de datos remotas.

## 2. Dada la siguientes estructuras de datos.

```
var a  = new int[]{1,2,3};
var b = new int[] {1,2};
```

## a) Escribe con Linq los valores de a que no están en b.

Para resolver este problema podemos incurrir a dos métodos diferentes, el método Contains() y el método Except().

``var itemsANoB = a.Where(c => !b.Contains(c));`` La variable itemsANoB contendrá todos los valores de a donde se hace la comprobación de que no estén contenidos en la lista b. El método Where recibe como parámetro un delegado que devuelve un tipo bool el cuál hemos implementado con el método Contains que determina si una secuencia contiene un elemento que especificamos. 

``var itemsANoB2 = a.Except(b);`` El método Except() realiza exactamente lo que estamos buscando en el ejercicio directamente. Necesita como parámetro un IEnumerable que será nuestro segundo array y proporciona la diferencia de conjunto de las dos secuencias, devolviendo aquellas que están en a y que no están en b. Si la sentencia es al contrario, entonces se proporcionarán los que están en b y no en a.

## b) Escribe el mismo código con sql pensando que a y b son dos tablas de una bb.dd. y los valores están en la columna Id.

``SELECT * FROM a LEFT JOIN b ON a.Id = b.Id WHERE b.Id IS NULL`` 

## 3. Escribe el código necesario para que un método devuelva (en este ejercicio no se puede utilizar LINQ):

1. Los pares de una secuencia de enteros de longitud indeterminada 
2. Los mayores de 10 de dicha secuencia.
3. Los menores de 10 de dicha secuencia.

Crearemos los métodos, que devuelven IEnumerable<int>, Pares, MayoresDe10 y MenoresDe10. Estos métodos reciben como parámetros dos enteros, uno from y otro to. Tras comprobaciones lógicas de estos parámetros, haremos yield return dentro de un bucle for con aquellos números que están dentro del intervalo (from, to) que cumplen con las condiciones especificadas.

## 4. Una vez escrito el código del ejercicio anterior obtén el Máximo de los valores utilizando LINQ.

Será fácil usar LINQ ahora puesto que los métodos anteriores devuelven objetos IEnumerable<int>. La línea de código, `` Pares(from, to).Max();`` nos devolverá lo que requiere el ejercicio, ya que el método Max, de la clase Enumerable, devuelve el máximo del IEnumerable<int> que lo invoca. Haremos lo mismo con los otros dos métodos, ``MayoresDe10(from, to).Max();`` y ``MenoresDe10(from, to).Max();``

## 5. Describe los objetos basicos de ADO.NET y su funcionalidad.

Los objetos básicos de ADO.NET son *Connection* que proporciona la conectividad a un origen de datos, *Command* que permite tener acceso a comandos de base de datos para devolver datos, modificarlos, ejecutar procedimientos almacenados y enviar o recuperar información sobre parámetros (*parameters*), que son el último de los objetos que conforman, básicamente, ADO.NET.

##6. Escribe con lambda una función capaz de sumar dos números y multiplicarlos, una vez escrito con lambda hacer lo mismo con un método.

En primer lugar, para crear una lambda, necesitamos una función delegada `` delegate int Funcion(int a, int b); `` que recibe dos enteros y devuelve un entero. Digamos que así será el "contrato" que ha de seguir nuestra expresión lambda. 

Creamos una instancia de este delegado ``Funcion funcion = (a, b) => a + b;`` y le asignamos la expresión lambda ``(a, b) => a + b`` que no es más que los dos parámetros que recibe los suma y retorna dicha suma. Podemos también asignar ahora al delegado ``funcion = (a, b) => a * b`` dándonos así la expresión lambda para retornar la multiplicación de ambos enteros. 

Como se puede ver, las asignaciones se pueden hacer tantas veces como queramos y se va a ejecutar el delegado ``var resultado = funcion(valor1, valor2)`` con la última asignación que realicemos.

En segundo lugar, podemos crear los métodos:

```
static int Suma(int a, int b)
{
    return a + b;
}

static int Producto(int a, int b)
{
    return a * b;
}
```
que son los métodos Suma y Producto antes definidos con las expresiones lambda y también podremos hacer las asignaciones ``funcion = Suma;`` y ``funcion = Producto;``, ejecutándose el último de los métodos al que nuestro puntero ``funcion`` está apuntando.












