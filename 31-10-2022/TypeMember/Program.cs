using System;

class Program
{
  #region Name
  private int _id;
  private string _firstName;
  private string _lastName;
  #endregion

  public int id
  {
    get { return _id; }
    set {_id = value; }
  }

  public int firstName
  {
    get { return _firstName; }
    set {_firstName = value; }
  }

  public int lastName
  {
    get { return _lastName; }
    set {_lastName = value; }
  }

  public string getFullName()
  {
    return this._firstName + " " + this._lastName;
  }
}