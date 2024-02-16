using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMSection : Section
{
    void Start()
    {
        sectionName = "PM Section";
        
        base.Start();
        
        baseSalary = new Dictionary<string, float>();
        baseSalary[Seniority.SEMISENIOR] = 2400f;
        baseSalary[Seniority.SENIOR] = 4000f;

        salaryIncrements = new Dictionary<string, float>();
        salaryIncrements[Seniority.SEMISENIOR] = 0.05f;
        salaryIncrements[Seniority.SENIOR] = 0.1f;

        for (var i = 0; i < 20; i++) {
            this.addEmployee(new Employee(this, Seniority.SEMISENIOR));
        }
        for (var i = 0; i < 10; i++) {
            this.addEmployee(new Employee(this, Seniority.SENIOR));
        }
    }
}
