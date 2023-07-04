namespace test_app.task_2_reflection
{
    public class InstanceService
    {
        public static IEnumerable<T> GetInstances<T>()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where
                (
                    t => typeof(T).IsAssignableFrom(t)
                        && !t.IsAbstract
                )
                .Select(t => {
                    if (t.Name == "Car")
                    {
                        return (T)Activator.CreateInstance(t, "Car", 150);
                    }
                    else if (t.Name == "Motorcycle")
                    {
                        return (T)Activator.CreateInstance(t, "Motorcycle", 210);
                    }
                    else if (t.Name == "AaaPlane")
                    {
                        return (T)Activator.CreateInstance(t, "AaaPlane", 700);
                    }
                    else
                    {
                        return (T)Activator.CreateInstance(t, "Bicycle", 280);
                    }
                })
                .ToArray();
        }
    }
}
