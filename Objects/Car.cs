using System.Collections.Generic;

namespace Cars.Objects
{
  public class Car
  {
    private string _makeModel;
    private static List<string> _instances = new List<string> {};

    public Car (string makeModel)
    {
      _makeModel = makeModel;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public static List<string> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(_makeModel);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
