# Estructuras de datos

## Arreglos
Un arreglo es una estructura de datos que almacena un conjunto de elementos del mismo tipo, ubicados en posiciones contiguas de memoria.  
Cada elemento se identifica mediante un índice.  
**Características:**  
Tamaño fijo (no se puede cambiar una vez creado).  
Acceso directo a cualquier elemento usando su índice.  
Muy eficiente para búsqueda por posición, pero costoso para inserciones o eliminaciones.  
**Ejemplo:**  
[10, 20, 30, 40] → arreglo de enteros de tamaño 4.  

## Pilas
Una pila es una estructura de datos lineal que sigue el principio LIFO (Last In, First Out), es decir, el último en entrar es el primero en salir.  
**Operaciones principales:**  
push: insertar un elemento en la cima.  
pop: eliminar el elemento de la cima.  
peek: ver el elemento en la cima sin eliminarlo.  
**Ejemplo de uso:**  
Deshacer acciones en un editor o navegar hacia atrás en un navegador.  

## Cola
Una cola sigue el principio FIFO (First In, First Out), es decir, el primero en entrar es el primero en salir.  
Los elementos se agregan por un extremo (final) y se eliminan por el otro (frente).
**Operaciones principales:**  
enqueue: insertar al final.  
dequeue: eliminar del frente.  
front: consultar el primer elemento.  
**Ejemplo de uso:**  
Gestión de tareas en una impresora o atención de clientes en fila.

## Lista (List)
Una lista es una colección ordenada de elementos llamados nodos, donde cada nodo contiene datos y una o más referencias (enlaces) a otros nodos.  
A diferencia de los arreglos, las listas permiten inserciones y eliminaciones dinámicas.

## Lista Simplemente Enlazada
Cada nodo contiene:  
Dato  
Referencia al siguiente nodo  
**Ventajas:**  
Permite inserciones y eliminaciones rápidas.  
Tamaño dinámico.  
**Desventajas:**  
Solo se puede recorrer en una dirección (inicio → fin).  
No permite acceso directo por índice.  
**Ejemplo:**  
[A] → [B] → [C] → NULL  

## Lista Doblemente Enlazada
Cada nodo contiene:  
Dato  
Referencia al nodo anterior  
Referencia al nodo siguiente  
**Ventajas:**  
Se puede recorrer en ambas direcciones.  
Inserciones y eliminaciones más flexibles.  
**Desventajas:**  
Requiere más memoria por los punteros adicionales.  
**Ejemplo:**  
NULL ← [A] ⇄ [B] ⇄ [C] → NULL  

## Lista Circular
Es una variación de las listas donde el último nodo se conecta con el primero, formando un ciclo cerrado.  
Puede ser simple o doble.  
**Ventajas:**  
Permite recorridos continuos sin llegar a NULL.  
Útil para estructuras que requieren acceso cíclico (como turnos o juegos).  
**Desventajas:**  
Es más difícil detectar el final de la lista.  
Puede provocar bucles infinitos si no se maneja con cuidado.  
**Ejemplo:**  
[A] → [B] → [C] → [A]