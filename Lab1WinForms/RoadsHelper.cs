using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1WinForms
{
    class RoadsHelper
    {
        private List<List<List<int>>> roads; //Пути разных ветвей
        private List<List<List<int>>> knots; //Матрицы различных узлов
        private List<float> weights; //Веса узлов
        private List<List<int>> const_matrix;


        public void Clear()
        {
            roads.Clear();
            knots.Clear();
            weights.Clear();
            const_matrix.Clear();
        }
        public RoadsHelper(List<List<int>> matrix)
        {
            roads = new List<List<List<int>>>();
            knots = new List<List<List<int>>>();
            weights = new List<float>();
            const_matrix = new Methods().clone_matix(matrix);
        }

        public void addRoad(List<List<int>> road)
        {
            roads.Add(road);
        }
        public void addKnot(List<List<int>> matrix)
        {
            knots.Add(matrix);
        }
        public void addWeight(float weight)
        {
            weights.Add(weight);
        }

        public void AddRoKnWe(float weight, List<List<int>> matrix, List<List<int>> road)
        {
            addKnot(matrix);
            addRoad(road);
            addWeight(weight);
        }

        //Индекс лучшей матрицы на данный момент
        public int getIndBestWeight()
        {
            float max_item = weights.Min();
            return weights.FindLastIndex(x => x == max_item);
        }
        //Получение матрицы и пути
        public void getMatrixAndRoad(int index, ref List<List<int>> matrix, ref List<List<int>> road)
        {
            matrix = knots[index];
            road = roads[index];

            ////Забываем про этот узел, в него больше не вернемся
            knots.RemoveAt(index);
            roads.RemoveAt(index);
            weights.RemoveAt(index);
            //weights[index] = float.MaxValue;
        }
        //Получение лучшей матрицы и дороги 
        public float getBestMatrixAndRoad(ref List<List<int>> matrix, ref List<List<int>> road)
        {
            int index = getIndBestWeight();
            float best_weight = weights[index];
            getMatrixAndRoad(index, ref matrix, ref road);
            return best_weight;
        }

    }
}
