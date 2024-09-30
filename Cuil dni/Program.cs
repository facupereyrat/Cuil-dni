using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su CUIL (Formato: XX-XXXXXXXX-X):");
        string cuil = Console.ReadLine();

        // Validar el formato del CUIL (básicamente, que contenga los caracteres correctos)
        if (IsValidCuil(cuil))
        {
            // Extraer el DNI del CUIL
            string dni = GetDNIFromCuil(cuil);
            Console.WriteLine($"Su DNI es: {dni}");
        }
        else
        {
            Console.WriteLine("El formato del CUIL es incorrecto.");
        }
    }

    static bool IsValidCuil(string cuil)
    {
        // Comprobar si el CUIL tiene el formato correcto
        return System.Text.RegularExpressions.Regex.IsMatch(cuil, @"^\d{2}-\d{8}-\d$");
    }

    static string GetDNIFromCuil(string cuil)
    {
        // Extraer el DNI del CUIL (quitar los dos primeros dígitos y el guion)
        return cuil.Substring(3, 8);
    }
}
