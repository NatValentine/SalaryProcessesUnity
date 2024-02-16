using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee
{
    private Section section;
    private string seniority;

    public Employee(Section section, string seniority) {
        this.section = section;
        this.seniority = seniority;
    }

    public float salary() {
        return section.getSalary(seniority);
    }

    public string getSeniority() {
        return seniority;
    }

    public void setSeniority(string seniority) {
        this.seniority = seniority;
    }
}
