# Uninitialized Property vs. Uninitialized Local Variable in C#

This repository demonstrates a common, yet subtle, difference in C# concerning the handling of uninitialized properties versus uninitialized local variables.  Uninitialized local variables will always result in a compile-time error. However, uninitialized properties will return their default values without explicit error, which might lead to unexpected behavior in certain scenarios.

## Bug Description
The `Bug.cs` file shows an example where accessing an uninitialized property (`MyProperty`) does not generate an error; it simply returns the default value for the type (0 in this case).  In contrast, trying to access an uninitialized local variable (`uninitializedVariable` - commented out) would cause a compile-time error.

## Bug Solution
The `BugSolution.cs` file shows a better way to handle this situation by ensuring that properties are initialized either in the constructor, or wherever the property is declared. This prevents any unforeseen consequences of default values.