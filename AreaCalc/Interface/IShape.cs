using System;
namespace AreaCalc.Interface
{
	public interface IShape
	{
        //Можно добавить любую фигуру, достаточно будет определить в ней метод вычисления площади

        //Compile time is the period when the programming code is converted to the machine code (i.e. binary code). Runtime is the period of time when a program is running and generally occurs after compile time.
        //Считаю, что для выполнения подзадачи "Вычисление площади фигуры без знания типа фигуры в compile-time" достаточно создать общий для всех фигур интерфейc.
        double CalcArea();
	}
}

