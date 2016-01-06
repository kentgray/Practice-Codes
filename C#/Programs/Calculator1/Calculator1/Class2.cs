static void HandleNullReference()
{
    Program prog = null;
    try
    {
        Console.WriteLine(prog.ToString());
        38
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine(ex.Message);

    }
}
