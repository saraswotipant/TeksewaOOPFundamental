class Person
{
    public string Name;
    public double Height;
    public double Weight;
    public Person(string name, double height,double weight)
    {
      Name = name;
      Height = height;
      Weight = weight;
    }

  double CalculateBMI(double height, double weight)
  {

    double bmi = weight / Math.Pow((height*0.3048),2);
    return Math.Round(bmi,2);

  }

public void PrintDetails()
{

Console.WriteLine($"BMI Index of {this.Name} having height {this.Height} feet and weight {this.Weight} kg is {CalculateBMI(this.Height, this.Weight)}");

}
}