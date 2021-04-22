using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;

            Position viceFinanPosition = new Position();
            viceFinanPosition.Name = "Vicerector Financiero";
            viceFinanPosition.Salary = 750;

            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;

            Position jefeFinanPosition = new Position();
            jefeFinanPosition.Name = "Jefe financiero";
            jefeFinanPosition.Salary = 610;

            Position secFinan1Position = new Position();
            secFinan1Position.Name = "Secretaria financiera 1";
            secFinan1Position.Salary = 350;

            Position secFinan2Position = new Position();
            secFinan2Position.Name = "Secretaria financiera 2";
            secFinan2Position.Salary = 310;

            Position viceAcadPosition = new Position();
            viceAcadPosition.Name = "Vicerector academico";
            viceAcadPosition.Salary = 780;

            Position jefeRegistroPosition = new Position();
            jefeRegistroPosition.Name = "Jefe registro";
            jefeRegistroPosition.Salary = 640;

            Position secRegistro2Position = new Position();
            secRegistro2Position.Name = "Secretaria registro 2";
            secRegistro2Position.Salary = 360;

            Position secRegistro1Position = new Position();
            secRegistro1Position.Name = "Secretaria registro 1";
            secRegistro1Position.Salary = 400;

            Position asistente2Position = new Position();
            asistente2Position.Name = "Asistente 2";
            asistente2Position.Salary = 170;

            Position asistente1Position = new Position();
            asistente1Position.Name = "Asistente 1";
            asistente1Position.Salary = 250;

            Position mensajeroPosition = new Position();
            mensajeroPosition.Name = "Mensajero";
            mensajeroPosition.Salary = 90;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, viceFinanPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, viceFinanPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFinan1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFinan2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinanPosition, viceFinanPosition.Name);
            universityTree.CreatePosition(universityTree.Root, viceAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegistroPosition, viceAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secRegistro2Position, jefeRegistroPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secRegistro1Position, jefeRegistroPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asistente2Position, secRegistro1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asistente2Position.Name);
            universityTree.CreatePosition(universityTree.Root, asistente1Position, secRegistro1Position.Name);
            





            universityTree.PrintTree(universityTree.Root);

            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total salaries: { totalSalary}");

            Console.ReadLine();
        }
    }
}
