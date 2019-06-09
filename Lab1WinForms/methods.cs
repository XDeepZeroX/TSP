using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1WinForms
{
    class Methods
    {
        public Methods()
        {
            List<List<float>> test = new List<List<float>>() {
                new List<float> {float.MaxValue,0,1,6,1},
                new List<float> {2, float.MaxValue, 0,0,0},
                new List<float> {1,0, float.MaxValue, 2,2},
                new List<float> {2,0,3, float.MaxValue, 5},
                new List<float> {0,2,5,7, float.MaxValue }
            };
            #region old
            //Console.WriteLine("Test matrix:");
            //foreach (var row in test)
            //{
            //    foreach (var item in row)
            //    {
            //        Console.Write($" {item}");
            //    }
            //    Console.Write('\n');
            //}
            //Console.Write($"\nMin elements in ROW: ");
            //foreach (var item in get_min_in_row(test))
            //    Console.Write($" {item}");

            //Console.Write($"\nMin elements in COL: ");
            //foreach (var item in get_min_in_col(test))
            //    Console.Write($" {item}");

            //Console.WriteLine($"\nSub elements in ROW: ");
            //foreach (var row in sub_row(test, get_min_in_row(test)))
            //{
            //    foreach (var item in row)
            //    {
            //        Console.Write($" {item}");
            //    }
            //    Console.Write('\n');
            //}

            //Console.Write("\n\n\n\n");
            //foreach (var row in sub_col(test, new List<float> { 2, 2, 2 }))
            //{
            //    foreach (var item in row)
            //    {
            //        Console.Write($" {item}");
            //    }
            //    Console.Write('\n');
            //}
            #endregion
            
            List<List<int>> road = new List<List<int>>()
            {
                new List<int>() {1,6},
                new List<int>() {3,5},
                new List<int>() {6,2},
                new List<int>() {4,3}
            };
            List<int> coordinate = new List<int>() { 5, 4 };
            var result = does_creat_loop(coordinate, road, test.Count);
        }


        public List<int> get_min_in_row(List<List<int>> matrix)
        {
            List<int> min_items_row = new List<int>();
            foreach (var row in matrix)
            {
                min_items_row.Add(row.Min());
            }
            return min_items_row;
        }
        public List<int> get_min_in_col(List<List<int>> matrix)
        {
            List<int> min_items_col = new List<int>();
            for (int i = 0; i < matrix.Count; i++)
            {
                min_items_col.Add(matrix.Select(x => x[i]).ToList().Min());
            }
            return min_items_col;
        }

        public void sub_row(List<List<int>> matrix, List<int> row)
        {
            if (matrix.Count != row.Count)
            {
                Console.WriteLine("Кол-во строк в матрице не совпадает  с кол-вом элементов в векторе");
                return;
            }
            for (int i = 0; i < matrix.Count; i++)
            {
                if (row[i] < int.MaxValue-1000)
                    matrix[i] = matrix[i].Select(x => x - row[i]).ToList();
            }

        }
        public void sub_col(List<List<int>> matrix, List<int> col)
        {
            if (matrix[0].Count != col.Count)
            {
                Console.WriteLine("Кол-во столбцов в матрице не совпадает с кол-вом элементов в векторе");
                return;
            }
            for (int i = 0; i < col.Count; i++)
            {
                if (col[i] < int.MaxValue - 1000)
                    matrix.Select(x => { x[i] -= col[i]; return x.ToList(); }).ToList();
            }
        }

        //Вычисление оценок нулевых элементов
        public List<int> calc_ratings(List<List<int>> matrix)
        {

            List<float> ratings = new List<float>();
            List<List<int>> indexes = new List<List<int>>();
            List<float> const_row = create_list(matrix.Count, -1),
                        const_col = create_list(matrix.Count, -1);
            //Счиаем константы приведенеия
            for (int i = 0; i < matrix.Count; i++)
            {
                //
                #region Константы приведение в строках
                if (matrix[i].FindAll(x => x == 0).Count > 1)
                    const_row[i] = 0;
                else
                    const_row[i] = matrix[i].Where(x => x != 0).Min();
                #endregion
                #region Константы приведение в столбцах
                int count = matrix.Select(x => x[i]) //Кол-во 0-ых элементов в i столбце
                    .ToList()
                    .FindAll(x => x == 0).Count;
                if (count > 1)
                    const_col[i] = 0;
                else
                    const_col[i] = matrix.Select(x => x[i])
                                          .Where(x => x != 0)
                                          .Min();
                #endregion
            }
            //Находим все эелементы == 0 и считаем оценки
            for (int i = 0; i < matrix.Count; i++)
            {
                int last_index = 0, index = 0;
                while ((index = matrix[i].FindIndex(last_index, x => x == 0)) != -1)
                {
                    ratings.Add(const_row[i] + const_col[index]);
                    indexes.Add(new List<int> { i, index });
                    last_index = index + 1;
                }
            }
            //Возвращаем координаты элемента с наивысшей оценкой
            float max_value = ratings.Max();
            var bast_last_rating = ratings.FindIndex(x => x == ratings.Max()); //---------------Поменять на Last---------------

            return indexes[bast_last_rating];
        }

        //Копирование матрицы
        public List<List<float>> clone_matix(List<List<float>> matrix)
        {
            //return matrix.ToArray();
            return matrix.Select(x => x.Select(y => y).ToList()).ToList();
        }
        public List<List<int>> clone_matix(List<List<int>> matrix)
        {
            return matrix.Select(x => x.Select(y => y).ToList()).ToList();
        }
        //Создание нового List
        public List<float> create_list(int lenght, float value = 0)
        {
            List<float> result = new List<float>(lenght);
            for (int i = 0; i < lenght; i++)
                result.Add(value);
            return result;
        }

        //Удаление столбца и/или строки в матрице
        public void fill_matrix(List<List<int>> matrix, int row = int.MaxValue, int col = int.MaxValue, int value = int.MaxValue)
        {
            if (row != int.MaxValue)
                if (row < matrix[0].Count)
                    matrix[row] = matrix[row].AsParallel().Select(x => x = value).ToList();
                else
                    Console.WriteLine("Индекс строки за пределами матрицы");
            if (col != int.MaxValue)
                if (col < matrix.Count)
                    matrix = matrix.AsParallel().Select(x =>
                    {
                        x[col] = value;
                        return x.ToList();
                    }).ToList();
                else
                    Console.WriteLine("Индекс столбца за пределами матрицы");

        }

        //Удаление петель
        public void loop_removal(ref List<List<int>> matrix, List<List<int>> road)
        {
            int index_col, last_index;
            //Итерируем по элементам матрицы которые == 0
            for (int i = 0; i < matrix.Count; i++)
            {
                last_index = 0;
                while ((index_col = matrix[i].FindIndex(last_index, x => x == 0)) != -1)
                {//Нашли элемент == 0
                    last_index = index_col + 1;
                    //Проверяем, образует ли он петлю
                    if (does_creat_loop(new List<int>() { i + 1, index_col + 1 }, road, matrix.Count))
                    {
                        matrix[i][index_col] = int.MaxValue;
                    }
                }
            }
        }
        public bool does_creat_loop(List<int> coordinate, List<List<int>> road, int number_city)
        {
            int find_knot = coordinate[0],
                next_knot = coordinate[1],
                count_city = 1;

            int index_row = 0;
            while ((index_row = road.FindIndex(x => x[1] == find_knot)) != -1)
            {
                count_city += 1;
                if ((find_knot = road[index_row][0]) == next_knot)
                    if (count_city == number_city) //Если мы прошли все города и вернулись в исходный (не считается петлей)
                        return false;
                    else
                        return true;
            }
            return false;
        }



        public List<List<int>> getListCoordinaties(string data)
        {
            List<List<int>> coordinaties = new List<List<int>>();
            List<string> dataSplit = data.Split('\n').ToList();
            foreach(string coord in dataSplit)
            {
                try
                {
                    var XY = coord.Split(';');
                    coordinaties.Add(new List<int>() { int.Parse(XY[0]), int.Parse(XY[1]) });
                }catch(Exception ex) { Console.WriteLine(ex.ToString()); }
            }
            return coordinaties;
        }
        public List<List<int>> getWeightsRoads(List<List<int>> coordinaties)
        {
            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < coordinaties.Count; i++)
            {
                List<int> line = new List<int>();
                for (int j = 0; j < coordinaties.Count; j++)
                {
                    if (i == j)
                        line.Add(int.MaxValue);
                    else
                        line.Add(getWeight(coordinaties[i], coordinaties[j]));
                }
                result.Add(line);
            }
            return result;
        }
        public int getWeight(List<int> coordinate1, List<int> coordinate2)
        {
            return (int)Math.Round(Math.Sqrt(Math.Pow(coordinate2[0] - coordinate1[0], 2) +
                Math.Pow(coordinate2[1] - coordinate1[1], 2)));
        }

    }
}
