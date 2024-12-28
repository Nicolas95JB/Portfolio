using System;

class Experience {
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public string Description { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime? DateTo { get; set; }
    public bool CurrentJob { get; set; }

    public Experience() {}

    public Experience(string _jobTitle, string _company, string _description, DateTime _dateFrom, DateTime? _dateTo, bool _currentJob): this() {
        JobTitle = _jobTitle;
        Company =  _company;
        Description =  _description;
        DateFrom =  _dateFrom;
        DateTo =  _dateTo;
        CurrentJob =  _currentJob;
    }   
}