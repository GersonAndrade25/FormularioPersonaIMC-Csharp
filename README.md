# FormularioPersonaIMC-Csharp

Aplicación de escritorio desarrollada en C# con Windows Forms para modelar y evaluar datos personales.

## Funcionalidades

- Ingreso de datos: nombre, edad, sexo, peso, altura.
- Cálculo del IMC (Índice de Masa Corporal).
- Verificación de mayoría de edad (21 años).
- Visualización estructurada de los resultados en un `TreeView`.

## Lógica implementada

La clase `Persona` contiene:

- Atributos: `Nombre`, `Edad`, `Sexo`, `Peso`, `Altura`.
- Método `CalcularIMC()`:
  - Retorna:
    - `-1` si el IMC < 20 → Bajo peso.
    - `0` si el IMC entre 20 y 25 → Peso ideal.
    - `1` si el IMC > 25 → Sobrepeso.
- Método `EsMayorDeEdad()`:
  - Retorna `Es mayor de edad` si la edad ≥ 21.

## Uso

1. Ingresar los datos en el formulario.
2. Seleccionar el sexo.
3. Presionar el botón "Cargar".
4. Ver los resultados en el `TreeView`.

## Autor

Gerson Andrade — Proyecto educativo y profesional para el portfolio.
