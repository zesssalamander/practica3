using System;
using System.Collections;

namespace alumno
{
class practica3
{
public string nombre, codigo,indice;
public int opc;
public static void Main (string[] args)
{

practica3 pra = new practica3 ();

Hashtable tabla = new Hashtable ();



do {
Console.WriteLine("ingrese codigo");
pra.codigo = Console.ReadLine();
Console.WriteLine("ingrese nombre");
pra.nombre = Console.ReadLine();
tabla.Add(pra.codigo,pra.nombre);

Console.WriteLine("1 ingresar mas valores");
Console.WriteLine("2 editar valores");
Console.WriteLine("3  valores");
Console.WriteLine("4 delete valores");
Console.WriteLine("5 exit");
pra.opc =int.Parse (Console.ReadLine());
switch(pra.opc)
{
case 1:
break;
case 2:
Console.WriteLine("ingrese codigo a editar");
pra.indice=Console.ReadLine();
tabla.Remove(pra.indice);

Console.WriteLine("ingrese nuevo codigo");
pra.codigo = Console.ReadLine();
Console.WriteLine("ingrese nombre");
pra.nombre = Console.ReadLine();
tabla.Add(pra.codigo,pra.nombre);

break;
case 3:

Console.WriteLine("ingrese codigo");
pra.indice=Console.ReadLine();
object valor = tabla [pra.indice];
Console.WriteLine ("el nombre es : "+valor);


break;
case 4:
Console.WriteLine("ingrese codigo a remover");
pra.indice=Console.ReadLine();
tabla.Remove(pra.indice);


break;

}


}while (pra.opc!=5);

}
}
}