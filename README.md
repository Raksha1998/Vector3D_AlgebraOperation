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

1. Do you implement the 3D vector as a class or as a struct?
I decided to implement the 3D vector as struct.
As per my knowledge-
Struct is more suitable for simple computation, and given task also invloves simple algebra operations, I preferred struct.
And it is typically more efficient in terms of memory usage and can be faster, reduces garbage collection.
Class would have also been great choice to go with, and I am already familiar with class and wanted to explore more on struct, I decided struct.

2.Should a vector be immutable after it has been constructed or should it be possible to change the
value of the components afterwards?
An immutable vector can be safer in this case since, 
Every method and operation has a new resulting vector, its components need not to be updated frequently.
And also to prevent accidental modification of the vector's components which may lead inaccurate resulting vector.

3.How do check if two vectors are equal or unequal? Do you overload the operators for equality and inequality or not?
I used operator overload to check equality and inequality of vector.

4.How do you compute the hashcode of a vector?
Using the below code we can compute hashcode of vector-
//Conside x,y,z as ddouble precision floating datatype
public class Vector3D {
    public double x;
    public double y;
    public double z;
public override int GetHashCode() {
        int hash = 17;
        hash = hash * 23 + x.GetHashCode();
        hash = hash * 23 + y.GetHashCode();
        hash = hash * 23 + z.GetHashCode();
        return hash;
    }

