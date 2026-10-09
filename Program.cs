Console.WriteLine("Enter first exam grade1: ");
int grade1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second exam grade2: ");
int grade2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third exam grade3: ");
int grade3 = int.Parse(Console.ReadLine());
int sum = grade1 + grade2 + grade3;
double average = sum / 3.0;
bool isPassing = average >= 60;

Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average:F2}");
Console.WriteLine($"Is the average >= 60? {isPassing}");
