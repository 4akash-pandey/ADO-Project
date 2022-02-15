using System;

public class Hall
{
    private int _id;
    private string _name;
    private string _mobileNumber;
    private double _costPerDay;
    private string _owner;

    public Hall() { }

    public Hall(int _id, string _name, string _mobileNumber, double _costPerDay, string _owner)
    {
        this._id = _id;
        this._name = _name;
        this._mobileNumber = _mobileNumber;
        this._costPerDay = _costPerDay;
        this._owner = _owner;
    }

    public Hall(string _name, string _mobileNumber, double _costPerDay, string _owner)
    {
        this._name = _name;
        this._mobileNumber = _mobileNumber;
        this._costPerDay = _costPerDay;
        this._owner = _owner;
    }

    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public string MobileNumber { get => _mobileNumber; set => _mobileNumber = value; }
    public double CostPerDay { get => _costPerDay; set => _costPerDay = value; }
    public string Owner { get => _owner; set => _owner = value; }
}