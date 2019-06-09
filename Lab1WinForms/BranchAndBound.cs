using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1WinForms
{
    class BranchAndBound
    {
        Methods help;
        static int port = 14444;
        const int MAXVALUE = int.MaxValue - 100001;

        public BranchAndBound()
        {
            help = new Methods();
        }
        public TimeSpan searchRoadTest(List<List<int>> original, List<List<int>> matrix)
        {
            RoadsHelper roadsHelper = new RoadsHelper(original);
            List<List<int>> road = new List<List<int>>();
            DateTime timer2 = DateTime.Now;
            float H = 0;
            List<int> min_elements_row = help.get_min_in_row(matrix); //Найдем в каждой строке минимальное значение
            H += help.get_min_in_row(matrix).Where(x => x != float.MaxValue).Sum();
            help.sub_row(matrix, min_elements_row); //Произведем редукцию строк
            List<int> min_elements_col = help.get_min_in_col(matrix);//найдем минимальное значение в каждом столбце
            H += help.get_min_in_col(matrix).Where(x => x != float.MaxValue).Sum();
            help.sub_col(matrix, min_elements_col); //Произведем редукцию столбцов

            #region Главный алгоритм
            while (true)
            {
                if (min_elements_col.All(x => x == int.MaxValue) &&
                    min_elements_row.All(x => x == int.MaxValue))
                    break;
                float weight;
                List<int> coordinate = help.calc_ratings(matrix);//Найдем среди вычисленных оценок нулевых 
                                                                 //клеток координату клетки с наивысшей оценкой:
                help.loop_removal(ref matrix, road); //Удаляем петли
                //Исключаем узел
                List<List<int>> temp = help.clone_matix(matrix);
                temp[coordinate[0]][coordinate[1]] = int.MaxValue;

                min_elements_row = help.get_min_in_row(temp); //Найдем в каждой строке минимальное значение
                weight = H + help.get_min_in_row(temp).Where(x => x != int.MaxValue).Sum();
                help.sub_row(temp, min_elements_row); //Произведем редукцию строк
                min_elements_col = help.get_min_in_col(temp);//найдем минимальное значение в каждом столбце
                weight += help.get_min_in_col(temp).Where(x => x != int.MaxValue).Sum();
                help.sub_col(temp, min_elements_col); //Произведем редукцию столбцов
                roadsHelper.AddRoKnWe(weight, help.clone_matix(temp), help.clone_matix(road)); //Запоминаем узел

                //Берем узел

                road.Add(new List<int>() { coordinate[0] + 1, coordinate[1] + 1 }); //Добавляем ветку(дорогу)
                help.fill_matrix(matrix, coordinate[0], coordinate[1]);
                matrix[coordinate[1]][coordinate[0]] = int.MaxValue;
                //print_matrix(matrix);
                help.loop_removal(ref matrix, road); //Удаляем петли

                min_elements_row = help.get_min_in_row(matrix); //Найдем в каждой строке минимальное значение
                weight = H + min_elements_row.Where(x => x != int.MaxValue).Sum();
                help.sub_row(matrix, min_elements_row); //Произведем редукцию строк
                min_elements_col = help.get_min_in_col(matrix);//найдем минимальное значение в каждом столбце
                weight += min_elements_col.Where(x => x != int.MaxValue).Sum();
                help.sub_col(matrix, min_elements_col); //Произведем редукцию столбцов
                roadsHelper.AddRoKnWe(weight, help.clone_matix(matrix), help.clone_matix(road));//Запоминаем узел
                //Возвращяем лучший узел
                road.Clear();
                matrix.Clear();
                H = roadsHelper.getBestMatrixAndRoad(ref matrix, ref road);

            }
            #endregion
            var time2 = DateTime.Now - timer2;
            return time2;
        }
        public TimeSpan searchRoadMain(List<List<int>> coordinates, Func<Image, int> setImage, int Width, int Height, ref bool run)
        {
            DateTime timer1 = DateTime.Now;

            List<List<int>> road = new List<List<int>>();
            float distance = 0;

            //File file = new File();

            List<List<int>> original = help.getWeightsRoads(coordinates);
            List<List<int>> matrix = original.Select(x => x.Select(y => y).ToList()).ToList();

            RoadsHelper roadsHelper = new RoadsHelper(original);
            
            DateTime timer2 = DateTime.Now;

            float H = 0;
            List<int> min_elements_row = help.get_min_in_row(matrix); //Найдем в каждой строке минимальное значение
            H += help.get_min_in_row(matrix).Where(x => x < MAXVALUE).Sum();
            help.sub_row(matrix, min_elements_row); //Произведем редукцию строк
            List<int> min_elements_col = help.get_min_in_col(matrix);//найдем минимальное значение в каждом столбце
            H += help.get_min_in_col(matrix).Where(x => x < MAXVALUE).Sum();
            help.sub_col(matrix, min_elements_col); //Произведем редукцию столбцов
            #region Главный алгоритм
            while (run)
            {
                if (min_elements_col.All(x => x > MAXVALUE) &&
                    min_elements_row.All(x => x > MAXVALUE))
                    break;

                List<int> coordinate = help.calc_ratings(matrix);//Найдем среди вычисленных оценок нулевых 
                                                                 //клеток координату клетки с наивысшей оценкой:
                help.loop_removal(ref matrix, road); //Удаляем петли
                //Исключаем узел
                List<List<int>> temp = help.clone_matix(matrix);
                temp[coordinate[0]][coordinate[1]] = int.MaxValue;

                min_elements_row = help.get_min_in_row(temp); //Найдем в каждой строке минимальное значение
                float weight = H + help.get_min_in_row(temp).Where(x => x < MAXVALUE).Sum();
                help.sub_row(temp, min_elements_row); //Произведем редукцию строк
                min_elements_col = help.get_min_in_col(temp);//найдем минимальное значение в каждом столбце
                weight += help.get_min_in_col(temp).Where(x => x < MAXVALUE).Sum();
                help.sub_col(temp, min_elements_col); //Произведем редукцию столбцов
                //Console.WriteLine($"Матрица после исключения ребра: ({coordinate[0] + 1},{coordinate[1] + 1}) \nВес: {weight}");
                //print_matrix(temp);
                roadsHelper.AddRoKnWe(weight, help.clone_matix(temp), help.clone_matix(road)); //Запоминаем узел

                setImage(getImageRoads(coordinates, road, Width, Height)); //Изображение
                //Application.DoEvents();
                //Thread.Sleep(10);

                //Берем узел

                road.Add(new List<int>() { coordinate[0] + 1, coordinate[1] + 1 }); //Добавляем ветку(дорогу)
                help.fill_matrix(matrix, coordinate[0], coordinate[1]);
                matrix[coordinate[1]][coordinate[0]] = int.MaxValue;
                //print_matrix(matrix);
                help.loop_removal(ref matrix, road); //Удаляем петли

                min_elements_row = help.get_min_in_row(matrix); //Найдем в каждой строке минимальное значение
                weight = H + min_elements_row.Where(x => x < MAXVALUE).Sum();
                help.sub_row(matrix, min_elements_row); //Произведем редукцию строк
                min_elements_col = help.get_min_in_col(matrix);//найдем минимальное значение в каждом столбце
                weight += min_elements_col.Where(x => x < MAXVALUE).Sum();
                help.sub_col(matrix, min_elements_col); //Произведем редукцию столбцов

                //Console.WriteLine($"Матрица после взятия ребра: ({coordinate[0] + 1},{coordinate[1] + 1}) \nВес: {weight}");
                //print_matrix(matrix);
                roadsHelper.AddRoKnWe(weight, help.clone_matix(matrix), help.clone_matix(road));//Запоминаем узел

                setImage(getImageRoads(coordinates, road, Width, Height));//Изображение
                Application.DoEvents();
                //Thread.Sleep(10);

                //Возвращяем лучший узел
                road.Clear();
                matrix.Clear();
                H = roadsHelper.getBestMatrixAndRoad(ref matrix, ref road);

            }
            roadsHelper.Clear();
            #endregion
            var time2 = DateTime.Now - timer2;

            string result = "";
            int last_city = 1;
            for (int i = 0; i < road.Count; i++)
            {
                for (int j = 0; j < road.Count; j++)
                {
                    if (road[j][0] == last_city)
                    {
                        result += $"{last_city} => ";
                        last_city = road[j][1];
                        distance += original[road[j][0] - 1][road[j][1] - 1];
                        break;
                    }
                }
            }

            result += "1";
            Console.WriteLine(result);
            Console.WriteLine($"Длина пути: {distance}");

            var time1 = DateTime.Now - timer1;
            Console.WriteLine($"\nВремя выполнения алгоритма: {time2}\n" +
                $"Полное время выполнение программы: {time1}");

            //setImage(getImage(roadsToString(road), '2'));
            //getImage(pictureBox, roadsToString(road), '2');
            setImage(getImageRoads(coordinates, road, Width, Height));
            return time2;
        }
        public Image getImageRoads(List<List<int>> coordinates, List<List<int>> roads, int Width, int Height)
        {
            Bitmap bitmap = new Bitmap(Width, Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Black, 2);
            //Точки
            for (int i = 0; i < coordinates.Count; i++)
                graphics.DrawCircle(coordinates[i][0], coordinates[i][1], 2);
            //Линии 
            foreach (var road in roads)
            {
                var coordinate1 = coordinates[road[0]-1];
                var coordinate2 = coordinates[road[1]-1];
                graphics.DrawLine(pen, coordinate1[0], coordinate1[1], coordinate2[0], coordinate2[1]);
            }
            return (Image)bitmap;
        }
        public Image getImage(object x, char numFunction = '1')
        {
            string message = $"{numFunction} {(string)x}";
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //try
            //{
            socket.Connect(ipPoint);

            byte[] data = Encoding.Unicode.GetBytes(message);
            socket.Send(data);

            data = new byte[256];
            StringBuilder stringBuilder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = socket.Receive(data, data.Length, SocketFlags.None);
                stringBuilder.Append(Encoding.UTF8.GetString(data, 0, bytes));

            } while (socket.Available > 0);
            // закрываем сокет
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            return Image.FromFile(stringBuilder.ToString());
        }
        public Image getImage(List<List<int>> coordinates, int Width, int Height)
        {

            Bitmap bitmap = new Bitmap(Width, Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Black, 1);
            for(int i = 0; i< coordinates.Count; i++)
                graphics.DrawCircle(coordinates[i][0], coordinates[i][1], 2);
            return (Image)bitmap;
        }

        public List<List<int>> GenerateData(int numberCity, int maxWidht, int maxHeight)
        {
            Random rand = new Random();
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < numberCity; i++)
            {
                var x = rand.Next(1, maxWidht);
                var y = rand.Next(1, maxHeight);
                result.Add(new List<int>() { x, y });
            }
            return result;
        }
        //public string GenerateData(int numberCity)
        //{
        //    Random rand = new Random();

        //    List<int> x = new List<int>();
        //    List<int> y = new List<int>();
        //    string result = "";
        //    for (int i = 0; i < numberCity; i++)
        //    {
        //        x.Add(rand.Next(1, 1000));
        //        y.Add(rand.Next(1, 1000));
        //        result += $"{x[i]};{y[i]}\n";
        //    }
        //    return result.Remove(result.Length - 1);
        //}

        public string roadsToString(List<List<int>> roads)
        {
            string result = "";
            foreach (var road in roads)
            {
                result += $"{road[0]};{road[1]}\n";
            }
            return result.Remove(result.Length - 1);
        }

    }
}
