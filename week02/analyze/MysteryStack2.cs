public static class MysteryStack2
{
    private static bool IsFloat(string text)
    {// funcion que determina si una string puede ser pasado a float
        return float.TryParse(text, out _);
    }

    public static float Run(string text)
    {
        // crea un stack y lo guarda en una variable
        var stack = new Stack<float>();
        // la condicion del for lo que es hace es separar el texto recibido por argumento
        // y convertirlo en un array, usa el parametro recibido, en este caso un espacio
        // y separa en base a eso
        // es decir: si el texto fuera "No entiendo nada" qudaria como
        // ["No", "entiendo", "nada"]
        foreach (var item in text.Split(' '))
        {
            // revisa cada parte del texto recibido con Or
            if (item == "+" || item == "-" || item == "*" || item == "/")
            {
                // si el stack tiene menos de dos numeros para operar
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1!");

                // crea dos variables y le asigna el valor del back del stack
                var op2 = stack.Pop();
                var op1 = stack.Pop();
                // crea la variable que guarda el resultado de la operacion
                float res;
                if (item == "+")
                {
                    res = op1 + op2;
                }
                else if (item == "-")
                {
                    res = op1 - op2;
                }
                else if (item == "*")
                {
                    res = op1 * op2;
                }
                else
                {
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!");

                    res = op1 / op2;
                }
                // guarda el resultado en el stack
                stack.Push(res);
            }
            else if (IsFloat(item)) // si no es una operacion simplemente lo guarda
            {
                stack.Push(float.Parse(item));
            }
            else if (item == "")// si esta vacio simplemente no hace nada
            {
            }
            else
            {//maneja inputs no validos
                throw new ApplicationException("Invalid Case 3!");
            }
        }

        if (stack.Count != 1)// verifica que quede solo un numero como resultado final
            throw new ApplicationException("Invalid Case 4!");

        return stack.Pop();// retorna el stack
    }
}