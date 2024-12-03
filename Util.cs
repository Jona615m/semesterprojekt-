class Util {

    public static void TypeEffect(string textInput) {
        foreach (char c in textInput)
        {
            //Det ovenfor bliver printed med et foreachloop hvor der er et delay på 100 ms mellem hvert bogstav
            Console.Write(c);
            Thread.Sleep(10); // Delay mellem hver karakter der bliver udskrevet
        }
        Console.WriteLine(); //Rykker til næste linje efter det er blevet printed 
    }

}
