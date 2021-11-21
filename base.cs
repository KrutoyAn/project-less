
public class BaseShip
{
public virtual string Move(int distance)
{
    string result = string.Format("Пройдено км: {0}", distance);
    return result; 
}

public virtual string Fight()
{
    return "Произошел бой";
}

/*    protected int _speed;

    public virtual string Move(int distance)
    {
        string result = string.Format("(Родительский класс) Пройддено км {0}", distance);
        return result;
    }
    public override string ToString()
    {
        return "Базовый класс для всех кораблей "; 
    }
}
*/
/*Переопределили */
/*
public class TransportShip : BaseShip
{
    public override string Move(int distance)
    {
        string result = base.Move(distance);
        result+= string.Format("\r\n(Дочерний класс) Транспортный корабль  преодолел км:{0}", distance);
        return result;   
    }
        public override string ToString()
    {
        return "Транспортный корабль"; 
    }
*/
}