using System;

partial class PartialCustomerTwo // Allow us to split classes into 2 or more classes.
                                //All these class are combined into single class, When application is compiled
                                // Can also used to split strut or interface into 2 or more classes.
{
  public string fullName()
    {
      return _firstName + " " + _lastName;
    }
}