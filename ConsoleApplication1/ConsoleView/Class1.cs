namespace ConsoleView
{
    class Class1
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.Nome = "Godofredo"; //set
            a.Matricula = 123; //set


            console.writeline("Aluno: " + a.Nome); //get

            ConsoleView.readkey();
        }
    }
}
