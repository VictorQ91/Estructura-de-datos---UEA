// See https://aka.ms/new-console-template for more information
Console.WriteLine("Universidad Estatal Amazonica");
Console.WriteLine("Tarea Semana 2 - Figuras Geometricas");
Console.WriteLine("Nombre: Victor Quiroz Quimis");

Rectangulo figura1 = new Rectangulo(2,3);
Console.WriteLine("El area del rectangulo es: " + figura1.Area_Rectangulo());
Console.WriteLine("El perimetro del rectangulo es: " + figura1.Perimetro_Rectangulo());

Cuadrado figura2 = new Cuadrado(3);
Console.WriteLine("El area del cuadrado es:" + figura2.Area_Cuadrado());
Console.WriteLine("El perimetro del cuadrado es:" + figura2.Perimetro_Cuadrado());