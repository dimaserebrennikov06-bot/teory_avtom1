using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace teoryAvtom1
{
    // Перечисление для типов деталей
    public enum DetailType { Gear, Square, Triangle, Rhombus, Washer, Nut, None }
    // Перечисление для цветов деталей
    public enum DetailColor { Red, Green, Blue, Yellow, None }

    // Класс, описывающий Деталь
    public class Detail
    {
        public DetailType Type { get; set; }
        public DetailColor Color { get; set; }
        private int positionX {get; set; }
        private int positionY {get; set; }

        public Detail(DetailType type, DetailColor color)
        {
            Type = type;
            Color = color;
            this.positionX = 10;
            this.positionY = 100;
        }

        // Для удобства вывода в текст
        public override string ToString()
        {
            return $"{Color} {Type}";
        }

        public void moveX(int move) {//50
            //int positionX;
            //Timer.start;
            
        }

        //функция которая обрабатывает тик
        //деталька будет сдвигаться на 5 пикселей
    }

    // Класс, описывающий Ящик
    public class Box
    {
        private static Random random = new Random(); // Общий Random

        public DetailType TargetType { get; set; }
        public DetailColor TargetColor { get; set; }
        public int CurrentCount { get; set; }
        public int MaxCount { get; set; } = 8;
        public bool IsActive { get; set; } = true;
        public string DisplayName { get; private set; } // НОВОЕ СВОЙСТВО

        public bool IsFull => CurrentCount >= MaxCount;

        public Box(DetailType type, DetailColor color, int initialCount)
        {
            TargetType = type;
            TargetColor = color;
            CurrentCount = initialCount;
            DisplayName = $"{color} {type}"; // Создаем текст для Label
        }

        // Метод, чтобы попытаться "положить" деталь в этот ящик
        public bool TryAcceptDetail(Detail detail)
        {
            if (IsActive && !IsFull && detail.Type == TargetType && detail.Color == TargetColor)
            {
                CurrentCount++;

                // ЕСЛИ ЯЩИК ЗАПОЛНИЛСЯ - ДЕЛАЕМ НЕАКТИВНЫМ
                if (IsFull)
                {
                    this.IsActive = false;
                }

                return true;
            }
            return false;
        }

        public bool checkDetails(Detail detail) {//проверяем детальку
            return detail.DetailType == TargetType && detail.DetailColor == TargetColor;
        }
    }

    // Главный класс, который будет управлять всей игровой логикой
    public class GameState
    {
        public List<Box> Boxes { get; set; } = new List<Box>();
        public Detail CurrentDetail { get; set; } = null; // Текущая деталь на конвейере
        public int CurrentDetailPosition { get; set; } = 0; // Позиция детали (0-100)
        public bool IsRunning { get; set; } = false; // Идет ли игра

        public List<DetailType> AllowedTypes { get; set; } = new List<DetailType>();
        public List<DetailColor> AllowedColors { get; set; } = new List<DetailColor>();

        private Random random = new Random();

        // Настройки конвейера
        public const int ConveyorLength = 100;
        public const int DropZonePosition = 80; // Здесь деталь падает в ящик

        // Конструктор - временные настройки для теста
        public GameState()
        {
            // Пустые списки - будут заполняться через настройки
            AllowedTypes = new List<DetailType>();
            AllowedColors = new List<DetailColor>();
        }

        public void CreateBoxes()
        {
            Boxes.Clear();

            // Просто массив из 8 значений
            int[] counts = { 3, 5, 1, 7, 6, 2, 4, 4 };
            int index = 0;

            foreach (var type in AllowedTypes)
            {
                foreach (var color in AllowedColors)
                {
                    if (index < counts.Length)
                    {
                        Boxes.Add(new Box(type, color, counts[index]));
                        index++;
                    }
                }
            }
        }

        public void GenerateSingleDetail(List<DetailType> availableDetails)
        {
            if (availableDetails == null || availableDetails.Count == 0)
            {
                CurrentDetail = null;
                return;
            }

            DetailType randomType = availableDetails[random.Next(availableDetails.Count)];
            DetailColor randomColor = AllowedColors[random.Next(AllowedColors.Count)];

            CurrentDetail = new Detail(randomType, randomColor);
            CurrentDetailPosition = 0;
        }


        public bool ProcessCurrentDetail()
        {
            if (CurrentDetail == null) return false;

            foreach (var box in Boxes)
            {
                if (box.TryAcceptDetail(CurrentDetail))
                {
                    CurrentDetail = null; // Убираем деталь с конвейера
                    return true;
                }
            }
            return false;
        }


        // Новый метод MoveConveyor для использования в форме
        public void MoveConveyor()
        {
            if (CurrentDetail != null)
            {
                // Двигаем деталь вперед
                CurrentDetailPosition += 5;
            }
        }

        // Метод для сброса игры
        public void ResetGame()
        {
            Boxes.Clear();
            CurrentDetail = null;
            CurrentDetailPosition = 0;
            IsRunning = false;
        }
    }

}
