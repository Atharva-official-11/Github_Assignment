using Task2.Model;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Events events = new Events();

            events.RegisterForWDWorkshop(1684, new Student("A", "BE"));
            events.RegisterForWDWorkshop(1685, new Student("B", "BE")); 
            events.RegisterForWDWorkshop(1686, new Student("C", "BE"));
            events.RegisterForWDWorkshop(1685, new Student("D", "BE"));
            events.RegisterForWDWorkshop(1687, new Student("E", "BE"));

            events.DisplayStudentListOfWDWorkshop();

            events.RegisterForUIUXWorkshop(1685, new Student("F", "BE"));
            events.RegisterForUIUXWorkshop(1684, new Student("G", "BE"));
            events.RegisterForUIUXWorkshop(1685, new Student("H", "BE"));
            events.RegisterForUIUXWorkshop(1686, new Student("I", "BE"));
            events.RegisterForUIUXWorkshop(1687, new Student("J", "BE"));

            events.DisplayStudentListOfUIUXWorkshop();


            events.RegisterForRoboticsAutomationWorkshop(1687, new Student("K", "BE"));
            events.RegisterForRoboticsAutomationWorkshop(1684, new Student("L", "BE"));
            events.RegisterForRoboticsAutomationWorkshop(1685, new Student("M", "BE"));
            events.RegisterForRoboticsAutomationWorkshop(1686, new Student("N", "BE"));
            events.RegisterForRoboticsAutomationWorkshop(1685, new Student("Q", "BE"));

            events.DisplayStudentListOfRoboticsAutomationWorkshop();

        }
    }
}
