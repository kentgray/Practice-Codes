static void HandleUncaughtException()
{
    Program prog = null;
    try
    {
        Console.WriteLine(prog.ToString());
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine("From ArgumentNullException: " + ex.Message);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("From ArgumentException: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("From Exception: " + ex.Message);
    }
    finally
    {
        Console.WriteLine("Finally always executes.");
    }
}