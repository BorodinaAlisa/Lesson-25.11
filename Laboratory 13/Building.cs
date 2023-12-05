using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_13
{
    internal class Building
    {
        private static int nextUniqueNumber = 1;
        public int UniqueNumber { get; }
        public int Height { get; }
        public int Floors { get; }
        public int Apartments { get; }
        public int Entrances { get; }
        public Building(int height, int floors, int apartments, int entrances)
        {
            Height = height;
            Floors = floors;
            Apartments = apartments;
            Entrances = entrances;
            UniqueNumber = getNextUniqueNumber();
        }
        public int ApartmentsOnFloor => Apartments / Floors;
        public int ApartmentsInEntrance => Apartments / Entrances;
        public int FloorHeight => Height / Floors;
        private static int getNextUniqueNumber()
        {
            int uniqueNumber = nextUniqueNumber;
            nextUniqueNumber++;
            return uniqueNumber;
        }
        public override string ToString()
        {
            return $"Номер здания: {UniqueNumber}, высота: {Height}, количество этажей: {Floors}, количество квартир: {Apartments}, количество подъездов: {Entrances}";
        }
    }
}
