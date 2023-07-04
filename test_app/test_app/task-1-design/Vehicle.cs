namespace test_app.task_1_design
{
    public abstract class Vehicle
    {
        public string Type { get; }
        public int MaxSpeed { get; }

        public Vehicle(string type, int maxSpeed)
        {
            Type = type;
            MaxSpeed = maxSpeed;
        }
    }
}
