using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HRSection : Section
{
    void Start()
    {
        sectionName = "HR Section";
        
        base.Start();
        
        baseSalary = new Dictionary<string, float>();
        baseSalary[Seniority.JUNIOR] = 500f;
        baseSalary[Seniority.SEMISENIOR] = 1000f;
        baseSalary[Seniority.SENIOR] = 1500f;

        salaryIncrements = new Dictionary<string, float>();
        salaryIncrements[Seniority.JUNIOR] = 0.005f;
        salaryIncrements[Seniority.SEMISENIOR] = 0.02f;
        salaryIncrements[Seniority.SENIOR] = 0.05f;

        for (var i = 0; i < 13; i++) {
            var emp = new Employee(this, Seniority.JUNIOR);
            addEmployee(emp);
        }
        for (var i = 0; i < 2; i++) {
            var emp = new Employee(this, Seniority.SEMISENIOR);
            addEmployee(emp);
        }
        for (var i = 0; i < 5; i++) {
            var emp = new Employee(this, Seniority.SENIOR);
            addEmployee(emp);
        }
    }
}
