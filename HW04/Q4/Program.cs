using System;
using System.Collections.Generic;

class Position
{
    public char Column { get; set; }
    public int Row { get; set; }

    public Position(char column, int row)
    {
        Column = column;
        Row = row;
    }

    public Position Move(int direction, int steps)
    {
        Position newPosition = new Position(Column, Row);

        switch (direction)
        {
            case 1: newPosition.Row += steps; break;
            case 2: newPosition.Row += steps; newPosition.Column -= (char)steps; break;
            case 3: newPosition.Column -= (char)steps; break;
            case 4: newPosition.Row -= steps; newPosition.Column -= (char)steps; break;
            case 5: newPosition.Row -= steps; break;
            case 6: newPosition.Row -= steps; newPosition.Column += (char)steps; break;
            case 7: newPosition.Column += (char)steps; break;
            case 8: newPosition.Row += steps; newPosition.Column += (char)steps; break;
        }

        if (newPosition.Column < 'A' || newPosition.Column > 'H' || newPosition.Row < 1 || newPosition.Row > 8)
            return null;

        return newPosition;
    }

    public override string ToString() => $"{Column}{Row}";
}

class Program
{
    static void Main()
    {
        Stack<Position> mainUndo = new Stack<Position>();
        Stack<Position> secondaryUndo = new Stack<Position>();

        Position current = new Position('A', 1);
        mainUndo.Push(current);

        while (true)
        {
            int command = int.Parse(Console.ReadLine());

            switch (command)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    int steps = int.Parse(Console.ReadLine());
                    Position newPosition = current.Move(command, steps);

                    if (newPosition != null)
                    {
                        current = newPosition;
                        mainUndo.Push(current);
                        secondaryUndo.Clear();
                    }
                    break;
                case 9:
                    if (mainUndo.Count > 1)
                    {
                        secondaryUndo.Push(mainUndo.Pop());
                        current = mainUndo.Peek();
                    }
                    break;
                case 10:
                    if (secondaryUndo.Count > 0)
                    {
                        current = secondaryUndo.Pop();
                        mainUndo.Push(current);
                    }
                    break;
                case 11:
                    Console.WriteLine(current);
                    return;
            }
        }
    }
}
