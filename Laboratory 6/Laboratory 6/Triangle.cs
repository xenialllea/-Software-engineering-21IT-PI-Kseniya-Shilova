namespace Laboratory_6;

public class Triangle
{
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
        CheckTriangle();
        GetStrategy();
    }

    private double _firstSide;

    public double FirstSide
    {
        get => _firstSide;
        set
        {
            _firstSide = value;
            CheckTriangle();
            GetStrategy();
        }
    }

    private double _secondSide;

    public double SecondSide
    {
        get => _secondSide;
        set
        {
            _secondSide = value;
            CheckTriangle();
            GetStrategy();
        }
    }

    private double _thirdSide;

    public double ThirdSide
    {
        get => _thirdSide;
        set
        {
            _thirdSide = value;
            CheckTriangle();
            GetStrategy();
        }
    }

    private IStrategy AreaStrategy { get; set; }

    public double GetArea()
    {
        return AreaStrategy.GetArea(FirstSide, SecondSide, ThirdSide);
    }

    private void GetStrategy()
    {
        {
            double[] sides = new double[] { FirstSide, SecondSide, ThirdSide };
            Array.Sort(sides);
            if (Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))
            {
                _firstSide = sides[0];
                _secondSide = sides[1];
                _thirdSide = sides[2];
                AreaStrategy = new RightTriangleStrategy();
            }
            else
            {
                AreaStrategy = new HeronStrategy();
            }
        }
    }

    private void CheckTriangle()
    {
        if (!(FirstSide < SecondSide + ThirdSide && SecondSide < FirstSide + ThirdSide && ThirdSide < FirstSide + SecondSide))
            throw new ArgumentException("Triangle does not exist");
       
    }
}