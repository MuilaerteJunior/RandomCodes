# RandomCodes - Proof if you can

## C# Examples

- ### ExceptionAsErrorUsage

Code to test if using Exception object (or even an extended's exception object) for validation has any relevant performance issue. Some people prefered this approach for application validations.

IMO: This is a practice that I don't see good advantages, exceptions should be treated as validations (or messages) between application and developers. I prefer using simples strings or specific objects (not extending exception) for validations in general cases.

- ### Yield usage

Code to practice the yield usage. Yield using for custom filter avoid using a temporary variable to filtered values, as well, stateful usage is for operating with these filtered values.
