# Vector3D_AlgebraOperation

Vector3D_AlgebraOperation consist three parts in a single Visual Studio project (solution).
1. Vector3D_AlgebraOperation- Implementation of a class library for the algebraic operations of 3D vectors.
2. Vector3D_AlgeOprTest- Implementation of unit test project for the class library.
3. CrossProduct_WPF_App- Implementation of a WPF desktop application that uses the class library to compute the cross product of two 3D vectors.

The project is implemented with the following constraints:
▪ Visual Studio 2022
▪ C# language
▪ .NET framework: 6.0
▪ Test framework: MS Test V2 (TestMethod)

For Task1-
The following are the reasons for my decision on the given aspects:

I decided to implement the 3D vector as struct.
As per my knowledge-
1. Struct is more suitable for simple computation, and given task also invloves simple algebra operations, I preferred struct.
And it is typically more efficient in terms of memory usage and can be faster, reduces garbage collection.
Class would have also been great choice to go with, and I am already familiar with class and wanted to explore more on struct, I decided struct.

2. An immutable vector can be safer in this case since, 
Every method and operation has a new resulting vector, its components need not to be updated frequently.
And also to prevent accidental modification of the vector's components which may lead inaccurate resulting vector.


3. I used operator overload to check equality and inequality of vector.


