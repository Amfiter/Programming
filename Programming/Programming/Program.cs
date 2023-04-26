using Programming.Models.Classes;

namespace Programming
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration

            Models.Classes.Rectangle rec1 = new Models.Classes.Rectangle(12,23,"Orange");
            Models.Classes.Rectangle rec2 = new Models.Classes.Rectangle(22, 12, "Orange");
            Ring rin1 = new Ring(1.0,50.4 ,new Point2D(500,500));
            Ring rin2 = new Ring(1.0, 2, new Point2D(20, 10));

            var checkCollisionRectangle =  CollisionManager.IsCollision(rec1, rec2);
            var chechCollisionRing = CollisionManager.IsCollision(rin1,rin2);

            Console.WriteLine(checkCollisionRectangle);
            Console.WriteLine(chechCollisionRing);

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
            
        }
    }
}