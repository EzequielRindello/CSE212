public static class MysteryStack1
{
    public static string Run(string text)
    {
        // crea un stack 
        var stack = new Stack<char>();
        // por cada letra en el texto recibido en la funcion se agrega al stack, la palabra queda igual.
        // por ejemplo: "Hola" agrega cada letra: (H, o, l, a)
        foreach (var letter in text)
            stack.Push(letter);

        // inicializa una variable para el resultado
        var result = "";
        // este loop lo que hace es recorrer el largo de la texto y agregar el Pop() index a el resultado
        // es decir: H o l a -> saca la a y lo agrega a result
        //           H o l   -> saca la l y lo agrega a result
        //           H o     -> saca la o y lo agrega a result
        //           H       -> saca la H y lo agrega a result
        while (stack.Count > 0)
            result += stack.Pop();

        return result; // como resultado obtenemos el texto invertido: aloH
    }
}