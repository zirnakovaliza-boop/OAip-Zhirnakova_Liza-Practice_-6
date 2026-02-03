using System;

class Program
{
    static void Main(string[] args)
    {
        Surgeon surgeon = new Surgeon();
        surgeon.FullName = "Иванов Алексей Сергеевич";
        surgeon.Phone = "+7-999-123-45-67";
        surgeon.Email = "surgeon@hospital.ru";
        surgeon.QualificationCategory = "высшая";
        surgeon.OperationsPerformed = 250;

        Console.WriteLine($"ФИО: {surgeon.FullName}");
        Console.WriteLine($"Должность: {surgeon.Position}");
        Console.WriteLine($"Телефон: {surgeon.Phone}");
        Console.WriteLine($"Email: {surgeon.Email}");
        Console.WriteLine($"Категория: {surgeon.QualificationCategory}");
        Console.WriteLine($"Проведено операций: {surgeon.OperationsPerformed}");

     
        Console.WriteLine("\n1. Собственные методы (унаследованные):");
        surgeon.CreateReport();
        surgeon.ProvideAssistance();


        Console.WriteLine("\n2. Переопределенные методы (override):");
        surgeon.PerformProcedure();
        surgeon.ConductsInspection();

        Console.WriteLine("\n3. Скрытые методы (new):");
        surgeon.MeasureVitals();
        surgeon.TakeBiomaterial();

        MedicalWorker worker = surgeon; 

        Console.WriteLine("\nПри вызове через базовый класс MedicalWorker:");
        worker.PerformProcedure();      
        worker.ConductsInspection();    

        Console.WriteLine("\nПри вызове скрытых методов через базовый класс:");
        worker.MeasureVitals();        
        worker.TakeBiomaterial();      
    }
}
