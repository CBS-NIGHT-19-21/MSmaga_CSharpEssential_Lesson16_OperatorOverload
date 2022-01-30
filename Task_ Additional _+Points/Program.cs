namespace Task_Additional_Points
{
    class Program
    {
        static void Main()
        {
            #region Задание Дополнительное
            // Используя Visual Studio, создайте проект по шаблону Console Application.
            // Создайте структуру описывающую точку в трехмерной системе координат.
            // Организуйте возможность сложения двух точек, через использование
            // перегрузки оператора +.
            #endregion
            Point[] arrPoints = new Point[6];

            arrPoints[0] = new Point(1, 2, 3);
            arrPoints[1] = new Point(13, 19, 1319);

            arrPoints[2] = arrPoints[0] + arrPoints[1];
            arrPoints[3] = arrPoints[0] - arrPoints[1];
            arrPoints[4] = arrPoints[0] * arrPoints[1];
            arrPoints[5] = arrPoints[0] / arrPoints[1];

            for (int i = 0; i < arrPoints.Length; i++)
            {
                Console.WriteLine($"Point [{i}]:\tX = {arrPoints[i].X:F2}" +
                                  $"\tY = {arrPoints[i].Y:F2}\tZ = {arrPoints[i].Z:F2}");
            }

            // Delay
            Console.ReadLine();
        }
    }
}

