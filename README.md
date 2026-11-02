# Práctica TDD: Máquina de Café ☕

Este repositorio contiene la solución al proyecto de la **Máquina de Café** desarrollado bajo la metodología de **Desarrollo Guiado por Pruebas (TDD)** en C# utilizando **xUnit**.

---

## 📋 Descripción del Proyecto
El objetivo de esta práctica es construir un sistema de dispensador de café aplicando rigurosamente el ciclo de TDD (**Rojo, Verde, Refactorizar**), garantizando que cada línea de código de producción esté respaldada por una prueba unitaria previa.

### Criterios de aceptación implementados:
* **Selección de tamaños de vaso:** Pequeño (3 Oz), Mediano (5 Oz) y Grande (7 Oz).
* **Control de azúcar:** Selección personalizada de cucharadas de azúcar.
* **Validación de recursos (Casos límite):** Verificación y mensajes de error en caso de que escaseen los vasos, el café o el azúcar.
* **Actualización de inventario:** Descuento automático y preciso de los insumos tras cada dispensación exitosa.

---

## 🏗️ Estructura de la Solución
La solución se encuentra dividida en dos proyectos principales:

1. **`MaquinaCafe` (Biblioteca de clases / Producción):**
   * `CoffeeMachine`: Lógica central que coordina las interacciones.
   * `CoffeeMaker`: Administra la cantidad de café disponible y los suministros.
   * `Glasses`: Controla el stock y tipo de recipientes.
   * `SugarBowl`: Gestiona el inventario del azucarero.

2. **`MaquinaCafeTest` (Proyecto de Pruebas Unitarias):**
   * Implementado con **xUnit**.
   * Sigue el patrón **AAA (Arrange, Act, Assert)** para garantizar pruebas independientes y repetibles.

---

## 🚀 Cómo ejecutar las pruebas
1. Abre el archivo de solución (`.sln`) en **Visual Studio**.
2. Ve al menú superior y selecciona **Prueba > Explorador de pruebas** (Test Explorer).
3. Haz clic en **Ejecutar todas** (o utiliza el atajo `Ctrl + R, A`) para comprobar que todas las pruebas se encuentren en **verde**.

---

Autor: `Joel Alberto Benitez Varela
Practica con fines educativos - Trabajo realizado como asignación de la asignatura de Ingenieria de Software del Instituto Tecnológico de las Américas ITLA
