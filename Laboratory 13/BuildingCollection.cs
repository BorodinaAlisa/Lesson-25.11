using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_13
{
    internal class BuildingCollection
    {
        private Building[] buildings;
        public BuildingCollection()
        {
            buildings = new Building[10]; // Инициализируем массив на 10 зданий
        }
        public Building this[int index]
        {
            get
            {
                if (index >= 0 && index < buildings.Length)
                {
                    return buildings[index];
                }
                else
                {
                    throw new IndexOutOfRangeException($"Зданиe с таким индексом {index} не существует!");
                }
            }
            set
            {
                if (index >= 0 && index < buildings.Length)
                {
                    buildings[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException($"Зданиe с таким индексом {index} не существует!");
                }
            }
        }
    }
}
