using System;
class Surgeon : MedicalWorker
{
    //собственные свойства дочернего класса
    public string QualificationCategory { get; set; }
    public int OperationsPerformed { get; set; }

    public Surgeon()
    {
        Position = "Хирург";
    }
    //переопределение виртуальных методов
    public override void PerformProcedure()
    {
        Console.WriteLine($"{Position} {FullName} проводит операцию");
        Console.WriteLine($"Квалификация: {QualificationCategory}");
        Console.WriteLine($"Опыт: {OperationsPerformed} операций");
    }

    public override void ConductsInspection()
    {
        Console.WriteLine($"{Position} {FullName} проводит предоперационный осмотр");
        Console.WriteLine("Оценивает показания к операции");
        Console.WriteLine("Проверяет результаты обследований");
    }

    //сокрытие методов из родителя
    public new void MeasureVitals()
    {
        Console.WriteLine($"{Position} {FullName} измеряет показатели перед операцией:");
        Console.WriteLine("- Артериальное давление (оценка риска наркоза)");
        Console.WriteLine("- Частоту сердечных сокращений");
        Console.WriteLine("- Сатурацию кислорода");
        Console.WriteLine("- Коагулограмму (свертываемость крови)");
    }

    public new void TakeBiomaterial()
    {
        Console.WriteLine($"{Position} {FullName} берет биоматериал для диагностики:");
        Console.WriteLine("- Выполняет биопсию тканей");
        Console.WriteLine("- Берет содержимое абсцессов");
        Console.WriteLine("- Отправляет материал на гистологическое исследование");
    }
}

