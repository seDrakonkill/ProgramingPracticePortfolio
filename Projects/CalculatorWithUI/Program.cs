namespace CalculatorWithUI
{
    internal static class UICalculator
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize(); 
            Application.Run(new Form1());  //What does this do? It seems to call Form1.cs, which seems to initialize itself.
        }
    }

    internal static class Functions
    {
        static float storedVariable = 0;
        public static float Add(float var1, float var2)
        {
            storedVariable = var1 + var2;
            return 0;
        }
        public static float Subtract(float var1, float var2)
        {
            storedVariable = var1 - var2;
            return 0;
        }
        public static float Multiply(float var1, float var2)
        {
            storedVariable = var1 * var2;
            return 0;
        }
        public static float Divide(float var1, float var2)
        {
            storedVariable = var1 / var2;
            return 0;
        }
        public static float SqRoot(float var1, float var2)
        {
            storedVariable = var1;
            return 0;
        }
        public static float Log(float var1, float var2)
        {
            storedVariable = var1 + var2;
            return 0;
        }

    }
}