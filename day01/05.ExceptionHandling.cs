namespace day01
{
    class ExceptionHandling
    {
        //01 Handling division by zero, using globa exception
        public static void TryDivByZero()
        {
            try
            {
                int a = 10;
                int b = a / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
        }

        //02 
        public static void TryCatchParse()
        {
            Console.WriteLine("Berfore Parsing");
            Console.WriteLine("Age : ");
            string? input = Console.ReadLine();

            try
            {
                int age = int.Parse(input);
                Console.WriteLine($"you are {age} years old");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex) when (input.Contains("$"))
            {
                Console.WriteLine($"{ex.Message} do not use $$");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Sukses Bestieee");
            }
        }


        //03 object
        static void SayHelloThrow(object obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            if (!(obj is string))
            {
                throw new ArgumentNullException("String expected");
            }
        }

        public static void CallSayHello()
        {
            try
            {
                Console.WriteLine("Try to execute...");
                SayHelloThrow(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"argument : {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"wrong : {ex.Message}");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
    }
}