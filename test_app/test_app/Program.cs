// See https://aka.ms/new-console-template for more information
using test_app.task_1_design;
using test_app.task_2_reflection;

foreach (var item in InstanceService.GetInstances<Vehicle>())
{
    Console.WriteLine($"Type - {item.Type}, MaxSpeed - {item.MaxSpeed}");
}

Write();

void Write()
{
    string info = "";
    foreach (var item in InstanceService.GetInstances<Vehicle>())
    {
        info = $"Type - {item.Type}, MaxSpeed - {item.MaxSpeed}" + "\n";
    }

    using (StreamWriter writer = new StreamWriter(
            $"{Path.Combine(Directory.GetCurrentDirectory(), "\\info.txt")}"))
        writer.WriteLine(info);
}
