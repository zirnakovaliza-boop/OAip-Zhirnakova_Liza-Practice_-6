using System;

class MedicalWorker
{
    //свойства родительского класса
    public string FullName { get; set; }
    public string Position { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    //собственные методы
    public void CreateReport()
    {
        Console.WriteLine($"{Position} {FullName} составляет отчет");
    }

    public void ProvideAssistance()
    {
        Console.WriteLine($"{Position} оказывает первую помощь");
    }

    //виртуальные методы
    public virtual void PerformProcedure()
    {
        Console.WriteLine($"{Position} выполняет общую медицинскую процедуру");
    }

    //Методы сокрытые в наследнике
    public virtual void ConductsInspection()
    {
        Console.WriteLine($"{Position} проводит общий осмотр пациента");
    }

    public void MeasureVitals()
    {
        Console.WriteLine($"{Position} измеряет основные показатели: давление, пульс, температуру");
    }

    public void TakeBiomaterial()
    {
        Console.WriteLine($"{Position} берет стандартные анализы: кровь, мочу");
    }
}

