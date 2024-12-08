public class Cuadrado {
    private double Lado;


/// <summary>
/// Constructor de la clase cuadrado
/// </summary>
/// <param name="_lado"></param>
/// <param name=""></param>
    public Cuadrado(double _lado){
        Lado = _lado;
    }

/// <summary>
/// Función para calcular el area de un cuadrado
/// </summary>
/// <returns> Retorna un valor double</returns>
    public double Area_Cuadrado(){
        return Lado * Lado;
    }

/// <summary>
/// Función para calcular el perimetro del cuadrado
/// </summary>
/// <returns> Retorna un valor double</returns>
    public double Perimetro_Cuadrado(){
        return Lado + Lado + Lado + Lado;
    }

}        