# C# Runtime Error: Accessing a Non-Existent Property

This repository demonstrates a common runtime error in C#: attempting to access a property that does not exist within a class.  The `bug.cs` file contains code that will throw a `System.Runtime.InteropServices.COMException` when executed. The `bugSolution.cs` file provides a corrected version.

## Bug Description

The `MyMethod()` function in `bug.cs` attempts to read the value of a property named `NonExistentProperty`.  Since this property is not defined in `ExampleClass`, the program throws a runtime exception when this line is reached.  This type of error can be difficult to track down, especially in larger projects.

## Solution

The solution involves careful code review and ensuring that all properties accessed are correctly defined. In larger projects, static analysis tools can help identify potential issues such as this.

## How to reproduce

1. Clone this repository.
2. Compile and run `bug.cs`. Observe the runtime exception.
3. Compile and run `bugSolution.cs`. Observe that it runs without errors.