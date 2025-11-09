# Mars Rover Kata

## Descripción del Problema
Debes desarrollar un programa que simule el movimiento de un rover en Marte. El rover se mueve en una cuadrícula/meseta rectangular.

## Reglas Principales

### Posición y Orientación
- El rover tiene una posición (x, y) en la cuadrícula
- Tiene una orientación cardinal: N (Norte), S (Sur), E (Este), W (Oeste)
- La posición inicial se proporciona como entrada (ej: "0 0 N")

### Comandos
El rover recibe una cadena de comandos:
- **L** (Left): Gira 90° a la izquierda sin moverse
- **R** (Right): Gira 90° a la derecha sin moverse  
- **M** (Move): Avanza una posición en la dirección que está mirando

### Rotaciones
- Desde N: L→W, R→E
- Desde S: L→E, R→W
- Desde E: L→N, R→S
- Desde W: L→S, R→N

### Movimiento
- N: y aumenta (+1)
- S: y disminuye (-1)
- E: x aumenta (+1)
- W: x disminuye (-1)

## Consideraciones Importantes

1. **Límites de la cuadrícula**: Se define el tamaño máximo (ej: "5 5")
2. **Múltiples rovers**: A veces se pide manejar varios rovers en la misma cuadrícula
3. **Validaciones**: Considerar qué pasa si el rover sale de los límites
4. **Entrada/Salida**: Formato típico:
   - Entrada: tamaño cuadrícula, posición inicial, comandos
   - Salida: posición final (x y orientación)

## Ejemplo
```
Cuadrícula: 5 5
Posición inicial: 1 2 N
Comandos: LMLMLMLMM
Resultado: 1 3 N
```
