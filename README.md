# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property that hasn't been initialized.  The example shows how this can lead to unexpected behavior and potential runtime errors.

## The Bug
The `bug.cs` file contains a class `ExampleClass` with a property `MyProperty` that is not initialized. The `MyMethod` attempts to use this property, potentially resulting in an unpredictable outcome.

## The Solution
The `bugSolution.cs` file provides a corrected version.  `MyProperty` is now initialized with a default value (0 in this case).  This prevents any issues from uninitialized property access.

## How to reproduce
1. Clone this repository.
2. Open `bug.cs` in your C# IDE (Visual Studio, Rider, etc.).
3. Compile and run the code.  Observe the potential unexpected behavior (the value of `value` will be unpredictable)
4. Open `bugSolution.cs` and repeat steps 2 and 3.  Observe that the issue is resolved and a predictable value is produced.
