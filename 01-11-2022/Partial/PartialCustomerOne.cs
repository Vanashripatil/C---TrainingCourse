using System;

partial class PartialCustomerOne
{
  private string _firstName;
    private string _lastName;

    public string _firstName
    {
      get { return _firstName; }
      set {_firstName = value; }
    }

    public string _lastName
    {
      get { return _lastName; }
      set {_lastName = value; }
    }
}