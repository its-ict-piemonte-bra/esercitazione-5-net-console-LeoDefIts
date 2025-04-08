using System.Data;

namespace lesson
{
    /// <summary>
    /// defines a point in a 2d space.
    /// </summary>
    struct Point2D
    {
        /// <summary>
        /// the X coordinate of the point
        /// </summary>
        public int x;
        /// <summary>
        /// the Y coordinate of the point
        /// </summary>
        public int y;
    };
    struct Point3D
    {
        /// <summary>
        /// the X coordinate of the point
        /// </summary>
        public int x;
        /// <summary>
        /// the Y coordinate of the point
        /// </summary>
        public int y;
        /// <summary>
        /// the Z coordinate of the point
        /// </summary>
        public int z;
    };
    struct UserIdentity
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            LessonInformation();

            Console.WriteLine();

            Console.WriteLine("E ora gli esercizi: ");
            Console.WriteLine("Esercizio 1:");
            Exercise3();
        }
        private static void Exercise1()
        {
            bool errore;
            int x = -1, y = -1;
            do
            {
                errore = false;
                // controlliamo se l'utente inserisce realmente dei numeri
                try
                {
                    Console.WriteLine("inserisci la coordinata x: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("inserisci la coordinata y: ");
                    y = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    errore = true;
                    Console.WriteLine("cordinata non vallida");
                    return;
                }
            }
            while (errore);

            try
            {
                // il try nel caso emtta dei numeri negativi (che vanno bene in questo caso)
                Point2D point2D = Create2DPoint(x, y);
                Console.WriteLine($"point2d.x = {point2D.x} - point2d = {point2D.y}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Exercise2()
        {
            bool errore;
            int x = -1, y = -1, z = -1;
            do
            {
                errore = false;
                // controlliamo se l'utente inserisce realmente dei numeri
                try
                {
                    Console.WriteLine("inserisci la coordinata x: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("inserisci la coordinata y: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("inserisci la coordinata x: ");
                    z = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    errore = true;
                    Console.WriteLine("cordinata non vallida");
                    return;
                }
            }
            while (errore);

            try
            {
                // il try nel caso emtta dei numeri negativi (che vanno bene in questo caso)
                Point3D point3D = Create3DPoint(x, y, z);
                Console.WriteLine($"point3d.x = {point3D.x} - point3d = {point3D.y} - point3d = {point3D.z}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        ///  prints information about a user identity
        /// </summary>
        private static void Exercise3()
        {
            bool errore;
            string firstName = "", lastName = "", birthday = "";

            Console.WriteLine("inserisci nome");
            firstName = Console.ReadLine();
            Console.WriteLine("inserisci lcognome");
            lastName = Console.ReadLine();
            Console.WriteLine("inserisci data di anscita");
            birthday = Console.ReadLine();

            do
            {
                errore = false;
                // controlliamo se l'utente inserisce realmente dei numeri
                try
                {
                    Console.WriteLine("inserisci i tuoi social credits");
                    socialCredits = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException)
                {
                    errore = true;
                    Console.WriteLine("non e' un numero");
                    return;
                }
            }
            while (errore);

            UserIdentity identity = new UserIdentity(); 

        }
        /// <summary>
        /// contains the informations regarding today
        /// </summary>
        private static void LessonInformation()
        {
            Console.WriteLine(@"Il tipo di dato 'struct'
            
            Fra i tipi derivati esistono anceh i cosiddetti 
            'tipi di dato non omogenei'. Essi sono costruiti da campi di tipo 
            potenzialmente diverso, ognuno caratterizato da nome e un valore

            Riempiendo in questa categoria i tipi di 'struct' e 'class' 
            
            In questo programma ci sono 2 esempi di definizione  della struct:
            -Point2D
            -Point3D

            Inializzo una variabile con la parola chiave 'new'");

            Point2D point = new Point2D();

            Console.WriteLine("Assegnamo dei falori ai campi usando il punto (.)");

            point.x = 0;
            point.y = 1;

            Console.WriteLine($"point.x = {point.x}, point.y = {point.y}");
            Console.WriteLine();

            Console.WriteLine(@"Tutti i valori non inizializati hanno automaticamente lo 
            zoro-value");
            Point3D point3d = new Point3D();

            Console.WriteLine($"point3d.x = {point3d.x}, point3d.y = {point3d.y},  point3d.z = {point3d.z}");
        }


        private static Point2D Create2DPoint(int x, int y)
        {
            if (x <= 0)
            {
                throw new ArgumentException($"Coordinata X errata: {x} non e' maggiore di 0");
            }
            if (y <= 0)
            {
                throw new ArgumentException($"Coordinata Y errata: {y} non e' maggiore di 0");
            }
            // creiamo 
            Point2D point2d = new Point2D();
            point2d.x = x;
            point2d.y = y;

            return point2d;
        }
        private static Point3D Create3DPoint(int x, int y, int z)
        {
            if (x <= 0)
            {
                throw new ArgumentException($"Coordinata X errata: {x} non e' maggiore di 0");
            }
            if (y <= 0)
            {
                throw new ArgumentException($"Coordinata Y errata: {y} non e' maggiore di 0");
            }
            if (z <= 0)
            {
                throw new ArgumentException($"Coordinata X errata: {z} non e' maggiore di 0");
            }
            // creiamo 
            Point3D point3d = new Point3D();
            point3d.x = x;
            point3d.y = y;
            point3d.z = z;

            return point3d;
        }
    }
}
