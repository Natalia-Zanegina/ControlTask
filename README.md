# Контрольная работа за I четверть
Выполнила: Занегина Н.А.

## Задание:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. При решении рекомендуется не пользоваться коллекциями, лучше обойтись исключительно массивами.

## Ход решения:
1. Создана блок-схема решения __*основной*__ задачи.

2. Написан метод, создающий массив строк: string[ ] __CreateArray__. Метод принимает на вход количество элементов массива. 

3. Создан метод void __Fill__ для заполнения массива пользователем:
   * в цикле for проходим по каждому элементу;
   * на каждом шаге запрашиваем у пользователя ввод строки с клавиатуры

4. Произведена __*декомпозиция*__ основной задачи: для подсчета количества элементов итогового массива создан вспомогательный метод int __CountOfElements__, принимающий на вход первоначальный массив.
   * вводим переменную int size, инициализируем нулем;
   * в цикле for проходим по каждому элементу;
   * в случае выполнения условия (длина элемента меньше или равна 3) увеличиваем size на единицу.

5. Создан метод для решения основной задачи: string[ ] __ArrayOfElementsUpTo3Char__, принимающий на вход первоначальный массив и количество элементов нового массива.
   * создаем новый массив с числом элементов, полученным на входе;
   * вводим переменную int j, инициализируем нулем;
   * в цикле for проходим по каждому элементу;
   * в случае выполнения условия (длина элемента меньше или равна 3) присваиваем значение i-того элемента первоначального массива j-тому элементу нового массива, а j увеличиваем на единицу.

6. Написан метод для подготовки вывода итогового массива: void __Print__, принимающий на вход итоговый массив:
   * создается пустая строка output;
   * в цикле for проходим по каждому элементу и прибавляем его и пробел к строке output;

7. Написан интерфейс взаимодействия с пользователем.