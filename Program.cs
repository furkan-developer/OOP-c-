
// fiziksel olarak ram de oluşturulan c tipinin nesneni
A a = new C() { };
// D d = (D)a; // Run-time hata verir
D d = a as D; // d = null ataması olur.

if (d is null)
{
    System.Console.WriteLine("d is null");
}

class A { }
class B : A { }
class C : B { }
class D : C { }