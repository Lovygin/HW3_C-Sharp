//Find_distance_between_two_points_with_given_coordinates_in_3D_plane (3 coordinates for 1 points). Вычислить дистанцию между 2-мя точками с заданными координатами в 3D пространстве (3 координаты на 1 точку).
//Formula: sqrt((x1 - x2)^2 +(y1 - y2)^2)//sqrt - корень квадратный выражения
//double s = Math.Sqrt(...);
Console.Clear();
Console.WriteLine("Enter values x and y for the point 'A' one by one");
double xA = double.Parse(Console.ReadLine());
double yA = double.Parse(Console.ReadLine());
double zA = double.Parse(Console.ReadLine());

Console.WriteLine("Enter values x and y for the point 'B' one by one");
double xB = double.Parse(Console.ReadLine());
double yB = double.Parse(Console.ReadLine());
double zB = double.Parse(Console.ReadLine());

double distans = Math.Round(Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2)), 2);
Console.WriteLine("Distance between two points: " + distans);